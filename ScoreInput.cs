using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMUS_BMCSDL_Lab03
{
    public partial class ScoreInput : UserControl
    {
        private string MALOP;
        private string password;
        private string username;
        private string pubkey;
        List<List<string>> allStudents;
        SqlConnection connection;
        public ScoreInput(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
            password = "123456";
            username = "NV01";
            pubkey = "NV01";
            InitializeMyComponent();
        }
        private void InitializeMyComponent()
        {
            lv_score.Columns.Add("MASV").Width = 90;
            lv_score.Columns.Add("HOTEN").Width = 173;
            lv_score.Columns.Add("TENHP").Width = 173;
            lv_score.Columns.Add("DIEM").Width = 87;
            lv_score.Font = new System.Drawing.Font("Microsoft Sans Serif",
                10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            refresh();
        }
        private List<List<string>> getAllStudent(string malop)
        {
            List<List<string>> students = new List<List<string>>();
            //students.Add(new List<string>() { "SV01", "NGUYEN VAN A", "VAT LY LUONG TU", "" });
            //students.Add(new List<string>() { "SV02", "NGUYEN VAN B", "VAT LY LUONG TU", "" });
            //students.Add(new List<string>() { "SV03", "NGUYEN VAN C", "VAT LY LUONG TU", "" });
            SqlCommand command = new SqlCommand("EXEC SP_UV_BANGDIEM '"+malop+"','"+password+"'", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(new List<string>() { reader["MASV"].ToString(), reader["HOTEN"].ToString(),
                        reader["TENHP"].ToString(),reader["DIEM"].ToString(),reader["MAHP"].ToString() });
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return students;
        }
        private void gotoManageStudent()
        {
            Home.DisplayMember(Home.MANAGE_STUDENT_ID);
        }
        public void refresh()
        {
            MALOP = "LOP01";
            allStudents = getAllStudent(MALOP);
            groupBox1.Visible = false;
            lv_score.Items.Clear();
            foreach (List<string> student in allStudents)
            {
                ListViewItem item = new ListViewItem();
                item.Text = student[0];
                item.ForeColor = System.Drawing.Color.Aqua;
                item.Font = new System.Drawing.Font("Microsoft Sans Serif",
                    9F, System.Drawing.FontStyle.Regular, System.Drawing.
                    GraphicsUnit.Point, ((byte)(163)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = student[1] });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = student[2] });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = student[3] });
                lv_score.Items.Add(item);
            }
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.BackColor = Color.YellowGreen;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            gotoManageStudent();
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.BackColor = Color.Aqua;
        }

        private void lv_score_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_score.SelectedItems.Count > 0)
            {
                groupBox1.Visible = true;
                ListViewItem item = lv_score .SelectedItems[0];
                lb_msv.Text = "Mã SV: "+item.Text;
                lb_name.Text = "Họ tên: " + item.SubItems[1].Text;
                tb_score.Text = "";
            }
        }

        private void tb_score_TextChanged(object sender, EventArgs e)
        {
            if (tb_score.Text.Length > 0)
            {
                btn_save.Enabled = true;
            }
            else
            {
                btn_save.Enabled = false;
            }
        }
        private void tb_score_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_score.Text;
            text= text+e.KeyChar;
            if((e.Handled = !char.IsControl(e.KeyChar)))
            {
                try
                {
                    float number = float.Parse(text);
                    if (number >= 0f && number <= 10f)
                    {
                        e.Handled = false;
                        
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                catch (Exception ex)
                {
                    e.Handled = true;
                }
            }
            
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }
        private bool checkNumber(char s)
        {
            return s>=48 && s<=57;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Not Implement!");
            if(tb_score.Text.Length > 0)
            {
                int index = lv_score.SelectedItems[0].Index;
                string masv = allStudents[index][0];
                string mahp = allStudents[index][4];

                SqlCommand command = new SqlCommand("EXEC SP_INS_PUBLIC_BANGDIEM '" + masv + "','" + mahp + 
                    "',"+tb_score.Text+",'"+pubkey+"'", connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đã lưu điểm");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Điểm không được để trống! Mời thử lại");
            }
        }

        private void ScoreInput_Load(object sender, EventArgs e)
        {

        }

        private void MASV_Click(object sender, EventArgs e)
        {

        }
    }
}
