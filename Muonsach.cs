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
    public partial class Muonsach : Form
    {
        bool them_or_sua;
        public Muonsach()
        {
            InitializeComponent();
            luu.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (them_or_sua)
            {
                if (combomanv.Text.Equals(""))
                {
                    MessageBox.Show("loi, ma nhan vien khong duoc trong");
                    combomanv.Focus();
                    return;
                }
                if (combomadg.Text.Equals(""))
                {
                    MessageBox.Show("loi, ma doc gia khong duoc trong");
                    combomadg.Focus();
                    return;
                }
                if (txtngaymuon.Text.Equals(""))
                {
                    MessageBox.Show("loi,ngay muon khong duoc trong");
                    txtngaymuon.Focus();
                    return;
                }
                string hinhthuc;
                if (taicho.Checked)
                {
                    hinhthuc = "true";
                }
                else
                {
                    mangve.Checked = true;
                    hinhthuc = "false";
                }
       
                string cmd = "insert into phieumuon(madg,manv,hinhthuc,ngaymuon) values (" + Convert.ToInt32(combomadg.Text)
                            + "," + Convert.ToInt32(combomanv.Text) + ",'" + hinhthuc + "','" + txtngaymuon.Text + "')";

                if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                {
                    loaddulieu();
                    MessageBox.Show("Da luu thanh cong");

                    txtmaphieu.Enabled = false;
                    combomanv.Enabled = false;
                    combomadg.Enabled = false;
                    taicho.Enabled = false;
                    mangve.Enabled = false;
                    txtngaymuon.Enabled = false;
                    them.Enabled = true;
                    sua.Enabled = true;
                    luu.Enabled = false;
                    xoa.Enabled = true;

                }

            }
            else 
            {
                if (combomanv.Text.Equals(""))
                {
                    MessageBox.Show("loi, ma nhan vien khong duoc trong");
                    combomanv.Focus();
                    return;
                }
                if (combomadg.Text.Equals(""))
                {
                    MessageBox.Show("loi, ma doc gia khong duoc trong");
                    combomadg.Focus();
                    return;
                }
                if (txtngaymuon.Text.Equals(""))
                {
                    MessageBox.Show("loi,ngay muon khong duoc trong");
                    txtngaymuon.Focus();
                    return;
                }
                string hinhthuc;
                if (taicho.Checked)
                {
                    hinhthuc = "true";
                }
                else
                {
                    mangve.Checked = true;
                    hinhthuc = "false";
                }
              
                string cmd = "update phieumuon set hinhthuc='" + hinhthuc + "', ngaymuon= '" + txtngaymuon.Text + "', madg=" + Convert.ToInt32(combomadg.Text)
                            + ",  manv=" + Convert.ToInt32(combomanv.Text) + " where maphieu='"+ txtmaphieu.Text+"'";

                if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                {
                    loaddulieu();
                    MessageBox.Show("Da luu thanh cong");

                    txtmaphieu.Enabled = false;
                    combomanv.Enabled = false;
                    combomadg.Enabled = false;
                    taicho.Enabled = false;
                    mangve.Enabled = false;
                    txtngaymuon.Enabled = false;
                    them.Enabled = true;
                    sua.Enabled = true;
                    luu.Enabled = false;
                    xoa.Enabled = true;

                }
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {

        }

        private void Muonsach_Load(object sender, EventArgs e)
        {

            loaddulieu();
        }

        private void dspm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dspm.Rows[e.RowIndex];
            txtmaphieu.Text = row1.Cells["maphieu"].Value.ToString();
            combomanv.Text = row1.Cells["manv"].Value.ToString();
            combomadg.Text = row1.Cells["madg"].Value.ToString();
            if (row1.Cells["hinhthuc"].Value.ToString().Equals("True"))
            {
                taicho.Checked = true;
                mangve.Checked = false;
            }
            else
            {
                taicho.Checked = false;
                mangve.Checked = true;
            }
       
            txtngaymuon.Text = row1.Cells["ngaymuon"].Value.ToString();
            ctpm.Enabled = true;
        }

        private void them_Click(object sender, EventArgs e)
        {
            them_or_sua = true;
            txtmaphieu.Enabled = false;
            combomanv.Enabled = true;
            combomadg.Enabled = true;
            taicho.Enabled = true;
            mangve.Enabled = true;
            txtngaymuon.Enabled = true;
            them.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            xoa.Enabled = false;
            txtmaphieu.Text = "";
            combomanv.Text = "";
            combomadg.Text = "";
            txtngaymuon.Text = "";
            ctpm.Enabled = false;

        }

        private void sua_Click(object sender, EventArgs e)
        {
            them_or_sua = false;
            txtmaphieu.Enabled = false;
            combomanv.Enabled = true;
            combomadg.Enabled = true;
            taicho.Enabled = true;
            mangve.Enabled = true;
            txtngaymuon.Enabled = true;
            them.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            xoa.Enabled = false;
            ctpm.Enabled = false;
       
        }
        public void loaddulieu()
        {
            string cmd1 = "select manv from nhanvien";
            DataTable dt1 = cosoulieu.ExecSqlQuery(cmd1, cosoulieu.connstr);
            combomanv.DataSource = dt1;
            combomanv.ValueMember = "manv";
            combomanv.DisplayMember = "manv";
            string cmd2 = "select madg from docgia";
            DataTable dt2 = cosoulieu.ExecSqlQuery(cmd2, cosoulieu.connstr);
            combomadg.DataSource = dt2;
            combomadg.ValueMember = "madg";
            combomadg.DisplayMember = "madg";
            string cmd = "select * from phieumuon";
            DataTable dt = cosoulieu.ExecSqlQuery(cmd, cosoulieu.connstr);
            dspm.DataSource = dt;
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dspm.Rows[0];
            txtmaphieu.Text = row1.Cells["maphieu"].Value.ToString();
            combomanv.Text = row1.Cells["manv"].Value.ToString();
            combomadg.Text = row1.Cells["madg"].Value.ToString();
            if (row1.Cells["hinhthuc"].Value.ToString().Equals("True"))
            {
                taicho.Checked = true;
                mangve.Checked = false;
            }
            else
            {
                taicho.Checked = false;
                mangve.Checked = true;
            }
          
            txtngaymuon.Text = row1.Cells["ngaymuon"].Value.ToString();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Xóa phiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
              if (result == DialogResult.OK)
              {
                  string cmd = "delete from phieumuon where maphieu=" + txtmaphieu.Text;
                  cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr);
                  loaddulieu();
              }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void taicho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ctpm_Click(object sender, EventArgs e)
        {
            ctphieumuon.maphieu1 = Convert.ToInt32( txtmaphieu.Text);
            new ctphieumuon().ShowDialog();
        }

        private void ms_Click(object sender, EventArgs e)
        {
            sachmuon.maphieu = Convert.ToInt32(txtmaphieu.Text);
            
            new sachmuon().ShowDialog();
            

        }

    }
}
