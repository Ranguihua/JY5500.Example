using System;
using System.Windows.Forms;
using JY5500;

///<summary>
/// JY5500 finite point mode digital input (digital trigger)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number
/// 2. Select the digital trigger source and trigger edge
/// 3. Press the Start button to start finite point mode digital acquisition
/// </summary>
///

namespace Winform_DI_Finite_Digital_Trigger
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// DITask
        /// </summary>
        private JY5500DITask ditask;

        /// <summary>
        /// the Buffer of data acquisition by the DITask
        /// </summary>
        private byte[,] dataBuf;

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

            //Call the enumeration of DITriggerMode in the driver as a menu
            comboBox_triggermode.Items.AddRange(Enum.GetNames(typeof(DITriggerMode)));
            comboBox_triggermode.SelectedIndex = 0;

            //Call the enumeration of DIDigitalTriggerSource in the driver as a menu
            comboBox_triggerSource.Items.AddRange(Enum.GetNames(typeof(DIDigitalTriggerSource)));
            comboBox_triggerSource.SelectedIndex = 0;

            //Call the enumeration of DIDigitalTriggerEdge in the driver as a menu
            comboBox_triggerEdge.Items.AddRange(Enum.GetNames(typeof(DIDigitalTriggerEdge)));
            comboBox_triggerEdge.SelectedIndex = 0;
        }


        /// <summary>
        /// Set the default ports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_cardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cardID.Text)
            {
                case "5510":
                case "5511":
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    break;
                case "5515":
                case "5516":
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    break;
                default:
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    break;
            }
        }

        /// <summary>
        /// Start digital Signal input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //new DITask based on the selected Solt Number
                ditask = new JY5500DITask(comboBox_SoltNumber.SelectedIndex);

                //AddChannel
                for (int i = 0; i < checkedListBox_portChoose.Items.Count; i++)
                {
                    if (checkedListBox_portChoose.GetItemChecked(i))
                    {
                        ditask.AddChannel(i);
                    }
                }

                //Parameter configuration
                ditask.Mode = DIMode.Continuous;
                ditask.SampleRate = (double)numericUpDown_sampleRate.Value;
                ditask.SamplesToAcquire = (int)numericUpDown_samplesToAcquire.Value;
                ditask.Trigger.Type = DITriggerType.Digital;
                ditask.Trigger.Mode = (DITriggerMode)Enum.Parse(typeof(DITriggerMode), comboBox_triggermode.Text, true);
                ditask.Trigger.Digital.Edge = (DIDigitalTriggerEdge)Enum.Parse(typeof(DIDigitalTriggerEdge), comboBox_triggerEdge.Text, true);
                ditask.Trigger.Digital.Source = (DIDigitalTriggerSource)Enum.Parse(typeof(DIDigitalTriggerSource), comboBox_triggerSource.Text, true);
                
                try
                {
                    //Start ATTask data acquisition
                    ditask.Start();
                }

                catch (JYDriverException ex)
                {
                    toolStripStatusLabel1.Text = "TaskStart失败";
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                dataBuf = new byte[ditask.SamplesToAcquire, ditask.Channels.Count];

                //Disable parameter setting and start button to enable timer function
                timer_FetchData.Enabled = true;
                groupBox_ParamConfig.Enabled = false;
                groupBox_TrigParam.Enabled = false;
                button_start.Enabled = false;
                button_stop.Enabled = true;
                toolStripStatusLabel1.Text = "Waiting to receive the trigger signal...";
            }

            catch (JYDriverException ex)
            {
                toolStripStatusLabel.Text = "aiTask start failed";
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
                if (ditask != null)
                {
                    ditask.Stop();
                }
            }

            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //Clear the channel that was added last time
            ditask.Channels.Clear();

            //Enable parameter setting and start button to disable timer function
            timer_FetchData.Enabled = false;
            groupBox_ParamConfig.Enabled = true;
            groupBox_TrigParam.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            toolStripStatusLabel.Text = "Stop data acquisition";
        }

        /// <summary>
        ///  Timer, read data every 10ms and display
        /// </summary>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                if (ditask.AvailableSamples >= (ulong)dataBuf.GetLength(0))
                {
                    ditask.ReadData(ref dataBuf, (uint)dataBuf.GetLength(0), -1);
                    toolStripStatusLabel.Text = "Reading in data...";
                    easyChartX_readData.Plot(dataBuf, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);
                    try
                        {
                            if (ditask != null)
                            {
                                ditask.Stop();
                            }
                        }

                        catch (JYDriverException ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }

                         //Clear the channel that was added last time
                        ditask.Channels.Clear();

                        //Enable parameter setting and start button to disable timer function
                        timer_FetchData.Enabled = false;
                        groupBox_ParamConfig.Enabled = true;
                        groupBox_TrigParam.Enabled = true;
                        button_start.Enabled = true;
                        button_stop.Enabled = false;
                        toolStripStatusLabel1.Text = string.Format("Stop data acquisition");
                }
                else
                {
                    timer_FetchData.Enabled = true;
                }
            }
            catch (JYDriverException ex)
            {
                toolStripStatusLabel1.Text = "Failed to read data";
                MessageBox.Show(ex.Message);
                return;
            }
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
                if (ditask != null)
                {
                    ditask.Stop();
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
