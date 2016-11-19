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
    public partial class sach : Form
    {
        bool them_or_sua;
        public sach()
        {
            InitializeComponent();
            luu.Enabled = false;
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void loaddulieu()
        {
            string cmd = "select * from sach";
            DataTable dt = cosoulieu.ExecSqlQuery(cmd, cosoulieu.connstr);
            dssach.DataSource = dt;
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dssach.Rows[0];
            txtmasach.Text = row1.Cells["masach"].Value.ToString();
            txttensach.Text = row1.Cells["tensach"].Value.ToString();
            txtkhosach.Text = row1.Cells["khosach"].Value.ToString();
            txtsotrang.Text = row1.Cells["sotrang"].Value.ToString();
            txtgia.Text = row1.Cells["gia"].Value.ToString();
            txtngonngu.Text = row1.Cells["ngonngu"].Value.ToString();
            txttheloai.Text = row1.Cells["theloai"].Value.ToString();
            if(row1.Cells["tinhtrang"].Value.ToString().Equals("True"))
            {
                moi.Checked=true;
            }
            else{
                 moi.Checked=false;
            }
            if (row1.Cells["chomuon"].Value.ToString().Equals("True"))
            {
                damuon.Checked = true;
            }
            else
            {
                damuon.Checked = false;
            }
            //txttinhtrang.Text = row1.Cells["tinhtrang"].Value.ToString();
           // txtchomuon.Text = row1.Cells["chomuon"].Value.ToString();
        }

        private void dssach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dssach.Rows[e.RowIndex];
            txtmasach.Text = row1.Cells["masach"].Value.ToString();
            txttensach.Text = row1.Cells["tensach"].Value.ToString();
            txtkhosach.Text = row1.Cells["khosach"].Value.ToString();
            txtsotrang.Text = row1.Cells["sotrang"].Value.ToString();
            txtgia.Text = row1.Cells["gia"].Value.ToString();
            txtngonngu.Text = row1.Cells["ngonngu"].Value.ToString();
            txttheloai.Text = row1.Cells["theloai"].Value.ToString();
            if(row1.Cells["tinhtrang"].Value.ToString().Equals("True"))
            {
                moi.Checked=true;
            }
            else{
                 moi.Checked=false;
            }
            if (row1.Cells["chomuon"].Value.ToString().Equals("True"))
            {
                damuon.Checked = true;
            }
            else
            {
                damuon.Checked = false;
            }
            //txttinhtrang.Text = row1.Cells["tinhtrang"].Value.ToString();
           // txtchomuon.Text = row1.Cells["chomuon"].Value.ToString();
        }

        private void them_Click_1(object sender, EventArgs e)
        {
            them_or_sua = true;
            txtmasach.Enabled = true;
            txttensach.Enabled = true;
            txtkhosach.Enabled = true;
            txtsotrang.Enabled = true;
            txtgia.Enabled = true;
            txtngonngu.Enabled = true;
            txttheloai.Enabled = true;
            moi.Enabled = true;
            damuon.Enabled = true;
            them.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            xoa.Enabled = false;
            txtmasach.Text = "";
            txttensach.Text = "";
            txtkhosach.Text = "";
            txtsotrang.Text = "";
            txtgia.Text = "";
            txtngonngu.Text = "";
            txttheloai.Text = "";
            //txttinhtrang.Text = "";
           // txtchomuon.Text = "";

        }

        private void sua_Click(object sender, EventArgs e)
        {
            them_or_sua = false;
            txtmasach.Enabled = false;
            txttensach.Enabled = true;
            txtkhosach.Enabled = true;
            txtsotrang.Enabled = true;
            txtgia.Enabled = true;
            txtngonngu.Enabled = true;
            txttheloai.Enabled = true;
            moi.Enabled = true;
            damuon.Enabled = true;
            them.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            xoa.Enabled = false;
          
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Xóa sach", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                string cmd = "delete from sach where masach='" +txtmasach.Text+"'";
                cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr);
                loaddulieu();
            }
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (them_or_sua)
            {
                if (txtmasach.Text.Equals(""))
                {
                    MessageBox.Show("loi, ma sach khong duoc trong");
                    txtmasach.Focus();
                    return;
                }
                if (txttensach.Text.Equals(""))
                {
                    MessageBox.Show("loi, ten sach khong duoc trong");
                    txttensach.Focus();
                    return;
                }
                if (txtkhosach.Text.Equals(""))
                {
                    MessageBox.Show("loi, kho sach khong duoc trong");
                    txtkhosach.Focus();
                    return;
                }
                if (txtsotrang.Text.Equals(""))
                {
                    MessageBox.Show("loi, so trang khong duoc trong");
                    txtsotrang.Focus();
                    return;
                }
                if (txtgia.Text.Equals(""))
                {
                    MessageBox.Show("loi, gia khong duoc trong");
                    txtgia.Focus();
                    return;
                }
                if (txtngonngu.Text.Equals(""))
                {
                    MessageBox.Show("loi, ngon ngu khong duoc trong");
                    txtngonngu.Focus();
                    return;
                }
                if (txttheloai.Text.Equals(""))
                {
                    MessageBox.Show("loi, the loai khong duoc trong");
                    txttheloai.Focus();
                    return;
                }
                string chomuon;
                if (damuon.Checked)
                {
                    chomuon = "true";
                }
                else
                {
                    chomuon = "false";
                }
                string tinhtrang;
                if (moi.Checked)
                {
                    tinhtrang = "true";
                }
                else
                {
                    tinhtrang = "false";
                }
                string cmd = "insert into sach(masach,tensach,khosach,sotrang,gia,ngonngu,theloai,tinhtrang,chomuon) values ('" + txtmasach.Text
                            + "','" + txttensach.Text + "','" + txtkhosach.Text + "','" + txtsotrang.Text + "','" + txtgia.Text + "','" + txtngonngu.Text + "','" + txttheloai.Text + "','" + tinhtrang + "','" + chomuon + "')";

                if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                {
           
                    loaddulieu();
                    MessageBox.Show("Da luu thanh cong");

                    txtmasach.Enabled = false;
                    txttensach.Enabled = false;
                    txtkhosach.Enabled = false;
                    txtsotrang.Enabled = false;
                    txtgia.Enabled = false;
                    txtngonngu.Enabled = false;
                    txttheloai.Enabled = false;
                    moi.Enabled = false;
                    damuon.Enabled = false;
                    them.Enabled = true;
                    sua.Enabled = true;
                    luu.Enabled = false;
                    xoa.Enabled = true;



                }

            }
            else
            {

               
                if (txttensach.Text.Equals(""))
                {
                    MessageBox.Show("loi, ten sach khong duoc trong");
                    txttensach.Focus();
                    return;
                }
                if (txtkhosach.Text.Equals(""))
                {
                    MessageBox.Show("loi, kho sach khong duoc trong");
                    txtkhosach.Focus();
                    return;
                }
                if (txtsotrang.Text.Equals(""))
                {
                    MessageBox.Show("loi, so trang khong duoc trong");
                    txtsotrang.Focus();
                    return;
                }
                if (txtgia.Text.Equals(""))
                {
                    MessageBox.Show("loi, gia khong duoc trong");
                    txtgia.Focus();
                    return;
                }
                if (txtngonngu.Text.Equals(""))
                {
                    MessageBox.Show("loi, ngon ngu khong duoc trong");
                    txtngonngu.Focus();
                    return;
                }
                if (txttheloai.Text.Equals(""))
                {
                    MessageBox.Show("loi, the loai khong duoc trong");
                    txttheloai.Focus();
                    return;
                }
                string chomuon;
                if (damuon.Checked)
                {
                    chomuon = "true";
                }
                else
                {
                    chomuon = "false";
                }
                string tinhtrang;
                if (moi.Checked)
                {
                    tinhtrang = "true";
                }
                else
                {
                    tinhtrang = "false";
                }
                string cmd = "update sach set tensach='" + txttensach.Text + "',khosach='" + txtkhosach.Text + "',sotrang='" + txtsotrang.Text + "',gia='" + txtgia.Text + "',ngonngu='" + txtngonngu.Text + "',theloai='" + txttheloai.Text + "',tinhtrang='" + tinhtrang + "',chomuon='" + chomuon + "' where masach='" + txtmasach.Text + "'";


                if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                {
                  
                    loaddulieu();
                    MessageBox.Show("Da luu thanh cong");
                    txtmasach.Enabled = false;
                    txttensach.Enabled = false;
                    txtkhosach.Enabled = false;
                    txtsotrang.Enabled = false;
                    txtgia.Enabled = false;
                    txtngonngu.Enabled = false;
                    txttheloai.Enabled = false;
                    moi.Enabled = false;
                    damuon.Enabled = false;
                    them.Enabled = true;
                    sua.Enabled = true;
                    luu.Enabled = false;
                    xoa.Enabled = true;



                }
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

    }
}
