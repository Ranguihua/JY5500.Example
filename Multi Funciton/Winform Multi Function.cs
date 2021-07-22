using System;
using System.Linq;
using System.Windows.Forms;
using JY5500;
using SeeSharpTools.JY.DSP.Fundamental;
using System.Threading;


/// <summary>
/// JY5500 Single Channel acquisition (finite length mode stream)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// </summary>
namespace Winform_JY5510Demo
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// AI任务
        /// </summary>
        private JY5500AITask aiTask;

        /// <summary>
        /// 存放AI采集到的数据，容量为100ms样点数
        /// </summary>
        private double[] readValue;
        
        /// <summary>
        /// AO任务
        /// </summary>
        private JY5500AOTask aoTask;

        /// <summary>
        /// 存放AO待更新的数据，容量为待更新样点数
        /// </summary>
        private double[] writeValue;

        /// <summary>
        /// 读取测量值的缓存
        /// </summary>
        private double[] MeasureValue;

        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
            comboBox_rangeLimitAI.SelectedIndex = 0;
            comboBox_rangeLimitAO.SelectedIndex = 0;
        }
        #endregion

        #region Event Handler
        /// <summary>
        ///  初始化面板参数设定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_CardID.SelectedIndex = 0;
            comboBox_boardNum.SelectedIndex = 0;
            comboBox_ChanNoAI.SelectedIndex = 0;
            comboBox_ChanNoAO.SelectedIndex = 0;
            radioButtonSine.Checked = true;
            numericUpDown_dutyCycle.Visible = false;
            labelDutyCycle.Visible = false;


            groupBoxDO.Enabled = false;

            comboBox_measureType.Items.AddRange(Enum.GetNames(typeof(CIType)));
            comboBox_counterNumberCO.SelectedIndex = 0;
            comboBox_counterNumberCI.SelectedIndex = 1;
            comboBox_measureType.SelectedIndex = 2;
            comboBox_measureType.Enabled = false;
        }


        #region AIO
        /// <summary>
        /// 开始AI AO任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_startAIO_Click(object sender, EventArgs e)
        {
            //开始AO输出
            try
            {
                //创建AO任务
                aoTask = new JY5500AOTask(comboBox_boardNum.SelectedIndex);
                //配置通道
                switch (comboBox_rangeLimitAO.SelectedIndex)
                {
                    case 0:
                        aoTask.AddChannel(comboBox_ChanNoAO.SelectedIndex, -10, 10);
                        break;
                  
                    default:
                        return;
                }
                //基本参数配置
                aoTask.Mode = AOMode.ContinuousWrapping;
                aoTask.UpdateRate = (double)numericUpDown_UpdateRate.Value;
				writeValue = new double[(int)aoTask.UpdateRate / 10];
                //波形参数配置
                double amplitude = (double)numericUpDown_WaveAmplitude.Value;
                double dutyCycle = (double)numericUpDown_dutyCycle.Value;
                double frequency = (double)numericUpDown_WaveFre.Value;
                
                //根据选择的波形类型生成波形
                switch (groupBox_WaveConfig.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text)
                {
                    case "SineWave":
                        Generation.SineWave(ref writeValue, amplitude, 0, frequency, aoTask.UpdateRate);//正弦波
                        break;
                    case "SquareWave":
                        Generation.SquareWave(ref writeValue, amplitude, dutyCycle, frequency, aoTask.UpdateRate);//方波
                        break;
                    case "UniformWhiteNoise":
                        Generation.UniformWhiteNoise(ref writeValue, amplitude);//白噪声
                        break;
                    default:
                        break;
                }
                aoTask.WriteData(writeValue, -1);
                aoTask.Start();
                groupBox_GenParamAI.Enabled = false;
                groupBox_GenParamAO.Enabled = false;
                groupBox_WaveConfig.Enabled = false;
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //开始AI采集
            try
            {
                //创建AI任务
                aiTask = new JY5500AITask(comboBox_boardNum.SelectedIndex);
                //添加通道
                switch (comboBox_rangeLimitAI.SelectedIndex)
                {
                    case 0:
                        aiTask.AddChannel(comboBox_ChanNoAI.SelectedIndex, -10, 10, AITerminal.RSE);
                        break;
                    case 1:
                        aiTask.AddChannel(comboBox_ChanNoAI.SelectedIndex, -5, 5, AITerminal.RSE);
                        break;
                    case 2:
                        aiTask.AddChannel(comboBox_ChanNoAI.SelectedIndex, -2, 2, AITerminal.RSE);
                        break;
                    case 3:
                        aiTask.AddChannel(comboBox_ChanNoAI.SelectedIndex, -1, 1, AITerminal.RSE);
                        break;
                    case 4:
                        aiTask.AddChannel(comboBox_ChanNoAI.SelectedIndex, -0.5, 0.5, AITerminal.RSE);
                        break;
                    case 5:
                        aiTask.AddChannel(comboBox_ChanNoAI.SelectedIndex, -0.2, 0.2, AITerminal.RSE);
                        break;
                    case 6:
                        aiTask.AddChannel(comboBox_ChanNoAI.SelectedIndex, -0.1, 0.1, AITerminal.RSE);
                        break;
                    default:
                        return;
                }
                //基本参数配置
                aiTask.Mode = AIMode.Continuous;
                aiTask.SampleRate = (double)numericUpDown_SampleRate.Value;
                //开始任务
                aiTask.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            readValue = new double[(int)aiTask.SampleRate / 2];
            timer_AIOFetchData.Enabled = true;
            button_startAIO.Enabled = false;
            button_stopAIO.Enabled = true;

    }
          private void timer_AIOFetchData_Tick(object sender, EventArgs e)
        {
            timer_AIOFetchData.Enabled = false;

            //如果本地缓冲区数据足够则读取数据并显示，如果不够，返回
			if (aiTask.AvailableSamples >= (ulong)readValue.Length)
            {
                try
                {
                    aiTask.ReadData(ref readValue, readValue.Length, -1);
                    easyChartX1.Plot(readValue);
                }
				catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
					button_stopAIO_Click (null, null);
					return;
                }
            }

            timer_AIOFetchData.Enabled = true;
            return;

        }

        /// <summary>
        /// 根据选择的波形显示要配置的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch ((((RadioButton)sender).Text))
            {
                case "SineWave":
                    numericUpDown_dutyCycle.Visible = false;
                    labelDutyCycle.Visible = false;
                    numericUpDown_WaveFre.Visible = true;
                    labelFre.Visible = true;
                    break;
                case "SquareWave":
                    numericUpDown_dutyCycle.Visible = true;
                    labelDutyCycle.Visible = true;
                    numericUpDown_WaveFre.Visible = true;
                    labelFre.Visible = true;
                    break;
                case "UniformWhiteNoise":
                    numericUpDown_dutyCycle.Visible = false;
                    labelDutyCycle.Visible = false;
                    numericUpDown_WaveFre.Visible = false;
                    labelFre.Visible = false;
                    break;
                default:
                    return;
            }
        }
        /// <summary>
        /// 停止AI AO任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stopAIO_Click(object sender, EventArgs e)
        {
            button_startAIO.Enabled = true;
            if(aiTask!=null)
            {
                aiTask?.Stop();
            }
            if(aoTask!=null)
            {
                aoTask?.Stop();
            }
            timer_AIOFetchData.Enabled = false;
            groupBox_WaveConfig.Enabled = true;
            groupBox_GenParamAO.Enabled = true;
            groupBox_GenParamAI.Enabled = true;
        }

        #endregion

        #region DIO

        #region Private Fields

        /// <summary>
        /// DO任务
        /// </summary>
        JY5500DOTask dotask;
        /// <summary>
        /// DI任务
        /// </summary>
        JY5500DITask ditask;

        /// <summary>
        /// 存放待写出的数据
        /// </summary>
        bool[] DOWriteData;

        /// <summary>
        /// 存放读取的数据
        /// </summary>
        bool[] DIReadData;
        #endregion

       
        #region Event Handler
    
        /// <summary>
        /// switchArray的值发生变化时，执行一次DO输出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchArray1_ControlValueChanged(object sender, SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventArgs e)
        {

            DOWriteData = switchArray1.Value;
            try
            {
                dotask.WriteSinglePoint(DOWriteData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 全部设为高电平
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllHigh_Click(object sender, EventArgs e)
        {
            switchArray1.Value = new bool[] { true, true, true, true, true, true, true, true };

        }
        /// <summary>
        /// 全部设为低电平
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllLow_Click(object sender, EventArgs e)
        {
            switchArray1.Value = new bool[] { false, false, false, false, false, false, false, false };

        }
        /// <summary>
        /// 开始DI、DO任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_startDIO_Click(object sender, EventArgs e)
        {

            try
            {
                ditask = new JY5500DITask(comboBox_boardNum.SelectedIndex);
                ditask.AddChannel(0);//添加端口0
                ditask.Mode = DIMode.Single;
                DIReadData = new bool[8];
                ditask.Start();
                ditask.ReadSinglePoint(ref DIReadData);
                timer_DIOFetchData.Enabled = true;


                dotask = new JY5500DOTask(comboBox_boardNum.SelectedIndex);
                dotask.AddChannel(1);//添加所有通道
                dotask.Mode = DOMode.Single;
                DOWriteData = switchArray1.Value;
                dotask.WriteSinglePoint(DOWriteData);
                dotask.Start();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            groupBoxDO.Enabled = true;
        }
        /// <summary>
        /// 停止DO、DI任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// 定时器，每100ms刷新一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_DIOFetchData_Tick(object sender, EventArgs e)
        {
            timer_DIOFetchData.Enabled = false;
            try
            {
                ditask.ReadSinglePoint(ref DIReadData);
                ledArray1.Value = DIReadData;
                timer_DIOFetchData.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button_stopDIO_Click(object sender, EventArgs e)
        {
            groupBoxDO.Enabled = false;
            timer_DIOFetchData.Enabled = false;
            if (dotask != null)
            {
                dotask.Channels.Clear();//把上次启动添加的通道清掉
                dotask.Stop();
            }
            if (ditask != null)
            {
                ditask.Channels.Clear();//把上次启动添加的通道清掉
                ditask.Stop();
            }
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_DIOFetchData.Enabled = false;

        }
        #endregion

        #region Methods
        #endregion
        #endregion

        #region CIO
        #region Private Fields
        /// <summary>
        /// CO任务
        /// </summary>
        private JY5500COTask coTask;

        /// <summary>
        /// CI任务
        /// </summary>
        private JY5500CITask ciTask;

        /// <summary>
        /// 测量值
        /// </summary>
        //private double measureValue;
        #endregion

    
        #region Event Handler
     
        /// <summary>
        /// 启动输出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_startCIO_Click(object sender, EventArgs e)
        {
            groupBox_genParaCO.Enabled = false;
            button_startCIO.Enabled = false;
            groupBox_genParaCI.Enabled = false;


            try
            {
                //配置脉冲输出任务
                coTask = new JY5500COTask(comboBox_boardNum.SelectedIndex, Convert.ToInt32(comboBox_counterNumberCO.Text));
                coTask.Mode = COMode.Single;
              

                COPulse pulse = new COPulse(COPulseType.DutyCycleFrequency, (double)numericUpDown_frequency.Value,
                            (double)numericUpDown1.Value, -1);

                coTask.WriteSinglePoint(pulse);

                Thread.Sleep(100);
                try
                {
                    coTask.Start();
                }
                 catch (Exception ex)
                {
                  MessageBox.Show(ex.Message);
                 }
                //配置周期/脉宽测量任务

                ciTask = new JY5500CITask(comboBox_boardNum.SelectedIndex, Convert.ToInt32(comboBox_counterNumberCI.Text));
                ciTask.Mode = CIMode.Continuous;
                ciTask.Type = CIType.Frequency;
                ciTask.SampleClock.Internal.Rate = 10;


                try
                {
                    ciTask.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MeasureValue = new double[10];
                try
                {
                    ciTask.ReadData(ref MeasureValue, MeasureValue.Length, -1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView1.Rows.Clear();
                for (int i = 0; i < MeasureValue.Length; i++)
                {
                    dataGridView1.Rows.Add(MeasureValue[i]);
                }
                //textBox_measureValue.Text = measureValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 停止输出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stopCIO_Click(object sender, EventArgs e)
        {
            if (coTask != null)
            {
                coTask.Stop();
               
            }
            if(ciTask!=null)
            {
                ciTask.Stop();
            }

            //重新启用参数设置按钮
            groupBox_genParaCO.Enabled = true;
            button_startCIO.Enabled = true;
            groupBox_genParaCI.Enabled = true;
        }
        #endregion

        #region Methods
        #endregion
        #endregion

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (aiTask != null)
            {
                aiTask?.Stop();
            }
            if (aoTask != null)
            {
                aoTask?.Stop();
            }
            timer_AIOFetchData.Enabled = false;
        }


        #endregion

        #region Methods
        #endregion
        
        private void comboBox_CardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_CardID.Text)
            {
                case "5510":
                    numericUpDown_UpdateRate.Maximum = 2860000;
                    numericUpDown_SampleRate.Maximum = 2000000;
                    comboBox_ChanNoAO.Items.Clear();
                    comboBox_ChanNoAI.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_ChanNoAO.Items.Add(i);
                    }
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_ChanNoAI.Items.Add(i);
                    }
                    comboBox_counterNumberCO.Items.Clear();
                    comboBox_counterNumberCI.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumberCO.Items.Add(i);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumberCI.Items.Add(i);
                    }
                    break;
                case "5511":
                    numericUpDown_UpdateRate.Maximum = 2860000;
                    numericUpDown_SampleRate.Maximum = 1250000;
                    comboBox_ChanNoAO.Items.Clear();
                    comboBox_ChanNoAI.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_ChanNoAO.Items.Add(i);
                    }
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_ChanNoAI.Items.Add(i);
                    }
                    comboBox_counterNumberCO.Items.Clear();
                    comboBox_counterNumberCI.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumberCO.Items.Add(i);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumberCI.Items.Add(i);
                    }
                    break;
                case "5512":
                    numericUpDown_UpdateRate.Maximum = 1000000;
                    numericUpDown_SampleRate.Maximum = 500000;
                    comboBox_ChanNoAO.Items.Clear();
                    comboBox_ChanNoAI.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_ChanNoAO.Items.Add(i);
                    }
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_ChanNoAI.Items.Add(i);
                    }
                    comboBox_counterNumberCO.Items.Clear();
                    comboBox_counterNumberCI.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumberCO.Items.Add(i);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumberCI.Items.Add(i);
                    }
                    break;
                case "5515":
                    numericUpDown_UpdateRate.Maximum = 2860000;
                    numericUpDown_SampleRate.Maximum = 2000000;
                    comboBox_ChanNoAO.Items.Clear();
                    comboBox_ChanNoAI.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_ChanNoAO.Items.Add(i);
                    }
                    for (int i = 0; i < 16; i++)
                    {
                        comboBox_ChanNoAI.Items.Add(i);
                    }
                    comboBox_counterNumberCO.Items.Clear();
                    comboBox_counterNumberCI.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_counterNumberCO.Items.Add(i);
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_counterNumberCI.Items.Add(i);
                    }
                    break;
                case "5516":
                    numericUpDown_UpdateRate.Maximum = 2860000;
                    numericUpDown_SampleRate.Maximum = 1250000;
                    comboBox_ChanNoAO.Items.Clear();
                    comboBox_ChanNoAI.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_ChanNoAO.Items.Add(i);
                    }
                    for (int i = 0; i < 16; i++)
                    {
                        comboBox_ChanNoAI.Items.Add(i);
                    }
                    comboBox_counterNumberCO.Items.Clear();
                    comboBox_counterNumberCI.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_counterNumberCO.Items.Add(i);
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_counterNumberCI.Items.Add(i);
                    }
                    break;
                case "5517":
                    numericUpDown_UpdateRate.Maximum = 1000000;
                    numericUpDown_SampleRate.Maximum = 500000;
                    comboBox_ChanNoAO.Items.Clear();
                    comboBox_ChanNoAI.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_ChanNoAO.Items.Add(i);
                    }
                    for (int i = 0; i < 16; i++)
                    {
                        comboBox_ChanNoAI.Items.Add(i);
                    }
                    comboBox_counterNumberCO.Items.Clear();
                    comboBox_counterNumberCI.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_counterNumberCO.Items.Add(i);
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_counterNumberCI.Items.Add(i);
                    }
                    break;
                default:
                    numericUpDown_UpdateRate.Maximum = 2860000;
                    numericUpDown_SampleRate.Maximum = 2000000;
                    comboBox_ChanNoAO.Items.Clear();
                    comboBox_ChanNoAI.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_ChanNoAO.Items.Add(i);
                    }
                    for (int i = 0; i < 32; i++)
                    {
                        comboBox_ChanNoAI.Items.Add(i);
                    }
                    comboBox_counterNumberCO.Items.Clear();
                    comboBox_counterNumberCI.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumberCO.Items.Add(i);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_counterNumberCI.Items.Add(i);
                    }
                    break;
            }
            comboBox_ChanNoAI.SelectedIndex = 0;
            comboBox_ChanNoAO.SelectedIndex = 0;
            comboBox_counterNumberCO.SelectedIndex = 0;
            comboBox_counterNumberCI.SelectedIndex = 1;
            numericUpDown_UpdateRate.Value = numericUpDown_UpdateRate.Maximum;
            numericUpDown_SampleRate.Value = numericUpDown_SampleRate.Maximum;
        }

    }
}
