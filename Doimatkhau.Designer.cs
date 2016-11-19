namespace QLTV
{
    partial class Doimatkhau
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Cpass = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtnpass = new System.Windows.Forms.TextBox();
            this.txtcfpass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(32, 30);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(60, 14);
            this.username.TabIndex = 0;
            this.username.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(32, 71);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(57, 14);
            this.password.TabIndex = 0;
            this.password.Text = "Password";
            // 
            // Cpass
            // 
            this.Cpass.AutoSize = true;
            this.Cpass.Location = new System.Drawing.Point(32, 151);
            this.Cpass.Name = "Cpass";
            this.Cpass.Size = new System.Drawing.Size(97, 14);
            this.Cpass.TabIndex = 0;
            this.Cpass.Text = "Confirm Password";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(146, 27);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(132, 20);
            this.txtuser.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(146, 71);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(132, 20);
            this.txtpass.TabIndex = 1;
            // 
            // txtnpass
            // 
            this.txtnpass.Location = new System.Drawing.Point(146, 109);
            this.txtnpass.Name = "txtnpass";
            this.txtnpass.Size = new System.Drawing.Size(132, 20);
            this.txtnpass.TabIndex = 1;
            // 
            // txtcfpass
            // 
            this.txtcfpass.Location = new System.Drawing.Point(146, 148);
            this.txtcfpass.Name = "txtcfpass";
            this.txtcfpass.Size = new System.Drawing.Size(132, 20);
            this.txtcfpass.TabIndex = 1;
            // 
            // newpass
            // 
            this.newpass.AutoSize = true;
            this.newpass.Location = new System.Drawing.Point(32, 112);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(83, 14);
            this.newpass.TabIndex = 0;
            this.newpass.Text = "New Password";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(150, 201);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 31);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(270, 201);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 31);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // Doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 262);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.txtcfpass);
            this.Controls.Add(this.txtnpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.Cpass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Doimatkhau";
            this.Text = "Doimatkhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Cpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtnpass;
        private System.Windows.Forms.TextBox txtcfpass;
        private System.Windows.Forms.Label newpass;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}