using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackingSample1
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // Indicates whether the software is licensed.
            bool licensed;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            licensed = bool.Parse(ConfigurationManager.AppSettings["licensed"]);

            if (licensed)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("You're not licensed :-(");
            }
        }
    }
}
