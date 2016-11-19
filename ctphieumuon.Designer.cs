namespace QLTV
{
    partial class ctphieumuon
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
            this.dssm = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.moi = new System.Windows.Forms.CheckBox();
            this.datra = new System.Windows.Forms.CheckBox();
            this.thoat = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.trasach = new System.Windows.Forms.Button();
            this.tra = new System.Windows.Forms.Label();
            this.tinhtrang = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.masach = new System.Windows.Forms.Label();
            this.txtmanvn = new System.Windows.Forms.TextBox();
            this.txtngaytra = new System.Windows.Forms.TextBox();
            this.manvn = new System.Windows.Forms.Label();
            this.ngaytra = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.maphieu = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dssm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dssm
            // 
            this.dssm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dssm.Location = new System.Drawing.Point(0, 0);
            this.dssm.Name = "dssm";
            this.dssm.Size = new System.Drawing.Size(669, 191);
            this.dssm.TabIndex = 0;
            this.dssm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dssm_CellClick);
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
            this.splitContainer1.Panel1.Controls.Add(this.moi);
            this.splitContainer1.Panel1.Controls.Add(this.datra);
            this.splitContainer1.Panel1.Controls.Add(this.thoat);
            this.splitContainer1.Panel1.Controls.Add(this.luu);
            this.splitContainer1.Panel1.Controls.Add(this.trasach);
            this.splitContainer1.Panel1.Controls.Add(this.tra);
            this.splitContainer1.Panel1.Controls.Add(this.tinhtrang);
            this.splitContainer1.Panel1.Controls.Add(this.txtmasach);
            this.splitContainer1.Panel1.Controls.Add(this.masach);
            this.splitContainer1.Panel1.Controls.Add(this.txtmanvn);
            this.splitContainer1.Panel1.Controls.Add(this.txtngaytra);
            this.splitContainer1.Panel1.Controls.Add(this.manvn);
            this.splitContainer1.Panel1.Controls.Add(this.ngaytra);
            this.splitContainer1.Panel1.Controls.Add(this.txtmaphieu);
            this.splitContainer1.Panel1.Controls.Add(this.maphieu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dssm);
            this.splitContainer1.Size = new System.Drawing.Size(669, 434);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 4;
            // 
            // moi
            // 
            this.moi.AutoSize = true;
            this.moi.Enabled = false;
            this.moi.Location = new System.Drawing.Point(116, 129);
            this.moi.Name = "moi";
            this.moi.Size = new System.Drawing.Size(43, 18);
            this.moi.TabIndex = 3;
            this.moi.Text = "Mới";
            this.moi.UseVisualStyleBackColor = true;
            // 
            // datra
            // 
            this.datra.AutoSize = true;
            this.datra.Enabled = false;
            this.datra.Location = new System.Drawing.Point(384, 45);
            this.datra.Name = "datra";
            this.datra.Size = new System.Drawing.Size(59, 18);
            this.datra.TabIndex = 3;
            this.datra.Text = "Đã Trả";
            this.datra.UseVisualStyleBackColor = true;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(299, 201);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(83, 27);
            this.thoat.TabIndex = 2;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // luu
            // 
            this.luu.Enabled = false;
            this.luu.Location = new System.Drawing.Point(158, 201);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(83, 27);
            this.luu.TabIndex = 2;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // trasach
            // 
            this.trasach.Location = new System.Drawing.Point(28, 201);
            this.trasach.Name = "trasach";
            this.trasach.Size = new System.Drawing.Size(83, 27);
            this.trasach.TabIndex = 2;
            this.trasach.Text = "Trả Sách";
            this.trasach.UseVisualStyleBackColor = true;
            this.trasach.Click += new System.EventHandler(this.trasach_Click);
            // 
            // tra
            // 
            this.tra.AutoSize = true;
            this.tra.Location = new System.Drawing.Point(285, 49);
            this.tra.Name = "tra";
            this.tra.Size = new System.Drawing.Size(23, 14);
            this.tra.TabIndex = 0;
            this.tra.Text = "Trả";
            // 
            // tinhtrang
            // 
            this.tinhtrang.AutoSize = true;
            this.tinhtrang.Location = new System.Drawing.Point(7, 130);
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Size = new System.Drawing.Size(58, 14);
            this.tinhtrang.TabIndex = 0;
            this.tinhtrang.Text = "Tình Trạng";
            // 
            // txtmasach
            // 
            this.txtmasach.Enabled = false;
            this.txtmasach.Location = new System.Drawing.Point(101, 86);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(130, 20);
            this.txtmasach.TabIndex = 1;
            // 
            // masach
            // 
            this.masach.AutoSize = true;
            this.masach.Location = new System.Drawing.Point(7, 89);
            this.masach.Name = "masach";
            this.masach.Size = new System.Drawing.Size(49, 14);
            this.masach.TabIndex = 0;
            this.masach.Text = "Mã Sách";
            // 
            // txtmanvn
            // 
            this.txtmanvn.Enabled = false;
            this.txtmanvn.Location = new System.Drawing.Point(384, 118);
            this.txtmanvn.Name = "txtmanvn";
            this.txtmanvn.Size = new System.Drawing.Size(130, 20);
            this.txtmanvn.TabIndex = 1;
            this.txtmanvn.TextChanged += new System.EventHandler(this.txtngaytra_TextChanged);
            // 
            // txtngaytra
            // 
            this.txtngaytra.Enabled = false;
            this.txtngaytra.Location = new System.Drawing.Point(384, 83);
            this.txtngaytra.Name = "txtngaytra";
            this.txtngaytra.Size = new System.Drawing.Size(130, 20);
            this.txtngaytra.TabIndex = 1;
            this.txtngaytra.TextChanged += new System.EventHandler(this.txtngaytra_TextChanged);
            // 
            // manvn
            // 
            this.manvn.AutoSize = true;
            this.manvn.Location = new System.Drawing.Point(285, 124);
            this.manvn.Name = "manvn";
            this.manvn.Size = new System.Drawing.Size(67, 14);
            this.manvn.TabIndex = 0;
            this.manvn.Text = "Mã NV Nhận";
            // 
            // ngaytra
            // 
            this.ngaytra.AutoSize = true;
            this.ngaytra.Location = new System.Drawing.Point(285, 89);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(51, 14);
            this.ngaytra.TabIndex = 0;
            this.ngaytra.Text = "Ngày Trả";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Enabled = false;
            this.txtmaphieu.Location = new System.Drawing.Point(101, 45);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(130, 20);
            this.txtmaphieu.TabIndex = 1;
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
            // ctphieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 434);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ctphieumuon";
            this.Text = "ctphieumuon";
            this.Load += new System.EventHandler(this.ctphieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssm)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dssm;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button trasach;
        private System.Windows.Forms.Label tra;
        private System.Windows.Forms.Label tinhtrang;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label masach;
        private System.Windows.Forms.TextBox txtngaytra;
        private System.Windows.Forms.Label ngaytra;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.Label maphieu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label manvn;
        private System.Windows.Forms.TextBox txtmanvn;
        private System.Windows.Forms.CheckBox datra;
        private System.Windows.Forms.CheckBox moi;
    }
}