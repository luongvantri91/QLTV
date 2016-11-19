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
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals(""))
            {
                MessageBox.Show("User khong duoc de trong");
                txtuser.Focus();
                return;
            }
            if (txtpass.Text.Equals(""))
            {
                MessageBox.Show("Password khong duoc de trong");
                txtpass.Focus();
                return;
            }
            if(!txtcfpass.Text.Equals(txtpass.Text))
            {
                MessageBox.Show("Xac thuc Password khong dung");
                txtcfpass.Focus();
                return;
            }
            string cmd = "execute tao_login '" + txtuser.Text + "','" + txtpass.Text + "','" + txtuser.Text + "','nhanvien'";
            if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
            {
                MessageBox.Show("tao login thanh cong");
                this.Close();
            }
            else
            {
                MessageBox.Show("ten login da ton tai");
            }

            
        }

        private void dangky_Load(object sender, EventArgs e)
        {

        }
    }
}
