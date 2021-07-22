using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using SeeSharpTools.JY.ArrayUtility;

/// <summary>
/// JY5315 Single Channel acquisition (infinite length mode stream)
/// Author：JYTEK
/// Modified date：2020.9.8
/// Driver version： JY5315 Installer_V1.0.0.msi
/// Installation package:  SeeSharpTools.JY.GUI 1.4.7
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Channel Count and Read Length once
/// 2. Press the open file button to select the bin file
/// 3. Press the Start button to playback data 
/// </summary>
/// 
namespace Winform_AI_Infinite_Streaming
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// FileStream
        /// </summary>
        private FileStream _playbackfs;

        /// <summary>
        /// BinaryReader
        /// </summary>
        private BinaryReader _playbackbr;

        /// <summary>
        /// playback data buffer
        /// </summary>
        double[,] playback;

        /// <summary>
        /// byte buf 
        /// </summary>
        byte[] buf;

        /// <summary>
        /// total Samples
        /// </summary>
        private long totalSamples = 0;

        /// <summary>
        /// read Length
        /// </summary>
        private long readLength = 0;

        /// <summary>
        /// read Length Once
        /// </summary>
        private int readLengthOnce = 0;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// Set the default index of combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            button_OpenFile.Enabled = true;
            button_start.Enabled = false;
            button_stop.Enabled = false;
        }

        /// <summary>
        /// open file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            var fileBrower = new OpenFileDialog { Filter = @"(*.bin)|*.bin" };
            if (fileBrower.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var exist = File.Exists(fileBrower.FileName);
            //判断给定的路径是否存在,如果不存在则退出
            if (exist)
            {
                var fileSize = new FileInfo(fileBrower.FileName).Length;
                totalSamples = fileSize / sizeof(double) / (int)numericUpDown_channelCount.Value;
                numericUpDown_totalSamples.Value = totalSamples;
            }
            else
            {
                MessageBox.Show("file is not exist");
                return;
            }

            _playbackfs = new FileStream(fileBrower.FileName, FileMode.Open);
            _playbackbr = new BinaryReader(_playbackfs);

            button_OpenFile.Enabled = false;
            button_start.Enabled = true;
            button_stop.Enabled = true;
        }

        /// <summary>
        /// start playback
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            playback = new double[(int)numericUpDown_PreviewSamplesPerChannels.Value, (int)numericUpDown_channelCount.Value];
            readLength = 0;
            timer_FetchData.Enabled = true;

            button_OpenFile.Enabled = false;
            button_start.Enabled = false;
            button_stop.Enabled = true;
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
                // 
                if((totalSamples - readLength) > playback.GetLength(0))
                {
                    buf = _playbackbr.ReadBytes(playback.Length * sizeof(double));
                    Buffer.BlockCopy(buf, 0, playback, 0, buf.Length);
                    easyChartX_playbackData.Plot(playback, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);
                    readLength += playback.GetLength(0);
                    numericUpDown_readLength.Value = readLength;
                }
                else
                {
                    readLengthOnce = (int)(totalSamples - readLength);
                    var dataBuf = new double[readLengthOnce, (int)numericUpDown_channelCount.Value];
                    buf = _playbackbr.ReadBytes(dataBuf.Length * sizeof(double));
                    Buffer.BlockCopy(buf, 0, dataBuf, 0, dataBuf.Length * sizeof(double));
                    easyChartX_playbackData.Plot(dataBuf, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);
                    readLength += readLengthOnce;
                    numericUpDown_readLength.Value = readLength;
                }


                if (readLength >= totalSamples)
                {
                    button_stop_Click(null, null);
                    toolStripStatusLabel1.Text = "read data over";
                    return;
                }
                else
                {
                    toolStripStatusLabel1.Text = "reading  data...";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Failed to read preview data";
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
            timer_FetchData.Enabled = true;
        }

        /// <summary>
        /// Stop Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;;
            try
            {
                //close file
                _playbackfs.Close();
                _playbackbr.Close();
                toolStripStatusLabel1.Text = "stop";

            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Failed to stop Task";
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //Disable timer and stop button, enable start button and parameter configuration button disable timer and stop task button, enable parameter configuration and start button

            button_OpenFile.Enabled = true;
            button_start.Enabled = false;
            button_stop.Enabled = false;
            groupBox_param.Enabled = true;
        }

        /// <summary>
        /// FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Determine if the task exists


            }
            catch (Exception ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
        }


        #endregion

        #region  Methods
        #endregion


    }
}
