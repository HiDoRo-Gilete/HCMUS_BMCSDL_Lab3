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
        public static string malop;
        SqlConnection connection;
        public ManageClass(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }
        public void gotoManageStudent()
        {
            Home.DisplayMember(Home.MANAGE_STUDENT_ID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gotoManageStudent();
        }
    }
}
