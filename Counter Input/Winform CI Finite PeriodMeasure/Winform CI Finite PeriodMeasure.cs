using System;
using System.Windows.Forms;
using JY5500;

// <summary>
/// JY5500 finite mode period measurement
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number and CounterID number
/// 2. Select clock source, input sample rate and SamplesToAcquire
/// 3. Count the number of cycles of the input signal between the two rising edges of SampleClk
///
/// In this mode, CTR_GATE is connected to the pulse signal to be tested in this mode to measure the signal period.
/// </summary>
///

namespace Winform_CI_Finite_PeriodMeasure
{
    public partial class MainForm : Form
    {
        #region private Fields
        /// <summary>
        /// ciTask
        /// </summary>
        private JY5500CITask ciTask;

        /// <summary>
        /// the Buffer of data read by the ciTask
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
                comboBox_CounterID.Items.Add(i);
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
                    comboBox_CounterID.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_CounterID.Items.Add(i);
                    }
                    break;
                case "5511":
                    comboBox_CounterID.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_CounterID.Items.Add(i);
                    }
                    break;
                case "5515":
                    comboBox_CounterID.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_CounterID.Items.Add(i);
                    }
                    break;
                case "5516":
                    comboBox_CounterID.Items.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_CounterID.Items.Add(i);
                    }
                    break;
                default:
                    comboBox_CounterID.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_CounterID.Items.Add(i);
                    }
                    break;
            }
            comboBox_CounterID.SelectedIndex = 0;
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
                //new Task
                ciTask = new JY5500CITask(comboBox_SoltNumber.SelectedIndex, comboBox_CounterID.SelectedIndex);

                //Basic parameter configuration
                ciTask.Mode = CIMode.Finite;
                ciTask.Type = CIType.Period;
                ciTask.SamplesToAcquire = (uint)numericUpDown_samples.Value;

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
                    //start ciTask
                    ciTask.Start();
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

            //enable Parameter configuration button and start button，disable Stop button
            numericUpDown_sampleRate.Enabled = true;
            timer_FetchData.Enabled = false;
            groupBox_genPara.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
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

                    //enable Parameter configuration and start button，disable Stop button
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

        #endregion

        #region Measure
        #endregion

    }
}
