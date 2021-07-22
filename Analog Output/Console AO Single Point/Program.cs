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
namespace Console_AO_Single_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JY5500 Single Channel Analog Output in Single Mode");

            Console.WriteLine("Please Input BoardNumber：");
            int _boardNum = Convert.ToInt32(Console.ReadLine());

            JY5500AOTask aoTask = null;
            try
            {
                //New aoTask based on the selected Solt Number
                aoTask = new JY5500AOTask(_boardNum);
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Console.WriteLine("Please Input ChannelID：");
            int _channelID = Convert.ToInt32(Console.ReadLine());
            //AddChannel
            aoTask.AddChannel(_channelID, -10, 10);

            //Basic parameter configuration
            aoTask.Mode = AOMode.Single;

            try
            {
                //Start Task
                aoTask.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            int _flag= 1;

            while (_flag==1)
            {


                Console.WriteLine("Please Input WriteValue，range：(-10,10)：");
                double _writeValue = Convert.ToDouble(Console.ReadLine());

                try
                {
                    //WriteSinglePoint
                    aoTask.WriteSinglePoint(_writeValue, _channelID);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                Console.WriteLine("Channel " + _channelID + " Output " + _writeValue +
                    " V Voltage value finished,whether continuous Write Yes/No,1:Yes,0:No");
                _flag = Convert.ToInt32(Console.ReadLine());


            }

            try
            {
                aoTask.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Console.WriteLine("Single mode voltage value has been output, press any key to exit");
            Console.ReadKey();
        }
    }
}
