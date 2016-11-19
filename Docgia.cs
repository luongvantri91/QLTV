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
    
    public partial class Docgia : Form
    {
        bool them_or_sua;
        public Docgia()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Docgia_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        public void loaddulieu()
        {
         
            string cmd = "select * from docgia";
            DataTable dt = cosoulieu.ExecSqlQuery(cmd, cosoulieu.connstr);
            dsdg.DataSource = dt;
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dsdg.Rows[0];
            txtmadg.Text = row1.Cells["madg"].Value.ToString();
            txthodg.Text = row1.Cells["hodg"].Value.ToString();
            txttendg.Text = row1.Cells["tendg"].Value.ToString();
            txtemaildg.Text = row1.Cells["emaildg"].Value.ToString();
            txtsocmnd.Text = row1.Cells["socmnd"].Value.ToString();
            if (row1.Cells["gioitinh"].Value.ToString().Equals("True"))
            {
                nam.Checked = true;
                nu.Checked = false;
            }
            else
            {
                nu.Checked = true;
                nam.Checked = false;
            }
            txtngaysinh.Text = row1.Cells["ngaysinh"].Value.ToString();
            txtdiachi.Text = row1.Cells["diachi"].Value.ToString();
            txtdienthoai.Text = row1.Cells["dienthoai"].Value.ToString();
            txtngaylamthe.Text = row1.Cells["ngaylamthe"].Value.ToString();
            txtngayhethan.Text = row1.Cells["ngayhethan"].Value.ToString();
            if (row1.Cells["hoatdong"].Value.ToString().Equals("True"))
            {
                conhd.Checked = true;
               
            }
            else
            {
                conhd.Checked = false;
            
            }
          }

        

        private void dsdg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dsdg.Rows[e.RowIndex];
            txtmadg.Text = row1.Cells["madg"].Value.ToString();
            txthodg.Text = row1.Cells["hodg"].Value.ToString();
            txttendg.Text = row1.Cells["tendg"].Value.ToString();
            txtemaildg.Text = row1.Cells["emaildg"].Value.ToString();
            txtsocmnd.Text = row1.Cells["socmnd"].Value.ToString();
            if (row1.Cells["gioitinh"].Value.ToString().Equals("True"))
            {
                nam.Checked = true;
                nu.Checked = false;
            }
            else
            {
                nu.Checked = true;
                nam.Checked = false;
            }
            txtngaysinh.Text = row1.Cells["ngaysinh"].Value.ToString();
            txtdiachi.Text = row1.Cells["diachi"].Value.ToString();
            txtdienthoai.Text = row1.Cells["dienthoai"].Value.ToString();
            txtngaylamthe.Text = row1.Cells["ngaylamthe"].Value.ToString();
            txtngayhethan.Text = row1.Cells["ngayhethan"].Value.ToString();
            if (row1.Cells["hoatdong"].Value.ToString().Equals("True"))
            {
                conhd.Checked = true;
               
            }
            else
            {
                conhd.Checked = false;
              
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            them_or_sua = true;
            txtmadg.Enabled = true;
            txthodg.Enabled = true;
            txttendg.Enabled = true;
            txtemaildg.Enabled = true;
            txtsocmnd.Enabled = true;
            nam.Enabled = true;
            nu.Enabled = true;
            txtngaysinh.Enabled= true;
            txtdiachi.Enabled= true;
            txtdienthoai.Enabled = true;
            txtngaylamthe.Enabled = true;
            txtngayhethan.Enabled = true;
            conhd.Enabled = true;
          
            them.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            xoa.Enabled = false;
            txtmadg.Text = "";
            txthodg.Text = "";
            txttendg.Text = "";
            txtemaildg.Text = "";
            txtsocmnd.Text = "";
            txtngaysinh.Text = "";
             txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtngaylamthe.Text = "";
             txtngayhethan.Text = "";

        }



        private void xoa_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Xóa Độc Giả", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
              if (result == DialogResult.OK)
              {
                  string cmd = "delete from Docgia where madg='" + txtmadg.Text +"'";
                  cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr);
                  loaddulieu();
              }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            them_or_sua = false;
            txtmadg.Enabled = false;
            txthodg.Enabled = true;
            txttendg.Enabled = true;
            txtemaildg.Enabled = true;
            txtsocmnd.Enabled = true;
            nam.Enabled = true;
            nu.Enabled = true;
            txtngaysinh.Enabled = true;
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txtngaylamthe.Enabled = true;
            txtngayhethan.Enabled = true;
            conhd.Enabled = true;

            them.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            xoa.Enabled = false;
 
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (them_or_sua)
            {
                if (txtmadg.Text.Equals(""))
                {
                    MessageBox.Show("loi, ma doc gia khong duoc trong");
                    txtmadg.Focus();
                    return;
                }
                if (txthodg.Text.Equals(""))
                {
                    MessageBox.Show("loi, ho doc gia khong duoc trong");
                    txthodg.Focus();
                    return;
                }
                if (txttendg.Text.Equals(""))
                {
                    MessageBox.Show("loi, ten doc gia khong duoc trong");
                    txttendg.Focus();
                    return;
                }
                if (txtemaildg.Text.Equals(""))
                {
                    MessageBox.Show("loi, email doc gia khong duoc trong");
                    txtemaildg.Focus();
                    return;
                }
                if (txtsocmnd.Text.Equals(""))
                {
                    MessageBox.Show("loi, so cmnd khong duoc trong");
                    txtsocmnd.Focus();
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
                if (txtngaysinh.Text.Equals(""))
                {
                    MessageBox.Show("loi, ngay sinh khong duoc trong");
                    txtngaysinh.Focus();
                    return;
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
                if (txtngaylamthe.Text.Equals(""))
                {
                    MessageBox.Show("loi, ngay lam the khong duoc trong");
                    txtngaylamthe.Focus();
                    return;
                }
                if (txtngayhethan.Text.Equals(""))
                {
                    MessageBox.Show("loi, ngay het han khong duoc trong");
                    txtngayhethan.Focus();
                    return;
                }
                string hoatdong;
                if (conhd.Checked)
                {
                    hoatdong = "true";
                }
                else
                {
                    hoatdong = "false";
                }

                string cmd = "insert into docgia(madg,hodg,tendg,emaildg,socmnd,gioitinh,ngaysinh,diachi,dienthoai,ngaylamthe,ngayhethan,hoatdong) values ('" + txtmadg.Text
                               + "','" + txthodg.Text + "','" + txttendg.Text + "','" + txtemaildg.Text + "','" + txtsocmnd.Text + "','" + gioitinh + "','" + txtngaysinh.Text + "','" + txtdiachi.Text
                               + "','" + txtdienthoai.Text + "','" + txtngaylamthe.Text + "','" + txtngayhethan.Text + "','" + hoatdong + "')";

                if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                {
                    loaddulieu();
                    MessageBox.Show("Da luu thanh cong");
                    txtmadg.Enabled = false;
                    txthodg.Enabled = false;
                    txttendg.Enabled = false;
                    txtemaildg.Enabled = false;
                    txtsocmnd.Enabled = false;
                    nam.Enabled = false;
                    nu.Enabled = false;
                    txtngaysinh.Enabled = false;
                    txtdiachi.Enabled = false;
                    txtdienthoai.Enabled = false;
                    txtngaylamthe.Enabled = false;
                    txtngayhethan.Enabled = false;
                    conhd.Enabled = true;

                    them.Enabled = true;
                    sua.Enabled = true;
                    luu.Enabled = false;
                    xoa.Enabled = true;


                }
            }
            else
            {
                if (txthodg.Text.Equals(""))
                {
                    MessageBox.Show("loi, ho doc gia khong duoc trong");
                    txthodg.Focus();
                    return;
                }
                if (txttendg.Text.Equals(""))
                {
                    MessageBox.Show("loi, ten doc gia khong duoc trong");
                    txttendg.Focus();
                    return;
                }
                if (txtemaildg.Text.Equals(""))
                {
                    MessageBox.Show("loi, email doc gia khong duoc trong");
                    txtemaildg.Focus();
                    return;
                }
                if (txtsocmnd.Text.Equals(""))
                {
                    MessageBox.Show("loi, so cmnd khong duoc trong");
                    txtsocmnd.Focus();
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
                if (txtngaysinh.Text.Equals(""))
                {
                    MessageBox.Show("loi, ngay sinh khong duoc trong");
                    txtngaysinh.Focus();
                    return;
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
                if (txtngaylamthe.Text.Equals(""))
                {
                    MessageBox.Show("loi, ngay lam the khong duoc trong");
                    txtngaylamthe.Focus();
                    return;
                }
                if (txtngayhethan.Text.Equals(""))
                {
                    MessageBox.Show("loi, ngay het han khong duoc trong");
                    txtngayhethan.Focus();
                    return;
                }
                string hoatdong;
                if (conhd.Checked)
                {
                    hoatdong = "true";
                }
                else
                {
                    hoatdong = "false";
                }

                string cmd = "update docgia set hodg='" + txthodg.Text + "', tendg='" + txttendg.Text + "',emaildg='" + txtemaildg.Text + "',socmnd='" + txtsocmnd.Text + "',gioitinh='" + gioitinh + "',ngaysinh='" + txtngaysinh.Text + "',diachi='" + txtdiachi.Text
                               + "',dienthoai='" + txtdienthoai.Text + "',ngaylamthe='" + txtngaylamthe.Text + "',ngayhethan='" + txtngayhethan.Text + "',hoatdong='" + hoatdong + "' where madg='"+txtmadg.Text+"'";

                if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                {
                    loaddulieu();
                    MessageBox.Show("Da luu thanh cong");
                    txtmadg.Enabled = false;
                    txthodg.Enabled = false;
                    txttendg.Enabled = false;
                    txtemaildg.Enabled = false;
                    txtsocmnd.Enabled = false;
                    nam.Enabled = false;
                    nu.Enabled = false;
                    txtngaysinh.Enabled = false;
                    txtdiachi.Enabled = false;
                    txtdienthoai.Enabled = false;
                    txtngaylamthe.Enabled = false;
                    txtngayhethan.Enabled = false;
                    conhd.Enabled = true;

                    them.Enabled = true;
                    sua.Enabled = true;
                    luu.Enabled = false;
                    xoa.Enabled = true;


                }
            }
         }
              
    }
}
