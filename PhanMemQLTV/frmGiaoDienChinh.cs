using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLTV
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void quảnLýĐộcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLDocGia QLDocGia = new frmQLDocGia();
            QLDocGia.Show();
        }

        private void quảnLýThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLThuThu QLThuThu = new frmQLThuThu();
            QLThuThu.Show();
        }
        private void quảnLýTàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLTaiLieu QLTaiLieu = new frmQLTaiLieu();
            QLTaiLieu.Show();
        }


        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn thoát.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

    }
}
