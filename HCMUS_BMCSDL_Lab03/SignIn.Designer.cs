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
            this.labelForm = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_exitSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = false;
            this.labelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForm.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.ForeColor = System.Drawing.Color.White;
            this.labelForm.Location = new System.Drawing.Point(143, 70);
            this.labelForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(160, 45);
            this.labelForm.TabIndex = 0;
            this.labelForm.Text = "SIGN IN";
            this.labelForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = false;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(45, 143);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 20);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = false;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(50, 193);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // textboxUsername
            // 
            this.textboxUsername.AutoSize = false;
            this.textboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.ForeColor = System.Drawing.Color.Black;
            this.textboxUsername.Location = new System.Drawing.Point(135, 140);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(225, 30);
            this.textboxUsername.TabIndex = 2;
            this.textboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxPassword
            // 
            this.textboxPassword.AutoSize = false;
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.ForeColor = System.Drawing.Color.Black;
            this.textboxPassword.Location = new System.Drawing.Point(135, 190);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(225, 30);
            this.textboxPassword.TabIndex = 3;
            this.textboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_signin
            // 
            this.btn_signin.AutoSize = false;
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.Color.Black;
            this.btn_signin.Location = new System.Drawing.Point(135, 235);
            this.btn_signin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(90, 35);
            this.btn_signin.TabIndex = 4;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // btn_exitSignIn
            // 
            this.btn_exitSignIn.AutoSize = false;
            this.btn_exitSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitSignIn.ForeColor = System.Drawing.Color.Black;
            this.btn_exitSignIn.Location = new System.Drawing.Point(275, 235);
            this.btn_exitSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exitSignIn.Name = "btn_exitSignIn";
            this.btn_exitSignIn.Size = new System.Drawing.Size(80, 35);
            this.btn_exitSignIn.TabIndex = 5;
            this.btn_exitSignIn.Text = "Exit";
            this.btn_exitSignIn.UseVisualStyleBackColor = true;
            this.btn_exitSignIn.Click += new System.EventHandler(this.btn_exitSignIn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(430, 366);
            this.Controls.Add(this.btn_exitSignIn);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_exitSignIn;
    }
}