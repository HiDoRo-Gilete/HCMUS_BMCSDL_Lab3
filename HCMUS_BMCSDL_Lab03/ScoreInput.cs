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
    public partial class ScoreInput : UserControl
    {
        public ScoreInput()
        {
            InitializeComponent();
        }
        private void gotoManageStudent()
        {
            Home.DisplayMember(Home.MANAGE_STUDENT_ID);
        }
        public void refresh()
        {
            
        }
    }
}
