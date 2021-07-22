using System;
using System.Windows.Forms;
using JY5500;
using SeeSharpTools.JY.ArrayUtility;

/// <summary>
/// JY5500 multi-channel finite mode data acquisition (digital trigger)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the board number and the number of channels, select AITerminal
/// 2. Input sample rate, SamplesToAcquire, and input voltage range limits
/// 3. Configure trigger mode and digital trigger parameters
/// 4. Press the Start button to start multi-channel finite mode data acquisition
/// </summary>

namespace Winform_AI_Finite_MulitiChannel_Digital_Trigger
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// aiTask
        /// </summary>
        private JY5500AITask aiTask;

        /// <summary>
        ///  the Buffer of data acquisition by the aiTask
        /// </summary>
        double[,] readValue;

        /// <summary>
        /// the Buffer of data after readValue transpose, the capacity is the same as readValue
        /// </summary>
        double[,] displayValue;

        /// <summary>
        /// retriggercount that have been completed
        /// </summary>
        private int reTrigCnt;


        /// input low limit
        /// </summary>
        private double lowRange;

        /// <summary>
        /// input high limit
        /// </summary>
        /// <returns></returns>
        private double highRange;
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
            for(int i=1;i<33;i++)
            {
                comboBox_channelNumber.Items.Add(i);
            }
            comboBox_inputRange.SelectedIndex = 0;
            //Call the enumeration of AITerminal in the driver as a menu
            comboBox_terminalType.Items.AddRange(Enum.GetNames(typeof(AITerminal)));
            comboBox_terminalType.SelectedIndex = 0;

            //Call the enumeration of AIDigitalTriggerEdge in the driver as a menu
            comboBox_triggerEdge.Items.AddRange(Enum.GetNames(typeof(AIDigitalTriggerEdge)));
            comboBox_triggerEdge.SelectedIndex = 0;

            //Call the enumeration of AIDigitalTriggerSource in the driver as a menu
            comboBox_triggerSource.Items.AddRange(Enum.GetNames(typeof(AIDigitalTriggerSource)));
            comboBox_triggerSource.SelectedIndex = 0;

            //Call the enumeration of AITriggerMode in the driver as a menu
            comboBox_triggermode.Items.AddRange(Enum.GetNames(typeof(AITriggerMode)));
            comboBox_triggermode.SelectedIndex = 0;

            comboBox_cardID.SelectedIndex = 0;

        }

        private void comboBox_cardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cardID.Text)
            {
                case "5510":
                    numericUpDown_sampleRate.Maximum = 2000000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 33; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                case "5511":
                    numericUpDown_sampleRate.Maximum = 1250000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 33; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                case "5515":
                    numericUpDown_sampleRate.Maximum = 2000000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 17; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                case "5516":
                    numericUpDown_sampleRate.Maximum = 1250000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 17; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                default:
                    numericUpDown_sampleRate.Maximum = 2000000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 33; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
            }
            comboBox_channelNumber.SelectedIndex = 0;
        }
        /// <summary>
        /// select input limit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_inputRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_inputRange.SelectedIndex)
            {
                case 0:
                    lowRange = -10;
                    highRange = 10;
                    break;
                case 1:
                    lowRange = -5;
                    highRange = 5;
                    break;
                case 2:
                    lowRange = -2;
                    highRange = 2;
                    break;
                case 3:
                    lowRange = -1;
                    highRange = 1;
                    break;
                case 4:
                    lowRange = -0.5;
                    highRange = 0.5;
                    break;
                case 5:
                    lowRange = -0.2;
                    highRange = 0.2;
                    break;
                case 6:
                    lowRange = -0.1;
                    highRange = 0.1;
                    break;
                default:
                    lowRange = -10;
                    highRange = 10;
                    break;
            }
        }

        /// <summary>
        /// Start data acquisition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                reTrigCnt = 0;

                //New aiTask based on the selected Solt Number
                aiTask = new JY5500AITask(comboBox_SoltNumber.SelectedIndex);

                //AddChannel
                for (int i = 0; i < Convert.ToInt16(comboBox_channelNumber.Text); i++)
                {
                    aiTask.AddChannel(i, lowRange, highRange, (AITerminal)Enum.Parse(typeof(AITerminal), comboBox_terminalType.Text));
                }

                //Basic parameter configuration
                aiTask.Mode = AIMode.Finite;
                aiTask.SamplesToAcquire = (int)numericUpDown_samples.Value;

                aiTask.SampleRate = (double)numericUpDown_sampleRate.Value;

                //Trigger parameter configuration
                if (comboBox_triggermode.SelectedIndex == 1)
                {
                    aiTask.Trigger.Mode = AITriggerMode.Reference;
                }
                aiTask.Trigger.Type = AITriggerType.Digital;
                aiTask.Trigger.Digital.Source = (AIDigitalTriggerSource)Enum.Parse(typeof(AIDigitalTriggerSource), comboBox_triggerSource.Text, true);
                aiTask.Trigger.Digital.Edge = (AIDigitalTriggerEdge)Enum.Parse(typeof(AIDigitalTriggerEdge), comboBox_triggerEdge.Text, true);
                aiTask.Trigger.ReTriggerCount = (int)numericUpDown_retriggerCount.Value;

                try
                {
                    //Start
                    aiTask.Start();
                }
                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                readValue = new double[(int)numericUpDown_samples.Value, Convert.ToInt16(comboBox_channelNumber.Text)];
                displayValue = new double[readValue.GetLength(1), readValue.GetLength(0)];

                //Enable timer and Stop buttons, disable start button and parameter configuration button
                timer_FetchData.Enabled = true;
                groupBox_Param.Enabled = false;
                groupBox_TrigParam.Enabled = false;
                button_start.Enabled = false;
                button1_stop.Enabled = true;

            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Stop ATTask data acquisition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_stop_Click(object sender, EventArgs e)
        {
            try
            {
                //Determine if the task exists
                if (aiTask != null) 
                {
                    //Stop Task 
                    aiTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //Disable timer and Stop buttons, enable start button and parameter configuration button
            timer_FetchData.Enabled = false;
            button_start.Enabled = true;
            groupBox_Param.Enabled = true;
            groupBox_TrigParam.Enabled = true;
            button1_stop.Enabled = false;
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
                if (aiTask != null) 
                {
                    //Stop Task 
                    aiTask.Stop();
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
        ///Timer, check the buffer readable points every 10ms, if enough, read the data and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                //Read data and display if the local buffer data is enough
                if (aiTask.AvailableSamples >= (ulong)readValue.GetLength(0))
                {
                    //Read data
                    aiTask.ReadData(ref readValue, -1);
                    ArrayManipulation.Transpose(readValue, ref displayValue);
                    easyChartX_readData.Plot(displayValue);
                    reTrigCnt++;
                    if (reTrigCnt >= numericUpDown_retriggerCount.Value)
                    {
                        try
                        {
                            //Determine if the task exists
                            if (aiTask != null) 
                            {
                                //Stop Task 
                                aiTask.Stop();
                            }
                        }
                        catch (JYDriverException ex)
                        {
                            //Drive error message display
                            MessageBox.Show(ex.Message);
                            return;
                        }

                        //Clear the channel that was added last time
                        aiTask.Channels.Clear();

                        //Disable timer, enable Start button and parameter configuration button
                        timer_FetchData.Enabled = false;
                        groupBox_Param.Enabled = true;
                        groupBox_TrigParam.Enabled = true;
                        button_start.Enabled = true;
                        button1_stop.Enabled = false;
                        toolStripStatusLabel1.Text = string.Format("Complete {0} triggers，Stop data acquisition", reTrigCnt);
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = string.Format("Complete the {0}th trigger", reTrigCnt);
                        timer_FetchData.Enabled = true;
                    }
                }
                else
                {
                    timer_FetchData.Enabled = true;
                }
            }

            catch (JYDriverException ex)
            {
                timer_FetchData.Enabled = false;
                toolStripStatusLabel1.Text = "Failed to read data";
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
        }


        #endregion

        #region Methods
        #endregion

    }
}