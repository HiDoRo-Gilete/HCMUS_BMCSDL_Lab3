using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMUS_BMCSDL_Lab03
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SignIn signin = new SignIn();
            Application.Run(signin);
            if (signin.isLogin)
            {
                Application.Run(new Home());
            }
        }
    }
}
