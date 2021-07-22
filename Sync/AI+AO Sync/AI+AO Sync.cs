using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JY5500;
using SeeSharpTools.JY.ArrayUtility;

/// <summary>
/// JY5500 AI_AO_Sync
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the slot number and ai channeCount and ao channel number .
/// 2. Input sample rate 
/// 3. Routing AI and AO Sample Clock signal to pfi
/// 4. AO Sample clock select AI_SampleClock, AO Digital trigger source select AI_StartTrigger
/// 4. Press the start button to start continuous data acquisition and ao output
/// </summary>
namespace AI_AO_Sync
{
    /// <summary>
    /// Form class
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private JY5500AITask aiTask;
        private JY5500AOTask aoTask;
        double[,] readData;
        double[,] disPlaydata;
        double[] writeData;

        /// <summary>
        /// Set the default index of comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Call the enumeration of AISignalExportSource in the driver as a menu
            comboBox_aisignal.Items.AddRange(Enum.GetNames(typeof(AISignalExportSource)));
            comboBox_aisignal.SelectedIndex = 2;

            //Call the enumeration of AOSignalExportSource in the driver as a menu
            comboBox_aosignal.Items.AddRange(Enum.GetNames(typeof(AOSignalExportSource)));
            comboBox_aosignal.SelectedIndex = 1;

            //Call the enumeration of SignalExportDestination in the driver as a menu
            comboBox_aides.Items.AddRange(Enum.GetNames(typeof(SignalExportDestination)));
            comboBox_aides.SelectedIndex = 0;

            //Call the enumeration of SignalExportDestination in the driver as a menu
            comboBox_aodes.Items.AddRange(Enum.GetNames(typeof(SignalExportDestination)));
            comboBox_aodes.SelectedIndex = 1;

            //Call the enumeration of ClockTerminal in the driver as a menu
            comboBox_AOClock.Items.AddRange(Enum.GetNames(typeof(ClockTerminal)));
            comboBox_AOClock.SelectedIndex = 4;

            //Call the enumeration of AODigitalTriggerSource in the driver as a menu
            comboBox_AOTrig.Items.AddRange(Enum.GetNames(typeof(AODigitalTriggerSource)));
            comboBox_AOTrig.SelectedIndex = 16;

            //Call the enumeration of AISignalExportSource in the driver as a menu
            comboBox_cardID.SelectedIndex = 0;
            comboBox_SoltNumber.SelectedIndex = 0;
            comboBox_aochannel.SelectedIndex = 0;
            comboBox_channelNumber.SelectedIndex = 0;
        }

        /// <summary>
        /// Start AI_AO Sync Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void easyButton_Start_Click(object sender, EventArgs e)
        {
            //New aiTask based on the selected Solt Number
            try
            {
                aiTask = new JY5500AITask(comboBox_SoltNumber.SelectedIndex);
            }
            catch(Exception ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }


            ////AddChannel
            for (int i = 0; i < Convert.ToInt16(comboBox_channelNumber.Text); i++)
            {
                aiTask.AddChannel(i);
            }
            //Basic parameter configuration
            aiTask.Mode = AIMode.Continuous;
            aiTask.SampleRate = (double)numericUpDown_aisamplerate.Value;

            //signal routing
            aiTask.SignalExport.Add((AISignalExportSource)Enum.Parse(typeof(AISignalExportSource), comboBox_aisignal.Text),
                (SignalExportDestination)Enum.Parse(typeof(SignalExportDestination), comboBox_aides.Text));

            //New aoTask based on the selected Solt Number
            try
            {
                aoTask = new JY5500AOTask(comboBox_SoltNumber.SelectedIndex);
            }
            catch (Exception ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //AddChannel
            aoTask.AddChannel(comboBox_aochannel.SelectedIndex);
            aoTask.Mode = AOMode.ContinuousWrapping;

            //aoTask.UpdateRate = 10000;

            //Trigger and Clock parameter configuration
            aoTask.Trigger.Type = AOTriggerType.Digital;
            aoTask.Trigger.Digital.Source = (AODigitalTriggerSource)Enum.Parse(typeof(AODigitalTriggerSource), comboBox_AOTrig.Text);
            aoTask.SampleClock.Source = AOSampleClockSource.External;
            aoTask.SampleClock.External.Terminal = (ClockTerminal)Enum.Parse(typeof(ClockTerminal), comboBox_AOClock.Text);
            aoTask.SampleClock.External.ExpectedRate = (double)numericUpDown_aisamplerate.Value;

            //signal routing
            aoTask.SignalExport.Add((AOSignalExportSource)Enum.Parse(typeof(AOSignalExportSource), comboBox_aosignal.Text),
                (SignalExportDestination)Enum.Parse(typeof(SignalExportDestination), comboBox_aodes.Text));


            writeData = new double[(int)aoTask.SampleClock.External.ExpectedRate/10];
            SeeSharpTools.JY.DSP.Fundamental.Generation.SineWave(ref writeData, 5, 0, (double)numericUpDown_aosignalRate.Value, (double)numericUpDown_aisamplerate.Value);
            aoTask.WriteData(writeData);
            readData = new double[(int)(aiTask.SampleRate / 5), aiTask.Channels.Count];
            disPlaydata = new double[aiTask.Channels.Count, (int)(aiTask.SampleRate / 5)];

            try
            {
                aoTask.Start();
            }

            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                aiTask.Start();
            }

            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //Enable timer, disable parameter configuration button and start button, display status
            timer_FetchData.Enabled = true;
            easyButton_Start.Enabled = false;
            groupBox_AIParam.Enabled = false;
            groupBox_AOParam.Enabled = false;
            groupBox_SignalRouting.Enabled = false;
            groupBox_Trigger_Clock.Enabled = false;
            easyButton_Stop.Enabled = true;
        }

        /// <summary>
        /// Timer, refresh every 10ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            //Read data and display if the local buffer data is enough
            if (aiTask.AvailableSamples > (ulong)readData.GetLength(0))
            {
                aiTask.ReadData(ref readData);
                SeeSharpTools.JY.ArrayUtility.ArrayManipulation.Transpose(readData, ref disPlaydata);
                easyChartX1.Plot(disPlaydata);
            }
        }

        /// <summary>
        /// Stop AI_AO Sync Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void easyButton_Stop_Click(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            // disconnect signal routing
            aiTask.SignalExport.Clear((AISignalExportSource)Enum.Parse(typeof(AISignalExportSource), comboBox_aisignal.Text),
                           (SignalExportDestination)Enum.Parse(typeof(SignalExportDestination), comboBox_aides.Text));
            aoTask.SignalExport.Clear((AOSignalExportSource)Enum.Parse(typeof(AOSignalExportSource), comboBox_aosignal.Text),
                (SignalExportDestination)Enum.Parse(typeof(SignalExportDestination), comboBox_aodes.Text));

            //Stop Task 
            aiTask?.Stop();
            aoTask?.Stop();

            easyButton_Start.Enabled = true;
            groupBox_AIParam.Enabled = true;
            groupBox_AOParam.Enabled = true;
            groupBox_SignalRouting.Enabled = true;
            groupBox_Trigger_Clock.Enabled = true;
            easyButton_Stop.Enabled = false;
        }

        /// <summary>
        /// Set param value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_cardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cardID.Text)
            {
                case "5510":
                    numericUpDown_aisamplerate.Maximum = 2000000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 33; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    for(int i = 0; i < 4; i++)
                    {
                        comboBox_aochannel.Items.Add(i);
                    }
                    break;
                case "5511":
                    numericUpDown_aisamplerate.Maximum = 1250000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 33; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_aochannel.Items.Add(i);
                    }
                    break;
                case "5515":
                    numericUpDown_aisamplerate.Maximum = 2000000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 17; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_aochannel.Items.Add(i);
                    }
                    break;
                case "5516":
                    numericUpDown_aisamplerate.Maximum = 1250000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 17; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        comboBox_aochannel.Items.Add(i);
                    }
                    break;
                default:
                    numericUpDown_aisamplerate.Maximum = 2000000;
                    comboBox_channelNumber.Items.Clear();
                    for (int i = 1; i < 33; i++)
                    {
                        comboBox_channelNumber.Items.Add(i);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        comboBox_aochannel.Items.Add(i);
                    }
                    break;
            }
            comboBox_channelNumber.SelectedIndex = 0;
            numericUpDown_aisamplerate.Value = 10000;
        }


    }
 }


