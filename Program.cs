using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RateApp
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

            //if (RateApp.Properties.Settings.Default.UserMode != "Admin")
            //{

                Application.Run(new Form1());

            //}
            //else
            //{
            //    Application.Run(new Login());
            //}

            
        }
    }
}
