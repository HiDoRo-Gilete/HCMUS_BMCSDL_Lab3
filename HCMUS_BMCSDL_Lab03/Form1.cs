using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HCMUS_BMCSDL_Lab03
{
    public partial class Form1 : Form
    {
        private string servername;
        public bool isconnect = false;
        public SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            servername = tb_server.Text;
            if (servername.Equals(""))
            {
                MessageBox.Show("Server name cannot be empty!");
            }
            else
            {
                string sqlconnect = "server=" + servername + ";" +
                    "Trusted_Connection=yes;database=QLSINHVIEN;connection timeout=30;" +
                    "TrustServerCertificate=True;";
                try
                {
                    conn = new SqlConnection(sqlconnect);
                    conn.Open();
                    //SqlCommand command = new SqlCommand("EXEC SP_SEL_NHANVIEN", conn);
                    //SqlDataReader reader = command.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    MessageBox.Show(reader["LUONGCB"].ToString());
                    //}
                    conn.Close();
                    isconnect = true;
                    this.Close();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("QLSINHVIEN"))
                    {
                        MessageBox.Show("Mời cô chạy đoạn script tạo database QLSINHVIEN trước khi chạy app!");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        }
}
