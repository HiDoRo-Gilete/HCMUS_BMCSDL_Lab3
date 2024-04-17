﻿using System;
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
    public partial class Home : Form
    {
        public static int MANAGE_CLASS_ID = 0;
        public static int MANAGE_STUDENT_ID = 1;
        public static int MANAGE_SOCREINPUT_ID = 2;
        private static List<UserControl> userControls;
        public Home()
        {
            InitializeComponent();
            InitializeMyComponent();
        }
        private void InitializeMyComponent()
        {
            userControls = new List<UserControl>() { new ManageClass(),new ManageStudent(),new ScoreInput()};
            for(int i = 0; i < userControls.Count; i++)
            {
                userControls[i].Dock = DockStyle.Fill;
                container.Controls.Add(userControls[i]);
            }
            DisplayMember(0); //how to use:  DisplayMember(Home.MANAGE_CLASS_ID)
        }
        public static void DisplayMember(int id)
        {
            if (id < userControls.Count)
            {
                userControls[id].BringToFront();
                if(id == MANAGE_STUDENT_ID)
                {
                    ManageStudent ms = userControls[id] as ManageStudent;
                    ms.refresh();
                }
                else if (id == MANAGE_SOCREINPUT_ID)
                {
                    ScoreInput si = userControls[id] as ScoreInput;
                    si.refresh();
                }
            }
            
        }

    }
}