﻿using System;
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
    public partial class frm_thongTinDonHang : Form
    {
        public string chuoi = "Select * from chitietdonhang";
        public frm_thongTinDonHang()
        {
            InitializeComponent();
            Load_dta1();
        }

        public void Load_dta1()
        {
            DBConnect.Chuoiketnoi(chuoi, db1);
            db1.Columns[0].HeaderText = "Mã đơn"; db1.Columns[0].Width = 80;
            db1.Columns[1].HeaderText = "Tên và số lượng"; db1.Columns[1].Width = 200;
            db1.Columns[2].HeaderText = "Ngày bán"; db1.Columns[2].Width = 140;
            db1.Columns[3].HeaderText = "Tổng giá trị"; db1.Columns[3].Width = 100;
            db1.Columns[4].HeaderText = "Người nhập"; db1.Columns[4].Width = 190;
        }

        private void clear()
        {
            db1.Columns[0].HeaderText = "Mã đơn"; db1.Columns[0].Width = 80;
            db1.Columns[1].HeaderText = "Tên và số lượng"; db1.Columns[1].Width = 200;
            db1.Columns[2].HeaderText = "Ngày bán"; db1.Columns[2].Width = 140;
            db1.Columns[3].HeaderText = "Tổng giá trị"; db1.Columns[3].Width = 100;
            db1.Columns[4].HeaderText = "Người nhập"; db1.Columns[4].Width = 190;
            txt_matdonhang.Text = "";
            txt_tenvasoluong.Text = "";
            txt_ngaymua.Text = "";
            txtTotal.Text = "";
            txtNguoinhap.Text = "";

            btn_Xoa.Enabled = false;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from chitietdonhang where maphieuxuat= '" + txt_matdonhang.Text + "'";
            DBConnect.Execute(sql);
            DBConnect.Chuoiketnoi(chuoi, db1);
            clear();

        }

        private void db1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void db1_Click(object sender, EventArgs e)
        {

            int curow = db1.CurrentRow.Index;
            txt_matdonhang.Text = db1.Rows[curow].Cells[0].Value.ToString();
            txt_tenvasoluong.Text = db1.Rows[curow].Cells[1].Value.ToString();
            txt_ngaymua.Text = db1.Rows[curow].Cells[2].Value.ToString();
            txtTotal.Text = db1.Rows[curow].Cells[3].Value.ToString();
            txtNguoinhap.Text = db1.Rows[curow].Cells[4].Value.ToString();

            btn_Xoa.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_in_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
