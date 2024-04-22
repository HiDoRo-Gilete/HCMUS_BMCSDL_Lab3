using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMUS_BMCSDL_Lab03
{

    public partial class SignIn : Form
    {
        public bool isLogin = false;
        SqlConnection conn;
        private string pubkey;
        public SignIn(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        private void goToHome()
        {
            isLogin = true;
            this.Close();
        }


        private void btn_signin_Click(object sender, EventArgs e)
        {
            string username = textboxUsername.Text;
            string password = textboxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password!");
                return;
            }
            if (IsLoginValid(username, password))
            {
                MessageBox.Show("Sign In successfully!");
                Home.InitPass(username,password);
                Home.pubkey = pubkey;
                goToHome();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect.");
            }
        }


        private bool IsLoginValid(string username, string password)
        {
            SqlConnection connection = this.conn;
            connection.Open();
            bool check = false;
            string queryNV = "SELECT * FROM NHANVIEN WHERE TENDN = @TENDN";
            using (SqlCommand command = new SqlCommand(queryNV, connection))
            {
                command.Parameters.AddWithValue("@TENDN", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var hashedPassword = (byte[])reader["MATKHAU"];
                    if (hashedPassword != null)
                    {
                        byte[] inputPasswordHash = SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(password));

                        if (hashedPassword.SequenceEqual(inputPasswordHash))
                        {
                            check = true;
                            Home.typeUser = Home.Nhanvien;
                            pubkey = reader["PUBKEY"].ToString();
                        }
                    }
                    reader.Close();
                }
            }
            if (!check)
            {
                string querySV = "SELECT MATKHAU FROM SINHVIEN WHERE MASV = @MASV";
                using (SqlCommand command = new SqlCommand(querySV, connection))
                {
                    command.Parameters.AddWithValue("@MASV", username);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var hashedPassword = (byte[])reader["MATKHAU"];
                        if (hashedPassword != null)
                        {
                            byte[] inputPasswordHash = SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(password));

                            if (hashedPassword.SequenceEqual(inputPasswordHash))
                            {
                                check = true;
                                Home.typeUser = Home.Sinhvien;
                                pubkey = reader["PUBKEY"].ToString();
                            }
                        }
                        reader.Close();
                    }
                }
            }
            connection.Close();
            return check;
        }


        private void btn_signin_MouseHover(object sender, EventArgs e)
        {
            btn_signin.BackColor = Color.LightGray;
        }

        private void btn_signin_MouseLeave(object sender, EventArgs e)
        {
            btn_signin.BackColor = Color.White;
        }

        private void btn_signin_MouseMove(object sender, MouseEventArgs e)
        {
            btn_signin.BackColor = Color.LightGray;
        }

        private void btn_exitSignIn_MouseHover(object sender, EventArgs e)
        {
            btn_exitSignIn.BackColor = Color.LightGray;
        }

        private void btn_exitSignIn_MouseMove(object sender, EventArgs e)
        {
            btn_exitSignIn.BackColor = Color.LightGray;
        }

        private void btn_exitSignIn_MouseLeave(object sender, EventArgs e)
        {
            btn_exitSignIn.BackColor = Color.Aqua;
        }
        private void btn_exitSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}