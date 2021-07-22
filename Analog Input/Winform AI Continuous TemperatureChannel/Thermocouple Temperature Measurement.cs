using System;
using System.Windows.Forms;
using System.Collections.Generic;
using JY5500;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.Sensors;
using MathNet.Numerics.Statistics;

/// <summary>
/// JY5500 multi-channel continuous acquisition
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. use the TB-68 terminal box
/// 2. connect thermcouple with AI Channel1 to AI Channel31 (AI Channel15)，
///    because AI Channel0 connect with temperature sensor in TB-68 terminal box
/// 3. open the all switchs in the TB-68 terminal box
/// 4. Input the board number and the number of channels
/// 5. Input sample rate and input voltage range limit
/// 6. Press the start button start for continuous data collection
/// </summary>

namespace Winform_AI_Continuous_MulitiChannel
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// aiTask
        /// </summary>
        private JY5500AITask aiTask;

        /// <summary>
        ///  the Buffer of data acquisition by the aiTask
        /// </summary>
        double[,] readValue;

        /// <summary>
        /// 冷端补偿温度
        /// </summary>
        double[] coldJunctionValue;

        /// <summary>
        /// 通道时测温度
        /// </summary>
        double[][] temperatureValue;

        /// <summary>
        /// 通道温度平均值
        /// </summary>
        double[] temperatureAvg;

        /// <summary>
        /// 通道温度标准差
        /// </summary>
        double[] temperatureStd;

        /// <summary>
        /// 冷端补偿温度
        /// </summary>
        double coldJunctionT;

        /// <summary>
        /// 热电偶温度标准差字符串
        /// </summary>
        string strTemperatureStd = "";

        /// <summary>
        /// 热电偶温度平均值字符串
        /// </summary>
        string strTemperatureAvg = "";

        ThermocoupleType thermocoupleType;

        /// input low limit
        /// </summary>
        private double lowRange;

        /// <summary>
        /// input high limit
        /// </summary>
        /// <returns></returns>
        private double highRange;

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

            comboBox_cardID.SelectedIndex = 0;
            comboBox_inputRange.SelectedIndex = 6;
            comboBox_thermocoupleType.Items.AddRange(Enum.GetNames(typeof(ThermocoupleType)));
            comboBox_thermocoupleType.SelectedIndex = comboBox_thermocoupleType.Items.IndexOf(Enum.GetName(typeof(ThermocoupleType), ThermocoupleType.TypeK));
        }

        /// <summary>
        /// select input limit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_inputRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_inputRange.SelectedIndex)
            {
                case 0:
                    lowRange = -10;
                    highRange = 10;
                    break;
                case 1:
                    lowRange = -5;
                    highRange = 5;
                    break;
                case 2:
                    lowRange = -2;
                    highRange = 2;
                    break;
                case 3:
                    lowRange = -1;
                    highRange = 1;
                    break;
                case 4:
                    lowRange = -0.5;
                    highRange = 0.5;
                    break;
                case 5:
                    lowRange = -0.2;
                    highRange = 0.2;
                    break;
                case 6:
                    lowRange = -0.1;
                    highRange = 0.1;
                    break;
                default:
                    lowRange = -10;
                    highRange = 10;
                    break;
            }
        }


        /// <summary>
        /// Start data acquisition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            stripChartX_readData.Clear();
            stripChartX_readData.Series.Clear();

            // Determine the selected channel
            List<int> checkedChannels = new List<int>();
            for(int i = 0; i < checkedListBox_channels.Items.Count; i++)
            {
                if(checkedListBox_channels.GetItemChecked(i))
                {
                    checkedChannels.Add(i+1);
                }
            }

            stripChartX_readData.SeriesCount = checkedChannels.Count;

            // Initialize controls
            for (int i = 0; i < checkedChannels.Count; i++)
            {
                stripChartX_readData.Series.Add(new SeeSharpTools.JY.GUI.StripChartXSeries());
                stripChartX_readData.Series[i].Name = string.Format("Ch{0}", checkedChannels[i]);
            }

            try
            {

                //New aiTask based on the selected Solt Number
                aiTask = new JY5500AITask(comboBox_SoltNumber.SelectedIndex);

                //Add ColdJunction Channel 0 of TB-68 terminal box
                aiTask.AddChannel(0, -2.0, 2.0, AITerminal.RSE);
            
                //Add thermocopule channels 
                for (int i = 0; i < checkedChannels.Count; i++)
                {
                    aiTask.AddChannel(checkedChannels[i], lowRange, highRange, AITerminal.RSE);
                }

                //Basic parameter configuration
                aiTask.Mode = AIMode.Continuous;
           
                aiTask.SampleRate = (double)numericUpDown_sampleRate.Value;
       
                readValue = new double[(int)numericUpDown_samples.Value, aiTask.Channels.Count];

                coldJunctionValue = new double[readValue.GetLength(0)];
                temperatureValue = new double[readValue.GetLength(1) - 1][];          //[readValue.GetLength(0)];

                for (int i=0;i< readValue.GetLength(1) - 1; i++)
                {
                    temperatureValue[i] = new double[readValue.GetLength(0)];
                }
                temperatureAvg = new double[readValue.GetLength(1) - 1];
                temperatureStd = new double[readValue.GetLength(1) - 1];

                thermocoupleType = (ThermocoupleType)Enum.Parse(typeof(ThermocoupleType), comboBox_thermocoupleType.Text.Trim());

                //Start data acquisition
                aiTask.Start();
            }

            catch (JYDriverException ex)
            {
                toolStripStatusLabel.Text = "aiTask start failed";
                //Drive error message display
               MessageBox.Show(ex.Message);
               return;
            }

            //Enable timer, disable parameter configuration and start button, display status
            timer_FetchData.Enabled = true;
            button_start.Enabled = false;
            button_stop.Enabled = true;
            toolStripStatusLabel.Text = "Start data acquisition";
        }

        /// <summary>
        /// Stop ATTask data acquisition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                //Determine if the task exists
                if (aiTask != null) 
                {
                    //Stop Task 
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

            //Disable timer, enable parameter configuration and start button, display status
            timer_FetchData.Enabled = false;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            toolStripStatusLabel.Text = "Stop data acquisition";
        }

        /// <summary>
        /// Timer, refresh every 10ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                //Read data and display if the local buffer data is sufficient
                if (aiTask.AvailableSamples>=(ulong)readValue.GetLength(0))
                {
                    //Read data stored in readValue
                    aiTask.ReadData(ref readValue, -1);
                    toolStripStatusLabel.Text = "Reading data...";

                    for (int i = 0; i < readValue.GetLength(0); i++) 
                    {
                        coldJunctionValue[i] = readValue[i, 0];               // Get ch0 voltage
                        for (int j = 1; j < readValue.GetLength(1); j++) 
                        {
                            temperatureValue[j - 1][i] = readValue[i, j];     // Get other voltage
                        }
                    }

                    // Get cold Temperature
                    coldJunctionT = ColdJunctionTemp(ref coldJunctionValue);
                    textBox_coldJunction.Text = coldJunctionT.ToString("f1");

                    for (int i = 0; i < temperatureValue.GetLength(0); i++) 
                    {
                        for (int j = 0; j < temperatureValue[0].GetLength(0); j++) 
                        {
                            temperatureValue[i][j] = Thermocouple.Convert(thermocoupleType, temperatureValue[i][j], true, coldJunctionT);
                        }
                        temperatureAvg[i] = ArrayCalculation.Average(temperatureValue[i]);
                        temperatureStd[i] = Statistics.StandardDeviation(temperatureValue[i]);
                    }

                    if(temperatureValue.Length>0)
                    {
                        // 显示波形
                        stripChartX_readData.PlotSingle(temperatureAvg);

                        // 显示平均值、标准差
                        strTemperatureAvg = "";
                        strTemperatureStd = "";
                        for(int i = 0; i < temperatureStd.Length; i++) 
                        {
                            strTemperatureAvg = strTemperatureAvg + stripChartX_readData.Series[i].Name + " " + temperatureAvg[i].ToString("f1") + "\r\n";
                            strTemperatureStd = strTemperatureStd + stripChartX_readData.Series[i].Name + " " + temperatureStd[i].ToString("f2") + "\r\n";
                        }
                        textBox_avg.Text = strTemperatureAvg;
                        textBox_std.Text = strTemperatureStd;
                    }
                }
            }
            catch (JYDriverException ex)
            {
                timer_FetchData.Enabled = false;
                toolStripStatusLabel.Text = "Failed to read data";
                //Drive error message display
               MessageBox.Show(ex.Message);
               return;
            }

            //Enable the timer and continue to check if the buffer data is sufficient
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
                //Determine if the task exists
                if (aiTask != null) 
                {
                    //Stop Task 
                    aiTask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
               MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_cardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox_channels.Items.Clear();
            switch (comboBox_cardID.Text)
            {
                case "5510":
                    numericUpDown_sampleRate.Maximum = 2000000;
                    for (int i = 1; i < 32; i++)
                    {
                        checkedListBox_channels.Items.Add(string.Format("Ch{0}", i));
                    }

                    break;
                case "5511":
                    numericUpDown_sampleRate.Maximum = 1250000;
                    for (int i = 1; i < 32; i++)
                    {
                        checkedListBox_channels.Items.Add(string.Format("Ch{0}", i));
                    }
                    break;
                case "5515":
                    numericUpDown_sampleRate.Maximum = 2000000;
                    for (int i = 1; i < 16; i++)
                    {
                        checkedListBox_channels.Items.Add(string.Format("Ch{0}", i));
                    }
                    break;
                case "5516":
                    numericUpDown_sampleRate.Maximum = 1250000;
                    for (int i = 1; i < 16; i++)
                    {
                        checkedListBox_channels.Items.Add(string.Format("Ch{0}", i));
                    }
                    break;
                default:
                    numericUpDown_sampleRate.Maximum = 2000000;
                    for (int i = 1; i < 32; i++)
                    {
                        checkedListBox_channels.Items.Add(string.Format("Ch{0}", i));
                    }
                    break;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// 冷端补偿电压转换公式，T=a*V^2+b*V+c
        /// </summary>
        /// <param name="voltage">输入电压</param>
        /// <returns>冷端补偿温度</returns>
        private double ColdJunctionTemp(ref double[] voltage)
        {
            double tb68Temperature;
            double avg = ArrayCalculation.Average(voltage) * 1000.0;
            tb68Temperature = (-7.857923E-6) * avg * avg + (-1.777501E-1) * avg + 204.3937;
            return tb68Temperature;
        }
        #endregion

    }
}
