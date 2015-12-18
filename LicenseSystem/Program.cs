using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOfIssuingLicKeysApplication.Forms;

namespace SysOfIssuingLicKeysApplication
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
            Login log = new Login();
            log.ShowDialog();
            if (!log.exit)
                Application.Run(new MainForm());
           
        }
    }
}
