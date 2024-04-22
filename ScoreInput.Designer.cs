namespace HCMUS_BMCSDL_Lab03
{
    partial class ScoreInput
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
            this.lv_score = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MASV = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_msv = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_score
            // 
            this.lv_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lv_score.FullRowSelect = true;
            this.lv_score.GridLines = true;
            this.lv_score.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_score.HideSelection = false;
            this.lv_score.Location = new System.Drawing.Point(85, 241);
            this.lv_score.Name = "lv_score";
            this.lv_score.Size = new System.Drawing.Size(700, 339);
            this.lv_score.TabIndex = 0;
            this.lv_score.UseCompatibleStateImageBehavior = false;
            this.lv_score.View = System.Windows.Forms.View.Details;
            this.lv_score.SelectedIndexChanged += new System.EventHandler(this.lv_score_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MASV);
            this.panel1.Location = new System.Drawing.Point(85, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 56);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(580, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = "ĐIỂM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(350, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "HỌC PHẦN";
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
            this.label1.Size = new System.Drawing.Size(230, 52);
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
            this.MASV.Size = new System.Drawing.Size(120, 52);
            this.MASV.TabIndex = 0;
            this.MASV.Text = "MASV";
            this.MASV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MASV.Click += new System.EventHandler(this.MASV_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Aqua;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_back.Location = new System.Drawing.Point(18, 23);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(93, 45);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseLeave += new System.EventHandler(this.btn_back_MouseLeave);
            this.btn_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_back_MouseMove);
            // 
            // tb_score
            // 
            this.tb_score.CausesValidation = false;
            this.tb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_score.Location = new System.Drawing.Point(313, 93);
            this.tb_score.Name = "tb_score";
            this.tb_score.Size = new System.Drawing.Size(206, 26);
            this.tb_score.TabIndex = 3;
            this.tb_score.TabStop = false;
            this.tb_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_score.TextChanged += new System.EventHandler(this.tb_score_TextChanged);
            this.tb_score.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_score_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.lb_msv);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_score);
            this.groupBox1.Location = new System.Drawing.Point(249, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Aqua;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_save.Location = new System.Drawing.Point(435, 18);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 49);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_msv
            // 
            this.lb_msv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_msv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_msv.ForeColor = System.Drawing.Color.Aqua;
            this.lb_msv.Location = new System.Drawing.Point(15, 18);
            this.lb_msv.Name = "lb_msv";
            this.lb_msv.Size = new System.Drawing.Size(277, 52);
            this.lb_msv.TabIndex = 7;
            this.lb_msv.Text = "Mã SV: SV01";
            this.lb_msv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_name
            // 
            this.lb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_name.ForeColor = System.Drawing.Color.Aqua;
            this.lb_name.Location = new System.Drawing.Point(15, 78);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(277, 52);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Họ tên: Nguyen Van A";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(313, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 52);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhập điểm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScoreInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lv_score);
            this.Name = "ScoreInput";
            this.Size = new System.Drawing.Size(882, 628);
            this.Load += new System.EventHandler(this.ScoreInput_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MASV;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_msv;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label5;
    }
}