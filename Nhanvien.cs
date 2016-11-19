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
    public partial class Nhanvien : Form
    {
        bool them_or_sua;
        public Nhanvien()
        {
            InitializeComponent();
        }

     

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        public void loaddulieu()
        {
            string cmd = "select * from nhanvien";
            DataTable dt = cosoulieu.ExecSqlQuery(cmd, cosoulieu.connstr);
            dsnv.DataSource = dt;
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dsnv.Rows[0];
            txtmanv.Text = row1.Cells["manv"].Value.ToString();
            txthonv.Text = row1.Cells["honv"].Value.ToString();
            txttennv.Text = row1.Cells["tennv"].Value.ToString();
            if (row1.Cells["gioitinh"].Value.ToString().Equals("True"))
            {
                nam.Checked = true;
                nu.Checked = false;
            }
            else
            {
                nam.Checked = false;
                nu.Checked = true;
            }
            txtdiachi.Text = row1.Cells["diachi"].Value.ToString();
            txtdienthoai.Text = row1.Cells["dienthoai"].Value.ToString();
            txtemail.Text = row1.Cells["email"].Value.ToString();                  
        }


        private void dsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dsnv.Rows[e.RowIndex];
            txtmanv.Text = row1.Cells["manv"].Value.ToString();
            txthonv.Text = row1.Cells["honv"].Value.ToString();
            txttennv.Text = row1.Cells["tennv"].Value.ToString();
            if (row1.Cells["gioitinh"].Value.ToString().Equals("True"))
            {
                nam.Checked = true;
                nu.Checked = false;
            }
            else
            {
                nam.Checked = false;
                nu.Checked = true;
            }
            txtdiachi.Text = row1.Cells["diachi"].Value.ToString();
            txtdienthoai.Text = row1.Cells["dienthoai"].Value.ToString();
            txtemail.Text = row1.Cells["email"].Value.ToString();     
        }

        private void them_Click(object sender, EventArgs e)
        {
            them_or_sua = true;
            txtmanv.Enabled = false;
            txthonv.Enabled = true;
            txttennv.Enabled = true;
            nam.Enabled = true;
            nu.Enabled = true;
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txtemail.Enabled = true;
            them.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            xoa.Enabled = false;
            txtmanv.Text = ("");
            txthonv.Text = ("");
            txttennv.Text = ("");
            txtdiachi.Text = ("");
            txtdienthoai.Text = ("");
            txtemail.Text = ("");
        }

        private void sua_Click(object sender, EventArgs e)
        {
            them_or_sua = false;
            txtmanv.Enabled = false;
            txthonv.Enabled = true;
            txttennv.Enabled = true;
            nam.Enabled = true;
            nu.Enabled = true;
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txtemail.Enabled = true;
            them.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            xoa.Enabled = false;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (them_or_sua)
            {
              
                if (txthonv.Text.Equals(""))
                {
                    MessageBox.Show("loi, ho nhan vien khong duoc trong");
                    txthonv.Focus();
                    return;
                }
                if (txttennv.Text.Equals(""))
                {
                    MessageBox.Show("loi, ten nhan vien khong duoc trong");
                    txttennv.Focus();
                    return;
                }
                string gioitinh;
                if (nam.Checked)
                {
                    gioitinh = "true";
                }
                else
                {
                    nu.Checked = true;
                    gioitinh = "false";
                }
                if (txtdiachi.Text.Equals(""))
                {
                    MessageBox.Show("loi, dia chi khong duoc trong");
                    txtdiachi.Focus();
                    return;
                }
                if (txtdienthoai.Text.Equals(""))
                {
                    MessageBox.Show("loi, dien thoai khong duoc trong");
                    txtdienthoai.Focus();
                    return;
                }
                if (txtemail.Text.Equals(""))
                {
                    MessageBox.Show("loi, dien thoai khong duoc trong");
                    txtemail.Focus();
                    return;
                }

                string cmd = "insert into nhanvien(honv,tennv,gioitinh,diachi,dienthoai,email) values ('" + txthonv.Text + "','"+txttennv.Text+"','" + gioitinh + "','" + txtdiachi.Text + "','" + txtdienthoai.Text + "','" + txtemail.Text + "')";

                if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                {

                    loaddulieu();
                    MessageBox.Show("Da luu thanh cong");
                    txtmanv.Enabled = false;
                    txthonv.Enabled = false;
                    txttennv.Enabled = false;
                    nam.Enabled = false;
                    nu.Enabled = false;
                    txtdiachi.Enabled = false;
                    txtdienthoai.Enabled = false;
                    txtemail.Enabled = false;
                    them.Enabled = true;
                    sua.Enabled = true;
                    luu.Enabled = false;
                    xoa.Enabled = true;
                }
            }
            else
            {
                
                if (txthonv.Text.Equals(""))
                {
                    MessageBox.Show("loi, ho nhan vien khong duoc trong");
                    txthonv.Focus();
                    return;
                }
                if (txttennv.Text.Equals(""))
                {
                    MessageBox.Show("loi, ten nhan vien khong duoc trong");
                    txttennv.Focus();
                    return;
                }
                string gioitinh;
                if (nam.Checked)
                {
                    gioitinh = "true";
                }
                else
                {
                    gioitinh = "false";
                }
                if (txtdiachi.Text.Equals(""))
                {
                    MessageBox.Show("loi, dia chi khong duoc trong");
                    txtdiachi.Focus();
                    return;
                }
                if (txtdienthoai.Text.Equals(""))
                {
                    MessageBox.Show("loi, dien thoai khong duoc trong");
                    txtdienthoai.Focus();
                    return;
                }
                if (txtemail.Text.Equals(""))
                {
                    MessageBox.Show("loi, dien thoai khong duoc trong");
                    txtemail.Focus();
                    return;
                }

                string cmd = "update nhanvien set honv='" + txthonv.Text + "',tennv='"+txttennv.Text+"',gioitinh='" + gioitinh + "',diachi='" + txtdiachi.Text + "',dienthoai='" + txtdienthoai.Text + "',email='" + txtemail.Text + "' where manv='"+txtmanv.Text+"'";

                if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                {

                    loaddulieu();
                    MessageBox.Show("Da luu thanh cong");
                    txtmanv.Enabled = false;
                    txthonv.Enabled = false;
                    txttennv.Enabled = false;
                    nam.Enabled = false;
                    nu.Enabled = false;
                    txtdiachi.Enabled = false;
                    txtdienthoai.Enabled = false;
                    txtemail.Enabled = false;
                    them.Enabled = true;
                    sua.Enabled = true;
                    luu.Enabled = false;
                    xoa.Enabled = true;
                }
              }
            
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Xóa Độc Giả", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                string cmd = "delete from nhanvien where manv='" + txtmanv.Text + "'";
                cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr);
                loaddulieu();
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
