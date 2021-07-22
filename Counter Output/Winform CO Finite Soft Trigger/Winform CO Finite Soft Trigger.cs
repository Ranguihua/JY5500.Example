using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 finite pulse generation (software trigger)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number and CounterID number
/// 2. Configure the pulse output type and its parameters
/// 3. Press the Start button to start finite pulse generation
///
/// </summary>

namespace Winform_CO_Finite_Soft_Trigger
{
    public partial class MainForm : Form
    {
        #region private Fields
        /// <summary>
        /// coTask
        /// </summary>
        private JY5500COTask coTask;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        /// <summary>
        ///Set the default index of comboBox 
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_SoltNumber.SelectedIndex = 0;
            for (int i = 0; i < 4; i++)
            {
                comboBox_counterNumber.Items.Add(i);
            }
            comboBox_cardID.SelectedIndex = 0;

            //Call the enumeration of IdleState in the driver as a menu
            comboBox_IdleState.Items.AddRange(Enum.GetNames(typeof(COIdleState)));
            comboBox_IdleState.SelectedIndex = 0;

            //Call the enumeration of COPulseType in the driver as a menu
            comboBox_pulseType.Items.AddRange(Enum.GetNames(typeof(COPulseType)));
            comboBox_pulseType.SelectedIndex = 0;
        }

        private void comboBox_cardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cardID.Text)
            {
                case "5510":
                    comboBox_counterNumber.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumber.Items.Add(i);
                    }
                    break;
                case "5511":
                    comboBox_counterNumber.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumber.Items.Add(i);
                    }
                    break;
                case "5515":
                    comboBox_counterNumber.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_counterNumber.Items.Add(i);
                    }
                    break;
                case "5516":
                    comboBox_counterNumber.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_counterNumber.Items.Add(i);
                    }
                    break;
                default:
                    comboBox_counterNumber.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumber.Items.Add(i);
                    }
                    break;
            }
            comboBox_counterNumber.SelectedIndex = 0;
        }

        /// <summary>
        /// Start coTask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Click(object sender, EventArgs e)
        {
            try
            {
                //new coTask based on the selected Solt Number and counterID
                coTask = new JY5500COTask(comboBox_SoltNumber.SelectedIndex, comboBox_counterNumber.SelectedIndex);

                //Basic parameter configuration
                coTask.Mode = COMode.Single;
                coTask.IdleState = (COIdleState)Enum.Parse(typeof(COIdleState), comboBox_IdleState.Text, true);

                //trigger param configure
                coTask.Trigger.Type = COTriggerType.Soft;

                COPulse pulse = new COPulse((COPulseType)Enum.Parse(typeof(COPulseType), comboBox_pulseType.Text, true),
                    Convert.ToDouble(numericUpDown_highPulseWidth.Value), Convert.ToDouble(numericUpDown_lowPulseWidth.Value),
                   (int)numericUpDown_pulseCount.Value);

                coTask.WriteSinglePoint(pulse);

                try
                {
                    //Start coTask
                    coTask.Start();
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                //enable stop button，Disable parameter configuration and start button
                timer_FetchData.Enabled = true;
                groupBox_paraConfig.Enabled = false;
                groupBox_PulsePara.Enabled = false;
                button_Start.Enabled = false;
                button_stop.Enabled = false;
                button_sendSoftTrigger.Enabled = true;

            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                //Determine if the task exists
                if (coTask != null) 
                {
                    //Stop Task 
                    coTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //enable Parameter configuration and start button，disable Stop button
            timer_FetchData.Enabled = false;
            groupBox_paraConfig.Enabled = true;
            groupBox_PulsePara.Enabled = true;
            button_Start.Enabled = true;
            button_stop.Enabled = false;
            button_sendSoftTrigger.Enabled = false;
        }

        /// <summary>
        /// Send Soft Trigger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_sendSoftTrigger_Click(object sender, EventArgs e)
        {
            coTask.SendSoftwareTrigger();
            button_Start.Enabled = false;
            button_stop.Enabled = true;
            button_sendSoftTrigger.Enabled = false;
        }

        /// <summary>
        /// close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Determine if the task exists
                if (coTask != null) 
                {
                    //Stop Task 
                    coTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// timer，check coTask if is finished
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            if (coTask.WaitUntilDone() == true)
            {
                try
                {
                    if (coTask != null)
                    {
                        //Stop Task 
                        coTask.Stop();
                    }
                }

                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_FetchData.Enabled = false;
                groupBox_paraConfig.Enabled = true;
                groupBox_PulsePara.Enabled = true;
                button_Start.Enabled = true;
                button_stop.Enabled = false;
                button_sendSoftTrigger.Enabled = false;
            }
            else
            {
                timer_FetchData.Enabled = true;
            }
        }

        /// <summary>
        /// Set pulse parameters according to outputPulse Type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_pulseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pulse Type is configured according to the high and low Time numbers
            if (comboBox_pulseType.SelectedIndex == 1)
            {
                label_HighLevel.Text = "High Level Time(s)";
                numericUpDown_highPulseWidth.Increment = 0.0001M;
                numericUpDown_highPulseWidth.DecimalPlaces = 4;
                numericUpDown_highPulseWidth.Value = 0.0005M;

                label_LowLevel.Text = "Low Level Time(s)";
                numericUpDown_lowPulseWidth.Increment = 0.0001M;
                numericUpDown_lowPulseWidth.DecimalPlaces = 4;
                numericUpDown_lowPulseWidth.Value = 0.0005M;
            }
            //Pulse Type is configured according to the high and low Tick numbers
            else if (comboBox_pulseType.SelectedIndex == 2)
            {
                label_HighLevel.Text = "High Level Tick";
                numericUpDown_highPulseWidth.Increment = 1;
                numericUpDown_highPulseWidth.DecimalPlaces = 0;
                numericUpDown_highPulseWidth.Value = 100000;

                label_LowLevel.Text = "Low Level Tick";
                numericUpDown_lowPulseWidth.Increment = 1;
                numericUpDown_lowPulseWidth.DecimalPlaces = 0;
                numericUpDown_lowPulseWidth.Value = 100000;
            }

            //Pulse Type is configured according to the dutycycle and frequency
            else
            {
                label_LowLevel.Text = "Duty Cycle";
                numericUpDown_lowPulseWidth.Value = 0.5M;

                label_HighLevel.Text = "Frequency";
                numericUpDown_highPulseWidth.Value = 1000;
            }
        }
        #endregion

        #region Methods
        #endregion
        
    }
}
