using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 continuous mode digital input
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number
/// 2. Press the Start button to start continuous mode digital acquisition
///
/// </summary>
///

namespace Winform_DI_Continuous_Read
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

                try
                {
                    //Start ATTask data acquisition
                    ditask.Start();
                    //dotask.Start();
                }

                catch (JYDriverException ex)
                {
                    toolStripStatusLabel.Text = "StartAITask start failed";
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                dataBuf = new byte[(int)numericUpDown_readSamples.Value, ditask.Channels.Count];

                //Disable parameter setting and start button to enable timer function
                timer_FetchData.Enabled = true;
                groupBox_DIParamConfig.Enabled = false;
                button_start.Enabled = false;
                button_stop.Enabled = true;
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
        /// Timer, read data every 10ms and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                }
            }
            catch (JYDriverException ex)
            {
                toolStripStatusLabel.Text = " start read data failed";
                timer_FetchData.Enabled = false;
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            timer_FetchData.Enabled = true;
        }

        /// <summary>
        /// Stop input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                //Determine if the task exists
                if (ditask != null)
                {
                    //Stop Task 
                    ditask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //Clear the channel that was added last time
            ditask.Channels.Clear();

            //Enable parameter setting and start button to disable timer function
            timer_FetchData.Enabled = false;
            groupBox_DIParamConfig.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            toolStripStatusLabel.Text = "Stop data acquisition";
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
                if (ditask != null)
                {
                    //Stop Task 
                    ditask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }
        }

        #endregion

        #region Methods
        #endregion

        private void checkedListBox_portChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (checkedListBox_portChoose.Checked)
            //{
            //    for (int i = 0; i < checkedListBox_portChoose.Items.Count; i++)
            //    {
            //        checkedListBox_portChoose.SetItemCheckState(i, CheckState.Checked);
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < checkedListBox_portChoose.Items.Count; i++)
            //{
            //    checkedListBox_portChoose.SetItemCheckState(i, CheckState.Unchecked);
            //}
        }
    }
}

