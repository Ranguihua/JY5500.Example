﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Winform_CO_Continuous_Digital_Trigger
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
