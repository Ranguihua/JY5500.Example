using System;
using System.Windows.Forms;
using JY5500;
using SeeSharpTools.JY.ArrayUtility;

/// <summary>
/// JY5500 Single Channel acquisition (infinite length mode stream)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number and ChannelID and select AITerminal
/// 2. Input sample rate and input voltage range limit
/// 3. Input the preview point and save the path
/// 4. Select the save path
/// 5. Press the Start button to start the infinite length mode stream
/// </summary>

namespace Winform_AI_Infinite_Streaming
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// aiTask
        /// </summary>
        private JY5500AITask aiTask;

        /// <summary>
        /// the Buffer of data acquisition by the aiTask
        /// </summary>
        private double[,] RecordreadValue;
        private double[,] displayRecordreadValue;

        /// <summary>
        /// current time
        /// </summary>
        private DateTime currentTime;

        /// <summary>
        /// current time（string format）
        /// </summary>
        private string stringCurrentTime;

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
            comboBox_CardId.SelectedIndex = 0;
            comboBox_boardID.SelectedIndex = 0;
            for (int i = 1; i < 33; i++)
            {
                comboBox_channelcount.Items.Add(i);
            }
            comboBox_inputRange.SelectedIndex = 0;
            //Call the enumeration of AITerminal in the driver as a menu
            comboBox_terminalType.Items.AddRange(Enum.GetNames(typeof(AITerminal)));
            comboBox_terminalType.SelectedIndex = 0;

        }

        private void comboBox_CardId_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_CardId.Text)
            {
                case "5510":
                    numericUpDown_samplerate.Maximum = 2000000;
                    comboBox_channelcount.Items.Clear();
                    for (int i = 1; i < 33; i++)
                    {
                        comboBox_channelcount.Items.Add(i);
                    }
                    break;
                case "5511":
                    numericUpDown_samplerate.Maximum = 1250000;
                    comboBox_channelcount.Items.Clear();
                    for (int i = 1; i < 33; i++)
                    {
                        comboBox_channelcount.Items.Add(i);
                    }
                    break;
                case "5515":
                    numericUpDown_samplerate.Maximum = 2000000;
                    comboBox_channelcount.Items.Clear();
                    for (int i = 1; i < 17; i++)
                    {
                        comboBox_channelcount.Items.Add(i);
                    }
                    break;
                case "5516":
                    numericUpDown_samplerate.Maximum = 1250000;
                    comboBox_channelcount.Items.Clear();
                    for (int i = 1; i < 17; i++)
                    {
                        comboBox_channelcount.Items.Add(i);
                    }
                    break;
                default:
                    numericUpDown_samplerate.Maximum = 2000000;
                    comboBox_channelcount.Items.Clear();
                    for (int i = 1; i < 33; i++)
                    {
                        comboBox_channelcount.Items.Add(i);
                    }
                    break;
            }
            comboBox_channelcount.SelectedIndex = 0;
            numericUpDown_samplerate.Value = numericUpDown_samplerate.Maximum;
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
        /// start Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //New aiTask based on the selected Solt Number
                aiTask = new JY5500AITask(comboBox_boardID.SelectedIndex);

                //AddChannel
                for (int i = 0; i < Convert.ToInt16(comboBox_channelcount.Text); i++)
                {
                    aiTask.AddChannel(i, lowRange, highRange, (AITerminal)Enum.Parse(typeof(AITerminal), comboBox_terminalType.Text));
                }

                //Basic parameter configuration
                aiTask.Mode = AIMode.Record;
                aiTask.Record.Mode = RecordMode.Infinite;
                aiTask.SampleRate = (double)numericUpDown_samplerate.Value;
                currentTime = new DateTime();
                currentTime = DateTime.Now;
                stringCurrentTime = currentTime.ToString("m") + "_" + Convert.ToString(currentTime.Hour)
                    + "_" + Convert.ToString(currentTime.Minute) + "_" + Convert.ToString(currentTime.Second);
                aiTask.Record.FilePath = textBox_path.Text + "\\" + stringCurrentTime + ".bin";


                //Start data acquisition
                aiTask.Start();
            }

            catch (JYDriverException ex)
            {
                toolStripStatusLabel1.Text = "Task start failed";
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            RecordreadValue = new double[(int)numericUpDown_PreviewSamplesPerChannels.Value, aiTask.Channels.Count];
            displayRecordreadValue = new double[RecordreadValue.GetLength(1), RecordreadValue.GetLength(0)];

            timer_FetchData.Enabled = true;
            button_start.Enabled = false;
            button_stop.Enabled = true;
            groupBox_param.Enabled = false;
            toolStripStatusLabel1.Text = "start record Task";
        }

        /// <summary>
        /// Timer, read buffer preview data every 10ms and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;
            try
            {
                aiTask.GetRecordPreviewData(ref RecordreadValue, (int)numericUpDown_PreviewSamplesPerChannels.Value, -1);
                toolStripStatusLabel1.Text = "Reading preview data";
                ArrayManipulation.Transpose(RecordreadValue, ref displayRecordreadValue);
                easyChartX_readrecordData.Plot(displayRecordreadValue);
            }
            catch (JYDriverException ex)
            {
                toolStripStatusLabel1.Text = "Failed to read preview data";
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
            timer_FetchData.Enabled = true;
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
                if (aiTask != null) 
                {
                    toolStripStatusLabel1.Text = "Stop record Task";
                    //Stop Task 
                    aiTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                toolStripStatusLabel1.Text = " failed to stop record task ";
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //Disable timer and Stop button, enable parameter configuration button and start button
            timer_FetchData.Enabled = false;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            groupBox_param.Enabled = true;
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
        /// Save data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_savepath_Click_1(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            //Pop up a dialog box and manually select the save path
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        #endregion

        #region  Methods
        #endregion

    }
}
