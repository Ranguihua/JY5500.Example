using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 finite point mode digital input (software trigger)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number
/// 2. Press the Start button and the Send Soft Trigger button to start finite point mode digital signal acquisition
///
/// </summary>

namespace Winform_DI_Finite_Soft_Trigger
{
    public partial class MainForm : Form
    {

        #region Private Fields
        /// <summary>
        /// DI Task
        /// </summary>
        private JY5500DITask ditask;

        /// <summary>
        /// the Buffer of data acquisition by the DITask
        /// </summary>
        byte[,] dataBuf;

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


        }


        /// <summary>
        /// startDI Task
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
                ditask.Mode = DIMode.Finite;
                ditask.SampleRate = (double)numericUpDown_sampleRate.Value;
                ditask.SamplesToAcquire = (int)numericUpDown_samplesToAcquire.Value;

                //trigger param configure
                ditask.Trigger.Type = DITriggerType.Soft;
                ditask.Trigger.Mode = (DITriggerMode)Enum.Parse(typeof(DITriggerMode), comboBox_triggermode.Text);

                try
                {
                    //Start ATTask data acquisition
                    ditask.Start();
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                dataBuf = new byte[ditask.SamplesToAcquire, ditask.Channels.Count];

                //Disable parameter setting and start button to enable timer function
                timer_FetchData.Enabled = true;
                groupBox_ParamConfig.Enabled = false;
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
        /// Send Soft Trigger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_sendSoftTrigger_Click(object sender, EventArgs e)
        {
            ditask.SendSoftwareTrigger();
            button_start.Enabled = false;
            button_stop.Enabled = true;
            button_sendSoftTrigger.Enabled = false;
        }

        /// <summary>
        /// Stop
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

            //Enable parameter setting and start button to disable timer function
            timer_FetchData.Enabled = false;
            groupBox_ParamConfig.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            button_sendSoftTrigger.Enabled = false;
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

        /// <summary>
        /// Timer, read data every 10ms and display
        /// </summary>
        private void time_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

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

                //Clear channel
                ditask.Channels.Clear();

                //Enable parameter setting and start button to disable timer function
                timer_FetchData.Enabled = false;
                groupBox_ParamConfig.Enabled = true;
                button_start.Enabled = true;
                button_stop.Enabled = false;
                button_sendSoftTrigger.Enabled = false;
            }
            else
            {
                timer_FetchData.Enabled = true;
            }
        }
        #endregion

        #region Methods
        #endregion
        
    }
}
