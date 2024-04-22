
namespace HCMUS_BMCSDL_Lab03
{
    partial class ManageClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_inf = new System.Windows.Forms.GroupBox();
            this.dtg_class = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grb_inf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_class)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Location = new System.Drawing.Point(262, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(361, 46);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "DANH SÁCH LỚP";
            // 
            // grb_inf
            // 
            this.grb_inf.Controls.Add(this.dtg_class);
            this.grb_inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_inf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grb_inf.Location = new System.Drawing.Point(19, 93);
            this.grb_inf.Name = "grb_inf";
            this.grb_inf.Size = new System.Drawing.Size(842, 511);
            this.grb_inf.TabIndex = 2;
            this.grb_inf.TabStop = false;
            this.grb_inf.Text = "Thông tin chi tiết";
            // 
            // dtg_class
            // 
            this.dtg_class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_class.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtg_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtg_class.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtg_class.Location = new System.Drawing.Point(20, 26);
            this.dtg_class.MultiSelect = false;
            this.dtg_class.Name = "dtg_class";
            this.dtg_class.ReadOnly = true;
            this.dtg_class.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_class.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_class.RowTemplate.Height = 24;
            this.dtg_class.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_class.Size = new System.Drawing.Size(803, 467);
            this.dtg_class.TabIndex = 0;
            this.dtg_class.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_class_CellContentDoubleClick);
            // 
            // ManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.grb_inf);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ManageClass";
            this.Size = new System.Drawing.Size(882, 628);
            this.Load += new System.EventHandler(this.ManageClass_Load);
            this.grb_inf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_inf;
        private System.Windows.Forms.DataGridView dtg_class;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
