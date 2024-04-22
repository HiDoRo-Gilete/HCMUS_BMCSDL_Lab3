namespace HCMUS_BMCSDL_Lab03
{
    partial class ManageStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MASV = new System.Windows.Forms.Label();
            this.lv_student = new System.Windows.Forms.ListView();
            this.gb_edit = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.gb_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Aqua;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_back.Location = new System.Drawing.Point(28, 18);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(93, 45);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(715, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Input score";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_name
            // 
            this.lb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_name.ForeColor = System.Drawing.Color.Aqua;
            this.lb_name.Location = new System.Drawing.Point(233, 18);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(405, 59);
            this.lb_name.TabIndex = 7;
            this.lb_name.Text = "Lớp: Cơ Học Lượng Tử";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MASV);
            this.panel1.Location = new System.Drawing.Point(28, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 61);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(513, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 57);
            this.label3.TabIndex = 3;
            this.label3.Text = "ĐỊA CHỈ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(323, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "NGÀY SINH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỌ TÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MASV
            // 
            this.MASV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MASV.Dock = System.Windows.Forms.DockStyle.Left;
            this.MASV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MASV.ForeColor = System.Drawing.Color.Aqua;
            this.MASV.Location = new System.Drawing.Point(0, 0);
            this.MASV.Name = "MASV";
            this.MASV.Size = new System.Drawing.Size(120, 57);
            this.MASV.TabIndex = 0;
            this.MASV.Text = "MASV";
            this.MASV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lv_student
            // 
            this.lv_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lv_student.FullRowSelect = true;
            this.lv_student.GridLines = true;
            this.lv_student.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_student.HideSelection = false;
            this.lv_student.Location = new System.Drawing.Point(28, 326);
            this.lv_student.Name = "lv_student";
            this.lv_student.Size = new System.Drawing.Size(826, 259);
            this.lv_student.TabIndex = 8;
            this.lv_student.UseCompatibleStateImageBehavior = false;
            this.lv_student.View = System.Windows.Forms.View.Details;
            this.lv_student.SelectedIndexChanged += new System.EventHandler(this.lv_student_SelectedIndexChanged);
            // 
            // gb_edit
            // 
            this.gb_edit.Controls.Add(this.dtp1);
            this.gb_edit.Controls.Add(this.label5);
            this.gb_edit.Controls.Add(this.label4);
            this.gb_edit.Controls.Add(this.label6);
            this.gb_edit.Controls.Add(this.button2);
            this.gb_edit.Controls.Add(this.tb_addr);
            this.gb_edit.Controls.Add(this.tb_name);
            this.gb_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_edit.ForeColor = System.Drawing.Color.Aqua;
            this.gb_edit.Location = new System.Drawing.Point(30, 102);
            this.gb_edit.Name = "gb_edit";
            this.gb_edit.Size = new System.Drawing.Size(818, 136);
            this.gb_edit.TabIndex = 10;
            this.gb_edit.TabStop = false;
            this.gb_edit.Text = "Sinh viên: SV01";
            this.gb_edit.Visible = false;
            // 
            // tb_name
            // 
            this.tb_name.CausesValidation = false;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_name.Location = new System.Drawing.Point(151, 41);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(206, 26);
            this.tb_name.TabIndex = 11;
            this.tb_name.TabStop = false;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_addr
            // 
            this.tb_addr.CausesValidation = false;
            this.tb_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_addr.Location = new System.Drawing.Point(586, 39);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(206, 26);
            this.tb_addr.TabIndex = 13;
            this.tb_addr.TabStop = false;
            this.tb_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(699, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "Họ tên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(452, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 41);
            this.label4.TabIndex = 15;
            this.label4.Text = "Địa chỉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 41);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày Sinh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp1
            // 
            this.dtp1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtp1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtp1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtp1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtp1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp1.Location = new System.Drawing.Point(151, 86);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(350, 30);
            this.dtp1.TabIndex = 17;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.gb_edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lv_student);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_back);
            this.Name = "ManageStudent";
            this.Size = new System.Drawing.Size(882, 628);
            this.panel1.ResumeLayout(false);
            this.gb_edit.ResumeLayout(false);
            this.gb_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MASV;
        private System.Windows.Forms.ListView lv_student;
        private System.Windows.Forms.GroupBox gb_edit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}