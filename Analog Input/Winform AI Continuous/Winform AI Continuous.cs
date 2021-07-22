using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 Single channel continuous mode data acquisition 
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the slot number and channel number and select the terminal connection method
/// 2. Input sample rate and input voltage range limit
/// 3. Press the start button to start continuous data collection
/// </summary>

namespace Winform_AI_Continuous
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

            comboBox_inputRange.SelectedIndex = 0;
            //Call the enumeration of AITerminal in the driver as a menu
            comboBox_terminalType.Items.AddRange(Enum.GetNames(typeof(AITerminal)));
            comboBox_terminalType.SelectedIndex = 0;

            //Call the enumeration of AISampleClockSource in the driver as a menu
            comboBox_sampleClock.Items.AddRange(Enum.GetNames(typeof(AISampleClockSource)));
            comboBox_sampleClock.SelectedIndex = 0;

            //Call the enumeration of ClockTerminal in the driver as a menu
            comboBox_externalclockterminal.Items.AddRange(Enum.GetNames(typeof(ClockTerminal)));
            comboBox_externalclockterminal.SelectedIndex = 0;


            comboBox_cardID.SelectedIndex = 0;
        }

        /// <summary>
        /// Set CardID Basic Param
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// change AI Sample Clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_sampleClock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_sampleClock.SelectedIndex == 0)
            {
                label_SampleRate.Text = "Sample Rate(Sa/s)";
                label_ExternalClock.Enabled = false;
                comboBox_externalclockterminal.Enabled = false;
            }
            else
            {
                label_SampleRate.Text = "Expected Rate(Sa/s)";
                label_ExternalClock.Enabled = true;
                comboBox_externalclockterminal.Enabled = true;
            }
        }

        /// <summary>
        /// Start aiTask data acquisition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //New aiTask based on the selected Solt Number
                aiTask = new JY5500AITask(comboBox_SoltNumber.SelectedIndex);

                //Addchannel 
                aiTask.AddChannel(comboBox_channelNumber.SelectedIndex, lowRange, highRange, (AITerminal)Enum.Parse(typeof(AITerminal), comboBox_terminalType.Text));

                //Basic parameter configuration
                aiTask.Mode = AIMode.Continuous;
                aiTask.SampleClock.Source = (AISampleClockSource)Enum.Parse(typeof(AISampleClockSource), comboBox_sampleClock.Text, true);
                aiTask.SampleRate = (double)numericUpDown_sampleRate.Value;

                if (aiTask.SampleClock.Source == AISampleClockSource.External)
                {
                    aiTask.SampleClock.External.Terminal = (ClockTerminal)Enum.Parse(typeof(ClockTerminal), comboBox_externalclockterminal.Text, true);
                    aiTask.SampleClock.External.ExpectedRate = (double)numericUpDown_sampleRate.Value;
                }

                try
                {
                    //start
                    aiTask.Start();
                }
               
               catch (JYDriverException ex)
               {
                   toolStripStatusLabel.Text = "aiTask start failed";
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                   return;
               }

               readValue = new double[(int)numericUpDown_samples.Value];

                //Enable timer, disable parameter configuration button and start button, display status
                timer_FetchData.Enabled = true;
                groupBox_ParmConfig.Enabled = false;
                button_start.Enabled = false;
                button_stop.Enabled = true;
                toolStripStatusLabel.Text = "Start data acquisition";
            }

            catch (JYDriverException ex)
            {
                toolStripStatusLabel.Text = "aiTask failed";
                //Drive error message display
               MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Stop aiTask data acquisition
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
                    //stop
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

            //Disable timer, enable parameter configuration button and start button, display status
            timer_FetchData.Enabled = false;
            groupBox_ParmConfig.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            toolStripStatusLabel.Text = "Stop data acquisition";
        }

        /// <summary>
        /// Timer, refresh every 10ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

             try
                {
                   //Read data and display if the local buffer data is enough
                   if (aiTask.AvailableSamples>=(ulong)readValue.Length)
                    {
                       //Read data stored in readValue
                      aiTask.ReadData(ref readValue, readValue.Length, -1);
                      toolStripStatusLabel.Text = "Reading data...";
                      //Display data
                      easyChartX_readData.Plot(readValue);
                    }
               }
              catch (JYDriverException ex)
                {
                    toolStripStatusLabel.Text = "Failed to read data";
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }
                 //Enable the timer and continue to check if the buffer data is enough
                 timer_FetchData.Enabled = true;
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
                    //stop
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
