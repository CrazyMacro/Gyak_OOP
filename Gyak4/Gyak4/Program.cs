﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak4
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

            LoginForm loginWindow = new LoginForm();
            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Targyfelvetel());
            }

        }
    }
}
