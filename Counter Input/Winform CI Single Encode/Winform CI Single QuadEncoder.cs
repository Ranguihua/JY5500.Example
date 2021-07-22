using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 single mode Encode
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.4 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Orthogonal coding function, orthogonal coding includes three coding methods: X1, X2, X4
/// 2.X1: When A leads B, the count increase occurs on the rising edge of A; when B leads A, the count decrease occurs on the falling edge of A.
/// X2: When A leads B, the count increase occurs on the rising edge and falling edge of A; when B leads A, the count reduction occurs on the rising edge and falling edge of A.
/// X4: When A leads B, the increment increases on the rising and falling edges of A and B. When B leads A, the count reduction occurs on the rising and falling edges of A and B.
/// single mode Encode:
/// In this mode, input pins A and B refer to the Source port and AUX port of the CounterID, respectively, and the Gate port is grounded.
/// </summary>
///

namespace Winform_CI_Single_Encode
{
    public partial class MainForm : Form
    {
        #region private Fields
        /// <summary>
        /// CITask
        /// </summary>
        private JY5500CITask citask;

        /// <summary>
        /// the Buffer of data read by the CITask
        /// </summary>
        uint counterValue = 0;
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

            comboBox_encodeType.Items.AddRange(Enum.GetNames(typeof(QuadEncodingType)));

            comboBox_encodeType.SelectedIndex = 0;
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
        ///  Start Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Click(object sender, EventArgs e)
        {
            try
            {
                //new CITask based on the selected Solt Number and counterID
                citask = new JY5500CITask(comboBox_SoltNumber.SelectedIndex, comboBox_counterNumber.SelectedIndex);

                //Parameter configuration
                citask.Mode = CIMode.Single;
                citask.Type = CIType.QuadEncoder;
                citask.QuadEncoder.EncodingType = (QuadEncodingType)Enum.Parse(typeof(QuadEncodingType), comboBox_encodeType.Text, true);
                citask.QuadEncoder.ZReloadEnabled = false;
                try
                {
                    //start Task
                    citask.Start();
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                //enable timer and Stop button，Disable parameter configuration and start button
                timer_FetchData.Enabled = true;
                groupBox_genPara.Enabled = false;
                button_Start.Enabled = false;
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
                if (citask != null)
                {
                    citask.Stop();
                }
            }

            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //disable timer and stop button ,enable Parameter configuration button and start button
            timer_FetchData.Enabled = false;
            groupBox_genPara.Enabled = true;
            button_Start.Enabled = true;
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
                if (citask != null)
                {
                    citask.Stop();
                }
            }

            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// timer，refresh every 100ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            try
            {
                //read countervalue and display
                citask.ReadSinglePoint(ref counterValue);
                textBox_countValue.Text = counterValue.ToString();
            }
            catch (JYDriverException ex)
            {
                //Display driver error message
                MessageBox.Show(ex.Message);
                return;
            }

            timer_FetchData.Enabled = true;
        }

        #endregion

        #region Methods  
        #endregion

    }
}
