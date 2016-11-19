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
    public partial class sachmuon : Form
    {
        public static int maphieu;
        string tinhtrangsach;
        public sachmuon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sachmuon_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        public void loaddulieu()
        {
            string cmd = "select * from sach where chomuon='false'";
            DataTable dt = cosoulieu.ExecSqlQuery(cmd, cosoulieu.connstr);
            dssm.DataSource = dt;
            if (dssm.RowCount > 0)
            {

                DataGridViewRow row1 = new DataGridViewRow();
                row1 = dssm.Rows[0];
                txtmasach.Text = row1.Cells["masach"].Value.ToString();
                txttensach.Text = row1.Cells["tensach"].Value.ToString();
                if (row1.Cells["tinhtrang"].Value.ToString().Equals("True"))
                {
                    tinhtrangsach = "true";
                    moi.Checked = true;
                }
                else
                {
                    tinhtrangsach = "false";
                    moi.Checked = false;
                }
                dssm.Columns["chomuon"].ReadOnly = true;
            }
        }

        private void dssm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dssm.Rows[e.RowIndex];
            txtmasach.Text = row1.Cells["masach"].Value.ToString();
            txttensach.Text = row1.Cells["tensach"].Value.ToString();
            
             if(row1.Cells["tinhtrang"].Value.ToString().Equals("True"))
            {
                tinhtrangsach = "true";
                moi.Checked=true;
            }
            else{
                tinhtrangsach = "false";
                 moi.Checked=false;
            }

                                   
        }

        private void chapnhan_Click(object sender, EventArgs e)
        {
           
           string cmd2 = "select count(masach) as soluong from ctphieumuon where maphieu= " + maphieu;
           DataTable dt = cosoulieu.ExecSqlQuery(cmd2, cosoulieu.connstr);
           DataRow r = dt.Rows[0];
           if (Convert.ToInt32(r["soluong"].ToString()) < 3)
           {
               DialogResult result = MessageBox.Show("Bạn chắc muốn mượn sách này chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
               if (result == DialogResult.OK)
               {
                   string cmd = "update sach set chomuon='true' where masach='" + txtmasach.Text + "'";
                   if (cosoulieu.ExecSqlNonQuery(cmd, cosoulieu.connstr) == 1)
                   {

                       string cmd1 = "insert into ctphieumuon(maphieu,masach,tinhtrang) values ('" + maphieu + "','" + txtmasach.Text + "','" + tinhtrangsach + "')";
                       cosoulieu.ExecSqlNonQuery(cmd1, cosoulieu.connstr);
                       loaddulieu();
                   }
               }
           }
           else 
           {
               MessageBox.Show("loi,  Ban chi duoc muon 3 quyen sach");
               
               return;
 
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
