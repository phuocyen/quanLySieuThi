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
    public partial class frm_doiMatKhau : Form
    {
        public frm_doiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_doiMatKhau_Click(object sender, EventArgs e)
        {
            string sql1 = "Select count(*) from Admin where tk='" + txt_tk.Text.Trim() + "' ";
            string sql2 = "Select count(*) from tknhanvien where tk ='" + txt_tk.Text + "'";
            string sql3 = "Select count(*) from tkquanly where tk='" + txt_tk.Text + "' ";
            if (txt_newmk.Text.Length < 6)
            {
                MessageBox.Show("Mat khẩu bạn nhập ít nhất phải dài 6 ký tự", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DBConnect.ktratk(txt_tk.Text, txt_newmk.Text, txt_remk.Text, sql1, sql2, sql3);

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        
    }
}
