using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class ctphieumuon : Form
    {
        public static int maphieu1;
        public ctphieumuon()
        {
            InitializeComponent();
        }

        private void txtngaytra_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctphieumuon_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        public void loaddulieu()
        {
            string cmd = "select * from ctphieumuon where maphieu=" +maphieu1;
            DataTable dt = cosoulieu.ExecSqlQuery(cmd, cosoulieu.connstr);
            dssm.DataSource = dt;
            DataGridViewRow row1 = new DataGridViewRow();
            if (dt.Rows.Count > 0)
            {
                row1 = dssm.Rows[0];
                txtmaphieu.Text = row1.Cells["maphieu"].Value.ToString();
                txtmasach.Text = row1.Cells["masach"].Value.ToString();

                if (row1.Cells["tinhtrang"].Value.ToString().Equals("True"))
                {
                    moi.Checked = true;
                }
                else
                {
                    moi.Checked = false;
                }
            }
            else
            {
                 txtmaphieu.Text = "";
                 txtmasach.Text = "";
            }
            /* txtngaytra.Text = row1.Cells["ngaytra"].Value.ToString();
            txtmanvn.Text = row1.Cells["manv"].Value.ToString();
            if (row1.Cells["tra"].Value.ToString().Equals("True"))
            {
                datra.Checked = true;
            }
            else
            {
                datra.Checked = false;
            }*/
        }

        private void dssm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dssm.Rows[e.RowIndex];
            txtmaphieu.Text = row1.Cells["maphieu"].Value.ToString();
            txtmasach.Text = row1.Cells["masach"].Value.ToString();
           if (row1.Cells["tinhtrang"].Value.ToString().Equals("True"))
            {
                moi.Checked = true;
            }
            else
            {
                moi.Checked = false;
            }
           /* txtngaytra.Text = row1.Cells["ngaytra"].Value.ToString();
            txtmanvn.Text = row1.Cells["manv"].Value.ToString();
            if (row1.Cells["tra"].Value.ToString().Equals("True"))
            {
                datra.Checked = true;
            }
            else
            {
                datra.Checked = false;
            }*/
        }

        private void trasach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn có chắc muốn trả sách này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string cmd = "delete from ctphieumuon where masach='" + txtmasach.Text+"'";

                if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                {
                    string cmd1 = "update sach set chomuon='false' where masach='" + txtmasach.Text + "'";
                    cosoulieu.ExecSqlNonQuery(cmd1, cosoulieu.connstr);
                    loaddulieu();
                }
            }
            
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void luu_Click(object sender, EventArgs e)
        {
            datra.Checked = true;
            if (txtngaytra.Text.Equals(""))
            {
                MessageBox.Show("loi, ngay tra khong duoc trong");
                txtngaytra.Focus();
                return;
            }
            if (txtmanvn.Text.Equals(""))
            {
                MessageBox.Show("loi, ma nhan vien nhan khong duoc trong");
                txtmanvn.Focus();
                return;
            }

        }

    




    }
}
