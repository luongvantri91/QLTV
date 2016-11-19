namespace QLTV
{
    partial class sachmuon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dssm = new System.Windows.Forms.DataGridView();
            this.chapnhan = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.tensach = new System.Windows.Forms.Label();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.tinhtrang = new System.Windows.Forms.Label();
            this.moi = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dssm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dssm);
            this.panel1.Location = new System.Drawing.Point(1, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 265);
            this.panel1.TabIndex = 0;
            // 
            // dssm
            // 
            this.dssm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dssm.Location = new System.Drawing.Point(0, 0);
            this.dssm.Name = "dssm";
            this.dssm.Size = new System.Drawing.Size(854, 265);
            this.dssm.TabIndex = 0;
            this.dssm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dssm_CellClick);
            this.dssm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chapnhan
            // 
            this.chapnhan.Location = new System.Drawing.Point(230, 374);
            this.chapnhan.Name = "chapnhan";
            this.chapnhan.Size = new System.Drawing.Size(110, 40);
            this.chapnhan.TabIndex = 1;
            this.chapnhan.Text = "Chấp Nhận";
            this.chapnhan.UseVisualStyleBackColor = true;
            this.chapnhan.Click += new System.EventHandler(this.chapnhan_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(397, 374);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(110, 40);
            this.thoat.TabIndex = 1;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách";
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(66, 50);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(116, 20);
            this.txtmasach.TabIndex = 3;
            // 
            // tensach
            // 
            this.tensach.AutoSize = true;
            this.tensach.Location = new System.Drawing.Point(237, 53);
            this.tensach.Name = "tensach";
            this.tensach.Size = new System.Drawing.Size(52, 14);
            this.tensach.TabIndex = 2;
            this.tensach.Text = "Tên sách";
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(295, 51);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(116, 20);
            this.txttensach.TabIndex = 3;
            // 
            // tinhtrang
            // 
            this.tinhtrang.AutoSize = true;
            this.tinhtrang.Location = new System.Drawing.Point(449, 55);
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Size = new System.Drawing.Size(58, 14);
            this.tinhtrang.TabIndex = 2;
            this.tinhtrang.Text = "Tình Trạng";
            // 
            // moi
            // 
            this.moi.AutoSize = true;
            this.moi.Location = new System.Drawing.Point(528, 53);
            this.moi.Name = "moi";
            this.moi.Size = new System.Drawing.Size(43, 18);
            this.moi.TabIndex = 4;
            this.moi.Text = "Mới";
            this.moi.UseVisualStyleBackColor = true;
            // 
            // sachmuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 430);
            this.Controls.Add(this.moi);
            this.Controls.Add(this.tinhtrang);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.tensach);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.chapnhan);
            this.Controls.Add(this.panel1);
            this.Name = "sachmuon";
            this.Text = "sachmuon";
            this.Load += new System.EventHandler(this.sachmuon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dssm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dssm;
        private System.Windows.Forms.Button chapnhan;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label tensach;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Label tinhtrang;
        private System.Windows.Forms.CheckBox moi;
    }
}