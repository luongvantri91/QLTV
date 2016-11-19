using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            toolStripMenuItem1.Enabled = false;
            quanLyToolStripMenuItem.Enabled = false;
            thôngKêToolStripMenuItem.Enabled = false;

        }

 



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cosoulieu.mlogin = txtusername.Text;
            cosoulieu.password = txtpassword.Text;
            if (cosoulieu.KetNoi() == 1)
            {
                panel1.Visible = false;
      
                if (!txtusername.Text.Equals("sv"))
                {

                    toolStripMenuItem1.Enabled = false;
                    quanLyToolStripMenuItem.Enabled = false;
                    thôngKêToolStripMenuItem.Enabled = false;
                    String cmd = "execute sp_dangnhap '" + cosoulieu.mlogin + "'";

                    SqlDataReader rd = cosoulieu.ExecSqlDataReader(cmd, cosoulieu.connstr);
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            lbusername.Text = "Tên đăng nhập: " + rd[0].ToString();
                            lbfullname.Text = "Họ và tên: " + rd[1].ToString();
                            lbrole.Text = "Nhóm: " + rd[2].ToString();

                        }
                    }
                }
                else
                {
                    lbusername.Text = "Tên đăng nhập: sv";
                    lbfullname.Text = "Họ và tên: anonymous";
                    lbrole.Text = "Nhóm: Sinh vên";
                   
                    
                }

                toolStripMenuItem1.Enabled = true;
                quanLyToolStripMenuItem.Enabled = true;
                thôngKêToolStripMenuItem.Enabled = true;
            }
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Enabled = false;
            quanLyToolStripMenuItem.Enabled = false;
            thôngKêToolStripMenuItem.Enabled = false;
            panel1.Visible = true;
        }

        private void quanLyMươnTraSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Muonsach().ShowDialog();
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new sach().ShowDialog();
        }

        private void quanLyĐôcGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Docgia().ShowDialog();
        }

        private void traSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Nhanvien().ShowDialog();

        }

        private void đôcGiaMươnSachQuaHanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new thongke().ShowDialog();
        }

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Doimatkhau().ShowDialog();
        }

        private void đăngKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new dangky().ShowDialog();
        }
    }
}
