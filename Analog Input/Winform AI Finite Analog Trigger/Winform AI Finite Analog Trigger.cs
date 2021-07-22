using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 Single channel finite mode data acquisition (analog trigger)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the board number and ChannelID
/// 2. Input sample rate, SamplesToAcquire, and input voltage range limits
/// 3. Input analog trigger parameters, including trigger conditions and thresholds
/// 4. Press the Start button to start the finite point mode with analog trigger data acquisition
/// </summary>

namespace Winform_AI_Finite_Analog_Trigger
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
        private double[] readValue;

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
            for (int i = 0; i < 32; i++)
            {
                comboBox_channelNumber.Items.Add(i);
            }
            comboBox_channelNumber.SelectedIndex = 0;
            comboBox_inputRange.SelectedIndex = 0;

            //Call the enumeration of AIAnalogTriggerCondition in the driver as a menu
            comboBox_analogTriggerComparator.Items.AddRange(Enum.GetNames(typeof(AIAnalogTriggerComparator)));
            comboBox_analogTriggerComparator.SelectedIndex = 0;

            comboBox_analogTriggerEdge.Items.AddRange(Enum.GetNames(typeof(AIAnalogTriggerEdge)));
            comboBox_analogTriggerEdge.SelectedIndex = 0;

            comboBox_windowTriggerCondition.Items.AddRange(Enum.GetNames(typeof(AIAnalogWindowCondition)));
            comboBox_windowTriggerCondition.SelectedIndex = 0;
            //Call the enumeration of AITerminal in the driver as a menu
            comboBox_terminalType.Items.AddRange(Enum.GetNames(typeof(AITerminal)));
            comboBox_terminalType.SelectedIndex = 0;

            //Call the enumeration of AIAnalogTriggerSource in the driver as a menu
            comboBox_analogTrigSrc.Items.AddRange(Enum.GetNames(typeof(AIAnalogTriggerSource)));
            comboBox_analogTrigSrc.SelectedIndex = 0;

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
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                case "5511":
                    numericUpDown_sampleRate.Maximum = 1250000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                case "5515":
                    numericUpDown_sampleRate.Maximum = 2000000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 0; i < 16; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                case "5516":
                    numericUpDown_sampleRate.Maximum = 1250000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 0; i < 16; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                default:
                    numericUpDown_sampleRate.Maximum = 2000000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
            }
            //comboBox_channelNumber.SelectedIndex = 0;
        }

        /// <summary>
        /// set the threshold enable by trigger condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_analogTriggerComparator_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_analogTriggerComparator.SelectedIndex)
            {
                case 0:
                    label_triggerEdge.Visible = true;
                    comboBox_analogTriggerEdge.Visible = true;
                    label_windowTriggerCondition.Visible = false;
                    comboBox_windowTriggerCondition.Visible = false;
                    label_LowThreshold.Visible = false;
                    numericUpDown_LowThreshold.Visible = false;
                    label_HighThreshold.Visible = true;
                    numericUpDown_highthreshold.Visible = true;
                    label_HighThreshold.Text = "Threshold";
                    break;
                case 1:
                    label_triggerEdge.Visible = true;
                    comboBox_analogTriggerEdge.Visible = true;
                    label_windowTriggerCondition.Visible = false;
                    comboBox_windowTriggerCondition.Visible = false;
                    label_LowThreshold.Visible = true;
                    numericUpDown_LowThreshold.Visible = true;
                    label_HighThreshold.Visible = true;
                    numericUpDown_highthreshold.Visible = true;
                    label_HighThreshold.Text = "High Threshold（V）";
                    break;
                default:
                    label_triggerEdge.Visible = false;
                    comboBox_analogTriggerEdge.Visible = false;
                    label_windowTriggerCondition.Visible = true;
                    comboBox_windowTriggerCondition.Visible = true;
                    label_LowThreshold.Visible = true;
                    numericUpDown_LowThreshold.Visible = true;
                    label_HighThreshold.Visible = true;
                    numericUpDown_highthreshold.Visible = true;
                    label_HighThreshold.Text = "High Threshold（V）";
                    break;
            }
        }

        /// <summary>
        /// Determine the pre-trigger enable condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_triggermode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_triggermode.SelectedIndex == 0)
            {
                label_PreSamples.Visible = false;
                numericUpDown_PreSamples.Visible = false;
            }
            else
            {
                label_PreSamples.Visible = true;
                numericUpDown_PreSamples.Visible = true;

            }
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
                aiTask.AddChannel(comboBox_channelNumber.SelectedIndex, lowRange, highRange, (AITerminal)Enum.Parse(typeof(AITerminal), comboBox_terminalType.Text));

                //Basic parameter configuration
                aiTask.Mode = AIMode.Finite;
                aiTask.SamplesToAcquire = (int)numericUpDown_samples.Value;

                aiTask.SampleRate = (double)numericUpDown_sampleRate.Value;

                //Trigger parameter configuration
                if (comboBox_triggermode.SelectedIndex == 1)
                {
                    aiTask.Trigger.Mode = AITriggerMode.Reference;
                    aiTask.Trigger.PreTriggerSamples = (uint)numericUpDown_PreSamples.Value;
                }

                aiTask.Trigger.Type = AITriggerType.Analog;
                aiTask.Trigger.Analog.Source = (AIAnalogTriggerSource)Enum.Parse(typeof(AIAnalogTriggerSource), comboBox_analogTrigSrc.Text, true);
                aiTask.Trigger.Analog.Comparator =
                 (AIAnalogTriggerComparator)Enum.Parse(typeof(AIAnalogTriggerComparator), comboBox_analogTriggerComparator.Text, true);
                if (aiTask.Trigger.Analog.Comparator == AIAnalogTriggerComparator.Edge)
                {
                    aiTask.Trigger.Analog.Edge.Slope = (AIAnalogTriggerEdge)Enum.Parse(typeof(AIAnalogTriggerEdge), comboBox_analogTriggerEdge.Text, true);
                    aiTask.Trigger.Analog.Edge.Threshold = (double)numericUpDown_highthreshold.Value;
                }

                else if (aiTask.Trigger.Analog.Comparator == AIAnalogTriggerComparator.Hysteresis)
                {
                    aiTask.Trigger.Analog.Hysteresis.Slope = (AIAnalogTriggerEdge)Enum.Parse(typeof(AIAnalogTriggerEdge), comboBox_analogTriggerEdge.Text, true);
                    aiTask.Trigger.Analog.Hysteresis.HighThreshold = (double)numericUpDown_highthreshold.Value;
                    aiTask.Trigger.Analog.Hysteresis.LowThreshold = (double)numericUpDown_LowThreshold.Value;
                }
                else
                {
                    aiTask.Trigger.Analog.Window.Condition = (AIAnalogWindowCondition)Enum.Parse(typeof(AIAnalogWindowCondition), comboBox_windowTriggerCondition.Text, true);
                    aiTask.Trigger.Analog.Window.HighThreshold = (double)numericUpDown_highthreshold.Value;
                    aiTask.Trigger.Analog.Window.LowThreshold = (double)numericUpDown_LowThreshold.Value;
                }
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

                readValue = new double[(int)numericUpDown_samples.Value];

                //Enable timer, disable parameter configuration button and start button, display status
                timer_FetchData.Enabled = true;
                groupBox_ParamConfig.Enabled = false;
                groupBox_TrigParam.Enabled = false;
                button_start.Enabled = false;
                button_stop.Enabled = true;
                toolStripStatusLabel.Text = "Waiting to receive the trigger signal...";

            }

            catch (JYDriverException ex)
            {
                toolStripStatusLabel.Text = "aiTask start failed";
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
        private void button_stop_Click(object sender, EventArgs e)
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

            //Disable timer, restart enable start button and parameter configuration button
            timer_FetchData.Enabled = false;
            groupBox_ParamConfig.Enabled = true;
            groupBox_TrigParam.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
        }

        /// <summary>
        /// Timer, check if the retriggercount is enough every 10ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                //Read data and display if the local buffer data is enough
                if (aiTask.AvailableSamples >= (ulong)readValue.Length)
                {
                    aiTask.ReadData(ref readValue);
                    easyChartX_readData.Plot(readValue);
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
                        groupBox_ParamConfig.Enabled = true;
                        groupBox_TrigParam.Enabled = true;
                        button_start.Enabled = true;
                        button_stop.Enabled = false;
                        toolStripStatusLabel.Text = string.Format("Complete {0} triggers，Stop data acquisition", reTrigCnt);

                    }
                    else
                    {
                        toolStripStatusLabel.Text = string.Format("Complete the {0}th trigger", reTrigCnt);
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
                toolStripStatusLabel.Text = "Failed to read data";
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
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

        #endregion

        #region Methods
        #endregion
    }
}
