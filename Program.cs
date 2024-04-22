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
            Form1 form1 = new Form1();
            Application.Run(form1);
            if (form1.isconnect)
            {
                SignIn signin = new SignIn(form1.conn);
                Application.Run(signin);
                if (signin.isLogin)
                {
                    Application.Run(new Home(form1.conn));
                }
            }
        }
    }
}
