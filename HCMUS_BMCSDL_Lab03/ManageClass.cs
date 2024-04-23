using Microsoft.Data.SqlClient;
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
    public partial class ManageClass : UserControl
    {

        public bool isconnect = false;
        public static string malop;
        public static string tenlop;
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public ManageClass(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }
        public void gotoManageStudent()
        {
            Home.DisplayMember(Home.MANAGE_STUDENT_ID);
        }

        private void LoadData()
        {
            cmd = new SqlCommand("EXEC SP_SEL_PUBLIC_LOP", connection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            dtg_class.DataSource = table;
        }

        private void ManageClass_Load(object sender, EventArgs e)
        {
            connection.Open();
            LoadData();
            connection.Close();
        }

        private void dtg_class_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if( Home.typeUser == Home.Nhanvien)
            {
                malop = this.dtg_class.CurrentRow.Cells[0].Value.ToString();
                tenlop = this.dtg_class.CurrentRow.Cells[1].Value.ToString();
                gotoManageStudent();
            }
            
        }
    }
}