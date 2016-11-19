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
    public partial class thongke : Form
    {
        public thongke()
        {
            InitializeComponent();
        }

        private void thongke_Load(object sender, EventArgs e)
        {
            string cmd = "execute sp_thongkesachquahan";
            dataGridView1.DataSource = cosoulieu.ExecSqlQuery(cmd, cosoulieu.connstr);
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
