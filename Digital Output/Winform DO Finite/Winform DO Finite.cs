using System;
using System.Windows.Forms;
using JY5500;

/// <summary>
/// JY5500 digital signal output (finite mode)
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// Description:
/// 1. Input Solt Number, output rate, SamplesToAcquire and outputSignal frequency
/// 2. Generating digital signals
/// 3. Press the Start button to start the finite digital signal output
///
/// Note: JY5500 board has 4 digital output ports

namespace Winform_DO_Finite_Write
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// DOTask
        /// </summary>
        private JY5500DOTask dotask;

        /// <summary>
        ///  the buffer of written by the DO, and the capacity is the number of samples to be output.
        /// </summary>
        private byte[,] writeValue;

        /// <summary>
        /// port Column
        /// </summary>
        private int cloumn;

        /// <summary>
        /// one Cycle Points
        /// </summary>
        private int oneCyclePoints;

        /// <summary>
        /// high Level Points
        /// </summary>
        private int highLevelPoints;
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
            checkBox_Port0.Checked = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
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
                    checkBox_Port3.Visible = true;
                    numericUpDown_port3_Frequency.Visible = true;
                    numericUpDown_port3_duty.Visible = true;
                    break;
                case "5515":
                case "5516":
                    checkBox_Port3.Visible = false;
                    numericUpDown_port3_Frequency.Visible = false;
                    numericUpDown_port3_duty.Visible = false;
                    break;
                default:
                    numericUpDown_port3_Frequency.Visible = true;
                    numericUpDown_port3_duty.Visible = true;
                    checkBox_Port3.Visible = true;
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

                //AddChannel
                if (checkBox_Port0.Checked)
                {
                    dotask.AddChannel(0);
                }
                if (checkBox_Port1.Checked)
                {
                    dotask.AddChannel(1);
                }
                if (checkBox_Port2.Checked)
                {
                    dotask.AddChannel(2);
                }
                if (checkBox_Port3.Checked)
                {
                    dotask.AddChannel(3);
                }

                //Parameter configuration
                dotask.Mode = DOMode.Finite;
                dotask.UpdateRate = (double)numericUpDown_updateRate.Value;
                dotask.SamplesToUpdate = (int)numericUpDown_sampleToUpdate.Value;


                //GenerateData
                GenerateData();

                //display data
                easyChartX1.Plot(writeValue, 0, 1, SeeSharpTools.JY.GUI.MajorOrder.Column);

                try
                {
                    //Write data to buffer
                    dotask.WriteData(writeValue, (uint)writeValue.GetLength(0), -1);
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                    MessageBox.Show(ex.Message);
                    return;
                }

                try
                {
                    //startDOTask
                    dotask.Start();
                }

                catch (JYDriverException ex)
                {
                    //Drive error message display
                   MessageBox.Show(ex.Message);
                    return;
                }

                //Disable parameter configuration and start button
                timer_FetchData.Enabled = true;
                groupBox_genParam.Enabled = false;
                button_start.Enabled = false;
                button_stop.Enabled = true;
                ControlThePortEnable(false);

            }
            catch (JYDriverException ex)
            {
                //Display driver error message
               MessageBox.Show(ex.Message);
               return;
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
                //Determine if the task exists
                if (dotask != null) 
                {
                    //Stop Task 
                    dotask.Stop();
                }
            }
            catch (JYDriverException ex)
            {
                //Display driver error message
               MessageBox.Show(ex.Message);
               return;
            }

            //Clear the channel that was added last time
            dotask.Channels.Clear();

            //Disable timer and Stop button, re-enable Start and parameter configuration buttons
            timer_FetchData.Enabled = false;
            groupBox_genParam.Enabled = true;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            ControlThePortEnable(true);
        }

        /// <summary>
        /// Timer, check whether the Task ends every 100ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_FetchData_Tick(object sender, EventArgs e)
        {
            timer_FetchData.Enabled = false;

            //Check DO finite point outputTask is over, if it is over Stop Task,
            //otherwise Task is not completed, enable counter to continue query
            if (dotask.WaitUntilDone(10))
            {
                try
                {
                    //Determine if the task exists
                    if (dotask != null) 
                    {
                        //Stop Task 
                        dotask.Stop();
                    }
                }
                catch (JYDriverException ex)
                {
                    //Drive error message display
                   MessageBox.Show(ex.Message);
                   return;
                }

                //Disable timer and Stop button, re-enable Start and parameter configuration buttons
                timer_FetchData.Enabled = false;
                groupBox_genParam.Enabled = true;
                button_start.Enabled = true;
                button_stop.Enabled = false;
                ControlThePortEnable(true);
            }
            else
            {
                timer_FetchData.Enabled = true;
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
                //Determine if the task exists
                if (dotask != null) 
                {
                    //Stop Task 
                    dotask.Stop();
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
        /// <summary>
        /// Generate Data
        /// </summary>
        private void GenerateData()
        {
            //Generate digital signal
            writeValue = new byte[(int)dotask.SamplesToUpdate, dotask.Channels.Count];

            cloumn = 0;
            if (checkBox_Port0.Checked)
            {
                // cal one cycle points
                oneCyclePoints = (int)(dotask.SamplesToUpdate / (double)numericUpDown_port0_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPoints = (int)(oneCyclePoints * (double)numericUpDown_port0_duty.Value);

                //write data
                for (int i = 0; i < (int)(dotask.SamplesToUpdate / oneCyclePoints); i++)
                {
                    for (int j = 0; j < oneCyclePoints; j++)
                    {
                        if (j < highLevelPoints)
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0xFF;
                        }
                        else
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0x00;
                        }
                    }
                }

                // cloumn add
                cloumn++;
            }
            if (checkBox_Port1.Checked)
            {
                // cal one cycle points
                oneCyclePoints = (int)(dotask.SamplesToUpdate / (double)numericUpDown_port1_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPoints = (int)(oneCyclePoints * (double)numericUpDown_port1_duty.Value);

                //write data
                for (int i = 0; i < (int)(dotask.SamplesToUpdate / oneCyclePoints); i++)
                {
                    for (int j = 0; j < oneCyclePoints; j++)
                    {
                        if (j < highLevelPoints)
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0xFF;
                        }
                        else
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0x00;
                        }
                    }
                }

                // cloumn add
                cloumn++;
            }
            if (checkBox_Port2.Checked)
            {
                // cal one cycle points
                oneCyclePoints = (int)(dotask.SamplesToUpdate / (double)numericUpDown_port2_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPoints = (int)(oneCyclePoints * (double)numericUpDown_port2_duty.Value);

                //write data
                for (int i = 0; i < (int)(dotask.SamplesToUpdate / oneCyclePoints); i++)
                {
                    for (int j = 0; j < oneCyclePoints; j++)
                    {
                        if (j < highLevelPoints)
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0xFF;
                        }
                        else
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0x00;
                        }
                    }
                }

                // cloumn add
                cloumn++;
            }
            if (checkBox_Port3.Checked)
            {
                // cal one cycle points
                oneCyclePoints = (int)(dotask.SamplesToUpdate / (double)numericUpDown_port3_Frequency.Value);
                // cal 1 points in one cycle
                highLevelPoints = (int)(oneCyclePoints * (double)numericUpDown_port3_duty.Value);

                //write data
                for (int i = 0; i < (int)(dotask.SamplesToUpdate / oneCyclePoints); i++)
                {
                    for (int j = 0; j < oneCyclePoints; j++)
                    {
                        if (j < highLevelPoints)
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0xFF;
                        }
                        else
                        {
                            writeValue[i * oneCyclePoints + j, cloumn] = 0x00;
                        }
                    }
                }
            }

        }

        /// <summary>
        /// Control The Port Enable
        /// </summary>
        /// <param name="Enabled"></param>
        private void ControlThePortEnable(bool Enabled)
        {
            //port0
            checkBox_Port0.Enabled = checkBox_Port0.Checked || Enabled;
            numericUpDown_port0_Frequency.Enabled = checkBox_Port0.Checked || Enabled;
            numericUpDown_port0_duty.Enabled = checkBox_Port0.Checked || Enabled;

            //port1
            checkBox_Port1.Enabled = checkBox_Port1.Checked || Enabled;
            numericUpDown_port1_Frequency.Enabled = checkBox_Port1.Checked || Enabled;
            numericUpDown_port1_duty.Enabled = checkBox_Port1.Checked || Enabled;

            //port2
            checkBox_Port2.Enabled = checkBox_Port2.Checked || Enabled;
            numericUpDown_port2_Frequency.Enabled = checkBox_Port2.Checked || Enabled;
            numericUpDown_port2_duty.Enabled = checkBox_Port2.Checked || Enabled;

            //port3
            checkBox_Port3.Enabled = checkBox_Port3.Checked || Enabled;
            numericUpDown_port3_Frequency.Enabled = checkBox_Port3.Checked || Enabled;
            numericUpDown_port3_duty.Enabled = checkBox_Port3.Checked || Enabled;

        }
        #endregion

    }
}
