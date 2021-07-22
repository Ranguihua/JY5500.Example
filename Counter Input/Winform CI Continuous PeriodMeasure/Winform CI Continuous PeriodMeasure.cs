using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 continuous mode period measurement
/// Author: JYTEK
/// Date modified: 2020.6.11
/// Driver version: JY5500 Installer_V1.1.0.msi or later
/// Installation Package: SeeSharpTools.JY.GUI 1.4.4 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number and CounterID number
/// 2. Select clock source, input sample rate and SamplesToAcquire
/// 3. Count the number of cycles of the input signal between the two rising edges of SampleClk
///
/// In this mode, CTR_GATE is connected to the pulse signal to be tested in this mode to measure the signal period
/// </summary>
///

namespace Winform_CI_Continuous_PeriodMeasure1
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
            comboBox_SampleClockSource.SelectedIndex = 1;
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

        /// <summary>
        /// timer，reading the measure value every 100ms and displaying
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                if (citask.AvailableSamples >= (ulong)MeasureValue.Length)
                {
                    citask.ReadData(ref MeasureValue, (int)numericUpDown_samples.Value, -1);
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

            timer_FetchData.Enabled = true;
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
                citask.Type = CIType.Period;

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

                try
                {
                    //start CITask
                    citask.Start();
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                MeasureValue = new double[(int)numericUpDown_samples.Value];

                //enable timer，Disable parameter configuration button and start button
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

        #endregion

        #region Methods
        #endregion

    }
}
