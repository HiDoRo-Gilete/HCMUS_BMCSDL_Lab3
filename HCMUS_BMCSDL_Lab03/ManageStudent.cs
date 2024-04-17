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
    public partial class ManageStudent : UserControl
    {
        public ManageStudent()
        {
            InitializeComponent();
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
        }
    }
}
