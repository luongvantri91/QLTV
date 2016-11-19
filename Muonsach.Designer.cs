namespace QLTV
{
    partial class Muonsach
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
            this.hinhthuc = new System.Windows.Forms.Label();
            this.manvlv = new System.Windows.Forms.Label();
            this.madg = new System.Windows.Forms.Label();
            this.txtngaymuon = new System.Windows.Forms.TextBox();
            this.ngaymuon = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mangve = new System.Windows.Forms.RadioButton();
            this.taicho = new System.Windows.Forms.RadioButton();
            this.combomanv = new System.Windows.Forms.ComboBox();
            this.combomadg = new System.Windows.Forms.ComboBox();
            this.ctpm = new System.Windows.Forms.Button();
            this.ms = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.maphieu = new System.Windows.Forms.Label();
            this.dspm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dspm)).BeginInit();
            this.SuspendLayout();
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(332, 201);
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
            this.luu.Location = new System.Drawing.Point(218, 201);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(83, 27);
            this.luu.TabIndex = 2;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.button3_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(110, 201);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(83, 27);
            this.sua.TabIndex = 2;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(10, 201);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(83, 27);
            this.them.TabIndex = 2;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // hinhthuc
            // 
            this.hinhthuc.AutoSize = true;
            this.hinhthuc.Location = new System.Drawing.Point(246, 51);
            this.hinhthuc.Name = "hinhthuc";
            this.hinhthuc.Size = new System.Drawing.Size(56, 14);
            this.hinhthuc.TabIndex = 0;
            this.hinhthuc.Text = "Hình Thức";
            // 
            // manvlv
            // 
            this.manvlv.AutoSize = true;
            this.manvlv.Location = new System.Drawing.Point(7, 130);
            this.manvlv.Name = "manvlv";
            this.manvlv.Size = new System.Drawing.Size(39, 14);
            this.manvlv.TabIndex = 0;
            this.manvlv.Text = "Mã NV";
            // 
            // madg
            // 
            this.madg.AutoSize = true;
            this.madg.Location = new System.Drawing.Point(7, 89);
            this.madg.Name = "madg";
            this.madg.Size = new System.Drawing.Size(40, 14);
            this.madg.TabIndex = 0;
            this.madg.Text = "Mã ĐG";
            // 
            // txtngaymuon
            // 
            this.txtngaymuon.Enabled = false;
            this.txtngaymuon.Location = new System.Drawing.Point(302, 87);
            this.txtngaymuon.Name = "txtngaymuon";
            this.txtngaymuon.Size = new System.Drawing.Size(130, 20);
            this.txtngaymuon.TabIndex = 1;
            // 
            // ngaymuon
            // 
            this.ngaymuon.AutoSize = true;
            this.ngaymuon.Location = new System.Drawing.Point(238, 87);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(63, 14);
            this.ngaymuon.TabIndex = 0;
            this.ngaymuon.Text = "Ngày Mượn";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Enabled = false;
            this.txtmaphieu.Location = new System.Drawing.Point(63, 47);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(130, 20);
            this.txtmaphieu.TabIndex = 1;
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
            this.splitContainer1.Panel1.Controls.Add(this.mangve);
            this.splitContainer1.Panel1.Controls.Add(this.taicho);
            this.splitContainer1.Panel1.Controls.Add(this.combomanv);
            this.splitContainer1.Panel1.Controls.Add(this.combomadg);
            this.splitContainer1.Panel1.Controls.Add(this.ctpm);
            this.splitContainer1.Panel1.Controls.Add(this.ms);
            this.splitContainer1.Panel1.Controls.Add(this.thoat);
            this.splitContainer1.Panel1.Controls.Add(this.xoa);
            this.splitContainer1.Panel1.Controls.Add(this.luu);
            this.splitContainer1.Panel1.Controls.Add(this.sua);
            this.splitContainer1.Panel1.Controls.Add(this.them);
            this.splitContainer1.Panel1.Controls.Add(this.hinhthuc);
            this.splitContainer1.Panel1.Controls.Add(this.manvlv);
            this.splitContainer1.Panel1.Controls.Add(this.madg);
            this.splitContainer1.Panel1.Controls.Add(this.txtngaymuon);
            this.splitContainer1.Panel1.Controls.Add(this.ngaymuon);
            this.splitContainer1.Panel1.Controls.Add(this.txtmaphieu);
            this.splitContainer1.Panel1.Controls.Add(this.maphieu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dspm);
            this.splitContainer1.Size = new System.Drawing.Size(826, 446);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 3;
            // 
            // mangve
            // 
            this.mangve.AutoSize = true;
            this.mangve.Location = new System.Drawing.Point(387, 46);
            this.mangve.Name = "mangve";
            this.mangve.Size = new System.Drawing.Size(68, 18);
            this.mangve.TabIndex = 10;
            this.mangve.TabStop = true;
            this.mangve.Text = "Mang Về";
            this.mangve.UseVisualStyleBackColor = true;
            this.mangve.CheckedChanged += new System.EventHandler(this.taicho_CheckedChanged);
            // 
            // taicho
            // 
            this.taicho.AutoSize = true;
            this.taicho.Location = new System.Drawing.Point(320, 46);
            this.taicho.Name = "taicho";
            this.taicho.Size = new System.Drawing.Size(61, 18);
            this.taicho.TabIndex = 10;
            this.taicho.TabStop = true;
            this.taicho.Text = "Tại Chỗ";
            this.taicho.UseVisualStyleBackColor = true;
            this.taicho.CheckedChanged += new System.EventHandler(this.taicho_CheckedChanged);
            // 
            // combomanv
            // 
            this.combomanv.Enabled = false;
            this.combomanv.FormattingEnabled = true;
            this.combomanv.Location = new System.Drawing.Point(62, 128);
            this.combomanv.Name = "combomanv";
            this.combomanv.Size = new System.Drawing.Size(131, 22);
            this.combomanv.TabIndex = 9;
            // 
            // combomadg
            // 
            this.combomadg.Enabled = false;
            this.combomadg.FormattingEnabled = true;
            this.combomadg.Location = new System.Drawing.Point(63, 83);
            this.combomadg.Name = "combomadg";
            this.combomadg.Size = new System.Drawing.Size(130, 22);
            this.combomadg.TabIndex = 8;
            // 
            // ctpm
            // 
            this.ctpm.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctpm.Location = new System.Drawing.Point(561, 27);
            this.ctpm.Name = "ctpm";
            this.ctpm.Size = new System.Drawing.Size(211, 40);
            this.ctpm.TabIndex = 2;
            this.ctpm.Text = "Chi Tiết TPhiếu Mượn";
            this.ctpm.UseVisualStyleBackColor = true;
            this.ctpm.Click += new System.EventHandler(this.ctpm_Click);
            // 
            // ms
            // 
            this.ms.Location = new System.Drawing.Point(561, 89);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(211, 40);
            this.ms.TabIndex = 2;
            this.ms.Text = "Mượn Sách";
            this.ms.UseVisualStyleBackColor = true;
            this.ms.Click += new System.EventHandler(this.ms_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(446, 201);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(83, 27);
            this.thoat.TabIndex = 2;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // maphieu
            // 
            this.maphieu.AutoSize = true;
            this.maphieu.Location = new System.Drawing.Point(7, 49);
            this.maphieu.Name = "maphieu";
            this.maphieu.Size = new System.Drawing.Size(50, 14);
            this.maphieu.TabIndex = 0;
            this.maphieu.Text = "Mã Phiếu";
            // 
            // dspm
            // 
            this.dspm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dspm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dspm.Location = new System.Drawing.Point(0, 0);
            this.dspm.Name = "dspm";
            this.dspm.Size = new System.Drawing.Size(826, 196);
            this.dspm.TabIndex = 0;
            this.dspm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dspm_CellClick);
            // 
            // Muonsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 446);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Muonsach";
            this.Text = "Muonsach";
            this.Load += new System.EventHandler(this.Muonsach_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dspm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Label hinhthuc;
        private System.Windows.Forms.Label manvlv;
        private System.Windows.Forms.Label madg;
        private System.Windows.Forms.TextBox txtngaymuon;
        private System.Windows.Forms.Label ngaymuon;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label maphieu;
        private System.Windows.Forms.Button ctpm;
        private System.Windows.Forms.DataGridView dspm;
        private System.Windows.Forms.ComboBox combomanv;
        private System.Windows.Forms.ComboBox combomadg;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.RadioButton taicho;
        private System.Windows.Forms.RadioButton mangve;
        private System.Windows.Forms.Button ms;
    }
}