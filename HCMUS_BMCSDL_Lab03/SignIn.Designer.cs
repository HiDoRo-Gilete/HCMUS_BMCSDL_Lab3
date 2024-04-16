namespace HCMUS_BMCSDL_Lab03
{
    partial class SignIn
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
            this.btn_signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.Aqua;
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.Color.Black;
            this.btn_signin.Location = new System.Drawing.Point(206, 353);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(112, 47);
            this.btn_signin.TabIndex = 26;
            this.btn_signin.Text = "Sign in";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            this.btn_signin.MouseLeave += new System.EventHandler(this.btn_signin_MouseLeave);
            this.btn_signin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_signin_MouseMove);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.btn_signin);
            this.Name = "SignIn";
            this.Text = "Sign in";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_signin;
    }
}

