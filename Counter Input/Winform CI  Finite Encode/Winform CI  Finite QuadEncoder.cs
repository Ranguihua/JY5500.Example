using System;
using System.Windows.Forms;
using JY5500;

// <summary>
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. According to the time of writing to the register, there are 2 modes for edge counting:
/// The first type is not enabled. SampleClk: When the rising edge of the measurement signal comes, the count value is written to the register. The second type of implicit clock is enabled: when the rising edge of the measurement signal comes, the count value is written to the register.
/// 2. Counting direction When the external pin is selected to determine the counting direction, the input pin is CTR_AUX.
///
/// Simple counting function:
/// In this mode, the timer will record the number of pulses above the CTR_Source after the software start
/// </summary>

namespace Winform_CI__Finite_Encode
{
    public partial class MainForm : Form
    {
        #region private Fields
        /// <summary>
        /// ciTask
        /// </summary>
        private JY5500CITask ciTask;

        /// <summary>
        ///the Buffer of data read by the ciTask
        /// </summary>
        private uint[] readValue;
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

            //Call the enumeration of encodeType in the driver as a menu
            comboBox_encodeType.Items.AddRange(Enum.GetNames(typeof(QuadEncodingType)));
            comboBox_encodeType.SelectedIndex = 0;

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
        private void comboBox_clocksource_SelectedIndexChanged(object sender, EventArgs e)
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
        ///  Start ciTask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Click(object sender, EventArgs e)
        {
            try
            {
                //new ciTask based on the selected Solt Number and counterID
                ciTask = new JY5500CITask(comboBox_SoltNumber.SelectedIndex, comboBox_counterNumber.SelectedIndex);

                //Parameter configuration
                ciTask.Mode = CIMode.Finite;
                ciTask.SamplesToAcquire = (uint)numericUpDown_SampleToAcquire.Value;
                ciTask.Type = CIType.QuadEncoder;
                ciTask.QuadEncoder.ZReloadEnabled = false;

                //Configure the count direction and initial count value
                ciTask.QuadEncoder.EncodingType = (QuadEncodingType)Enum.Parse(typeof(QuadEncodingType), comboBox_encodeType.Text, true);
                ciTask.QuadEncoder.InitialCount = 0;

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
                    //Start ciTask
                    ciTask.Start();
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                   MessageBox.Show(ex.Message);
                   return;
                }

                readValue = new uint[ciTask.SamplesToAcquire];

                //enable timer and Stop button，Disable parameter configuration button and start button
                timer_FetchData.Enabled = true;
                groupBox_genPara.Enabled = false;
                button_Start.Enabled = false;
                button_stop.Enabled = true;

            }
            catch (JYDriverException ex)
            {
                //Display driver error message
               MessageBox.Show(ex.Message);
               return;
            }
        }

        /// <summary>
        /// The timer checks whether the buffer read point is enough every 100ms. If it is enough, 
        /// it reads the count value and displays the Stop Task.Otherwise, the timer is enabled
        /// and the buffer data is continuously checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                if (ciTask.AvailableSamples >=(ulong)readValue.Length)
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
                            //Stop ciTask
                            ciTask.Stop();
                        }
                    }

                    catch (JYDriverException ex)
                    {
                       MessageBox.Show(ex.Message);
                       return;
                    }

                    //disable Stop button，enable Parameter configuration button and start button
                    numericUpDown_sampleRate.Enabled = true;
                    timer_FetchData.Enabled = false;
                    button_Start.Enabled = true;
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
        /// Stop ciTask
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

            //Disable timer and Stop buttons, enable sample rate configuration, 
            //Parameter configuration and start button
            numericUpDown_sampleRate.Enabled = true;
            timer_FetchData.Enabled = false;
            button_Start.Enabled = true;
            groupBox_genPara.Enabled = true;
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
