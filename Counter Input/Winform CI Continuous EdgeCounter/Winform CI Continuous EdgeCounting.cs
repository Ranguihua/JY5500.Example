using System;
using System.Windows.Forms;
using JY5500;

///<summary>
/// JY5500 continuous mode edgeCounter
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. According to the time of writing to the register, there are 2 modes for edge counting:
/// The first type is not enabled. SampleClk: When the rising edge of the measurement signal comes,
/// the count value is written to the register. The second type of implicit clock is enabled: 
/// when the rising edge of the measurement signal comes, the count value is written to the register.
/// 2. Counting direction When the external pin is selected to determine the counting direction,
/// the input pin is CTR_AUX
/// 
/// continuous mode edgeCounter:
/// In this mode, the Counter will record the number of pulses above the CTR_Source.
/// </summary>

namespace Winform_CI_Continuous_Encode
{

    public partial class MainForm : Form
    {
        #region private Fields
        //new ciTask based on the selected Solt Number and counterID
        private JY5500CITask ciTask;

        //the Buffer of data read by the ciTask
        private uint[] readValue;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region  Event Handler
        /// <summary>
        /// Set the default index of comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_SoltNumber.SelectedIndex = 0;
            for (int i = 0; i < 4; i++)
            {
                comboBox_counterNumber.Items.Add(i);
            }
            comboBox_cardID.SelectedIndex = 0;

            //Call the enumeration of CountDirection in the driver as a menu
            comboBox_countDir.Items.AddRange(Enum.GetNames(typeof(CountDirection)));
            comboBox_countDir.SelectedIndex = 0;

            //Call the enumeration of CIClock in the driver as a menu
            comboBox_clockType.Items.AddRange(Enum.GetNames(typeof(CISampleClockSource)));
            comboBox_clockType.SelectedIndex = 1;
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
        /// Start ciTask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Click(object sender, EventArgs e)
        {
            try
            {
                //new ciTask based on the selected Solt Number and counterID based on the selected Solt Number and counterID
                ciTask = new JY5500CITask(comboBox_SoltNumber.SelectedIndex, comboBox_counterNumber.SelectedIndex);

                //Parameter configuration
                ciTask.Type = CIType.EdgeCounting;
                ciTask.Mode = CIMode.Continuous;

                //Configure the count direction and initial count value
                ciTask.EdgeCounting.Direction = (CountDirection)Enum.Parse(typeof(CountDirection), comboBox_countDir.Text, true);
                ciTask.EdgeCounting.InitialCount = (int)numericUpDown_initCount.Value;

                //Configure the clocksource and select the internal sampling rate
                ciTask.SampleClock.Source = (CISampleClockSource)Enum.Parse(typeof(CISampleClockSource), comboBox_clockType.Text, true);
                if (ciTask.SampleClock.Source == CISampleClockSource.Internal)
                {
                    ciTask.SampleClock.Internal.Rate = (double)numericUpDown_sampleRate.Value;
                }
                else
                {
                    ciTask.SampleClock.Implicit.ExpectedRate = (double)numericUpDown_sampleRate.Value;
                }

                try
                {
                    //start ciTask
                    ciTask.Start();
                }
                catch (JYDriverException ex)
                {
                    //Drive error message display
                   MessageBox.Show(ex.Message);
                   return;
                }

                readValue = new uint[(int)numericUpDown_samples.Value];

                //Disable parameter configuration button and start button
                timer_FetchData.Enabled = true;
                groupBox_genPara.Enabled = false;
                button_Start.Enabled = false;
                button_stop.Enabled = true;
                
            }
            catch (JYDriverException ex)
            {
               //Drive error message display
               MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        ///Timer, reading the count value every 100ms and displaying
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                if(ciTask.AvailableSamples>= (ulong)readValue.Length)
                {
                    //Read the count value and display
                    ciTask.ReadData(ref readValue, (int)readValue.Length, -1);
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < readValue.Length; i++)
                    {
                        dataGridView1.Rows.Add(readValue[i]);
                    }
                    
                }
            }
            catch (JYDriverException ex)
            {
               MessageBox.Show(ex.Message);
                return;
            }

            timer_FetchData.Enabled = true;
        }

        /// <summary>
        /// Stop CTTask data acquisition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (ciTask != null)
                {
                    ciTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
               MessageBox.Show(ex.Message);
               return;
            }

            //Disable stop button，enable Parameter configuration button and start button
            numericUpDown_sampleRate.Enabled = true;
            timer_FetchData.Enabled = false;
            groupBox_genPara.Enabled = true;
            button_Start.Enabled = true;
            button_stop.Enabled = false;
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
                if (ciTask != null)
                {
                    ciTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
               MessageBox.Show(ex.Message);
               return;
            }
        }

        /// <summary>
        /// Set the sampling rate enable condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_clockType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox_clockType.SelectedIndex)
            {
                case 1:
                    numericUpDown_sampleRate.Enabled = true;
                    break;
                default:
                    numericUpDown_sampleRate.Enabled = false;
                    break;
            }
        }

        #endregion

        #region Methods
        #endregion

    }
}
