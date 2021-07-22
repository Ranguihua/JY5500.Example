using System;
using System.Windows.Forms;
using JY5500;
using SeeSharpTools.JY.DSP.Fundamental;

/// <summary>
/// JYPCIe5500 multi-channel finite mode output
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number and the number of channels
/// 2. Input update rate, SamplesToAcquire, and output voltage range limits
/// 3. Input the waveform information for each channel, including WaveType, amplitude, frequency
/// 4. Press the Start button to start the finite point waveform output
/// </summary>

namespace Winform_AO_Finite_MulitiChannel
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// AO Task
        /// </summary>
        private JY5500AOTask aoTask;

        /// <summary>
        ///the Buffer of data written by the aoTask
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
            for(int i=1;i<5;i++)
            {
                comboBox_channelCount.Items.Add(i);
            }
            comboBox_outPutRange.SelectedIndex = 0;
            comboBox_waveformType0.SelectedIndex = 0;
            comboBox_waveformType1.SelectedIndex = 1;
            comboBox_waveformType2.SelectedIndex = 0;
            comboBox_waveformType3.SelectedIndex = 1;

            comboBox_cardID.SelectedIndex = 0;
        }

        private void comboBox_cardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cardID.Text)
            {
                case "5510":
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelCount.Items.Clear();
                    for (int i = 1; i < 5; i++)
                    {
                        comboBox_channelCount.Items.Add(i);
                    }
                    break;
                case "5511":
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelCount.Items.Clear();
                    for (int i = 1; i < 5; i++)
                    {
                        comboBox_channelCount.Items.Add(i);
                    }
                    break;
                case "5515":
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelCount.Items.Clear();
                    for (int i = 1; i < 3; i++)
                    {
                        comboBox_channelCount.Items.Add(i);
                    }
                    break;
                case "5516":
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelCount.Items.Clear();
                    for (int i = 1; i < 3; i++)
                    {
                        comboBox_channelCount.Items.Add(i);
                    }
                    break;
                default:
                    numericUpDown_updateRate.Maximum = 2860000;
                    comboBox_channelCount.Items.Clear();
                    for (int i = 1; i < 5; i++)
                    {
                        comboBox_channelCount.Items.Add(i);
                    }
                    break;
            }
            comboBox_channelCount.SelectedIndex = 0;
        }

        /// <summary>
        /// Set the enable condition for the Configure Waveform button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_channelCount_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (Convert.ToInt16(comboBox_channelCount.Text))
            {
                case 1:
                    comboBox_waveformType0.Enabled = true;
                    comboBox_waveformType1.Enabled = false;
                    comboBox_waveformType2.Enabled = false;
                    comboBox_waveformType3.Enabled = false;

                    numericUpDown_waveformAmplitude0.Enabled = true;
                    numericUpDown_waveformAmplitude1.Enabled = false;
                    numericUpDown_waveformAmplitude2.Enabled = false;
                    numericUpDown_waveformAmplitude3.Enabled = false;

                    numericUpDown_waveformFrequency0.Enabled = true;
                    numericUpDown_waveformFrequency1.Enabled = false;
                    numericUpDown_waveformFrequency2.Enabled = false;
                    numericUpDown_waveformFrequency3.Enabled = false;
                    break;
                case 2:
                    comboBox_waveformType0.Enabled = true;
                    comboBox_waveformType1.Enabled = true;
                    comboBox_waveformType2.Enabled = false;
                    comboBox_waveformType3.Enabled = false;

                    numericUpDown_waveformAmplitude0.Enabled = true;
                    numericUpDown_waveformAmplitude1.Enabled = true;
                    numericUpDown_waveformAmplitude2.Enabled = false;
                    numericUpDown_waveformAmplitude3.Enabled = false;

                    numericUpDown_waveformFrequency0.Enabled = true;
                    numericUpDown_waveformFrequency1.Enabled = true;
                    numericUpDown_waveformFrequency2.Enabled = false;
                    numericUpDown_waveformFrequency3.Enabled = false;
                    break;
                case 3:
                    comboBox_waveformType0.Enabled = true;
                    comboBox_waveformType1.Enabled = true;
                    comboBox_waveformType2.Enabled = true;
                    comboBox_waveformType3.Enabled = false;

                    numericUpDown_waveformAmplitude0.Enabled = true;
                    numericUpDown_waveformAmplitude1.Enabled = true;
                    numericUpDown_waveformAmplitude2.Enabled = true;
                    numericUpDown_waveformAmplitude3.Enabled = false;

                    numericUpDown_waveformFrequency0.Enabled = true;
                    numericUpDown_waveformFrequency1.Enabled = true;
                    numericUpDown_waveformFrequency2.Enabled = true;
                    numericUpDown_waveformFrequency3.Enabled = false;
                    break;
                case 4:
                    comboBox_waveformType0.Enabled = true;
                    comboBox_waveformType1.Enabled = true;
                    comboBox_waveformType2.Enabled = true;
                    comboBox_waveformType3.Enabled = true;

                    numericUpDown_waveformAmplitude0.Enabled = true;
                    numericUpDown_waveformAmplitude1.Enabled = true;
                    numericUpDown_waveformAmplitude2.Enabled = true;
                    numericUpDown_waveformAmplitude3.Enabled = true;

                    numericUpDown_waveformFrequency0.Enabled = true;
                    numericUpDown_waveformFrequency1.Enabled = true;
                    numericUpDown_waveformFrequency2.Enabled = true;
                    numericUpDown_waveformFrequency3.Enabled = true;
                    break;
                default:
                    return;
            }
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
        /// Start output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //creat task based on the selected Solt Number
                aoTask = new JY5500AOTask(comboBox_SoltNumber.SelectedIndex);

                //AddChannel
                for (int i = 0; i < Convert.ToInt16(comboBox_channelCount.Text); i++)
                {
                    aoTask.AddChannel(i, lowRange, highRange);
                }

                //Basic parameter configuration
                aoTask.Mode = AOMode.Finite;
                aoTask.UpdateRate = (double)numericUpDown_updateRate.Value;
                aoTask.SamplesToUpdate = (int)numericUpDown_samplesToUpdate.Value;


                writeValue = new double[aoTask.SamplesToUpdate * aoTask.Channels.Count];

                //Waveform generation
                WaveGenration();

                try
                {
                    //Write data to buffer
                    aoTask.WriteData(writeValue, -1);

                    easyChartX_AO.Plot(writeValue);
                }
                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                try
                {
                   aoTask.Start();
                }
                catch (JYDriverException ex)
                {
                   //Drive error message display
                   MessageBox.Show(ex.Message);
                   return;
                }

            }
            catch (JYDriverException ex)
            {
               //Drive error message display
               MessageBox.Show(ex.Message);
               return;
            }

            //Enable timer, disable parameter configuration button
            timer_FetchData.Enabled = true;
            groupBox_genParam.Enabled = false;
            groupBox_waveConfig.Enabled = false;
            button_start.Enabled = false;
            button_stop.Enabled = true;
        }

        /// <summary>
        /// Timer, query the Task state every 100ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            //If the Task is completed, execute stop and restart the Start parameter button.
            if (aoTask.WaitUntilDone(10) == true)
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

                aoTask.Channels.Clear();

                timer_FetchData.Enabled = false;
                groupBox_genParam.Enabled = true;
                groupBox_waveConfig.Enabled = true;
                button_start.Enabled = true;
                button_stop.Enabled = false;
            }
            else
            {
                //Task is not completed, enable timer, continue to query
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

            easyChartX_AO.Clear();

            timer_FetchData.Enabled = false;
            groupBox_genParam.Enabled = true;
            groupBox_waveConfig.Enabled = true;
            button_start.Enabled = true;
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
        #endregion

        #region Methods

        /// <summary>
        /// Single Channel Waveform generation
        /// </summary>
        private void singleChannelwaveGeneration()
        {
            //Waveform setting
            double amplitude = (double)numericUpDown_waveformAmplitude0.Value;
            double frequency = (double)numericUpDown_waveformFrequency0.Value;

            switch (comboBox_waveformType0.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue, amplitude, 0, frequency, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue, amplitude, 50, frequency, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue, amplitude);//White Noise
                    break;
                default:
                    return;
            }
        }

        /// <summary>
        /// Double Channel Waveform generation
        /// </summary>
        private void TwoChannelwaveGeneration()
        {
            //Channel0 Waveform setting
            double[] writeValue0 = new double[aoTask.SamplesToUpdate];
            double amplitude0 = (double)numericUpDown_waveformAmplitude0.Value;
            double frequency0 = (double)numericUpDown_waveformFrequency0.Value;

            switch (comboBox_waveformType0.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue0, amplitude0, 0, frequency0, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue0, amplitude0, 50, frequency0, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue0, amplitude0);//White Noise
                    break;
                default:
                    return;
            }

            //Channel1 Waveform setting
            double[] writeValue1 = new double[aoTask.SamplesToUpdate];
            double amplitude1 = (double)numericUpDown_waveformAmplitude1.Value;
            double frequency1 = (double)numericUpDown_waveformFrequency1.Value;

            switch (comboBox_waveformType1.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue1, amplitude1, 0, frequency1, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue1, amplitude1, 50, frequency1, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue1, amplitude1);//White Noise
                    break;
                default:
                    return;
            }

            for (int i = 0; i < aoTask.SamplesToUpdate; i++)
            {
                writeValue[i * 2] = writeValue0[i];
                writeValue[i * 2 + 1] = writeValue1[i];
            }

        }

        /// <summary>
        /// 3 Channels Waveform generation
        /// </summary>
        private void ThreeChannelwaveGeneration()
        {
            //Channel0 Waveform setting
            double[] writeValue0 = new double[aoTask.SamplesToUpdate];
            double amplitude0 = (double)numericUpDown_waveformAmplitude0.Value;
            double frequency0 = (double)numericUpDown_waveformFrequency0.Value;

            switch (comboBox_waveformType0.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue0, amplitude0, 0, frequency0, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue0, amplitude0, 50, frequency0, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue0, amplitude0);//White Noise
                    break;
                default:
                    return;
            }

            //Channel1 Waveform setting
            double[] writeValue1 = new double[aoTask.SamplesToUpdate];
            double amplitude1 = (double)numericUpDown_waveformAmplitude1.Value;
            double frequency1 = (double)numericUpDown_waveformFrequency1.Value;

            switch (comboBox_waveformType1.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue1, amplitude1, 0, frequency1, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue1, amplitude1, 50, frequency1, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue1, amplitude1);//White Noise
                    break;
                default:
                    return;
            }

            //Channel2 Waveform setting
            double[] writeValue2 = new double[aoTask.SamplesToUpdate];
            double amplitude2 = (double)numericUpDown_waveformAmplitude2.Value;
            double frequency2 = (double)numericUpDown_waveformFrequency2.Value;

            switch (comboBox_waveformType2.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue2, amplitude2, 0, frequency2, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue2, amplitude2, 50, frequency2, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue2, amplitude2);//White Noise
                    break;
                default:
                    return;
            }

            for (int i = 0; i < aoTask.SamplesToUpdate; i++)
            {
                writeValue[i*3] = writeValue0[i];
                writeValue[i*3+1] = writeValue1[i];
                writeValue[i*3+2] = writeValue2[i];
            }
        }

        /// <summary>
        /// 4 Channels Waveform generation
        /// </summary>
        private void FourChannelwaveGeneration()
        {
            //Channel0 Waveform setting
            double[] writeValue0 = new double[aoTask.SamplesToUpdate];
            double amplitude0 = (double)numericUpDown_waveformAmplitude0.Value;
            double frequency0 = (double)numericUpDown_waveformFrequency0.Value;

            switch (comboBox_waveformType0.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue0, amplitude0, 0, frequency0, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue0, amplitude0, 50, frequency0, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue0, amplitude0);//White Noise
                    break;
                default:
                    return;
            }

            //Channel1 Waveform setting
            double[] writeValue1 = new double[aoTask.SamplesToUpdate];
            double amplitude1 = (double)numericUpDown_waveformAmplitude1.Value;
            double frequency1 = (double)numericUpDown_waveformFrequency1.Value;

            switch (comboBox_waveformType1.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue1, amplitude1, 0, frequency1, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue1, amplitude1, 50, frequency1, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue1, amplitude1);//White Noise
                    break;
                default:
                    return;
            }

            //Channel2 Waveform setting
            double[] writeValue2 = new double[aoTask.SamplesToUpdate];
            double amplitude2 = (double)numericUpDown_waveformAmplitude2.Value;
            double frequency2 = (double)numericUpDown_waveformFrequency2.Value;

            switch (comboBox_waveformType2.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue2, amplitude2, 0, frequency2, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue2, amplitude2, 50, frequency2, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue2, amplitude2);//White Noise
                    break;
                default:
                    return;
            }

            //Channel3 Waveform setting
            double[] writeValue3 = new double[aoTask.SamplesToUpdate];
            double amplitude3 = (double)numericUpDown_waveformAmplitude3.Value;
            double frequency3 = (double)numericUpDown_waveformFrequency3.Value;

            switch (comboBox_waveformType3.SelectedIndex)
            {
                case 0:
                    Generation.SineWave(ref writeValue3, amplitude3, 0, frequency3, (int)aoTask.UpdateRate);//Sine wave
                    break;
                case 1:
                    Generation.SquareWave(ref writeValue3, amplitude3, 50, frequency3, (int)aoTask.UpdateRate);//Square wave
                    break;
                case 2:
                    Generation.UniformWhiteNoise(ref writeValue3, amplitude3);//White Noise
                    break;
                default:
                    return;
            }

            for (int i = 0; i < aoTask.SamplesToUpdate; i++)
            {
                writeValue[i*4] = writeValue0[i];
                writeValue[i*4+1] = writeValue1[i];
                writeValue[i*4+2] = writeValue2[i];
                writeValue[i*4+3] = writeValue3[i];
            }
        }

        /// <summary>
        /// AO waveform generation
        /// </summary>
        private void WaveGenration()
        {
            switch(Convert.ToInt16(comboBox_channelCount.Text))
            {
                case 1:
                    singleChannelwaveGeneration();
                    break;
                case 2:
                    TwoChannelwaveGeneration();
                    break;
                case 3:
                    ThreeChannelwaveGeneration();
                    break;
                case 4:
                    FourChannelwaveGeneration();
                    break;
                default:
                    return;
            }
        }
        #endregion

    }
}
