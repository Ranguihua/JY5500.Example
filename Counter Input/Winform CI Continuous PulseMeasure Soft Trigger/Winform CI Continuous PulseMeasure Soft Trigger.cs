using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 continuous mode single cycle pulse width measurement (software trigger)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.4 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. According to the time of writing to the register, there are 2 modes: not enabled. SampleClk: 
/// When the rising edge of the measurement signal comes, the high and low Tick meters are written into the register
/// Enable implicit clock: When a measurement is completed, the count value is written to the register
/// 2. When the pulse is measured, the pulse to be measured is selected as a high level pulse or a low level pulse
/// 3. Start pulse width measurement after Send Soft Trigger
/// In this mode, CTR0_GATE is connected to the pulse signal to be measured, 
/// and the pulse width time of the pulse on CTR0_GATE is measured
/// </summary>

namespace Winform_CI_Continuous_PulseMeasure_Soft_Trigger
{
    public partial class MainForm : Form
    {
        #region private Fields
        /// <summary>
        /// CITask
        /// </summary>
        private JY5500CITask citask;

        /// <summary>
        /// the Buffer of data read by the CITask
        /// </summary>
        private double[] HighPulseMeas;
        private double[] LowPulseMeas;
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
            for (int i = 0; i < 4; i++)
            {
                comboBox_counterNumber.Items.Add(i);
            }
            comboBox_cardID.SelectedIndex = 0;

            //Call the enumeration of CIClock in the driver as a menu
            comboBox_SampleClockSource.Items.AddRange(Enum.GetNames(typeof(CISampleClockSource)));
            comboBox_SampleClockSource.SelectedIndex = 0;
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
        /// Start CITask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //new Task
                citask = new JY5500CITask(comboBox_SoltNumber.SelectedIndex, comboBox_counterNumber.SelectedIndex);

                //Basic parameter configuration
                citask.Mode = CIMode.Continuous;
                citask.Type = CIType.Pulse;

                //Configure the clock source and select the internal sampling rate
                citask.SampleClock.Source = (CISampleClockSource)Enum.Parse(typeof(CISampleClockSource), comboBox_SampleClockSource.Text, true);
                if (citask.SampleClock.Source == CISampleClockSource.Internal)
                {
                    citask.SampleClock.Internal.Rate = (double)numericUpDown_sampleRate.Value;
                }
                else
                {
                    citask.SampleClock.Implicit.ExpectedRate = (double)numericUpDown_sampleRate.Value;
                }

                citask.Trigger.Type = CITriggerType.Soft;

                try
                {
                    //start Task
                    citask.Start();
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                HighPulseMeas = new double[(int)numericUpDown_samples.Value];
                LowPulseMeas = new double[(int)numericUpDown_samples.Value];

                //enable Counter，Disable parameter configuration and start button
                timer_FetchData.Enabled = true;
                groupBox_genPara.Enabled = false;
                button_start.Enabled = false;
                button_stop.Enabled = false;
                button_sendSoftTrigger.Enabled = true;
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Stop Task 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (citask != null)
                {
                    citask.Stop();
                }
            }

            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //enable Parameter configuration button and start button，disable Stop button
            numericUpDown_sampleRate.Enabled = true;
            timer_FetchData.Enabled = false;
            groupBox_genPara.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            button_sendSoftTrigger.Enabled = false;
        }

        /// <summary>
        /// timer，reading the count value every 100ms and displaying
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                if ((int)citask.AvailableSamples >= HighPulseMeas.Length)
                {
                    //read measurevalue and diaplay
                    citask.ReadData(ref HighPulseMeas, ref LowPulseMeas, (int)numericUpDown_samples.Value, -1);
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
                if (citask != null)
                {
                    citask.Stop();
                }
            }

            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Send Soft Trigger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_sendSoftTrigger_Click(object sender, EventArgs e)
        {
            citask.SendSoftwareTrigger();
            button_start.Enabled = false;
            button_stop.Enabled = true;
            button_sendSoftTrigger.Enabled = false;
        }

        /// <summary>
        ///  Set the sampling rate enable condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SampleClockSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_SampleClockSource.SelectedIndex)
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
