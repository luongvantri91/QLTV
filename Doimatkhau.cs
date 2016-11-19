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
    public partial class Doimatkhau : Form
    {
        public Doimatkhau()
        {
            InitializeComponent();
            txtuser.Text = cosoulieu.mlogin;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (!txtpass.Text.Equals(cosoulieu.password))
            {
                MessageBox.Show("nhap mat khau ko chinh xac");
                txtpass.Focus();
                return;
            }
            if (txtnpass.Text.Equals(""))
            {
                MessageBox.Show("khong de trong mat khau moi");
                txtnpass.Focus();
                return;
            }
            if (!txtcfpass.Text.Equals(txtnpass.Text))
            {
                MessageBox.Show("xac thuc mat khau moi bi sai");
                txtcfpass.Focus();
                return;
            }
            string cmd = "execute sp_password '" + txtpass.Text + "','" + txtnpass.Text + "','" + txtuser.Text + "'";
            cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr);
            cosoulieu.password = txtnpass.Text;
            cosoulieu.KetNoi();
            MessageBox.Show("doi mat khau thanh cong");
        }
    }
}
