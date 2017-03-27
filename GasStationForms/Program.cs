// Author: Ryan Alderton
// SID: 1609275
 
using System;
using System.Windows.Forms;

namespace GasStationForms
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
            Application.Run(new Form1());
        }



    }
}
