﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MVirs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MVirs { Visible = false });
        }
    }
}
