namespace QLTV
{
    partial class Nhanvien
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
            this.xoa = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.diachinv = new System.Windows.Forms.Label();
            this.gioitinh = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.thoat = new System.Windows.Forms.Button();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.tennv = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txthonv = new System.Windows.Forms.TextBox();
            this.emailnv = new System.Windows.Forms.Label();
            this.honv = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.dienthoainv = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.manv = new System.Windows.Forms.Label();
            this.dsnv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).BeginInit();
            this.SuspendLayout();
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(371, 210);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(83, 27);
            this.xoa.TabIndex = 2;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // luu
            // 
            this.luu.Enabled = false;
            this.luu.Location = new System.Drawing.Point(249, 210);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(83, 27);
            this.luu.TabIndex = 2;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(130, 210);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(83, 27);
            this.sua.TabIndex = 2;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(10, 210);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(83, 27);
            this.them.TabIndex = 2;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Enabled = false;
            this.txtdiachi.Location = new System.Drawing.Point(302, 49);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(130, 20);
            this.txtdiachi.TabIndex = 1;
            // 
            // diachinv
            // 
            this.diachinv.AutoSize = true;
            this.diachinv.Location = new System.Drawing.Point(246, 51);
            this.diachinv.Name = "diachinv";
            this.diachinv.Size = new System.Drawing.Size(41, 14);
            this.diachinv.TabIndex = 0;
            this.diachinv.Text = "Địa Chỉ";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSize = true;
            this.gioitinh.Location = new System.Drawing.Point(7, 173);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(49, 14);
            this.gioitinh.TabIndex = 0;
            this.gioitinh.Text = "Giới Tính";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nu);
            this.splitContainer1.Panel1.Controls.Add(this.nam);
            this.splitContainer1.Panel1.Controls.Add(this.thoat);
            this.splitContainer1.Panel1.Controls.Add(this.xoa);
            this.splitContainer1.Panel1.Controls.Add(this.luu);
            this.splitContainer1.Panel1.Controls.Add(this.sua);
            this.splitContainer1.Panel1.Controls.Add(this.them);
            this.splitContainer1.Panel1.Controls.Add(this.txtdiachi);
            this.splitContainer1.Panel1.Controls.Add(this.diachinv);
            this.splitContainer1.Panel1.Controls.Add(this.gioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.txttennv);
            this.splitContainer1.Panel1.Controls.Add(this.tennv);
            this.splitContainer1.Panel1.Controls.Add(this.txtemail);
            this.splitContainer1.Panel1.Controls.Add(this.txthonv);
            this.splitContainer1.Panel1.Controls.Add(this.emailnv);
            this.splitContainer1.Panel1.Controls.Add(this.honv);
            this.splitContainer1.Panel1.Controls.Add(this.txtdienthoai);
            this.splitContainer1.Panel1.Controls.Add(this.dienthoainv);
            this.splitContainer1.Panel1.Controls.Add(this.txtmanv);
            this.splitContainer1.Panel1.Controls.Add(this.manv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dsnv);
            this.splitContainer1.Size = new System.Drawing.Size(826, 440);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 2;
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Enabled = false;
            this.nu.Location = new System.Drawing.Point(130, 169);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(39, 18);
            this.nu.TabIndex = 3;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Enabled = false;
            this.nam.Location = new System.Drawing.Point(66, 168);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(46, 18);
            this.nam.TabIndex = 3;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(502, 210);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(83, 27);
            this.thoat.TabIndex = 2;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // txttennv
            // 
            this.txttennv.Enabled = false;
            this.txttennv.Location = new System.Drawing.Point(63, 128);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(130, 20);
            this.txttennv.TabIndex = 1;
            // 
            // tennv
            // 
            this.tennv.AutoSize = true;
            this.tennv.Location = new System.Drawing.Point(7, 130);
            this.tennv.Name = "tennv";
            this.tennv.Size = new System.Drawing.Size(43, 14);
            this.tennv.TabIndex = 0;
            this.tennv.Text = "Tên NV";
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(302, 124);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(130, 20);
            this.txtemail.TabIndex = 1;
            // 
            // txthonv
            // 
            this.txthonv.Enabled = false;
            this.txthonv.Location = new System.Drawing.Point(63, 87);
            this.txthonv.Name = "txthonv";
            this.txthonv.Size = new System.Drawing.Size(130, 20);
            this.txthonv.TabIndex = 1;
            // 
            // emailnv
            // 
            this.emailnv.AutoSize = true;
            this.emailnv.Location = new System.Drawing.Point(246, 128);
            this.emailnv.Name = "emailnv";
            this.emailnv.Size = new System.Drawing.Size(31, 14);
            this.emailnv.TabIndex = 0;
            this.emailnv.Text = "Email";
            // 
            // honv
            // 
            this.honv.AutoSize = true;
            this.honv.Location = new System.Drawing.Point(7, 89);
            this.honv.Name = "honv";
            this.honv.Size = new System.Drawing.Size(38, 14);
            this.honv.TabIndex = 0;
            this.honv.Text = "Họ NV";
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Enabled = false;
            this.txtdienthoai.Location = new System.Drawing.Point(302, 87);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(130, 20);
            this.txtdienthoai.TabIndex = 1;
            // 
            // dienthoainv
            // 
            this.dienthoainv.AutoSize = true;
            this.dienthoainv.Location = new System.Drawing.Point(238, 87);
            this.dienthoainv.Name = "dienthoainv";
            this.dienthoainv.Size = new System.Drawing.Size(58, 14);
            this.dienthoainv.TabIndex = 0;
            this.dienthoainv.Text = "Điện Thoại";
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(63, 47);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(130, 20);
            this.txtmanv.TabIndex = 1;
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Location = new System.Drawing.Point(7, 49);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(39, 14);
            this.manv.TabIndex = 0;
            this.manv.Text = "Mã NV";
            // 
            // dsnv
            // 
            this.dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsnv.Location = new System.Drawing.Point(0, 0);
            this.dsnv.Name = "dsnv";
            this.dsnv.Size = new System.Drawing.Size(826, 193);
            this.dsnv.TabIndex = 0;
            this.dsnv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsnv_CellClick);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 440);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label diachinv;
        private System.Windows.Forms.Label gioitinh;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label tennv;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txthonv;
        private System.Windows.Forms.Label emailnv;
        private System.Windows.Forms.Label honv;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label dienthoainv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label manv;
        private System.Windows.Forms.DataGridView dsnv;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.Button thoat;
    }
}