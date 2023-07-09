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
    public partial class frm_trangChu : Form
    {
        public frm_trangChu()
        {
            InitializeComponent();
        }

        

        private void frm_trangChu_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sanPham a = new frm_sanPham();
            a.lb_quyen.Text = lb_quyen.Text;
            a.Show();      
        }

        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_thongTinDonHang ql = new frm_thongTinDonHang();
            ql.Show();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                frm_khoiDong a = new frm_khoiDong();
                a.Show();
                this.Hide();
            }

        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            String tt = "";
            tt += "Phần mềm : Quản lý Siêu thị  \n";

               MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK);
    
        }

        private void ql_nhanvien_Click(object sender, EventArgs e)
        {
            frm_taiKhoan frm = new frm_taiKhoan();
            frm.ShowDialog();
        }

        private void ql_ncc_Click(object sender, EventArgs e)
        {
            frm_nhaCungCap a = new frm_nhaCungCap();
            a.Show();
        }

        private void mn_thongtin_Click(object sender, EventArgs e)
        {

        }

        private void mn_banhang_Click(object sender, EventArgs e)
        {
            frm_banHang a = new frm_banHang();
            a.lb_quyen.Text = lb_quyen.Text;
            a.Show();
        }

        private void mn_doiMatKhau_Click(object sender, EventArgs e)
        {
            frm_doiMatKhau a = new frm_doiMatKhau();
            a.Show();
        }

        private void lb_quyen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hỗTrợToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
