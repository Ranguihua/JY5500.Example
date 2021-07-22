using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 single point mode digital input
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.4 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input the Solt Number
/// 2. Press the Start button to start single point digital signal acquisition
///
/// </summary>

namespace Winform_DI_SinglePoint
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
        private bool[] readValue;
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

            readValue = new bool[8];
            comboBox_cardID.SelectedIndex = 0;
            panel2.Visible = false;
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
                    ledArrayPort3.Visible = true;
                    panel2.Visible = true;
                    break;
                case "5515":
                case "5516":
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    ledArrayPort3.Visible = false;
                    panel2.Visible = false;
                    break;
                default:
                    checkedListBox_portChoose.Items.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        checkedListBox_portChoose.Items.Add("port" + i);
                    }
                    ledArrayPort3.Visible = true;
                    panel2.Visible = true;
                    break;
            }
        }


        /// <summary>
        /// Start digital Signal input
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        private void button_start_Click(object sender, EventArgs e)
         {
            try
            {
                //new DITask based on the selected Solt Number
                ditask = new JY5500DITask(comboBox_SoltNumber.SelectedIndex);

                //Configure Mode
                ditask.Mode = DIMode.Single;

                //AddChannel
                for (int i = 0; i < checkedListBox_portChoose.Items.Count; i++)
                {
                    if (checkedListBox_portChoose.GetItemChecked(i))
                    {
                        ditask.AddChannel(i);
                    }
                }

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

               //read data 
                for (int i = 0; i < checkedListBox_portChoose.Items.Count; i++)
                {
                    if (checkedListBox_portChoose.GetItemChecked(i))
                    {
                        ditask.ReadSinglePoint(ref readValue, i);

                        switch (i)
                        {
                            case 0:
                                ledArrayPort0.Value = readValue;
                                break;
                            case 1:
                                ledArrayPort1.Value = readValue;
                                break;
                            case 2:
                                ledArrayPort2.Value = readValue;
                                break;
                            case 3:
                                ledArrayPort3.Value = readValue;
                                break;
                            default:
                                MessageBox.Show("only support 4 port");
                                return;
                        }
                    }
                }

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

    }
}


        
