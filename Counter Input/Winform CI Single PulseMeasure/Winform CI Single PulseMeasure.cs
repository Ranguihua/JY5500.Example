using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 single mode single cycle pulse width measurement
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. According to the time of writing to the register, there are 2 modes: not enabled. SampleClk: When the rising edge of the measurement signal comes, 
/// the high and low Tick meters are written into the register
/// Enable implicit clock: When a measurement is completed, the count value is written to the register
/// 2. When the pulse is measured, the pulse to be measured is selected as a high level pulse or a low level pulse
///
/// In this mode, CTR0_GATE is connected to the pulse signal to be measured, and the pulse width time of the pulse on CTR0_GATE is measured
/// </summary>

namespace Winform_CI_Single_FrequencyMeasure
{
    public partial class MainForm : Form
    {
        #region private Fields
        /// <summary>
        /// ciTask
        /// </summary>
        private JY5500CITask ciTask;

        /// <summary>
        /// 读取测量值的缓存
        /// </summary>
        private double HighPulseMeas;
        private double LowPulseMeas;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        /// <summary>
        ///Set the default index of comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_SoltNumber.SelectedIndex = 0;
            for (int i = 0; i < 4; i++)
            {
                comboBox_counterNumber.Items.Add(i);
            }
            comboBox_cardID.SelectedIndex = 0;

        }

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

        /// <summary>
        /// Start ciTask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //new ciTask based on the selected Solt Number and counterID
                ciTask = new JY5500CITask(comboBox_SoltNumber.SelectedIndex, comboBox_counterNumber.SelectedIndex);

                //Basic parameter configuration
                ciTask.Mode = CIMode.Single;
                ciTask.Type = CIType.Pulse;

                try
                {
                    //start Task
                    ciTask.Start();
                }
               catch (JYDriverException ex)
               {
                   //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
               }

                //enable timer and stop button，Disable parameter configuration and start button
                timer_FetchData.Enabled = true;
                groupBox_genPara.Enabled = false;
                button_start.Enabled = false;
                button_stop.Enabled = true;
            }
            catch (JYDriverException ex)
            {
               //Drive error message display
               MessageBox.Show(ex.Message);
               return;
            }
        }
       
        /// <summary>
        /// CounterID，每隔100ms读取一次测量值并显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                //读取测量值并显示
                ciTask.ReadSinglePoint(ref LowPulseMeas, ref HighPulseMeas);
                textBox_highPulseWidth.Text = HighPulseMeas.ToString();
                textBox_lowPulseWidth.Text = LowPulseMeas.ToString();
            }
            catch (JYDriverException ex)
            {
               MessageBox.Show(ex.Message);
               return;
            }

            timer_FetchData.Enabled = true;
        }

        /// <summary>
        /// Stop单脉宽测量Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            //禁用定时器和Stop按钮，启用Parameter configuration数据和start按钮
            timer_FetchData.Enabled = false;
            groupBox_genPara.Enabled = true;
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
        }


        #endregion

        #region Methods
        #endregion


    }
}
