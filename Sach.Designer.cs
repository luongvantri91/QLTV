namespace QLTV
{
    partial class sach
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.damuon = new System.Windows.Forms.CheckBox();
            this.moi = new System.Windows.Forms.CheckBox();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.chomuon = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.gia = new System.Windows.Forms.Label();
            this.txtsotrang = new System.Windows.Forms.TextBox();
            this.txtkhosach = new System.Windows.Forms.TextBox();
            this.tinhtrang = new System.Windows.Forms.Label();
            this.sotrang = new System.Windows.Forms.Label();
            this.khosach = new System.Windows.Forms.Label();
            this.txttheloai = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.theloai = new System.Windows.Forms.Label();
            this.tensach = new System.Windows.Forms.Label();
            this.txtngonngu = new System.Windows.Forms.TextBox();
            this.ngonngu = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.masach = new System.Windows.Forms.Label();
            this.dssach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dssach)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.damuon);
            this.splitContainer1.Panel1.Controls.Add(this.moi);
            this.splitContainer1.Panel1.Controls.Add(this.thoat);
            this.splitContainer1.Panel1.Controls.Add(this.xoa);
            this.splitContainer1.Panel1.Controls.Add(this.luu);
            this.splitContainer1.Panel1.Controls.Add(this.sua);
            this.splitContainer1.Panel1.Controls.Add(this.them);
            this.splitContainer1.Panel1.Controls.Add(this.chomuon);
            this.splitContainer1.Panel1.Controls.Add(this.txtgia);
            this.splitContainer1.Panel1.Controls.Add(this.gia);
            this.splitContainer1.Panel1.Controls.Add(this.txtsotrang);
            this.splitContainer1.Panel1.Controls.Add(this.txtkhosach);
            this.splitContainer1.Panel1.Controls.Add(this.tinhtrang);
            this.splitContainer1.Panel1.Controls.Add(this.sotrang);
            this.splitContainer1.Panel1.Controls.Add(this.khosach);
            this.splitContainer1.Panel1.Controls.Add(this.txttheloai);
            this.splitContainer1.Panel1.Controls.Add(this.txttensach);
            this.splitContainer1.Panel1.Controls.Add(this.theloai);
            this.splitContainer1.Panel1.Controls.Add(this.tensach);
            this.splitContainer1.Panel1.Controls.Add(this.txtngonngu);
            this.splitContainer1.Panel1.Controls.Add(this.ngonngu);
            this.splitContainer1.Panel1.Controls.Add(this.txtmasach);
            this.splitContainer1.Panel1.Controls.Add(this.masach);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dssach);
            this.splitContainer1.Size = new System.Drawing.Size(859, 444);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // damuon
            // 
            this.damuon.AutoSize = true;
            this.damuon.Enabled = false;
            this.damuon.Location = new System.Drawing.Point(564, 48);
            this.damuon.Name = "damuon";
            this.damuon.Size = new System.Drawing.Size(71, 18);
            this.damuon.TabIndex = 5;
            this.damuon.Text = "Đã Mượn";
            this.damuon.UseVisualStyleBackColor = true;
            // 
            // moi
            // 
            this.moi.AutoSize = true;
            this.moi.Enabled = false;
            this.moi.Location = new System.Drawing.Point(338, 166);
            this.moi.Name = "moi";
            this.moi.Size = new System.Drawing.Size(71, 18);
            this.moi.TabIndex = 4;
            this.moi.Text = "Sách Mới";
            this.moi.UseVisualStyleBackColor = true;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(483, 210);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(83, 27);
            this.thoat.TabIndex = 2;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(366, 210);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(83, 27);
            this.xoa.TabIndex = 2;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(242, 210);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(83, 27);
            this.luu.TabIndex = 2;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(125, 210);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(83, 27);
            this.sua.TabIndex = 2;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(8, 210);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(83, 27);
            this.them.TabIndex = 2;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click_1);
            // 
            // chomuon
            // 
            this.chomuon.AutoSize = true;
            this.chomuon.Location = new System.Drawing.Point(491, 49);
            this.chomuon.Name = "chomuon";
            this.chomuon.Size = new System.Drawing.Size(57, 14);
            this.chomuon.TabIndex = 0;
            this.chomuon.Text = "Cho Mượn";
            // 
            // txtgia
            // 
            this.txtgia.Enabled = false;
            this.txtgia.Location = new System.Drawing.Point(319, 45);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(130, 20);
            this.txtgia.TabIndex = 1;
            // 
            // gia
            // 
            this.gia.AutoSize = true;
            this.gia.Location = new System.Drawing.Point(263, 47);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(23, 14);
            this.gia.TabIndex = 0;
            this.gia.Text = "Giá";
            // 
            // txtsotrang
            // 
            this.txtsotrang.Enabled = false;
            this.txtsotrang.Location = new System.Drawing.Point(61, 171);
            this.txtsotrang.Name = "txtsotrang";
            this.txtsotrang.Size = new System.Drawing.Size(130, 20);
            this.txtsotrang.TabIndex = 1;
            // 
            // txtkhosach
            // 
            this.txtkhosach.Enabled = false;
            this.txtkhosach.Location = new System.Drawing.Point(63, 128);
            this.txtkhosach.Name = "txtkhosach";
            this.txtkhosach.Size = new System.Drawing.Size(130, 20);
            this.txtkhosach.TabIndex = 1;
            // 
            // tinhtrang
            // 
            this.tinhtrang.AutoSize = true;
            this.tinhtrang.Location = new System.Drawing.Point(253, 166);
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Size = new System.Drawing.Size(58, 14);
            this.tinhtrang.TabIndex = 0;
            this.tinhtrang.Text = "Tình Trạng";
            // 
            // sotrang
            // 
            this.sotrang.AutoSize = true;
            this.sotrang.Location = new System.Drawing.Point(5, 173);
            this.sotrang.Name = "sotrang";
            this.sotrang.Size = new System.Drawing.Size(51, 14);
            this.sotrang.TabIndex = 0;
            this.sotrang.Text = "Số Trang";
            // 
            // khosach
            // 
            this.khosach.AutoSize = true;
            this.khosach.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.khosach.Location = new System.Drawing.Point(7, 130);
            this.khosach.Name = "khosach";
            this.khosach.Size = new System.Drawing.Size(54, 14);
            this.khosach.TabIndex = 0;
            this.khosach.Text = "Khổ Sách";
            // 
            // txttheloai
            // 
            this.txttheloai.Enabled = false;
            this.txttheloai.Location = new System.Drawing.Point(319, 125);
            this.txttheloai.Name = "txttheloai";
            this.txttheloai.Size = new System.Drawing.Size(130, 20);
            this.txttheloai.TabIndex = 1;
            // 
            // txttensach
            // 
            this.txttensach.Enabled = false;
            this.txttensach.Location = new System.Drawing.Point(63, 87);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(130, 20);
            this.txttensach.TabIndex = 1;
            // 
            // theloai
            // 
            this.theloai.AutoSize = true;
            this.theloai.Location = new System.Drawing.Point(256, 128);
            this.theloai.Name = "theloai";
            this.theloai.Size = new System.Drawing.Size(48, 14);
            this.theloai.TabIndex = 0;
            this.theloai.Text = "Thể Loại";
            // 
            // tensach
            // 
            this.tensach.AutoSize = true;
            this.tensach.Location = new System.Drawing.Point(7, 89);
            this.tensach.Name = "tensach";
            this.tensach.Size = new System.Drawing.Size(53, 14);
            this.tensach.TabIndex = 0;
            this.tensach.Text = "Tên Sách";
            // 
            // txtngonngu
            // 
            this.txtngonngu.Enabled = false;
            this.txtngonngu.Location = new System.Drawing.Point(319, 85);
            this.txtngonngu.Name = "txtngonngu";
            this.txtngonngu.Size = new System.Drawing.Size(130, 20);
            this.txtngonngu.TabIndex = 1;
            // 
            // ngonngu
            // 
            this.ngonngu.AutoSize = true;
            this.ngonngu.Location = new System.Drawing.Point(256, 87);
            this.ngonngu.Name = "ngonngu";
            this.ngonngu.Size = new System.Drawing.Size(55, 14);
            this.ngonngu.TabIndex = 0;
            this.ngonngu.Text = "Ngôn Ngữ";
            // 
            // txtmasach
            // 
            this.txtmasach.Enabled = false;
            this.txtmasach.Location = new System.Drawing.Point(63, 47);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(130, 20);
            this.txtmasach.TabIndex = 1;
            // 
            // masach
            // 
            this.masach.AutoSize = true;
            this.masach.Location = new System.Drawing.Point(7, 49);
            this.masach.Name = "masach";
            this.masach.Size = new System.Drawing.Size(49, 14);
            this.masach.TabIndex = 0;
            this.masach.Text = "Mã Sách";
            this.masach.Click += new System.EventHandler(this.label1_Click);
            // 
            // dssach
            // 
            this.dssach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dssach.Location = new System.Drawing.Point(0, 0);
            this.dssach.Name = "dssach";
            this.dssach.Size = new System.Drawing.Size(859, 194);
            this.dssach.TabIndex = 0;
            this.dssach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dssach_CellClick);
            // 
            // sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 444);
            this.Controls.Add(this.splitContainer1);
            this.Name = "sach";
            this.Text = "sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dssach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label gia;
        private System.Windows.Forms.TextBox txtsotrang;
        private System.Windows.Forms.TextBox txtkhosach;
        private System.Windows.Forms.Label tinhtrang;
        private System.Windows.Forms.Label sotrang;
        private System.Windows.Forms.Label khosach;
        private System.Windows.Forms.TextBox txttheloai;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Label theloai;
        private System.Windows.Forms.Label tensach;
        private System.Windows.Forms.TextBox txtngonngu;
        private System.Windows.Forms.Label ngonngu;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label masach;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView dssach;
        private System.Windows.Forms.Label chomuon;
        private System.Windows.Forms.CheckBox moi;
        private System.Windows.Forms.CheckBox damuon;
        private System.Windows.Forms.Button thoat;

    }
}