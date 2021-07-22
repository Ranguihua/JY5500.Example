using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JYUSB61902;
using SeeSharpTools.JY.DSP.Fundamental;

namespace Test1902AI_AO
{
    public partial class MainForm : Form
    {
        #region 窗体初始化
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 变量声明
        /**
         * 变量声明
         */

        //定义AI任务
        private JYUSB61902AITask aitask;

        //存放AI采集到的数据
        private double[] readValue;

        //存放单点AI数据
        private double readSingleValue;

        //存放AI单点数据数组
        List<double> SingleValue = new List<double>();

        //定义AO任务
        private JYUSB61902AOTask aotask;

        // 存放AO待更新的数据，容量为待更新样点数
        private double[] writeValue;

        //存放AO单点输出
        private double writeSingleValue;

        //存放AO单点待输出数据
        List<double> AOSingleValue = new List<double>();

        // 输出波形幅度
        private double amplitude;

        // 输出波形频率
        private double frequency;

        // 定义CI任务
        private JYUSB61902CITask citask;

        // CI计数值,uint;0 到 4,294,967,295（2的32次方）;无符号 32 位整数
        private uint counterValue;

        #endregion

        #region 默认参数配置
        /**
         * 默认参数配置
         */
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            /**
             * AI
             */
            //板卡号默认为下拉框第一个选项
            comboBox_BoardNumber.SelectedIndex = 0;

            //通道号默认为下拉框第一个选项
            comboBox_ChannelId.SelectedIndex = 0;

            //设置连接方式下拉框选项并默认其值为下拉框第一个选项
            comboBox_Terminal.Items.AddRange(Enum.GetNames(typeof(AITerminal)));
            comboBox_Terminal.SelectedIndex = 0;

            //设置采样模式下拉框选项并默认其值为下拉框第二个选项
            comboBox_Mode.Items.AddRange(Enum.GetNames(typeof(AIMode)));
            comboBox_Mode.SelectedIndex = 1;

            //量程范围默认为下拉框第一个选项
            comboBox_Range.SelectedIndex = 0;

            /**
             * AO
             */
            //连接方式默认为下拉框第一个选项
            comboBox_Terminal.SelectedIndex = 0;

            //通道号默认为下拉框第一个选项
            comboBox_AOChannelId.SelectedIndex = 0;

            //设置输出模式下拉框选项并默认其值为下拉框第一个选项
            comboBox_OutputMode.Items.AddRange(Enum.GetNames(typeof(AOMode)));
            comboBox_OutputMode.SelectedIndex = 0;

            //设置波形默认为下拉框第一个
            comboBox_WaveType.SelectedIndex = 0;


            if (comboBox_OutputMode.SelectedIndex == 0)
            {
                numericUpDown_SampleUpdate.Enabled = false;
                numericUpDown_UpdateRate.Enabled = false;
            }

            /**
             * CI
             */
            //板卡号默认为下拉框第一个选项
            comboBox_CIBoardNumber.SelectedIndex = 0;

            //计数器默认为下拉框第一个选项
            comboBox_counterNumber.SelectedIndex = 0;

            //CI模式默认为下拉框第一个选项
            comboBox_CIMode.Items.AddRange(Enum.GetNames(typeof(CIMode)));
            comboBox_CIMode.SelectedIndex = 0;

            //时钟默认为下拉框第一个选项
            comboBox_ClockSource.Items.AddRange(Enum.GetNames(typeof(CIClockSource)));
            comboBox_ClockSource.SelectedIndex = 0;

            //gate默认为下拉框第一个选项
            comboBox_gateSource.Items.AddRange(Enum.GetNames(typeof(CIGateSource)));
            comboBox_gateSource.SelectedIndex = 0;

            //计数方向默认为下拉框第一个选项
            comboBox_countDIR.Items.AddRange(Enum.GetNames(typeof(CountDirection)));
            comboBox_countDIR.SelectedIndex = 0;

            //测量类型默认为下拉框第一个选项
            comboBox_MeasureType.Items.AddRange(Enum.GetNames(typeof(MeasureType)));
            comboBox_MeasureType.SelectedIndex = 0;

            if(comboBox_CIMode.SelectedItem.Equals("Counter") || comboBox_CIMode.SelectedItem.ToString() == "Counter")
            {
                label_MeasureType.Visible = false;
                comboBox_MeasureType.Visible = false;
                groupBox_MeasureResult.Visible = false;
                groupBox_countResult.Visible = true;
                label_GateSource.Enabled = true;
                comboBox_gateSource.Enabled = true;
                label_CountingDIR.Enabled = true;
                comboBox_countDIR.Enabled = true;
            }

            else if (comboBox_CIMode.SelectedItem.Equals("Measure") || comboBox_CIMode.SelectedItem.ToString() == "Measure")
            {
                label_MeasureType.Visible = true;
                comboBox_MeasureType.Visible = true;
                groupBox_MeasureResult.Visible = true;
                groupBox_countResult.Visible = false;
                label_GateSource.Enabled = false;
                comboBox_gateSource.Enabled = false;
                label_CountingDIR.Enabled = false;
                comboBox_countDIR.Enabled = false;
            }

        }
        #endregion

        #region AI
        #region AI模式选项卡改变事件
        private void comboBox_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //单点模式读取数据
            if (comboBox_Mode.SelectedItem.Equals("Single") || (String)comboBox_Mode.SelectedItem == "Single")
            {
                easyChartX_AI.Visible = false;
                easyChartX_AISingle.Visible = true;
            }

            //连续模式读取数据
            else if (comboBox_Mode.SelectedItem.Equals("Continuous") || (String)comboBox_Mode.SelectedItem == "Continuous")
            {
                easyChartX_AI.Visible = true;
                easyChartX_AISingle.Visible = false;
            }

            //有限模式读取数据
            else if (comboBox_Mode.SelectedItem.Equals("Finite") || (String)comboBox_Mode.SelectedItem == "Finite")
            {
                easyChartX_AI.Visible = true;
                easyChartX_AISingle.Visible = false;
            }
            else
            {
                easyChartX_AI.Visible = true;
                easyChartX_AISingle.Visible = false;
            }
        }
        #endregion

        #region AI启动事件
        private void button_Start_Click(object sender, EventArgs e)
        {
            try { 
            //初始化板卡
            aitask = new JYUSB61902AITask(int.Parse(comboBox_BoardNumber.Text));

            //添加通道
            string range = comboBox_Range.Text.Substring(1);
            double rangLow = -double.Parse(range);
            double rangHigh = double.Parse(range);
            aitask.AddChannel(int.Parse(comboBox_ChannelId.Text), rangLow, rangHigh, (AITerminal)Enum.Parse(typeof(AITerminal), comboBox_Terminal.Text, true));
            //aitask.AddChannel(0, -10,10,(AITerminal)Enum.Parse(typeof(AITerminal), comboBox2.Text, true));

            //设置AI模式
            aitask.Mode = (AIMode)Enum.Parse(typeof(AIMode), comboBox_Mode.Text, true);

            //设置AI的采样率
            aitask.SampleRate = (double)numericUpDown_SampleRate.Value;

            //设置AI的SamplesAquire
            aitask.SamplesToAcquire = (int)numericUpDown_SampleAcquire.Value;

            //启动任务
            aitask.Start();



            //单点模式读取数据
            if (aitask.Mode.Equals("Single") || aitask.Mode.ToString() == "Single")
            {
                easyChartX_AI.Visible = false;
                easyChartX_AISingle.Visible = true;
                aitask.SampleRate = 1;
                //打开定时器和停止按钮，屏蔽其它控件
                timer3.Enabled = true;
                button_Stop.Enabled = true;
                groupBox_SetAIParaments.Enabled = false;
                //button_Start.Enabled = false;

            }

            //连续模式读取数据
            else if (aitask.Mode.Equals("Continuous") || aitask.Mode.ToString() == "Continuous")
            {
                easyChartX_AI.Visible = true;
                easyChartX_AISingle.Visible = false;

                //采集的数据
                readValue = new double[(int)numericUpDown_SampleRate.Value / 10];

                //设置AI的采样率
                aitask.SampleRate = (double)numericUpDown_SampleRate.Value;

                //打开停止按钮和定时器，屏蔽其它控件
                timer1.Enabled = true; ;
                button_Stop.Enabled = true;
                groupBox_SetAIParaments.Enabled = false;
                button_Start.Enabled = false;
            }

            //有限模式读取数据
            else if (aitask.Mode.Equals("Finite") || aitask.Mode.ToString() == "Finite")
            {
                easyChartX_AI.Visible = true;
                easyChartX_AISingle.Visible = false;

                //采集的数据
                readValue = new double[aitask.SamplesToAcquire];
                //设置AI的采样率
                aitask.SampleRate = (double)numericUpDown_SampleRate.Value;

                //打开停止按钮，屏蔽其它控件
                timer2.Enabled = true; ;
                button_Stop.Enabled = true;
                groupBox_SetAIParaments.Enabled = false;
                button_Start.Enabled = false;
            }
            else
            {
                //设置AI的采样率
                aitask.SampleRate = (double)numericUpDown_SampleRate.Value;
                easyChartX_AI.Visible = true;
                easyChartX_AISingle.Visible = false;

                //打开停止按钮，屏蔽其它控件
                button_Stop.Enabled = true;
                groupBox_SetAIParaments.Enabled = false;
                //button_Start.Enabled = false;
            }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        #endregion
        
        #region AI单点模式定时器
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            //单点模式
            if (aitask.Mode.Equals("Single") || aitask.Mode.ToString() == "Single")
            {

                aitask.ReadSinglePoint(ref readSingleValue);
                SingleValue.Add(readSingleValue);
                easyChartX_AISingle.Plot(SingleValue);
            }

            timer3.Enabled = true;
        }
        #endregion
        
        #region AI有限模式定时器
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            //有限模式
            if (aitask.Mode.Equals("Finite") || aitask.Mode.ToString() == "Finite")
            {
                //如果本地缓冲区数据足够则读取数据并显示，如果不够，返回
                if (aitask.AvailableSamples >= readValue.Length)
                {
                    aitask.ReadData(ref readValue, readValue.Length, -1);
                    easyChartX_AI.Plot(readValue);

                    if (aitask != null)
                    {
                        aitask.Stop();
                    }

                    //禁用定时器，重新启动参数配置按钮
                    timer2.Enabled = false;
                    groupBox_SetAIParaments.Enabled = true;
                    button_Start.Enabled = true;
                    button_Stop.Enabled = false;
                }
                else
                {
                    timer2.Enabled = true;
                }

            }
        }
        #endregion
        
        #region AI连续模式定时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //连续模式
            if (aitask.Mode.Equals("Continuous") || aitask.Mode.ToString() == "Continuous")
            {
                //如果本地缓冲区数据足够则读取数据并显示，如果不够，返回
                if (aitask.AvailableSamples >= readValue.Length)
                {
                    aitask.ReadData(ref readValue, readValue.Length, -1);
                    easyChartX_AI.Plot(readValue);
                }
            }

            timer1.Enabled = true;
        }
        #endregion
        
        #region AI停止事件
        private void button_Stop_Click(object sender, EventArgs e)
        {
            //如果有任务存在，则停止任务
            if (aitask != null)
            {
                aitask?.Stop();
            }

            //清空上次启动添加的通道
            aitask.Channels.Clear();

            //禁用停止按钮，重新启动参数配置按钮
            groupBox_SetAIParaments.Enabled = true;
            button_Start.Enabled = true;

            //连续模式
            if (aitask.Mode.Equals("Continuous") || aitask.Mode.ToString() == "Continuous")
            {
                button_Stop.Enabled = false;
                timer1.Enabled = false;
            }

            //单点模式
            if (aitask.Mode.Equals("Single") || aitask.Mode.ToString() == "Single")
            {
                //button_Stop.Enabled = false;
                timer3.Enabled = false;
            }

            //有限模式
            if (aitask.Mode.Equals("Finite") || aitask.Mode.ToString() == "Finite")
            {
                //button_Stop.Enabled = false;
                timer2.Enabled = false;
                groupBox_SetAIParaments.Enabled = true;
                button_Start.Enabled = true;
                button_Stop.Enabled = false;
            }
        }
        #endregion
        #endregion

        #region AO
        #region AO输出模式选项卡改变事件
        private void comboBox_OutputMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //单点才有更新按钮
            if (comboBox_OutputMode.SelectedIndex == 0)
            {
                button_Update.Visible = true;
                numericUpDown_SampleUpdate.Enabled = false;
                numericUpDown_UpdateRate.Enabled = false;
            }
            else
            {
                button_Update.Visible = false;
                numericUpDown_SampleUpdate.Enabled = true;
                numericUpDown_UpdateRate.Enabled = true;
            }


            if (comboBox_OutputMode.SelectedIndex == 1)
            {
                numericUpDown_SampleUpdate.Value = 100000;
            }
            else if (comboBox_OutputMode.SelectedIndex == 2)
            {
                numericUpDown_SampleUpdate.Value = 1000000;
            }
            else if (comboBox_OutputMode.SelectedIndex == 3)
            {
                numericUpDown_UpdateRate.Value = 100000;
                numericUpDown_SampleUpdate.Value = 10000;
            }

        }
        #endregion

        #region AO启动事件
        private void button_AOStart_Click(object sender, EventArgs e)
        {
            //初始化AO任务
            aotask = new JYUSB61902AOTask(comboBox_BoardNumber.SelectedIndex);

            //添加通道
            string range = comboBox_Range.Text.Substring(1);
            double rangLow = -double.Parse(range);
            double rangHigh = double.Parse(range);
            aotask.AddChannel(comboBox_AOChannelId.SelectedIndex, rangLow, rangHigh);

            //基本参数配置
            aotask.Mode = (AOMode)Enum.Parse(typeof(AOMode), comboBox_OutputMode.Text, true);
            aotask.UpdateRate = (double)numericUpDown_UpdateRate.Value;
            aotask.SamplesToUpdate = (int)numericUpDown_SampleUpdate.Value;

            //波形设置
            writeValue = new double[(int)numericUpDown_UpdateRate.Value];
            amplitude = (double)numericUpDown_Amplitude.Value;
            frequency = (double)numericUpDown_Frequency.Value;
            switch (comboBox_WaveType.SelectedIndex)
            {
                case 0:
                    //正弦波
                    Generation.SineWave(ref writeValue, amplitude, 0, frequency, aotask.UpdateRate);
                    break;
                case 1:
                    //方波
                    Generation.SquareWave(ref writeValue, amplitude, 50, frequency, aotask.UpdateRate);
                    break;
                case 2:
                    //白噪声
                    Generation.UniformWhiteNoise(ref writeValue, amplitude);
                    break;
                default:
                    return;
            }


            //单点模式输出数据
            if (comboBox_OutputMode.SelectedItem.Equals("Single") || (String)comboBox_OutputMode.SelectedItem == "Single")
            {

                timer6.Enabled = true;
                groupBox_SetAOParaments.Enabled = false;
                numericUpDown_Frequency.Enabled = false;
                comboBox_WaveType.Enabled = false;
                button_AOStart.Enabled = false;
                button_AOStop.Enabled = true;
            }

            //有限模式输出数据
            else if (comboBox_OutputMode.SelectedItem.Equals("Finite") || (String)comboBox_OutputMode.SelectedItem == "Finite")
            {
                //写入数据
                aotask.WriteData(writeValue, -1);

                //输出画图
                easyChartX_AO.Plot(writeValue);

                //启动AO任务
                aotask.Start();

                timer4.Enabled = true;
                groupBox_SetAOParaments.Enabled = false;
                groupBox_SetWave.Enabled = false;
                button_AOStart.Enabled = false;
                button_AOStop.Enabled = true;
            }

            //ContinuousNoWrapping模式输出数据
            else if (comboBox_OutputMode.SelectedItem.Equals("ContinuousNoWrapping") || (String)comboBox_OutputMode.SelectedItem == "ContinuousNoWrapping")
            {

                timer5.Enabled = true;
                groupBox_SetAOParaments.Enabled = false;
                groupBox_SetWave.Enabled = false;
                button_AOStart.Enabled = false;
                button_AOStop.Enabled = true;
            }

            //ContinuousWrapping模式输出数据
            else if (comboBox_OutputMode.SelectedItem.Equals("ContinuousWrapping") || (String)comboBox_OutputMode.SelectedItem == "ContinuousWrapping")
            {

                //写入数据
                aotask.WriteData(writeValue, -1);
                try
                {
                    //启动AO任务
                    aotask.Start();
                }
                catch (JYDriverException ex)
                {
                    //显示驱动错误信息
                    MessageBox.Show(ex.Message);
                    return;
                }
                //输出画图
                easyChartX_AO.Plot(writeValue);

                //打开停止按钮，禁用参数配置按钮
                groupBox_SetAOParaments.Enabled = false;
                groupBox_SetWave.Enabled = false;
                button_AOStart.Enabled = false;
                button_AOStop.Enabled = true;
            }


        }
        #endregion

        #region AO单点模式更新按钮事件
        private void button_Update_Click(object sender, EventArgs e)
        {

            //波形设置
            writeValue = new double[(int)numericUpDown_UpdateRate.Value];
            amplitude = (double)numericUpDown_Amplitude.Value;
            frequency = (double)numericUpDown_Frequency.Value;
            switch (comboBox_WaveType.SelectedIndex)
            {
                case 0:
                    //正弦波
                    Generation.SineWave(ref writeValue, amplitude, 0, frequency, aotask.UpdateRate);
                    break;
                case 1:
                    //方波
                    Generation.SquareWave(ref writeValue, amplitude, 50, frequency, aotask.UpdateRate);
                    break;
                case 2:
                    //白噪声
                    Generation.UniformWhiteNoise(ref writeValue, amplitude);
                    break;
                default:
                    return;
            }
            amplitude = (double)numericUpDown_Amplitude.Value;
            timer6.Enabled = true;
            //groupBox_SetAOParaments.Enabled = true;
            button_AOStart.Enabled = false;
            button_AOStop.Enabled = true;
        }
        #endregion  

        #region AO单点模式定时器
        //单点模式AO
        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Enabled = false;

            //写入单点数据
            writeSingleValue = amplitude;

            aotask.WriteSinglePoint(writeSingleValue);

            AOSingleValue.Add(writeSingleValue);


            //启动AO任务
            aotask.Start();

            easyChartX_AO.Plot(AOSingleValue);

            timer6.Enabled = true;
        }
        #endregion

        #region AO有限模式定时器
        //有限模式AO
        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = false;

            //如果任务已完成，则执行stop，重新启动参数按钮
            if (aotask.WaitUntilDone(10))
            {
                try
                {
                    if (aotask != null) //判断是否任务存在
                    {
                        //停止任务
                        aotask.Stop();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                aotask.Channels.Clear();

                timer4.Enabled = false;
                groupBox_SetAOParaments.Enabled = true;
                groupBox_SetWave.Enabled = true;
                button_AOStart.Enabled = true;
                button_AOStop.Enabled = false;
            }

            else
            {
                //任务未完成，使能定时器，继续查询
                timer4.Enabled = true;
            }
        }
        #endregion

        #region AO连续非环绕模式定时器
        //连续非环绕模式AO
        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Enabled = false;

            if (aotask.AvaliableLenInSamples >= writeValue.Length)
            {
                //写入数据
                aotask.WriteData(writeValue, -1);

                //启动AO任务
                aotask.Start();

                //输出画图
                easyChartX_AO.Plot(writeValue);
            }

            //使能定时器，继续检查缓冲区数据是否足够
            timer5.Enabled = true;
        }
        #endregion

        #region AO停止事件
        private void button_AOStop_Click(object sender, EventArgs e)
        {

            if (aotask != null) //判断是否任务存在
            {
                //停止任务
                aotask.Stop();
            }

            //打开开始按钮，启用参数配置按钮
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            groupBox_SetAOParaments.Enabled = true;
            groupBox_SetWave.Enabled = true;
            numericUpDown_Frequency.Enabled = true;
            comboBox_WaveType.Enabled = true;
            button_AOStart.Enabled = true;
            button_AOStop.Enabled = false;
            button_Update.Visible = false;
        }
        #endregion
        #endregion

        

        #region 窗体关闭事件
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            //如果有AI任务存在，则停止任务
            if (aitask != null)
            {
                aitask.Stop();
            }

            //如果有AO任务存在，则停止任务
            if (aotask != null)
            {
                aotask.Stop();
            }
        }
        #endregion}

        //CI模式选项卡改变事件
        private void comboBox_CIMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CIMode.SelectedItem.Equals("Counter") || comboBox_CIMode.SelectedItem.ToString() == "Counter")
            {
                label_MeasureType.Visible = false;
                comboBox_MeasureType.Visible = false;
                groupBox_MeasureResult.Visible = false;
                groupBox_countResult.Visible = true;
                label_GateSource.Enabled = true;
                comboBox_gateSource.Enabled = true;
                label_CountingDIR.Enabled = true;
                comboBox_countDIR.Enabled = true;
            }

            else if (comboBox_CIMode.SelectedItem.Equals("Measure") || comboBox_CIMode.SelectedItem.ToString() == "Measure")
            {
                label_MeasureType.Visible = true;
                comboBox_MeasureType.Visible = true;
                groupBox_MeasureResult.Visible = true;
                groupBox_countResult.Visible = false;
                label_GateSource.Enabled = false;
                comboBox_gateSource.Enabled = false;
                label_CountingDIR.Enabled = false;
                comboBox_countDIR.Enabled = false;
            }
        }
    }
}
