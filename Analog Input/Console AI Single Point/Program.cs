using System;
using JY5500;
using System.Windows.Forms;


///<summary>
/// Author: JYTEK
/// Date modified: 2020.8.28
/// Driver version: JY5500 Installer_V2.0.0.msi or later
/// Installation package: SeeSharpTools.JY.GUI 1.4.7 or later
/// Use environment: .NET 4.0 or later
/// </summary>
namespace Console_AI_Single_Point
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JY5500 Single Channel Analog Input in Single Mode");

            Console.WriteLine("Please Input BoardNumber：");
            int _boardNum = Convert.ToInt32(Console.ReadLine());

            double readValue = 0;
            int  _flag = 1;

            //New aiTask based on the selected Solt Number        
            JY5500AITask aiTask = null;
            try
            {
                aiTask = new JY5500AITask(_boardNum);
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Console.WriteLine("Please Input ChannelID：");
            int _channelID = Convert.ToInt32(Console.ReadLine());

            //Basic parameter configuration
            aiTask.Mode = AIMode.Single;

            //AddChannel
            aiTask.AddChannel(_channelID, -10, 10, AITerminal.RSE);

            try
            {
                aiTask.Start();
            }

            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            while (_flag == 1)
            {
                try
                {               
                    //ReadSinglePoint
                    aiTask.ReadSinglePoint(ref readValue, _channelID);

                    Console.WriteLine("Channel " + _channelID + " input " + readValue +
                     " V Voltage value finished!");

                    Console.WriteLine("whether continuous Read  Yes/No,1:Yes,0:No");
                    _flag = Convert.ToInt16(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            try
            {
                aiTask.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //Clear the channel that was added last time
            aiTask.Channels.Clear();
            Console.WriteLine("Single mode Analog input finished, press any key to exit");
            Console.ReadKey();
        }
    }
}