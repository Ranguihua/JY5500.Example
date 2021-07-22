using System;
using System.Windows.Forms;
using JYPXIe5510;

namespace Winform_CI_Continuous_PulseMeasure
{
    public partial class MainForm : Form
    {

        #region private Fields
        /// <summary>
        /// CI任务
        /// </summary>
        private JYPXIe5510CITask citask;

        /// <summary>
        /// 读取测量值的缓存
        /// </summary>
        private double[] MeasureValue;
        #endregion

        #region Constructor
       public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// comboBox的默认索引
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_boardNumber.SelectedIndex = 0;
            comboBox_counterNumber.SelectedIndex = 0;

            //调用clockSource的枚举作为选单
            comboBox_clockSource.Items.AddRange(Enum.GetNames(typeof(CIClock)));
            comboBox_clockSource.SelectedIndex = 0;
        }

        /// <summary>
        /// 启动AITask任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //创建任务
                citask = new JYPXIe5510CITask(comboBox_boardNumber.SelectedIndex, comboBox_counterNumber.SelectedIndex);

                //基本参数配置
                citask.Mode = CIMode.Continuous;
                citask.ClockSource = (CIClock)Enum.Parse(typeof(CIClock), comboBox_clockSource.Text, true);

                if (citask.ClockSource == CIClock.Internal)
                {
                    citask.SampleRate = (double)numericUpDown_sampleRate.Value;
                }
             
                citask.Type = CIType.PulseMeasure;

                //开始测量任务
                citask.Start();

                MeasureValue = new double[(int)numericUpDown_samples.Value];

                //使能计数器，禁用参数配置数据和开始按钮
                timer1.Enabled = true;
                groupBox_genPara.Enabled = false;
                button_start.Enabled = false;
            }
            catch (JYDriverException ex)
            {
                //驱动错误信息显示
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            if (citask != null)
            {
                citask.Stop();
            }

            //禁用定时器，使能参数配置和开始按钮
            timer1.Enabled = false;
            groupBox_genPara.Enabled = true;
            button_start.Enabled = true;
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (citask != null)
            {
                citask.Stop();
            }
        }

        /// <summary>
        /// 计数器，每隔100ms读取一次计数值并显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if ((int)citask.AvailableSamples >= MeasureValue.Length)
                {
                    //读取测量值并显示
                    citask.ReadMeasure(MeasureValue, (uint)numericUpDown_samples.Value, -1);
                    easyChartX_ReadMeasureValue.Plot(MeasureValue);
                }
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 设置采样率启用条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_clockSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_clockSource.SelectedIndex)
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

    }
}
