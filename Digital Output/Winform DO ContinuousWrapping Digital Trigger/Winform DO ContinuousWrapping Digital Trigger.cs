using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 continuous surround mode digital output
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input Solt Number, sample rate
/// 2. Generating digital signals
/// 2. Press the Start button to start a continuous digital output
///
/// Note: JY5500 board has 4 digital output ports
/// </summary>

namespace Winform_DO_ContinuousWrapping_Digital_Trigger
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// DOTask
        /// </summary>
        private JY5500DOTask dotask;

        /// <summary>
        /// the buffer of written by the DO, and the capacity is the number of samples to be output.
        /// </summary>
        private byte[,] writeValue;

        /// <summary>
        /// port Column
        /// </summary>
        private int cloumn;

        /// <summary>
        /// one Cycle Points
        /// </summary>
        private int oneCyclePoints;

        /// <summary>
        /// high Level Points
        /// </summary>
        private int highLevelPoints;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// Set the default index of comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_SoltNumber.SelectedIndex = 0;

            //Call the enumeration of DODigitalTriggerSource in the driver as a menu
            comboBox_triggerSource.Items.AddRange(Enum.GetNames(typeof(DODigitalTriggerSource)));
            comboBox_triggerSource.SelectedIndex = 0;

            //Call the enumeration of DODigitalTriggerEdge in the driver as a menu
            comboBox_triggerEdge.Items.AddRange(Enum.GetNames(typeof(DODigitalTriggerEdge)));
            comboBox_triggerEdge.SelectedIndex = 0;

            comboBox_cardID.SelectedIndex = 0;
            checkBox_Port0.Checked = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
        }

        /// <summary>
        /// Set the default ports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_cardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cardID.Text)
            {
                case "5510":
                case "5511":
                    checkBox_Port3.Visible = true;
                    numericUpDown_port3_Frequency.Visible = true;
                    numericUpDown_port3_duty.Visible = true;
                    break;
                case "5515":
                case "5516":
                    checkBox_Port3.Visible = false;
                    numericUpDown_port3_Frequency.Visible = false;
                    numericUpDown_port3_duty.Visible = false;
                    break;
                default:
                    numericUpDown_port3_Frequency.Visible = true;
                    numericUpDown_port3_duty.Visible = true;
                    checkBox_Port3.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Start DOTask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //New DOTask based on the selected Solt Number
                dotask = new JY5500DOTask(comboBox_SoltNumber.SelectedIndex);

                //AddChannel
                if (checkBox_Port0.Checked)
                {
                    dotask.AddChannel(0);
                }
                if (checkBox_Port1.Checked)
                {
                    dotask.AddChannel(1);
                }
                if (checkBox_Port2.Checked)
                {
                    dotask.AddChannel(2);
                }
                if (checkBox_Port3.Checked)
                {
                    dotask.AddChannel(3);
                }

                //Parameter configuration
                dotask.Mode = DOMode.ContinuousWrapping;
                dotask.UpdateRate = (double)numericUpDown_updateRate.Value;
                dotask.Trigger.Type = DOTriggerType.Digital;
                dotask.Trigger.Digital.Edge = (DODigitalTriggerEdge)Enum.Parse(typeof(DODigitalTriggerEdge), comboBox_triggerEdge.Text, true);
                dotask.Trigger.Digital.Source = (DODigitalTriggerSource)Enum.Parse(typeof(DODigitalTriggerSource), comboBox_triggerSource.Text, true);

                //GenerateData
                GenerateData();

                //display data
                easyChartX1.Plot(writeValue, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);

                try
                {
                    //Write data to buffer
                    dotask.WriteData(writeValue, (uint)writeValue.GetLength(0), -1);
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                try
                {
                    //Start ATTask data acquisition
                    dotask.Start();
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                //disable Parameter configuration button
                groupBox_genParam.Enabled = false;
                groupBox_TrigParam.Enabled = false;
                button_start.Enabled = false;
                button_stop.Enabled = true;
                ControlThePortEnable(false);
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        ///  Stop Task 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                //Determine if the task exists
                if (dotask != null) 
                {
                    //Stop Task 
                    dotask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //Clear the channel that was added last time
            dotask.Channels.Clear();

            //enable Parameter configuration button
            groupBox_genParam.Enabled = true;
            groupBox_TrigParam.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            ControlThePortEnable(true);
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
                if (dotask != null) 
                {
                    //Stop Task 
                    dotask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
        }
        #endregion

        #region Methods

        private void GenerateData()
        {
            //Generate digital signal
            writeValue = new byte[(int)dotask.UpdateRate, dotask.Channels.Count];

            cloumn = 0;
            if (checkBox_Port0.Checked)
            {
                // cal one cycle points
                oneCyclePoints = (int)(dotask.UpdateRate / (double)numericUpDown_port0_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPoints = (int)(oneCyclePoints * (double)numericUpDown_port0_duty.Value);

                //write data
                for (int i = 0; i < (int)(dotask.UpdateRate / oneCyclePoints); i++)
                {
                    for (int j = 0; j < oneCyclePoints; j++)
                    {
                        if (j < highLevelPoints)
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0xFF;
                        }
                        else
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0x00;
                        }
                    }
                }

                // cloumn add
                cloumn++;
            }
            if (checkBox_Port1.Checked)
            {
                // cal one cycle points
                oneCyclePoints = (int)(dotask.UpdateRate / (double)numericUpDown_port1_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPoints = (int)(oneCyclePoints * (double)numericUpDown_port1_duty.Value);

                //write data
                for (int i = 0; i < (int)(dotask.UpdateRate / oneCyclePoints); i++)
                {
                    for (int j = 0; j < oneCyclePoints; j++)
                    {
                        if (j < highLevelPoints)
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0xFF;
                        }
                        else
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0x00;
                        }
                    }
                }

                // cloumn add
                cloumn++;
            }
            if (checkBox_Port2.Checked)
            {
                // cal one cycle points
                oneCyclePoints = (int)(dotask.UpdateRate / (double)numericUpDown_port2_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPoints = (int)(oneCyclePoints * (double)numericUpDown_port2_duty.Value);

                //write data
                for (int i = 0; i < (int)(dotask.UpdateRate / oneCyclePoints); i++)
                {
                    for (int j = 0; j < oneCyclePoints; j++)
                    {
                        if (j < highLevelPoints)
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0xFF;
                        }
                        else
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0x00;
                        }
                    }
                }

                // cloumn add
                cloumn++;
            }
            if (checkBox_Port3.Checked)
            {
                // cal one cycle points
                oneCyclePoints = (int)(dotask.UpdateRate / (double)numericUpDown_port3_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPoints = (int)(oneCyclePoints * (double)numericUpDown_port3_duty.Value);

                //write data
                for (int i = 0; i < (int)(dotask.UpdateRate / oneCyclePoints); i++)
                {
                    for (int j = 0; j < oneCyclePoints; j++)
                    {
                        if (j < highLevelPoints)
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0xFF;
                        }
                        else
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0x00;
                        }
                    }
                }
            }

        }


        /// <summary>
        /// Control The Port Enable
        /// </summary>
        /// <param name="Enabled"></param>
        private void ControlThePortEnable(bool Enabled)
        {
            //port0
            checkBox_Port0.Enabled = checkBox_Port0.Checked || Enabled;
            numericUpDown_port0_Frequency.Enabled = checkBox_Port0.Checked || Enabled;
            numericUpDown_port0_duty.Enabled = checkBox_Port0.Checked || Enabled;

            //port1
            checkBox_Port1.Enabled = checkBox_Port1.Checked || Enabled;
            numericUpDown_port1_Frequency.Enabled = checkBox_Port1.Checked || Enabled;
            numericUpDown_port1_duty.Enabled = checkBox_Port1.Checked || Enabled;

            //port2
            checkBox_Port2.Enabled = checkBox_Port2.Checked || Enabled;
            numericUpDown_port2_Frequency.Enabled = checkBox_Port2.Checked || Enabled;
            numericUpDown_port2_duty.Enabled = checkBox_Port2.Checked || Enabled;

            //port3
            checkBox_Port3.Enabled = checkBox_Port3.Checked || Enabled;
            numericUpDown_port3_Frequency.Enabled = checkBox_Port3.Checked || Enabled;
            numericUpDown_port3_duty.Enabled = checkBox_Port3.Checked || Enabled;

        }
        #endregion


    }
}

