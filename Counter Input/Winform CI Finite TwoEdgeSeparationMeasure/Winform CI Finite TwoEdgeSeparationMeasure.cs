using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 finite mode TwoEdgeSeparation 
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. There are 2 modes depending on the time of writing to the register:
/// The first type is not enabled. SampleClk: When the rising edge of the second signal comes, the number of Timebase pulses between the first signal and the rising edge of the second signal is written to the register.
/// Measure two edge differences that are not on the same channel. The second is to enable implicit clocking: when a measurement is completed, the count value is written to the register.
/// 2. Select which two rising edges are to be measured. The first signal comes from the Gate side and the second signal comes from the Aux side.
///
/// TwoEdgeSeparation:
/// In this mode, the difference between the two channel edges of CTR0_GATE and CTR0_AUX is mainly recorded in this mode
/// </summary>

namespace Winform_CI_Finite_TwoEdgeSeparationMeasure
{
    public partial class MainForm : Form
    {
        #region Private Fields

        //ciTask
        private JY5500CITask ciTask;

        //the Buffer of data read by the ciTask
        private double[] FirstToSecondMeas;
        private double[] SecondToFirstMeas;

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

        private void comboBox_cardID_SelectedIndexChanged_1(object sender, EventArgs e)
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
        /// Set the sampling rate enable condition
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
        /// Start Task
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
                ciTask.Mode = CIMode.Finite;
                ciTask.SamplesToAcquire = (uint)numericUpDown_samples.Value;
                ciTask.Type = CIType.TwoEdgeSeparation;

                //Configure the clock source and select the internal sampling rate
                ciTask.SampleClock.Source = (CISampleClockSource)Enum.Parse(typeof(CISampleClockSource), comboBox_SampleClockSource.Text, true);
                if (ciTask.SampleClock.Source == CISampleClockSource.Internal)
                {
                    ciTask.SampleClock.Internal.Rate = (double)numericUpDown_sampleRate.Value;
                }
                else
                {
                    ciTask.SampleClock.Implicit.ExpectedRate = (double)numericUpDown_sampleRate.Value;
                }

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


                FirstToSecondMeas = new double[(int)numericUpDown_samples.Value];
                SecondToFirstMeas = new double[(int)numericUpDown_samples.Value];

                //enable timer and Stop button ，disable Parameter configuration button and start button
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
        /// Timer, check the buffer read point number every 100ms, if it is enough, 
        /// read the measured value and display Stop Task, otherwise, enable Timer, 
        /// continue to check buffer data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                if (ciTask.AvailableSamples >= (ulong)SecondToFirstMeas.Length)
                {
                    //read measurevalue and diaplay
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
                    timer_FetchData.Enabled = false;
                    button_start.Enabled = true;
                    groupBox_genPara.Enabled = true;
                    button_stop.Enabled = false;
                }
                else
                {
                    timer_FetchData.Enabled = true;
                }
            }
            catch (JYDriverException ex)
            {
                //Display driver error message
                MessageBox.Show(ex.Message);
                return;
            }

        }

        /// <summary>
        /// Stop MeasureTask
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

            //disable timer and stop button ,enable Parameter configuration button and start button
            numericUpDown_sampleRate.Enabled = true;
            timer_FetchData.Enabled = false;
            button_start.Enabled = true;
            groupBox_genPara.Enabled = true;
            button_stop.Enabled = false;
        }


        #endregion

        #region Methods
        #endregion

    }
}
