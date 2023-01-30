using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    internal static class ProgramBase
    {
        /// <summary>
        /// the main entry for the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}