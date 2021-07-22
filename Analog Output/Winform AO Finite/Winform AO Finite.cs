using System;
using System.Windows.Forms;
using JY5500;
using SeeSharpTools.JY.DSP.Fundamental;

/// <summary>
/// JY5500 Single Channel finite mode output
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number and ChannelID
/// 2. Input update rate, SamplesToAcquire, and output voltage range limits
/// 3. Input channel waveform information, including WaveType, amplitude and frequency
/// 4. Press the Start button to start the finite point waveform output
/// </summary>

namespace Winform_AO_Finite
{
    public partial class MainForm : Form
    {
        #region Private Fields

        /// <summary>
        ///AO Task
        /// </summary>
        private JY5500AOTask aoTask;

        /// <summary>
        /// the Buffer of data written by the aoTask
        /// </summary>
        private double[] writeValue;

        /// output low limit
        /// </summary>
        private double lowRange;

        /// <summary>
        /// output high limit
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
            for(int i=0;i<4;i++)
            {
                comboBox_channelNumber.Items.Add(i);
            }
            comboBox_outPutRange.SelectedIndex = 0;
            comboBox_waveformType.SelectedIndex = 0;

            comboBox_cardID.SelectedIndex = 0;
        }

        private void comboBox_cardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cardID.Text)
            {
                case "5510":
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                case "5511":
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                case "5515":
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                case "5516":
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
                default:
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    break;
            }
            comboBox_channelNumber.SelectedIndex = 0;
        }

        /// <summary>
        /// select output limit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_outPutRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_outPutRange.SelectedIndex)
            {
                case 0:
                    lowRange = -10;
                    highRange = 10;
                    break;
                case 1:
                    lowRange = -5;
                    highRange = 5;
                    break;
                default:
                    lowRange = -10;
                    highRange = 10;
                    break;
            }
        }

        /// <summary>
        /// Start aoTask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //new task based on the selected Solt Number
                aoTask = new JY5500AOTask(comboBox_SoltNumber.SelectedIndex);

                //AddChannel
                aoTask.AddChannel(comboBox_channelNumber.SelectedIndex, lowRange, highRange);

                //Basic parameter configuration
                aoTask.Mode = AOMode.Finite;
                aoTask.UpdateRate = (double)numericUpDown_updateRate.Value;
                aoTask.SamplesToUpdate = (int)numericUpDown_samplesToUpdate.Value;


                //Waveform generation
                waveGeneration();

                try
                {
                    //Write data to buffer
                    aoTask.WriteData(writeValue, -1);

                    easyChartX_AO.Plot(writeValue);
                }
                catch (JYDriverException ex)
                {
                    //Display driver error message
                    MessageBox.Show(ex.Message);
                    return;
                }
               
                try
                {
                    //Start Task
                    aoTask.Start();
                }
                catch (JYDriverException ex)
                {
                    //Display driver error message
                   MessageBox.Show(ex.Message);
                   return;
                }

                //Enable timer and Stop buttons, disable start button and parameter configuration button
                timer_FetchData.Enabled = true;
                groupBox_genParam.Enabled = false;
                groupBox_waveConfig.Enabled = false;
                button_start.Enabled = false;
                button_stop.Enabled = true;
            }
            catch (JYDriverException ex)
            {
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
                if (aoTask != null) 
                {
                    //Stop Task 
                    aoTask.Stop();
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
        /// Timer, query the Task state every 100ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            //Stop aoTask if the Task is completed
            if (aoTask.WaitUntilDone(10) == true)
            {
                try
                {
                    if(aoTask!=null)
                    {
                        aoTask.Stop();
                    }
                }
                catch(JYDriverException ex)
                {
                   MessageBox.Show(ex.Message);
                   return;
                }

                //Clear channel
                aoTask.Channels.Clear();

                easyChartX_AO.Clear();

                //Disable timer and Stop buttons, enable parameter configuration button and start button
                timer_FetchData.Enabled = false;
                groupBox_genParam.Enabled = true;
                groupBox_waveConfig.Enabled = true;
                button_start.Enabled = true;
                button_stop.Enabled = false;
            }
            else
            {
                //Task is not completed, enable the timer, continue to query whether the task is completed
                timer_FetchData.Enabled = true;
            }
        }

        /// <summary>
        /// Stop output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                //Determine if the task exists
                if (aoTask != null) 
                {
                    //Stop Task 
                    aoTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
               MessageBox.Show(ex.Message);
                return;
            }

            //Clear the channel that was added last time
            aoTask.Channels.Clear();

            //enable the Start button and parameter configuration button,disable the Stop button
            timer_FetchData.Enabled = false;
            groupBox_genParam.Enabled = true;
            groupBox_waveConfig.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
        }
        #endregion

        #region Methods
        private void waveGeneration()
        {
            //Waveform setting
            writeValue = new double[aoTask.SamplesToUpdate];
            double amplitude = (double)numericUpDown_waveformAmplitude.Value;
            double frequency = (double)numericUpDown_waveformFrequency.Value;
            switch (comboBox_waveformType.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue, amplitude, 0, frequency, aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue, amplitude, 50, frequency, aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue, amplitude);//White Noise
                    break;
                default:
                    return;
            }
        }


        #endregion

    }
}
