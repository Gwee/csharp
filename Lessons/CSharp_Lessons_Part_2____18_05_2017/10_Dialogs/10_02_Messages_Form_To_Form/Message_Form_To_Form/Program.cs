using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Message_Form_To_Form
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
            Application.Run(new FormA());
        }
    }
}