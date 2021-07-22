using System;
using JY5500;
using System.Windows.Forms;
using System.Collections.Generic;
using SeeSharpTools.JY.DSP.Fundamental;

namespace Test5510CI_CO
{
    public partial class MainForm : Form
    {
        #region 变量声明

        #region AI变量

        private JY5500AITask aiTask;

        private double[] readValueAI;

        private double readSingleValueAI;

        //存放AI单点数据数组
        List<double> SingleValue = new List<double>();

        private double lowRangeAI;

        private double highRangeAI;

        #endregion

        #region AO变量

        /// <summary>
        ///AO Task
        /// </summary>
        private JY5500AOTask aoTask;

        /// <summary>
        /// the Buffer of data written by the aoTask
        /// </summary>
        private double[] writeValueAO;

        //存放AO单点输出
        private double writeSingleValue;

        //存放AO单点待输出数据
        List<double> AOSingleValue = new List<double>();

        /// <summary>
        /// Output waveform amplitude
        /// </summary>
        private double amplitudeAO;

        /// <summary>
        /// Output Waveform frequency
        /// </summary>
        private double frequencyAO;

        /// output low limit
        /// </summary>
        private double lowRangeAO;

        /// <summary>
        /// output high limit
        /// </summary>
        /// <returns></returns>
        private double highRangeAO;

        #endregion

        #region CI变量
        //定义CI任务
        private JY5500CITask ciTask;

        //CI任务读取数据缓冲区（edgecounting，quadencoder，TwoPulseEncoder）
        private uint[] readValue;

        //CI测量frequency，period结果存储
        private double[] MeasureValue;

        //CI测量pulse
        private double[] HighPulseMeas;
        private double[] LowPulseMeas;

        //CI测量twoedgeseparation
        private double[] FirstToSecondMeas;
        private double[] SecondToFirstMeas;


        //CI 单点
        private uint counterValue = 0;

        private double PeroidMeas;

        private double SingleHighPulseMeas;
        private double SingleLowPulseMeas;

        private double SecondToFirst;
        private double FirstToSecond;
        #endregion

        #region CO变量

        //定义CO任务
        private JY5500COTask coTask;

        #endregion

        #region DI变量

        private JY5500DITask diTask;

        /// <summary>
        /// the Buffer of data acquisition by the DITask
        /// </summary>
        private byte[,] dataBufDI;

        //单点
        private bool[] readSingleValueDI;

        #endregion

        #region DO变量

        /// <summary>
        /// DOTask
        /// </summary>
        private JY5500DOTask doTask;

        /// <summary>
        ///  the buffer of written by the DO, and the capacity is the number of samples to be output.
        /// </summary>
        private byte[,] writeValueDO;

        /// <summary>
        /// port Column
        /// </summary>
        private int cloumnDO;

        /// <summary>
        /// one Cycle Points
        /// </summary>
        private int oneCyclePointsDO;

        /// <summary>
        /// high Level Points
        /// </summary>
        private int highLevelPointsDO;

        //单点
        private bool[] writeSingleValueDO;

        #endregion

        #endregion

        #region 窗体初始化
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region  默认值设置
        //默认值设置
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region AI默认值配置

            comboBox_AISlotNumber.SelectedIndex = 0;
            for (int i = 0; i < 32; i++)
            {
                comboBox_AIChannelId.Items.Add(i);
            }

            comboBox_AIInputRange.SelectedIndex = 0;
            //Call the enumeration of AITerminal in the driver as a menu
            comboBox_AITerminalType.Items.AddRange(Enum.GetNames(typeof(AITerminal)));
            comboBox_AITerminalType.SelectedIndex = 0;

            //Call the enumeration of AISampleClockSource in the driver as a menu
            comboBox_AISampleClock.Items.AddRange(Enum.GetNames(typeof(AISampleClockSource)));
            comboBox_AISampleClock.SelectedIndex = 0;

            //Call the enumeration of ClockTerminal in the driver as a menu
            comboBox_AIExternalclockterminal.Items.AddRange(Enum.GetNames(typeof(ClockTerminal)));
            comboBox_AIExternalclockterminal.SelectedIndex = 0;

            comboBox_AIMode.Items.AddRange(Enum.GetNames(typeof(AIMode)));
            comboBox_AIMode.SelectedIndex = 0;

            comboBox_AICardId.SelectedIndex = 0;

            #endregion

            #region AO默认值配置

            comboBox_AOSlotNumber.SelectedIndex = 0;
            for (int i = 0; i < 4; i++)
            {
                comboBox_AOChannelId.Items.Add(i);
            }
            comboBox_AOOutPutRange.SelectedIndex = 0;

            comboBox_AOWaveformType.SelectedIndex = 0;

            comboBox_AOCardId.SelectedIndex = 0;

            comboBox_AOMode.Items.AddRange(Enum.GetNames(typeof(AOMode)));
            comboBox_AOMode.SelectedIndex = 0;

            button_AOStart.Enabled = true;
            button_AOStop.Enabled = false;
            button_AOUpdate.Enabled = false;

            #endregion

            #region CI默认值配置
            comboBox_SoltNumber.SelectedIndex = 0;

            for (int i = 0; i < 4; i++)
            {
                comboBox_counterNumber.Items.Add(i);
            }

            comboBox_counterNumber.SelectedIndex = 0;

            comboBox_cardID.SelectedIndex = 0;

            comboBox_countDir.Items.AddRange(Enum.GetNames(typeof(CountDirection)));

            comboBox_countDir.SelectedIndex = 0;

            comboBox_clockType.Items.AddRange(Enum.GetNames(typeof(CISampleClockSource)));

            comboBox_clockType.SelectedIndex = 1;

            comboBox_CIType.Items.AddRange(Enum.GetNames(typeof(CIType)));

            comboBox_CIType.SelectedIndex = 0;

            comboBox_CIMode.Items.AddRange(Enum.GetNames(typeof(CIMode)));

            comboBox_CIMode.SelectedIndex = 0;

            comboBox_encodeType.Items.AddRange(Enum.GetNames(typeof(QuadEncodingType)));

            comboBox_encodeType.SelectedIndex = 0;
            #endregion

            #region CO默认值配置
            comboBox_COMode.Items.AddRange(Enum.GetNames(typeof(COMode)));

            comboBox_COMode.SelectedIndex = 0;

            comboBox_COSoltNumber.SelectedIndex = 0;

            for (int i = 0; i < 4; i++)
            {
                comboBox_COCounterID.Items.Add(i);
            }
            comboBox_COCardID.SelectedIndex = 0;

            comboBox_COCounterID.SelectedIndex = 0;

            comboBox_IdleState.Items.AddRange(Enum.GetNames(typeof(COIdleState)));
            comboBox_IdleState.SelectedIndex = 0;

            comboBox_pulseType.Items.AddRange(Enum.GetNames(typeof(COPulseType)));
            comboBox_pulseType.SelectedIndex = 0;
            #endregion

            #region DI默认值配置

            comboBox_DIMode.Items.AddRange(Enum.GetNames(typeof(DIMode)));
            comboBox_DIMode.SelectedIndex = 0;

            comboBox_DISlotNumber.SelectedIndex = 0;
            comboBox_DICardId.SelectedIndex = 0;



            readSingleValueDI = new bool[8];


            #endregion

            #region DO默认值配置

            comboBox_DOMode.Items.AddRange(Enum.GetNames(typeof(DOMode)));
            comboBox_DOMode.SelectedIndex = 0;

            comboBox_DOSlotNumber.SelectedIndex = 0;
            comboBox_DOCardId.SelectedIndex = 0;
            checkBox_Port0.Checked = true;

            button_DOStart.Enabled = true;
            button_DOStop.Enabled = false;
            button_DOUpdate.Enabled = false;

            if (comboBox_DOMode.SelectedItem.Equals("Single"))
            {
                panel_DOSingle.Visible = true;
                easyChartX_DO.Visible = false;
            }
            else
            {
                panel_DOSingle.Visible = false;
                easyChartX_DO.Visible = true;
            }


            //单点
            writeSingleValueDO = new bool[8] { false, false, false, false, false, false, false, false };
            groupBox_port0.Enabled = false;
            groupBox_port1.Enabled = false;
            groupBox_port2.Enabled = false;
            groupBox_port3.Enabled = false;


            #endregion
        }
        #endregion

        #region AI

        #region AICardId选项卡更改事件
        private void comboBox_AICardId_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_AICardId.Text)
            {
                case "5510":
                    numericUpDown_sampleRate.Maximum = 2000000;
                    comboBox_AIChannelId.Items.Clear();
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_AIChannelId.Items.Add(i);
                    }

                    break;
                case "5511":
                    numericUpDown_sampleRate.Maximum = 1250000;
                    comboBox_AIChannelId.Items.Clear();
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_AIChannelId.Items.Add(i);
                    }
                    break;
                case "5515":
                    numericUpDown_sampleRate.Maximum = 2000000;
                    comboBox_AIChannelId.Items.Clear();
                    for (int i = 0; i < 16; i++)
                    {
                        comboBox_AIChannelId.Items.Add(i);
                    }
                    break;
                case "5516":
                    numericUpDown_sampleRate.Maximum = 1250000;
                    comboBox_AIChannelId.Items.Clear();
                    for (int i = 0; i < 16; i++)
                    {
                        comboBox_AIChannelId.Items.Add(i);
                    }
                    break;
                default:
                    numericUpDown_sampleRate.Maximum = 2000000;
                    comboBox_AIChannelId.Items.Clear();
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_AIChannelId.Items.Add(i);
                    }
                    break;
            }
            comboBox_AIChannelId.SelectedIndex = 0;
        }

        #endregion

        #region AIInputRange选项卡更改事件
        private void comboBox_AIInputRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_AIInputRange.SelectedIndex)
            {
                case 0:
                    lowRangeAI = -10;
                    highRangeAI = 10;
                    break;
                case 1:
                    lowRangeAI = -5;
                    highRangeAI = 5;
                    break;
                case 2:
                    lowRangeAI = -2;
                    highRangeAI = 2;
                    break;
                case 3:
                    lowRangeAI = -1;
                    highRangeAI = 1;
                    break;
                case 4:
                    lowRangeAI = -0.5;
                    highRangeAI = 0.5;
                    break;
                case 5:
                    lowRangeAI = -0.2;
                    highRangeAI = 0.2;
                    break;
                case 6:
                    lowRangeAI = -0.1;
                    highRangeAI = 0.1;
                    break;
                default:
                    lowRangeAI = -10;
                    highRangeAI = 10;
                    break;
            }
        }

        #endregion

        #region AISampleClock选项卡更改事件
        private void comboBox_AISampleClock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_AISampleClock.SelectedIndex == 0)
            {
                label_AISampleRate.Text = "Sample Rate(Sa/s)";
                label_AIExternalClock.Enabled = false;
                comboBox_AIExternalclockterminal.Enabled = false;
            }
            else
            {
                label_AISampleRate.Text = "Expected Rate(Sa/s)";
                label_AIExternalClock.Enabled = true;
                comboBox_AIExternalclockterminal.Enabled = true;
            }
        }

        #endregion

        #region AI启动事件
        private void button_AIStart_Click(object sender, EventArgs e)
        {
            try
            {
                //New aiTask based on the selected Solt Number
                aiTask = new JY5500AITask(comboBox_AISlotNumber.SelectedIndex);

                //Addchannel 
                aiTask.AddChannel(comboBox_AIChannelId.SelectedIndex, lowRangeAI, highRangeAI, (AITerminal)Enum.Parse(typeof(AITerminal), comboBox_AITerminalType.Text));

                //Basic parameter configuration
                aiTask.Mode = (AIMode)Enum.Parse(typeof(AIMode), comboBox_AIMode.Text, true);
                aiTask.SampleClock.Source = (AISampleClockSource)Enum.Parse(typeof(AISampleClockSource), comboBox_AISampleClock.Text, true);
                aiTask.SampleRate = (double)numericUpDown_AISampleRate.Value;

                if (aiTask.SampleClock.Source == AISampleClockSource.External)
                {
                    aiTask.SampleClock.External.Terminal = (ClockTerminal)Enum.Parse(typeof(ClockTerminal), comboBox_AIExternalclockterminal.Text, true);
                    aiTask.SampleClock.External.ExpectedRate = (double)numericUpDown_AISampleRate.Value;
                }

                #region AI Single
                //AI Single
                if (comboBox_AIMode.SelectedItem.Equals("Single"))
                {
                    try
                    {
                        aiTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        toolStripStatusLabel.Text = "aiTask start failed";
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }
                #endregion

                #region AI Continuous
                //AI Continuous
                if (comboBox_AIMode.SelectedItem.Equals("Continuous"))
                {
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

                    readValueAI = new double[(int)numericUpDown_AISampleAcquire.Value];
                }
                #endregion

                #region AI Finite
                //AI Finite
                if (comboBox_AIMode.SelectedItem.Equals("Finite"))
                {
                    try
                    {
                        aiTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        toolStripStatusLabel.Text = "aiTask start failed";
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    readValueAI = new double[(int)numericUpDown_AISampleAcquire.Value];
                }
                #endregion

                //Enable timer, disable parameter configuration button and start button, display status
                timer_AI.Enabled = true;
                groupBox_AIParmConfig.Enabled = false;
                button_AIStart.Enabled = false;
                button_AIStop.Enabled = true;
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
        #endregion

        #region AI定时器
        private void timer_AI_Tick(object sender, EventArgs e)
        {
            timer_AI.Enabled = false;

            if (comboBox_AIMode.SelectedItem.Equals("Single"))
            {
                aiTask.ReadSinglePoint(ref readSingleValueAI, (int)(comboBox_AIChannelId.SelectedItem));
                SingleValue.Add(readSingleValueAI);
                easyChartX_AIReadData.Plot(SingleValue);
                timer_AI.Enabled = true;
            }

            if (comboBox_AIMode.SelectedItem.Equals("Continuous"))
            {
                try
                {
                    //Read data and display if the local buffer data is enough
                    if (aiTask.AvailableSamples >= (ulong)readValueAI.Length)
                    {
                        //Read data stored in readValue
                        aiTask.ReadData(ref readValueAI, readValueAI.Length, -1);
                        toolStripStatusLabel.Text = "Reading data...";
                        //Display data
                        easyChartX_AIReadData.Plot(readValueAI);
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
                timer_AI.Enabled = true;
            }

            if (comboBox_AIMode.SelectedItem.Equals("Finite"))
            {
                try
                {
                    if (aiTask.AvailableSamples >= (ulong)readValueAI.Length)
                    {
                        //Read  data
                        aiTask.ReadData(ref readValueAI, readValueAI.Length, -1);
                        easyChartX_AIReadData.Plot(readValueAI);

                        try
                        {
                            //Stop ATTask data acquisition
                            aiTask.Stop();
                        }

                        catch (JYDriverException ex)
                        {
                            //Drive error message display
                            MessageBox.Show(ex.Message);
                            return;
                        }

                        //Clear the channel that was added last time
                        aiTask.Channels.Clear();

                        //Disable timer and Stop button, enable start button and parameter configuration button
                        timer_AI.Enabled = false;
                        groupBox_AIParmConfig.Enabled = true;
                        button_AIStart.Enabled = true;
                        button_AIStop.Enabled = false;

                    }
                    else
                    {
                        timer_AI.Enabled = true;
                    }
                }
                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

        }
        #endregion

        #region AI关闭事件
        private void button_AIStop_Click(object sender, EventArgs e)
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
            timer_AI.Enabled = false;
            groupBox_AIParmConfig.Enabled = true;
            button_AIStart.Enabled = true;
            button_AIStop.Enabled = false;
            toolStripStatusLabel.Text = "Stop data acquisition";
        }
        #endregion

        #endregion

        #region AO

        #region AO启动事件
        private void button_AOStart_Click(object sender, EventArgs e)
        {
            try
            {
                //new aoTask based on the selected Solt Number
                aoTask = new JY5500AOTask(comboBox_AOSlotNumber.SelectedIndex);

                //AddChannel
                aoTask.AddChannel(comboBox_AOChannelId.SelectedIndex, lowRangeAO, highRangeAO);

                //Basic parameter configuration
                aoTask.Mode = (AOMode)Enum.Parse(typeof(AOMode), comboBox_AOMode.Text, true);
                aoTask.UpdateRate = (double)numericUpDown_AOUpdateRate.Value;

                writeValueAO = new double[(int)numericUpDown_AOUpdateRate.Value];
                //Waveform generation
                waveGeneration();

                if (comboBox_AOMode.SelectedItem.Equals("ContinuousNoWrapping"))
                {
                    try
                    {
                        //Write data to buffer
                        aoTask.WriteData(writeValueAO, -1);

                        easyChartX_AO.Plot(writeValueAO);

                    }
                    catch (JYDriverException ex)
                    {
                        //Display driver error message
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    try
                    {
                        //StartAOtask
                        aoTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        //Display driver error message
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }


                if (comboBox_AOMode.SelectedItem.Equals("ContinuousWrapping"))
                {
                    try
                    {
                        //Write data to buffer
                        aoTask.WriteData(writeValueAO, -1);

                        easyChartX_AO.Plot(writeValueAO);
                    }
                    catch (JYDriverException ex)
                    {
                        //Display driver error message
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    try
                    {
                        //StartTask
                        aoTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        //Display driver error message
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

                if (comboBox_AOMode.SelectedItem.Equals("Single"))
                {

                }

                if (comboBox_AOMode.SelectedItem.Equals("Finite"))
                {
                    aoTask.SamplesToUpdate = (int)numericUpDown_AOSamplesToUpdate.Value;

                    try
                    {
                        //Write data to buffer
                        aoTask.WriteData(writeValueAO, -1);

                        easyChartX_AO.Plot(writeValueAO);
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

                }

            }
            catch (JYDriverException ex)
            {
                //Display driver error message
                MessageBox.Show(ex.Message);
                return;
            }

            //Enable timer, disable parameter configuration button and start button

            if (!comboBox_DOMode.SelectedItem.Equals("ContinunousWrapping"))
            {
                timer_AO.Enabled = true;
            }
            groupBox_AOGenParam.Enabled = false;
            button_AOStart.Enabled = false;
            button_AOStop.Enabled = true;
            button_AOUpdate.Enabled = true;
        }

        #endregion

        #region AO波形生成Methods
        /// <summary>
        /// Waveform generation
        /// </summary>
        private void waveGeneration()
        {
            //Waveform setting
            amplitudeAO = (double)numericUpDown_AOWaveformAmplitude.Value;
            frequencyAO = (double)numericUpDown_AOWaveformFrequency.Value;
            switch (comboBox_AOWaveformType.SelectedIndex)
            {
                case 0:
                    //Sine wave
                    Generation.SineWave(ref writeValueAO, amplitudeAO, 0, frequencyAO, aoTask.UpdateRate);
                    break;
                case 1:
                    //Square wave
                    Generation.SquareWave(ref writeValueAO, amplitudeAO, 50, frequencyAO, aoTask.UpdateRate);
                    break;
                case 2:
                    //White Noise
                    Generation.UniformWhiteNoise(ref writeValueAO, amplitudeAO);
                    break;
                default:
                    return;
            }
        }


        #endregion

        #region AOCardId选项卡更改事件
        private void comboBox_AOCardId_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cardID.Text)
            {
                case "5510":
                    numericUpDown_AOUpdateRate.Maximum = 2860000;
                    comboBox_AOChannelId.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_AOChannelId.Items.Add(i);
                    }
                    break;
                case "5511":
                    numericUpDown_AOUpdateRate.Maximum = 2860000;
                    comboBox_AOChannelId.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_AOChannelId.Items.Add(i);
                    }
                    break;
                case "5515":
                    numericUpDown_AOUpdateRate.Maximum = 2860000;
                    comboBox_AOChannelId.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_AOChannelId.Items.Add(i);
                    }
                    break;
                case "5516":
                    numericUpDown_AOUpdateRate.Maximum = 2860000;
                    comboBox_AOChannelId.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_AOChannelId.Items.Add(i);
                    }
                    break;
                default:
                    numericUpDown_AOUpdateRate.Maximum = 2860000;
                    comboBox_AOChannelId.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_AOChannelId.Items.Add(i);
                    }
                    break;
            }
            comboBox_AOChannelId.SelectedIndex = 0;
        }

        #endregion

        #region AOOutPutRange选项卡更改事件
        private void comboBox_AOOutPutRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_AOOutPutRange.SelectedIndex)
            {
                case 0:
                    lowRangeAO = -10;
                    highRangeAO = 10;
                    break;
                case 1:
                    lowRangeAO = -5;
                    highRangeAO = 5;
                    break;
                default:
                    lowRangeAO = -10;
                    highRangeAO = 10;
                    break;
            }
        }

        #endregion

        #region AO关闭事件
        private void button_AOStop_Click(object sender, EventArgs e)
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

            //Disable timer, enable Start button and parameter configuration button
            timer_AO.Enabled = false;
            groupBox_AOGenParam.Enabled = true;
            button_AOStart.Enabled = true;
            button_AOStop.Enabled = false;
            button_AOUpdate.Enabled = false;
        }

        #endregion

        #region AO更新事件
        private void button_AOUpdate_Click(object sender, EventArgs e)
        {
            timer_AO.Enabled = false;

            waveGeneration();

            timer_AO.Enabled = true;
        }

        #endregion

        #region AO定时器
        private void timer_AO_Tick(object sender, EventArgs e)
        {
            timer_AO.Enabled = false;

            if (comboBox_AOMode.SelectedItem.Equals("ContinuousNoWrapping")) {

                if (aoTask.AvaliableLenInSamples >= writeValueAO.Length)
                {
                aoTask.WriteData(writeValueAO, -1);

                easyChartX_AO.Plot(writeValueAO);
                }

            //Enable the timer and continue to check if the buffer data is enough
            timer_AO.Enabled = true;
            }



            if (comboBox_AOMode.SelectedItem.Equals("Single"))
            {

                //写入单点数据
                writeSingleValue = amplitudeAO;

                aoTask.WriteSinglePoint(writeSingleValue, (int)comboBox_AIChannelId.SelectedItem);

                AOSingleValue.Add(writeSingleValue);


                //启动AO任务
                aoTask.Start();

                easyChartX_AO.Plot(AOSingleValue);

                timer_AO.Enabled = true;
            }

            if (comboBox_AOMode.SelectedItem.Equals("Finite"))
            {

                if (aoTask.WaitUntilDone(10) == true)
                {
                    try
                    {
                        if (aoTask != null)
                        {
                            aoTask.Stop();
                        }
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    //Clear channel
                    aoTask.Channels.Clear();

                    easyChartX_AO.Clear();

                    //Disable timer and Stop buttons, enable parameter configuration button and start button
                    timer_AO.Enabled = false;
                    groupBox_AOGenParam.Enabled = true;
                    groupBox_AOWaveConfig.Enabled = true;
                    button_AOStart.Enabled = true;
                    button_AOUpdate.Enabled = false;
                    button_AOStop.Enabled = false;
                }
                else
                {
                    //Task is not completed, enable the timer, continue to query whether the task is completed
                    timer_AO.Enabled = true;
                }
            }

        }
        #endregion

        #endregion

        #region CI

        #region CI板卡号选项卡更改事件

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
        #endregion

        #region CI启动事件
        //开始CI任务
        private void button_Start_Click(object sender, EventArgs e)
        {
            try
            {
                ciTask = new JY5500CITask(comboBox_SoltNumber.SelectedIndex, comboBox_counterNumber.SelectedIndex);

                ciTask.Type = (CIType)Enum.Parse(typeof(CIType), comboBox_CIType.Text, true);

                ciTask.Mode = (CIMode)Enum.Parse(typeof(CIMode), comboBox_CIMode.Text, true);


                ciTask.SampleClock.Source = (CISampleClockSource)Enum.Parse(typeof(CISampleClockSource), comboBox_clockType.Text, true);

                if (ciTask.SampleClock.Source == CISampleClockSource.Internal)
                {
                    ciTask.SampleClock.Internal.Rate = (double)numericUpDown_sampleRate.Value;
                }
                else
                {
                    ciTask.SampleClock.Implicit.ExpectedRate = (double)numericUpDown_sampleRate.Value;
                }

                #region CI Continunous
                //CI continuous+edgecounting
                if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("EdgeCounting"))
                {
                    ciTask.EdgeCounting.Direction = (CountDirection)Enum.Parse(typeof(CountDirection), comboBox_countDir.Text, true);
                    ciTask.EdgeCounting.InitialCount = (int)numericUpDown_initCount.Value;
                    try
                    {
                        ciTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    readValue = new uint[(int)numericUpDown_samples.Value];

                }

                //CI continuous+FrequencyMeasure
                if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("Frequency"))
                {
                    try
                    {
                        ciTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    MeasureValue = new double[(int)numericUpDown_samples.Value];

                }

                //CI continuous+PeriodMeasure
                if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("Period"))
                {
                    try
                    {
                        ciTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    MeasureValue = new double[(int)numericUpDown_samples.Value];

                }

                //CI continuous+PulseMeasure
                if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("Pulse"))
                {
                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    HighPulseMeas = new double[(int)numericUpDown_samples.Value];
                    LowPulseMeas = new double[(int)numericUpDown_samples.Value];

                }

                //CI continuous+QuadEncoder
                if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("QuadEncoder"))
                {
                    ciTask.QuadEncoder.ZReloadEnabled = false;

                    ciTask.QuadEncoder.EncodingType = (QuadEncodingType)Enum.Parse(typeof(QuadEncodingType), comboBox_encodeType.Text, true);

                    ciTask.QuadEncoder.InitialCount = 0;

                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    readValue = new uint[(int)numericUpDown_samples.Value];

                }

                //CI continuous+TwoEdgeSeparation
                if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("TwoEdgeSeparation"))
                {
                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    FirstToSecondMeas = new double[(int)numericUpDown_samples.Value];
                    SecondToFirstMeas = new double[(int)numericUpDown_samples.Value];

                }

                //CI continuous+TwoPulseEncoder
                if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("TwoPulseEncoder"))
                {
                    ciTask.EdgeCounting.InitialCount = 0;
                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    readValue = new uint[(int)numericUpDown_samples.Value];

                }
                #endregion

                #region CI Finite
                //CI Finite+edgecounting
                if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("EdgeCounting"))
                {
                    ciTask.SamplesToAcquire = (uint)numericUpDown_samples.Value;
                    ciTask.EdgeCounting.Direction = (CountDirection)Enum.Parse(typeof(CountDirection), comboBox_countDir.Text, true);
                    ciTask.EdgeCounting.InitialCount = (int)numericUpDown_initCount.Value;
                    try
                    {
                        ciTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    readValue = new uint[ciTask.SamplesToAcquire];

                }

                //CI Finite+FrequencyMeasure
                if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("Frequency"))
                {
                    ciTask.SamplesToAcquire = (uint)numericUpDown_samples.Value;

                    try
                    {
                        ciTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    MeasureValue = new double[ciTask.SamplesToAcquire];

                }

                //CI Finite+PeriodMeasure
                if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("Period"))
                {
                    ciTask.SamplesToAcquire = (uint)numericUpDown_samples.Value;

                    try
                    {
                        ciTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    MeasureValue = new double[(int)numericUpDown_samples.Value];

                }

                //CI Finite+PulseMeasure
                if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("Pulse"))
                {

                    ciTask.SamplesToAcquire = (uint)numericUpDown_samples.Value;

                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    HighPulseMeas = new double[(int)numericUpDown_samples.Value];
                    LowPulseMeas = new double[(int)numericUpDown_samples.Value];

                }

                //CI Finite+QuadEncoder
                if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("QuadEncoder"))
                {
                    ciTask.SamplesToAcquire = (uint)numericUpDown_samples.Value;

                    ciTask.QuadEncoder.ZReloadEnabled = false;

                    ciTask.QuadEncoder.EncodingType = (QuadEncodingType)Enum.Parse(typeof(QuadEncodingType), comboBox_encodeType.Text, true);

                    ciTask.QuadEncoder.InitialCount = 0;

                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    readValue = new uint[ciTask.SamplesToAcquire];

                }

                //CI Finite+TwoEdgeSeparation
                if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("TwoEdgeSeparation"))
                {
                    ciTask.SamplesToAcquire = (uint)numericUpDown_samples.Value;

                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    FirstToSecondMeas = new double[(int)numericUpDown_samples.Value];
                    SecondToFirstMeas = new double[(int)numericUpDown_samples.Value];

                }

                //CI Finite+TwoPulseEncoder
                if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("TwoPulseEncoder"))
                {
                    ciTask.SamplesToAcquire = (uint)numericUpDown_samples.Value;
                    ciTask.EdgeCounting.InitialCount = 0;
                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    readValue = new uint[ciTask.SamplesToAcquire];

                }
                #endregion

                #region CI Single
                //CI Single+edgecounting
                if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("EdgeCounting"))
                {
                    ciTask.EdgeCounting.Direction = (CountDirection)Enum.Parse(typeof(CountDirection), comboBox_countDir.Text, true);
                    ciTask.EdgeCounting.InitialCount = (int)numericUpDown_initCount.Value;
                    try
                    {
                        ciTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }


                }

                //CI Single+FrequencyMeasure
                if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("Frequency"))
                {
                    try
                    {
                        ciTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }

                //CI Single+PeriodMeasure
                if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("Period"))
                {
                    try
                    {
                        ciTask.Start();
                    }
                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    MeasureValue = new double[(int)numericUpDown_samples.Value];

                }

                //CI Single+PulseMeasure
                if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("Pulse"))
                {
                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }


                }

                //CI Single+QuadEncoder
                if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("QuadEncoder"))
                {
                    ciTask.QuadEncoder.EncodingType = (QuadEncodingType)Enum.Parse(typeof(QuadEncodingType), comboBox_encodeType.Text, true);

                    ciTask.QuadEncoder.ZReloadEnabled = false;

                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }


                }

                //CI Single+TwoEdgeSeparation
                if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("TwoEdgeSeparation"))
                {
                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }

                //CI Single+TwoPulseEncoder
                if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("TwoPulseEncoder"))
                {
                    ciTask.TwoPulseEncoder.InitialCount = 0;
                    try
                    {
                        ciTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }
                #endregion

                timer_CI.Enabled = true;
                groupBox_genPara.Enabled = false;
                button_Start.Enabled = false;
                button_stop.Enabled = true;

            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        #region clockType选项卡更改事件
        private void comboBox_clockType_SelectedIndexChanged(object sender, EventArgs e)
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

        #endregion

        #region CItype选项卡改变事件
        private void comboBox_CIType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CI edgecounting
            if (comboBox_CIType.SelectedItem.Equals("EdgeCounting"))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("CounterValues", "CounterValues");
                dataGridView1.Columns[0].Width = 460;

            }

            //CI frequency
            if (comboBox_CIType.SelectedItem.Equals("Frequency"))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("FrequencyMeasure(Hz)", "FrequencyMeasure(Hz)");
                dataGridView1.Columns[0].Width = 460;

            }

            //CI period
            if (comboBox_CIType.SelectedItem.Equals("Period"))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("PeriodMeas(S)", "PeriodMeas(S)");
                dataGridView1.Columns[0].Width = 460;

            }

            //CI pulse
            if (comboBox_CIType.SelectedItem.Equals("Pulse"))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("HighPulseMeas(S)", "HighPulseMeas(S)");
                dataGridView1.Columns[0].Width = 230;
                dataGridView1.Columns.Add("LowPulseMeas(S)", "LowPulseMeas(S)");
                dataGridView1.Columns[1].Width = 230;

            }

            //CI quadencoder
            if (comboBox_CIType.SelectedItem.Equals("QuadEncoder"))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("CounterValues", "CounterValues");
                dataGridView1.Columns[0].Width = 460;

            }

            //CI twoedgeseparation
            if (comboBox_CIType.SelectedItem.Equals("TwoEdgeSeparation"))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("FirstToSecondMeas(S)", "FirstToSecondMeas(S)");
                dataGridView1.Columns[0].Width = 230;
                dataGridView1.Columns.Add("SecondToFirstMeas(S)", "SecondToFirstMeas(S)");
                dataGridView1.Columns[1].Width = 230;
            }

            //CI twopulseencoder
            if (comboBox_CIType.SelectedItem.Equals("TwoPulseEncoder"))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("CounterValues", "CounterValues");
                dataGridView1.Columns[0].Width = 460;

            }
        }
        #endregion

        #region CI定时器
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_CI.Enabled = false;

            #region CI Continuous定时器
            //CI continuous+edgecounting
            if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("EdgeCounting"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)readValue.Length)
                    {
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

                timer_CI.Enabled = true;
            }

            //CI continuous+FrequencyMeasure
            if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("Frequency"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)MeasureValue.Length)
                    {
                        ciTask.ReadData(ref MeasureValue, (int)numericUpDown_samples.Value, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < MeasureValue.Length; i++)
                        {
                            dataGridView1.Rows.Add(MeasureValue[i]);
                        }
                    }
                }
                catch (JYDriverException ex)
                {
                    //Display driver error message
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI continuous+PeriodMeasure
            if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("Period"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)MeasureValue.Length)
                    {
                        ciTask.ReadData(ref MeasureValue, (int)numericUpDown_samples.Value, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < MeasureValue.Length; i++)
                        {
                            dataGridView1.Rows.Add(MeasureValue[i]);
                        }
                    }

                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI continuous+PulseMeasure
            if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("Pulse"))
            {
                try
                {
                    if ((int)ciTask.AvailableSamples >= HighPulseMeas.Length)
                    {
                        ciTask.ReadData(ref HighPulseMeas, ref LowPulseMeas, (int)numericUpDown_samples.Value, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < LowPulseMeas.Length; i++)
                        {
                            dataGridView1.Rows.Add(HighPulseMeas[i], LowPulseMeas[i]);
                        }
                    }
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI continuous+QuadEncoder
            if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("QuadEncoder"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)readValue.Length)
                    {
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

                timer_CI.Enabled = true;
            }

            //CI continuous+TwoEdgeSeparation
            if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("TwoEdgeSeparation"))
            {
                try
                {
                    ciTask.ReadData(ref FirstToSecondMeas, ref SecondToFirstMeas, (int)numericUpDown_samples.Value, -1);
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < SecondToFirstMeas.Length; i++)
                    {
                        dataGridView1.Rows.Add(FirstToSecondMeas[i], SecondToFirstMeas[i]);
                    }
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI continuous+TwoPulseEncoder
            if (comboBox_CIMode.SelectedItem.Equals("Continuous") && comboBox_CIType.SelectedItem.Equals("TwoPulseEncoder"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)readValue.Length)
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

                timer_CI.Enabled = true;
            }
            #endregion

            #region CI Finite定时器
            //CI Finite+edgecounting
            if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("EdgeCounting"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)readValue.Length)
                    {
                        ciTask.ReadData(ref readValue, (int)ciTask.SamplesToAcquire, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < readValue.Length; i++)
                        {
                            dataGridView1.Rows.Add(readValue[i]);
                        }

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

                        numericUpDown_sampleRate.Enabled = true;
                        timer_CI.Enabled = false;
                        button_Start.Enabled = true;
                        groupBox_genPara.Enabled = true;
                        button_stop.Enabled = false;
                    }
                    else
                    {
                        timer_CI.Enabled = true;
                    }
                }
                catch (JYDriverException ex)
                {
                    //Display driver error message
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            //CI Finite+FrequencyMeasure
            if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("Frequency"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)MeasureValue.Length)
                    {
                        ciTask.ReadData(ref MeasureValue, (int)numericUpDown_samples.Value, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < MeasureValue.Length; i++)
                        {
                            dataGridView1.Rows.Add(MeasureValue[i]);
                        }

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


                        numericUpDown_sampleRate.Enabled = true;
                        timer_CI.Enabled = false;
                        button_Start.Enabled = true;
                        groupBox_genPara.Enabled = true;
                        button_stop.Enabled = false;
                    }
                    else
                    {
                        timer_CI.Enabled = true;
                    }
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            //CI Finite+PeriodMeasure
            if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("Period"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)MeasureValue.Length)
                    {
                        ciTask.ReadData(ref MeasureValue, (int)numericUpDown_samples.Value, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < MeasureValue.Length; i++)
                        {
                            dataGridView1.Rows.Add(MeasureValue[i]);
                        }

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

                        numericUpDown_sampleRate.Enabled = true;
                        timer_CI.Enabled = false;
                        button_Start.Enabled = true;
                        groupBox_genPara.Enabled = true;
                        button_stop.Enabled = false;
                    }
                    else
                    {
                        timer_CI.Enabled = true;
                    }
                }
                catch (JYDriverException ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            //CI Finite+PulseMeasure
            if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("Pulse"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)LowPulseMeas.Length)
                    {
                        ciTask.ReadData(ref HighPulseMeas, ref LowPulseMeas, (int)numericUpDown_samples.Value, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < LowPulseMeas.Length; i++)
                        {
                            dataGridView1.Rows.Add(HighPulseMeas[i], LowPulseMeas[i]);
                        }

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

                        numericUpDown_sampleRate.Enabled = true;
                        timer_CI.Enabled = false;
                        button_Start.Enabled = true;
                        groupBox_genPara.Enabled = true;
                        button_stop.Enabled = false;
                    }
                    else
                    {
                        timer_CI.Enabled = true;
                    }
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            //CI Finite+QuadEncoder
            if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("QuadEncoder"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)readValue.Length)
                    {
                        ciTask.ReadData(ref readValue, (int)ciTask.SamplesToAcquire, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < readValue.Length; i++)
                        {
                            dataGridView1.Rows.Add(readValue[i]);
                        }

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

                        numericUpDown_sampleRate.Enabled = true;
                        timer_CI.Enabled = false;
                        button_Start.Enabled = true;
                        groupBox_genPara.Enabled = true;
                        button_stop.Enabled = false;
                    }
                    else
                    {
                        timer_CI.Enabled = true;
                    }
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            //CI Finite+TwoEdgeSeparation
            if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("TwoEdgeSeparation"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)SecondToFirstMeas.Length)
                    {

                        ciTask.ReadData(ref FirstToSecondMeas, ref SecondToFirstMeas, (int)numericUpDown_samples.Value, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < SecondToFirstMeas.Length; i++)
                        {
                            dataGridView1.Rows.Add(FirstToSecondMeas[i], SecondToFirstMeas[i]);
                        }

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

                        //disable timer and stop button ,enable Parameter configuration button and start button
                        numericUpDown_sampleRate.Enabled = true;
                        timer_CI.Enabled = false;
                        button_Start.Enabled = true;
                        groupBox_genPara.Enabled = true;
                        button_stop.Enabled = false;
                    }
                    else
                    {
                        timer_CI.Enabled = true;
                    }
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            //CI Finite+TwoPulseEncoder
            if (comboBox_CIMode.SelectedItem.Equals("Finite") && comboBox_CIType.SelectedItem.Equals("TwoPulseEncoder"))
            {
                try
                {
                    if (ciTask.AvailableSamples >= (ulong)readValue.Length)
                    {
                        ciTask.ReadData(ref readValue, (int)ciTask.SamplesToAcquire, -1);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < readValue.Length; i++)
                        {
                            dataGridView1.Rows.Add(readValue[i]);
                        }

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

                        numericUpDown_sampleRate.Enabled = true;
                        timer_CI.Enabled = false;
                        button_Start.Enabled = true;
                        groupBox_genPara.Enabled = true;
                        button_stop.Enabled = false;
                    }
                    else
                    {
                        timer_CI.Enabled = true;
                    }
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }


            }
            #endregion

            #region CI Single定时器
            //CI Single+edgecounting
            if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("EdgeCounting"))
            {
                try
                {
                    ciTask.ReadSinglePoint(ref counterValue);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(counterValue.ToString());
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI Single+FrequencyMeasure
            if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("Frequency"))
            {
                try
                {
                    ciTask.ReadSinglePoint(ref PeroidMeas);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(PeroidMeas.ToString());
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI Single+PeriodMeasure
            if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("Period"))
            {
                try
                {
                    //读取测量值并显示
                    ciTask.ReadSinglePoint(ref PeroidMeas);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(PeroidMeas.ToString());
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI Single+PulseMeasure
            if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("Pulse"))
            {
                try
                {
                    //读取测量值并显示
                    ciTask.ReadSinglePoint(ref SingleLowPulseMeas, ref SingleHighPulseMeas);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(SingleLowPulseMeas.ToString(), SingleHighPulseMeas.ToString());
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI Single+QuadEncoder
            if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("QuadEncoder"))
            {
                try
                {
                    ciTask.ReadSinglePoint(ref counterValue);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(counterValue.ToString());
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI Single+TwoEdgeSeparation
            if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("TwoEdgeSeparation"))
            {
                try
                {
                    ciTask.ReadSinglePoint(ref FirstToSecond, ref SecondToFirst);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(FirstToSecond.ToString(), SecondToFirst.ToString());

                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }

            //CI Single+TwoPulseEncoder
            if (comboBox_CIMode.SelectedItem.Equals("Single") && comboBox_CIType.SelectedItem.Equals("TwoPulseEncoder"))
            {
                try
                {
                    ciTask.ReadSinglePoint(ref counterValue);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(counterValue.ToString());
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_CI.Enabled = true;
            }
            #endregion

        }
        #endregion

        #region CI结束按钮事件
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
            timer_CI.Enabled = false;
            groupBox_genPara.Enabled = true;
            button_Start.Enabled = true;
            button_stop.Enabled = false;
        }

        #endregion

        #endregion

        #region CO

        #region COCardID选项卡改变事件
        private void comboBox_COCardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_COCardID.Text)
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

        #endregion

        #region pulseType选项卡更改事件
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

        #region CO启动事件
        private void button_COStart_Click(object sender, EventArgs e)
        {
            try
            {
                coTask = new JY5500COTask(comboBox_COSoltNumber.SelectedIndex, comboBox_COCounterID.SelectedIndex);

                coTask.Mode = (COMode)Enum.Parse(typeof(COMode), comboBox_COMode.Text, true);                

                coTask.IdleState = (COIdleState)Enum.Parse(typeof(COIdleState), comboBox_IdleState.Text, true);

                COPulse pulse = new COPulse((COPulseType)Enum.Parse(typeof(COPulseType), comboBox_pulseType.Text, true),
                    Convert.ToDouble(numericUpDown_highPulseWidth.Value), Convert.ToDouble(numericUpDown_lowPulseWidth.Value),
                   -1);


                if (comboBox_COMode.SelectedItem.Equals("Continuous"))
                {
                    coTask.WriteSinglePoint(pulse);
                    try
                    {
                        coTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    groupBox_paraConfig.Enabled = false;
                    groupBox_PulsePara.Enabled = true;
                    numericUpDown_highPulseWidth.Enabled = true;
                    numericUpDown_lowPulseWidth.Enabled = true;
                    comboBox_pulseType.Enabled = true;
                    comboBox_IdleState.Enabled = false;
                    label_idleState.Enabled = false;
                    button_COStart.Enabled = false;
                    button_COStop.Enabled = true;
                    button1.Enabled = true;

                }

                if (comboBox_COMode.SelectedItem.Equals("Finite"))
                {
                    coTask.WriteSinglePoint(pulse);
                    try
                    {
                        coTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    timer_CO.Enabled = true;
                    groupBox_paraConfig.Enabled = false;
                    groupBox_PulsePara.Enabled = false;
                    button_COStart.Enabled = false;
                    button_COStop.Enabled = true;
                }

                if (comboBox_COMode.SelectedItem.Equals("Single"))
                {
                    coTask.InitialDelay = (uint)numericUpDown_initialDelay.Value;

                    coTask.WriteSinglePoint(pulse);

                    try
                    {
                        coTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    if (!comboBox_DOMode.SelectedItem.Equals("Continunous"))
                    {
                        timer_CO.Enabled = true;
                    }
                    groupBox_paraConfig.Enabled = false;
                    groupBox_PulsePara.Enabled = false;
                    button_COStart.Enabled = false;
                    button_COStop.Enabled = true;
                }

            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        #endregion

        #region CO停止事件
        private void button_COStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (coTask != null)
                {
                    coTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            groupBox_paraConfig.Enabled = true;
            groupBox_PulsePara.Enabled = true;
            comboBox_IdleState.Enabled = true;
            label_idleState.Enabled = true;
            button_COStart.Enabled = true;
            button_COStop.Enabled = false;
            button1.Enabled = false;
        }
        #endregion

        #region CObutton1事件
        private void button1_Click(object sender, EventArgs e)
        {
            coTask.WriteSinglePoint(new COPulse((COPulseType)Enum.Parse(typeof(COPulseType), comboBox_pulseType.Text, true),
                    Convert.ToDouble(numericUpDown_highPulseWidth.Value), Convert.ToDouble(numericUpDown_lowPulseWidth.Value),
                   -1));
        }
        #endregion

        #region CO定时器

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_CO.Enabled = false;

            if (comboBox_COMode.SelectedItem.Equals("Finite"))
            {
                if (coTask.WaitUntilDone() == true)
                {
                    try
                    {
                        if (coTask != null)
                        {
                            coTask.Stop();
                        }
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    timer_CO.Enabled = false;
                    groupBox_paraConfig.Enabled = true;
                    groupBox_PulsePara.Enabled = true;
                    button_COStart.Enabled = true;
                    button_COStop.Enabled = false;
                }
                else
                {
                    timer_CO.Enabled = true;
                }
            }

            if (comboBox_COMode.SelectedItem.Equals("Single"))
            {

                if (coTask.WaitUntilDone() == true)
                {
                    try
                    {
                        if (coTask != null)
                        {
                            coTask.Stop();
                        }
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    timer_CO.Enabled = false;
                    groupBox_paraConfig.Enabled = true;
                    groupBox_PulsePara.Enabled = true;
                    button_COStart.Enabled = true;
                    button_COStop.Enabled = false;
                }
                else
                {
                    timer_CO.Enabled = true;
                }

            }
        }

        #endregion

        #endregion

        #region DI

        #region DICardId选项卡更改事件
        private void comboBox_DICardId_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_DICardId.Text)
            {
                case "5510":
                case "5511":
                    checkedListBox_DIPortChoose.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        checkedListBox_DIPortChoose.Items.Add("port" + i);
                    }
                    break;
                case "5515":
                case "5516":
                    checkedListBox_DIPortChoose.Items.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        checkedListBox_DIPortChoose.Items.Add("port" + i);
                    }
                    break;
                default:
                    checkedListBox_DIPortChoose.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        checkedListBox_DIPortChoose.Items.Add("port" + i);
                    }
                    break;
            }
        }

        #endregion

        #region DI启动事件
        private void button_DIStart_Click(object sender, EventArgs e)
        {
            try
            {
                //new DITask based on the selected Solt Number
                diTask = new JY5500DITask(comboBox_DISlotNumber.SelectedIndex);

                //AddChannel
                for (int i = 0; i < checkedListBox_DIPortChoose.Items.Count; i++)
                {
                    if (checkedListBox_DIPortChoose.GetItemChecked(i))
                    {
                        diTask.AddChannel(i);
                    }
                }

                //Parameter configuration
                diTask.Mode = (DIMode)Enum.Parse(typeof(DIMode), comboBox_DIMode.Text, true);
                diTask.SampleRate = (double)numericUpDown_DISampleRate.Value;

                #region DI Continunous
                if (comboBox_DIMode.SelectedItem.Equals("Continuous"))
                {
                    try
                    {
                        //Start ATTask data acquisition
                        diTask.Start();
                        //dotask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        toolStripStatusLabel.Text = "StartDITask start failed";
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    dataBufDI = new byte[(int)numericUpDown_DIReadSamples.Value, diTask.Channels.Count];
                }
                #endregion

                #region DI Finite
                if (comboBox_DIMode.SelectedItem.Equals("Finite"))
                {
                    diTask.SamplesToAcquire = (int)numericUpDown_DISamplesToAcquire.Value;
                    try
                    {
                        //Start ATTask data acquisition
                        diTask.Start();
                        //dotask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        toolStripStatusLabel.Text = "StartDITask start failed";
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    dataBufDI = new byte[diTask.SamplesToAcquire, diTask.Channels.Count];
                }
                #endregion

                #region DI Single
                if (comboBox_DIMode.SelectedItem.Equals("Single"))
                {
                    try
                    {
                        //Start ATTask data acquisition
                        diTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    //read data 
                    for (int i = 0; i < checkedListBox_DIPortChoose.Items.Count; i++)
                    {
                        if (checkedListBox_DIPortChoose.GetItemChecked(i))
                        {
                            diTask.ReadSinglePoint(ref readSingleValueDI, i);

                            switch (i)
                            {
                                case 0:
                                    ledArray1.Value = readSingleValueDI;
                                    break;
                                case 1:
                                    ledArray2.Value = readSingleValueDI;
                                    break;
                                case 2:
                                    ledArray3.Value = readSingleValueDI;
                                    break;
                                case 3:
                                    ledArray4.Value = readSingleValueDI;
                                    break;
                                default:
                                    MessageBox.Show("only support 4 port");
                                    return;
                            }
                        }
                    }

                    try
                    {
                        if (diTask != null)
                        {
                            diTask.Stop();
                        }
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                #endregion

                //Disable parameter setting and start button to enable timer function

                if (!comboBox_DIMode.SelectedItem.Equals("Single"))
                {
                    timer_DI.Enabled = true;
                }
                groupBox_DIParamConfig.Enabled = false;
                button_DIStart.Enabled = false;
                button_DIStop.Enabled = true;
            }

            catch (JYDriverException ex)
            {
                toolStripStatusLabel.Text = "diTask start failed";
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
        }
        #endregion
        
        #region DI关闭事件
        private void button_DIStop_Click(object sender, EventArgs e)
        {
            try
            {
                //Determine if the task exists
                if (diTask != null)
                {
                    //Stop Task 
                    diTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //Clear the channel that was added last time
            diTask.Channels.Clear();

            //Enable parameter setting and start button to disable timer function
            timer_DI.Enabled = false;
            groupBox_DIParamConfig.Enabled = true;
            button_DIStart.Enabled = true;
            button_DIStop.Enabled = false;
            toolStripStatusLabel.Text = "Stop data acquisition";
        }

        #endregion

        #region DI定时器
        private void timer_DI_Tick(object sender, EventArgs e)
        {
            timer_DI.Enabled = false;

            if (comboBox_DIMode.SelectedItem.Equals("Continuous"))
            {
                try
                {
                    if (diTask.AvailableSamples >= (ulong)dataBufDI.GetLength(0))
                    {
                        diTask.ReadData(ref dataBufDI, (uint)dataBufDI.GetLength(0), -1);
                        toolStripStatusLabel.Text = "Reading in data...";
                        easyChartX_DI.Plot(dataBufDI, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);
                    }
                }
                catch (JYDriverException ex)
                {
                    toolStripStatusLabel.Text = " start read data failed";
                    timer_DI.Enabled = false;
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_DI.Enabled = true;
            }

            if (comboBox_DIMode.SelectedItem.Equals("Finite"))
            {
                if (diTask.AvailableSamples >= (ulong)dataBufDI.GetLength(0))
                {
                    diTask.ReadData(ref dataBufDI, (uint)dataBufDI.GetLength(0), -1);
                    toolStripStatusLabel.Text = "Reading in data...";
                    easyChartX_DI.Plot(dataBufDI, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);

                    try
                    {
                        if (diTask != null)
                        {
                            diTask.Stop();
                        }
                    }

                    catch (JYDriverException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    //Clear the channel that was added last time
                    diTask.Channels.Clear();

                    //Enable parameter setting and start button to disable timer function
                    timer_DI.Enabled = false;
                    groupBox_DIParamConfig.Enabled = true;
                    button_DIStart.Enabled = true;
                    button_DIStop.Enabled = false;
                }
                else
                {
                    timer_DI.Enabled = true;
                }

            }
        }
        #endregion

        #endregion

        #region DO

        #region DOCardId选项卡更改事件
        private void comboBox_DOCardId_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_DOCardId.Text)
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

        #endregion

        #region DOUpdate事件
        private void button_DOUpdate_Click(object sender, EventArgs e)
        {
            timer_DO.Enabled = false;

            GenerateData();
            //display data
            easyChartX_DO.Plot(writeValueDO, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);

            timer_DO.Enabled = true;
        }
        #endregion

        #region DO GenerateData,ControlThePortEnable Methods
        /// <summary>
        /// Generate Data
        /// </summary>
        private void GenerateData()
        {
            //Generate digital signal
            cloumnDO = 0;
            if (checkBox_Port0.Checked)
            {
                // cal one cycle points
                oneCyclePointsDO = (int)(doTask.UpdateRate / (double)numericUpDown_port0_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPointsDO = (int)(oneCyclePointsDO * (double)numericUpDown_port0_duty.Value);

                //write data
                for (int i = 0; i < (int)(doTask.UpdateRate / oneCyclePointsDO); i++)
                {
                    for (int j = 0; j < oneCyclePointsDO; j++)
                    {
                        if (j < highLevelPointsDO)
                        {
                            writeValueDO[i * oneCyclePointsDO + j, cloumnDO] = 0xFF;
                        }
                        else
                        {
                            writeValueDO[i * oneCyclePointsDO + j, cloumnDO] = 0x00;
                        }
                    }
                }

                // cloumn add
                cloumnDO++;
            }
            if (checkBox_Port1.Checked)
            {
                // cal one cycle points
                oneCyclePointsDO = (int)(doTask.UpdateRate / (double)numericUpDown_port1_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPointsDO = (int)(oneCyclePointsDO * (double)numericUpDown_port1_duty.Value);

                //write data
                for (int i = 0; i < (int)(doTask.UpdateRate / oneCyclePointsDO); i++)
                {
                    for (int j = 0; j < oneCyclePointsDO; j++)
                    {
                        if (j < highLevelPointsDO)
                        {
                            writeValueDO[i * oneCyclePointsDO + j, cloumnDO] = 0xFF;
                        }
                        else
                        {
                            writeValueDO[i * oneCyclePointsDO + j, cloumnDO] = 0x00;
                        }
                    }
                }

                // cloumn add
                cloumnDO++;
            }
            if (checkBox_Port2.Checked)
            {
                // cal one cycle points
                oneCyclePointsDO = (int)(doTask.UpdateRate / (double)numericUpDown_port2_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPointsDO = (int)(oneCyclePointsDO * (double)numericUpDown_port2_duty.Value);

                //write data
                for (int i = 0; i < (int)(doTask.UpdateRate / oneCyclePointsDO); i++)
                {
                    for (int j = 0; j < oneCyclePointsDO; j++)
                    {
                        if (j < highLevelPointsDO)
                        {
                            writeValueDO[i * oneCyclePointsDO + j, cloumnDO] = 0xFF;
                        }
                        else
                        {
                            writeValueDO[i * oneCyclePointsDO + j, cloumnDO] = 0x00;
                        }
                    }
                }

                // cloumn add
                cloumnDO++;
            }
            if (checkBox_Port3.Checked)
            {
                // cal one cycle points
                oneCyclePointsDO = (int)(doTask.UpdateRate / (double)numericUpDown_port3_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPointsDO = (int)(oneCyclePointsDO * (double)numericUpDown_port3_duty.Value);

                //write data
                for (int i = 0; i < (int)(doTask.UpdateRate / oneCyclePointsDO); i++)
                {
                    for (int j = 0; j < oneCyclePointsDO; j++)
                    {
                        if (j < highLevelPointsDO)
                        {
                            writeValueDO[i * oneCyclePointsDO + j, cloumnDO] = 0xFF;
                        }
                        else
                        {
                            writeValueDO[i * oneCyclePointsDO + j, cloumnDO] = 0x00;
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

        #region DO启动事件
        private void button_DOStart_Click(object sender, EventArgs e)
        {
            try
            {
                //New DOTask based on the selected Solt Number
                doTask = new JY5500DOTask(comboBox_DOSlotNumber.SelectedIndex);

                //AddChannel
                if (checkBox_Port0.Checked)
                {
                    doTask.AddChannel(0);
                }
                if (checkBox_Port1.Checked)
                {
                    doTask.AddChannel(1);
                }
                if (checkBox_Port2.Checked)
                {
                    doTask.AddChannel(2);
                }
                if (checkBox_Port3.Checked)
                {
                    doTask.AddChannel(3);
                }

                //Parameter configuration
                doTask.Mode = (DOMode)Enum.Parse(typeof(DOMode),comboBox_DOMode.Text,true);
                doTask.UpdateRate = (double)numericUpDown_DOUpdateRate.Value;

                writeValueDO = new byte[(int)doTask.UpdateRate, doTask.Channels.Count];
                //GenerateData
                GenerateData();

                if (comboBox_DOMode.SelectedItem.Equals("ContinuousNoWrapping"))
                {
                    //display data
                    easyChartX_DO.Plot(writeValueDO, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);

                    try
                    {
                        //Write data to buffer
                        doTask.WriteData(writeValueDO, (uint)writeValueDO.GetLength(0), -1);
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
                        doTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

                if (comboBox_DOMode.SelectedItem.Equals("ContinuousWrapping"))
                {
                    //display data
                    easyChartX_DO.Plot(writeValueDO, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);

                    try
                    {
                        //Write data to buffer
                        doTask.WriteData(writeValueDO, (uint)writeValueDO.GetLength(0), -1);
                    }

                    catch (JYDriverException ex)
                    {
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    try
                    {
                        //Start DOTask data acquisition
                        doTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

                if (comboBox_DOMode.SelectedItem.Equals("Finite"))
                {
                    doTask.SamplesToUpdate = (int)numericUpDown_DOSampleToUpdate.Value;

                    //display data
                    easyChartX_DO.Plot(writeValueDO, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);

                    try
                    {
                        //Write data to buffer
                        doTask.WriteData(writeValueDO, (uint)writeValueDO.GetLength(0), -1);
                    }

                    catch (JYDriverException ex)
                    {
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    try
                    {
                        //startDOTask
                        doTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

                if (comboBox_DOMode.SelectedItem.Equals("Single"))
                {
                    //Add channels
                    for (int i = 0; i < checkedListBox_DOPortChoose.Items.Count; i++)
                    {
                        if (checkedListBox_DOPortChoose.GetItemChecked(i))
                        {
                            doTask.AddChannel(i);
                        }
                    }
                    //Configure DOMode
                    doTask.Mode = DOMode.Single;

                    //write data
                    for (int i = 0; i < checkedListBox_DOPortChoose.Items.Count; i++)
                    {
                        if (checkedListBox_DOPortChoose.GetItemChecked(i))
                        {
                            switch (i)
                            {
                                case 0:
                                    writeSingleValueDO = switchArrayport0.Value;
                                    break;
                                case 1:
                                    writeSingleValueDO = switchArrayport1.Value;
                                    break;
                                case 2:
                                    writeSingleValueDO = switchArrayport2.Value;
                                    break;
                                case 3:
                                    writeSingleValueDO = switchArrayport3.Value;
                                    break;
                            }
                            doTask.WriteSinglePoint(writeSingleValueDO, i);

                        }
                    }

                    try
                    {
                        //Start ATTask data acquisition
                        doTask.Start();
                    }

                    catch (JYDriverException ex)
                    {
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    groupBox_port0.Enabled = true;
                    groupBox_port1.Enabled = true;
                    groupBox_port2.Enabled = true;
                    groupBox_port3.Enabled = true;
                }


                //disable Parameter configuration button
                if (!comboBox_DOMode.SelectedItem.Equals("ContinunousWrapping") && !comboBox_DOMode.SelectedItem.Equals("Single"))
                {
                    timer_DO.Enabled = true;
                }
                groupBox_DOGenParam.Enabled = false;
                button_DOStart.Enabled = false;
                button_DOStop.Enabled = true;
                button_DOUpdate.Enabled = true;
                ControlThePortEnable(false);
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        #endregion

        #region DO关闭事件
        private void button_DOStop_Click(object sender, EventArgs e)
        {
            try
            {
                //Determine if the task exists
                if (doTask != null)
                {
                    //Stop Task 
                    doTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //Clear the channel that was added last time
            doTask.Channels.Clear();

            //enable Start Parameter configuration button
            timer_DO.Enabled = false;
            groupBox_DOGenParam.Enabled = true;
            button_DOStart.Enabled = true;
            button_DOStop.Enabled = false;
            button_DOUpdate.Enabled = false;
            ControlThePortEnable(true);

            groupBox_port0.Enabled = false;
            groupBox_port1.Enabled = false;
            groupBox_port2.Enabled = false;
            groupBox_port3.Enabled = false;
        }

        #endregion

        #region DO定时器
        private void timer_DO_Tick(object sender, EventArgs e)
        {
            timer_DO.Enabled = false;

            if (comboBox_DOMode.SelectedItem.Equals("ContinuousNoWrapping"))
            {
                try
                {
                    //Write data to buffer if the number of write points in the buffer is 
                    //greater than or equal to the length of Write data to buffer
                    if (doTask.AvaliableLenInSamples >= writeValueDO.GetLength(0))
                    {
                        doTask.WriteData(writeValueDO, (uint)writeValueDO.GetLength(0), -1);
                    }
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                timer_DO.Enabled = true;
            }

            if (comboBox_DOMode.SelectedItem.Equals("Finite"))
            {
                if (doTask.WaitUntilDone(10))
                {
                    try
                    {
                        //Determine if the task exists
                        if (doTask != null)
                        {
                            //Stop Task 
                            doTask.Stop();
                        }
                    }
                    catch (JYDriverException ex)
                    {
                        //Drive error message display
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    //Disable timer and Stop button, re-enable Start and parameter configuration buttons
                    timer_DO.Enabled = false;
                    groupBox_DOGenParam.Enabled = true;
                    button_DOStart.Enabled = true;
                    button_DOStop.Enabled = false;
                    ControlThePortEnable(true);
                }
                else
                {
                    timer_DO.Enabled = true;
                }
            }
        }


        #endregion

        #region DOMode选项卡更改事件
        private void comboBox_DOMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_DOMode.SelectedItem.Equals("Single"))
            {
                panel_DOSingle.Visible = true;
                easyChartX_DO.Visible = false;
            }
            else
            {
                panel_DOSingle.Visible = false;
                easyChartX_DO.Visible = true;
            }
        }

        #endregion

        #region DO Single switchArrayport_ControlValueChanged
        private void switchArrayport0_ControlValueChanged(object sender, SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventArgs e)
        {
            // port 0 is checked
            if (checkedListBox_DOPortChoose.GetItemChecked(0))
            {
                //The result of the Switch switch is assigned to the cached array that holds the data
                writeSingleValueDO = switchArrayport0.Value;

                //Write data to buffer
                doTask.WriteSinglePoint(writeSingleValueDO, 0);
            }
        }

        private void switchArrayport1_ControlValueChanged(object sender, SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventArgs e)
        {
            // port 1 is checked
            if (checkedListBox_DOPortChoose.GetItemChecked(1))
            {
                //The result of the Switch switch is assigned to the cached array that holds the data
                writeSingleValueDO = switchArrayport1.Value;

                //Write data to buffer
                doTask.WriteSinglePoint(writeSingleValueDO, 1);
            }
        }

        private void switchArrayport2_ControlValueChanged(object sender, SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventArgs e)
        {
                // port 2 is checked
                if (checkedListBox_DOPortChoose.GetItemChecked(2))
                {
                    //The result of the Switch switch is assigned to the cached array that holds the data
                    writeSingleValueDO = switchArrayport2.Value;

                    //Write data to buffer
                    doTask.WriteSinglePoint(writeSingleValueDO, 2);
                }
        
        }

        private void switchArrayport3_ControlValueChanged(object sender, SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventArgs e)
        {
            // port 3 is checked
            if (checkedListBox_DOPortChoose.GetItemChecked(3))
            {
                //The result of the Switch switch is assigned to the cached array that holds the data
                writeSingleValueDO = switchArrayport3.Value;

                //Write data to buffer
                doTask.WriteSinglePoint(writeSingleValueDO, 3);
            }
        }
        #endregion

        #endregion

        #region 窗体关闭事件
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                if (aiTask != null)
                {
                    aiTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            try
            {
                if (aoTask != null)
                {
                    aoTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

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

            try
            {
                if (coTask != null)
                {
                    coTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                if (diTask != null)
                {
                    diTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                if (doTask != null)
                {
                    doTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }



        #endregion

    }
}
