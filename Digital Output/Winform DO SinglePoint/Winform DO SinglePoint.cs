using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 digital output (single mode)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number
/// 2. Press the Start button to start a single digit output
/// 3. Modify the output level with the Siwtch switch
///
/// Note: JY5500 board has 4 digital output ports
/// </summary>

namespace Winform_DO_SinglePoint
{
    public partial class MainForm : Form
    {
        #region Private Fields

        /// <summary>
        /// DOTask
        /// </summary>
        private JY5500DOTask dotask;

        /// <summary>
        /// Store data to be written
        /// </summary>
        private bool[] writeValue;
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

            writeValue = new bool[8] { false, false, false, false, false, false, false, false };
            groupBox_port0.Enabled = false;
            groupBox_port1.Enabled = false;
            groupBox_port2.Enabled = false;
            groupBox_port3.Enabled = false;
            comboBox_cardID.SelectedIndex = 0;
        }

        private void comboBox_cardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cardID.Text)
            {
                case "5515":
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    groupBox_port3.Visible = false;
                    label3.Visible = false;
                    break;
                case "5516":
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    groupBox_port3.Visible = false;
                    label3.Visible = false;
                    break;
                case "5510":
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    groupBox_port3.Visible = true;
                    label3.Visible = true;
                    break;
                case "5511":
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    groupBox_port3.Visible = true;
                    label3.Visible = true;
                    break;
                default:
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    groupBox_port3.Visible = true;
                    label3.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Start DOTask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //new DOTask
                dotask = new JY5500DOTask(comboBox_SoltNumber.SelectedIndex);

                //Add channels
                for (int i = 0; i < checkedListBox_portChoose.Items.Count; i++)
                {
                    if (checkedListBox_portChoose.GetItemChecked(i))
                    {
                        dotask.AddChannel(i);
                    }
                }
                //Configure DOMode
                dotask.Mode = DOMode.Single;

                //write data
                for (int i = 0; i < checkedListBox_portChoose.Items.Count; i++)
                {
                    if (checkedListBox_portChoose.GetItemChecked(i))
                    {
                        switch(i)
                        {
                            case 0:
                                writeValue = switchArrayport0.Value;
                                break;
                            case 1:
                                writeValue = switchArrayport1.Value;
                                break;
                            case 2:
                                writeValue = switchArrayport2.Value;
                                break;
                            case 3:
                                writeValue = switchArrayport3.Value;
                                break;
                        }
                        dotask.WriteSinglePoint(writeValue, i);

                    }

                }

                try
                {
                    //Start ATTask data acquisition
                    dotask.Start();
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                //Disable Parameter configuration button
                groupBox_ParamConfig.Enabled = false;
                button_start.Enabled = false;
                groupBox_port0.Enabled = true;
                groupBox_port1.Enabled = true;
                groupBox_port2.Enabled = true;
                groupBox_port3.Enabled = true;
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
        /// port0 Write data to buffer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchArrayport0_ControlValueChanged(object sender, SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventArgs e)
        {
            // port 0 is checked
            if (checkedListBox_portChoose.GetItemChecked(0))
            {
                //The result of the Switch switch is assigned to the cached array that holds the data
                writeValue = switchArrayport0.Value;

                //Write data to buffer
                dotask.WriteSinglePoint(writeValue, 0);
            }

        }

        /// <summary>
        /// port1 Write data to buffer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchArrayport1_ControlValueChanged(object sender, SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventArgs e)
        {
            // port 0 is checked
            if (checkedListBox_portChoose.GetItemChecked(1))
            {
                //The result of the Switch switch is assigned to the cached array that holds the data
                writeValue = switchArrayport1.Value;

                //Write data to buffer
                dotask.WriteSinglePoint(writeValue, 1);
            }
        }

        /// <summary>
        /// port2 Write data to buffer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchArrayport2_ControlValueChanged(object sender, SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventArgs e)
        {
            // port 0 is checked
            if (checkedListBox_portChoose.GetItemChecked(2))
            {
                //The result of the Switch switch is assigned to the cached array that holds the data
                writeValue = switchArrayport2.Value;

                //Write data to buffer
                dotask.WriteSinglePoint(writeValue, 2);
            }
        }

        /// <summary>
        /// port3 Write data to buffer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchArrayport3_ControlValueChanged(object sender, SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventArgs e)
        {
            // port 0 is checked
            if (checkedListBox_portChoose.GetItemChecked(3))
            {
                //The result of the Switch switch is assigned to the cached array that holds the data
                writeValue = switchArrayport3.Value;

                //Write data to buffer
                dotask.WriteSinglePoint(writeValue, 3);
            }
        }

        /// <summary>
        /// Stop output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                //Stop ATTask data acquisition
                dotask.Stop();
            }

            catch (JYDriverException ex)
            {
                //Drive error message display
                MessageBox.Show(ex.Message);
                return;
            }

            //enable Start button and Parameter configuration button
            groupBox_ParamConfig.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            groupBox_port0.Enabled = false;
            groupBox_port1.Enabled = false;
            groupBox_port2.Enabled = false;
            groupBox_port3.Enabled = false;
        }
        #endregion

        #region Methods
        #endregion
    }
}
