using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Regis2008;

namespace RegisNet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int numberOfCopy = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormControl(numberOfCopy));
        }
    }
}
