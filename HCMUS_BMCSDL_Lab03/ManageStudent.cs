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
using Microsoft.IdentityModel.Tokens;

namespace HCMUS_BMCSDL_Lab03
{
    public partial class ManageStudent : UserControl
    {
        SqlConnection connection;
        private int typeUser;
        private string MALOP;
        private List<List<string>> students;
        private string username;
        public ManageStudent(SqlConnection connection,int typeUser, string username)
        {
            InitializeComponent();
            this.typeUser = typeUser;
            this.connection = connection;
            students = new List<List<string>>();
            lv_student.Columns.Add("MASV").Width = 90;
            lv_student.Columns.Add("HOTEN").Width = 152;
            lv_student.Columns.Add("NGAY SINH").Width = 145;
            lv_student.Columns.Add("DIACHI").Width = 227;
            lv_student.Font = new System.Drawing.Font("Microsoft Sans Serif",
                10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.username = username;
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
        private void getAllStudent()
        {
            students.Clear();
            SqlCommand command = new SqlCommand("EXEC SP_UV_SV_LOP '" + MALOP + "'", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    List<string> student = new List<string>() { reader["MASV"].ToString(), reader["HOTEN"].ToString(),
                        reader["NGAYSINH"].ToString(),reader["DIACHI"].ToString(),reader["MANV"].ToString() };
                    students.Add(student);

                    string birth = student[2].Substring(0, student[2].IndexOf(' '));
                    string[] dt = birth.Split('/');
                    student[2] = dt[1] + "/" + dt[0] + "/" + dt[2];
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
        }
        private void getViewForStudent()
        {
            lv_student.Items.Clear();
            foreach (List<string> student in students)
            {
                ListViewItem item = new ListViewItem();
                item.Text = student[0];
                item.ForeColor = System.Drawing.Color.Aqua;
                item.Font = new System.Drawing.Font("Microsoft Sans Serif",
                    10F, System.Drawing.FontStyle.Regular, System.Drawing.
                    GraphicsUnit.Point, ((byte)(163)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = student[1] });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = student[2] });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = student[3] });
                lv_student.Items.Add(item);
            }
        }
        public void refresh()
        {
            //xoa du lieu va tao lai 
            gb_edit.Visible = false;
            MALOP = ManageClass.malop;
            lb_name.Text = "LỚP: " + ManageClass.tenlop;
            getAllStudent();
            if(students.Count > 0 && students[0][4].Equals(username))
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
            getViewForStudent();
            //MessageBox.Show("refresh from form Manage Student");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            gotoManageClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gotoScorreInput();
        }

        private void lv_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_student.SelectedItems.Count>0)
            {
                ListViewItem item = lv_student.SelectedItems[0];
                if (students[0][4].Equals(username))
                {
                    gb_edit.Visible = true;
                    tb_name.Text = item.SubItems[1].Text;
                    tb_addr.Text = item.SubItems[3].Text;
                    string birth = item.SubItems[2].Text;
                    string [] dt = birth.Split('/');
                    dtp1.Value = new DateTime(int.Parse(dt[2]), int.Parse(dt[1]), int.Parse(dt[0]));
                }
                else
                {
                    MessageBox.Show("Không thể chỉnh sửa trên lớp học của giáo viên khác!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string masv = lv_student.SelectedItems[0].Text;
            string name = tb_name.Text;
            string addr = tb_addr.Text;
            string birth = dtp1.Value.Date.ToString();
            birth = birth.Substring(0, birth.IndexOf(' '));
            if(name.IsNullOrEmpty() || addr.IsNullOrEmpty())
            {
                MessageBox.Show("Họ tên hoặc địa chỉ không được để trống!");
            }
            else
            {
                SqlCommand command = new SqlCommand("EXEC SP_UPD_SV '" + masv + "','" + name +
                    "','" + birth + "','" + addr + "'", connection);
                
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật thông tin sinh viên thành công");
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
        }
    }
}
