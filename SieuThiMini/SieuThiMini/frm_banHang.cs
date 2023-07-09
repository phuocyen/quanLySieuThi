using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SieuThiMini
{
    public partial class frm_banHang : Form
    {
        public int a = 0;
        public int y = 0;

        public string chuoi = "Select masp,tensp,donvitinh,solg,giaban from sanpham";

        public frm_banHang()
        {
            InitializeComponent();
            Load_dta1();
        }

        private void frm_banHang_Load(object sender, EventArgs e)
        {

        }

        public void Load_dta1()
        {
            DBConnect.Chuoiketnoi(chuoi, db1);
            db1.Columns[0].HeaderText = "Mã sản phẩm"; db1.Columns[0].Width = 120;
            db1.Columns[1].HeaderText = "Tên sản phẩm"; db1.Columns[1].Width = 120;
            db1.Columns[2].HeaderText = "Đơn vị tính"; db1.Columns[4].Width = 120;
            db1.Columns[3].HeaderText = "Số lượng"; db1.Columns[3].Width = 120;
            db1.Columns[4].HeaderText = "Giá bán"; db1.Columns[2].Width = 120;
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select masp,tensp,donvitinh,solg,giaban from sanpham where tensp like N'%" + txt_timkiem.Text + "%' ";
            DBConnect.timkiem(load1, db1);
            db1.Columns[0].HeaderText = "Mã sản phẩm"; db1.Columns[0].Width = 120;
            db1.Columns[1].HeaderText = "Tên sản phẩm"; db1.Columns[1].Width = 120;
            db1.Columns[2].HeaderText = "Đơn vị tính"; db1.Columns[4].Width = 120;
            db1.Columns[3].HeaderText = "Số lượng"; db1.Columns[3].Width = 120;
            db1.Columns[4].HeaderText = "Giá bán"; db1.Columns[2].Width = 120;
       
        }

        private void db1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void db1_Click(object sender, EventArgs e)
        {
            int curow = db1.CurrentRow.Index;
            txt_ma.Text = db1.Rows[curow].Cells[0].Value.ToString();
            txt_ten.Text = db1.Rows[curow].Cells[1].Value.ToString();
            txt_donvitinh.Text = db1.Rows[curow].Cells[2].Value.ToString();
            txt_gia.Text = db1.Rows[curow].Cells[4].Value.ToString();
            txt_hangtrongkho.Text = db1.Rows[curow].Cells[3].Value.ToString();
   
        }

        private void dta2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dta2_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Add.Enabled = false;
                txt_slgban.Enabled = false;
                btn_Xoa.Enabled = true;
                int curow = dta2.CurrentRow.Index;

                txt_ma.Text = dta2.Rows[curow].Cells[0].Value.ToString();
                txt_ten.Text = dta2.Rows[curow].Cells[1].Value.ToString();
                txt_donvitinh.Text = dta2.Rows[curow].Cells[2].Value.ToString();
                txt_gia.Text = dta2.Rows[curow].Cells[3].Value.ToString();
                txt_slgban.Text = dta2.Rows[curow].Cells[4].Value.ToString();
                y = int.Parse(txt_slgban.Text);

                string solg = "Select solg from sanpham where masp ='" + txt_ma.Text + "'";
                SqlDataReader rd3 = DBConnect.showtext(solg);
                while (rd3.Read())
                {
                    a = int.Parse(rd3[0].ToString());

                }

            }
            catch
            {
                MessageBox.Show("Trống ! ", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_donvitinh.Text == "" || txt_gia.Text == "" || txt_ma.Text == "" || txt_ten.Text == "" || txt_hangtrongkho.Text == "" || txt_slgban.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ", "Thông Báo", MessageBoxButtons.OK);
            else
            {
                int a = int.Parse(txt_gia.Text);
                int b = int.Parse(txt_slgban.Text);
                int d = int.Parse(txt_hangtrongkho.Text);
                if (txt_chietKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập chiết khấu ! ", "Thông báo", MessageBoxButtons.OK);

                }
                else if (txt_slgban.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập So lg bán ! ", "Thông báo", MessageBoxButtons.OK);
                }

                else if (b > d)
                {
                    MessageBox.Show("Số lượng sản phẩm trong kho không đủ để bán\nBạn hãy nhập thêm hàng", "Thông báo ", MessageBoxButtons.OK);

                }

                else
                {
                    int x = d - b;

                    int s = a * b;
                    int n = dta2.Rows.Add();
                    double thanhtien = 0;
                    dta2.Rows[n].Cells[0].Value = txt_ma.Text;
                    dta2.Rows[n].Cells[1].Value = txt_ten.Text;
                    dta2.Rows[n].Cells[2].Value = txt_donvitinh.Text;
                    dta2.Rows[n].Cells[3].Value = txt_gia.Text;
                    dta2.Rows[n].Cells[4].Value = txt_slgban.Text;
                    dta2.Rows[n].Cells[5].Value = s.ToString();

                    string sql1 = "Update sanpham set solg ='" + x.ToString() + "'   WHERE masp ='" + dta2.Rows[n].Cells[0].Value.ToString() + "'";
                    DBConnect.luu(sql1);
                    string load1 = "Select masp,tensp,donvitinh,solg,giaban from  sanpham where  masp ='" + dta2.Rows[n].Cells[0].Value.ToString() + "' ";
                    DBConnect.Chuoiketnoi(load1, db1);
                    txt_donvitinh.Text = "";
                    txt_gia.Text = "";
                    txt_ma.Text = "";
                    txt_ten.Text = "";
                    txt_hangtrongkho.Text = "";

                    txt_slgban.Text = "1";

                    int sc = dta2.Rows.Count;

                    Load_dta1();



                    for (int i = 0; i < sc - 1; i++)
                    {

                        thanhtien += float.Parse(dta2.Rows[i].Cells[5].Value.ToString());


                    }
                    double g = double.Parse(txt_chietKhau.Text.ToString());
                    double m = thanhtien - (thanhtien * g / 100);
                    lb_tien.Text = m.ToString() + " VNĐ";
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {


                int h = a + y;
                string sql1 = "Update sanpham set Solg ='" + h.ToString() + "' WHERE masp ='" + txt_ma.Text + "'";
                DBConnect.Execute(sql1);
                string load1 = "Select masp,tensp,donvitinh,solg,giaban from sanpham  where  masp ='" + txt_ma.Text + "' ";
                DBConnect.Chuoiketnoi(load1, db1);
                int seleRow = dta2.CurrentCell.RowIndex;
                dta2.Rows.RemoveAt(seleRow);
                double thanhtien = 0;
                int sc = dta2.Rows.Count;
                txt_donvitinh.Text = "";
                txt_gia.Text = "";
                txt_ma.Text = "";
                txt_ten.Text = "";
                txt_hangtrongkho.Text = "";

                txt_slgban.Text = "1";
                btn_Xoa.Enabled = false;

                for (int i = 0; i < sc - 1; i++)
                {
                    thanhtien += float.Parse(dta2.Rows[i].Cells[5].Value.ToString());
                }
                btn_Add.Enabled = true;
                txt_slgban.Enabled = true;
                btn_Xoa.Enabled = false;
                double g = double.Parse(txt_chietKhau.Text.ToString());
                double m = thanhtien + thanhtien * g / 100;
                lb_tien.Text = m.ToString();
            }
            catch
            {
                MessageBox.Show("Ban chua chọn thuoc sản phẩm để xóa ! ", "Thong bao", MessageBoxButtons.OK);
            }
            Load_dta1();
        }

        private void btn_nhapLai_Click(object sender, EventArgs e)
        {
            txt_donvitinh.Text = "";
            txt_gia.Text = "";
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_hangtrongkho.Text = "";

            txt_slgban.Text = "1";
            btn_Xoa.Enabled = false;
            txt_slgban.Enabled = true;
            btn_Add.Enabled = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void TongTien_Click(object sender, EventArgs e)
        {
            try
            {

                if (dta2.RowCount == 1)
                {
                    MessageBox.Show("Danh sách trống không thể xuất hóa đơn!");
                }
                else
                {
                    DateTime nagy = DateTime.Now;
                    string tim = nagy.ToString();
                    string randomNameFile = tim.Replace(" ", "_").Replace("/", "-").Replace(":", "-");
                    double thanhtien = 0;
                    string s = "";      
                    int sc = dta2.Rows.Count;
                    for (int i = 0; i < sc - 1; i++)
                    {
                        s += dta2.Rows[i].Cells[1].Value.ToString() + " : " + dta2.Rows[i].Cells[4].Value.ToString() + ",  ";
                        thanhtien += double.Parse(dta2.Rows[i].Cells[5].Value.ToString());

                    }
                    double g = double.Parse(txt_chietKhau.Text.ToString());
                    double m = thanhtien + thanhtien * g / 100;

                    string date = date1.Text.Trim();

                    string str1 = "Insert into chitietdonhang Values('" + s.ToString() + "','" + date + "','" + m.ToString() + "',N'" + lb_quyen.Text + "','staff')";
                    DBConnect.them_dl1(str1);
                    InHoaDon hd = new InHoaDon();
                    hd.Show();
                    string duongdan = "";

                    //XuatExecl.nhapnhieu(dta2, duongdan, randomNameFile, lb_tien.Text, lb_Tile.Text, txt_chietKhau.Text);
                    MessageBox.Show("Thực hiện thành công ", "Thông báo ", MessageBoxButtons.OK);
                    dta2.Rows.Clear();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_slgban_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_slgban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        
        }

        private void txt_chietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
     
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Menu_thongTin_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            String tt = "";
            tt += "Phần mềm : Quản lý Siêu thị Mini \n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK);
       
        }

        private void Menu_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                frm_dangNhap a = new frm_dangNhap();
                a.Show();
                this.Hide();
            }
        }

        private void date1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       
    }
}
