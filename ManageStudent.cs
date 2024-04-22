using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using Azure.Identity;
using Microsoft.Data.SqlClient;

namespace HCMUS_BMCSDL_Lab03
{
    public partial class ManageStudent : UserControl
    {
        private string username;
        List<List<string>> allStudents;
        SqlConnection connection;
        public ManageStudent(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }
        private List<List<string>> getAllStudent(string MANV)
        {
            List<List<string>> students = new List<List<string>>();
            //students.Add(new List<string>() { "SV01", "NGUYEN VAN A", "VAT LY LUONG TU", "" });
            //students.Add(new List<string>() { "SV02", "NGUYEN VAN B", "VAT LY LUONG TU", "" });
            //students.Add(new List<string>() { "SV03", "NGUYEN VAN C", "VAT LY LUONG TU", "" });
            SqlCommand command = new SqlCommand("EXEC SP_UV_SV_LOP '" + MANV, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(new List<string>() { reader["MASV"].ToString(), reader["HOTEN"].ToString(),
                        reader["NGAYSINH"].ToString(),reader["DIACHI"].ToString()});
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return students;
        }
        // sang man hinh huy
        private void gotoScorreInput()
        {
            Home.DisplayMember(Home.MANAGE_SOCREINPUT_ID);
        }
        //sang man hinh phuc
        private void gotoManageClass()
        {
            Home.DisplayMember(Home.MANAGE_CLASS_ID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gotoManageClass();
        }
        public void refresh()
        {
            //xoa du lieu va tao lai 
            MessageBox.Show("refresh from form Manage Student");
            username = "NV01";
            allStudents = getAllStudent(username);
            groupBox1.Visible = false;
            listView1.Items.Clear();
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
                listView1.Items.Add(item);
            }
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            LopLabel.Text = "MASV: " + username;
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MALOP FROM LOP WHERE MANV = " + username;
            cmd.Connection = connection;
            connection.Open();
            SqlDataReader reader= cmd.ExecuteReader();
            string gv = "";
            while (reader.Read())
            {
                gv = reader["MAGV"].ToString();
            }
            gvLabel.Text = "Mã giáo viên: " + gv;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            gotoManageClass();
        }

        private void svPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(masvLabel.Text)) || string.IsNullOrEmpty(hotenLabel.Text) || string.IsNullOrEmpty(ngaysinhLabel.Text) || string.IsNullOrEmpty(diachiLabel.Text)) {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            } else
            {
                string MASV = "SV01";
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "EXEC SP_UDP_SV";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MASV", MASV));
                cmd.Parameters.Add(new SqlParameter("@HOTEN", hotenLabel.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", ngaysinhLabel.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", diachiLabel.Text));

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfully!");
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
