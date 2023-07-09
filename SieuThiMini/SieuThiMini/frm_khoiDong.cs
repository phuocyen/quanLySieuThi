using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini
{
    public partial class frm_khoiDong : Form
    {
        public frm_khoiDong()
        {
            InitializeComponent();
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dangNhap a = new frm_dangNhap();
            a.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Close();
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            String tt = "";
            tt += "Phần mềm : Quản lý Siêu thị Mini \n";

           
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK);
       
        }
    }
}
