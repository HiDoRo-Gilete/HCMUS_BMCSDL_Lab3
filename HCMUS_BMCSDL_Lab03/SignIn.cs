using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMUS_BMCSDL_Lab03
{
    public partial class SignIn : Form
    {
        public bool isLogin = false;
        public SignIn()
        {
            InitializeComponent();
        }
        private void goToHome()
        {
            isLogin = true;
            this.Close();
        }


        private void btn_signin_Click(object sender, EventArgs e)
        {
            goToHome();
        }

        private void btn_signin_MouseHover(object sender, EventArgs e)
        {
            btn_signin.BackColor = Color.Yellow;
        }

        private void btn_signin_MouseLeave(object sender, EventArgs e)
        {
            btn_signin.BackColor = Color.Aqua;
        }

        private void btn_signin_MouseMove(object sender, MouseEventArgs e)
        {
            btn_signin.BackColor = Color.Yellow;
        }
    }
}
