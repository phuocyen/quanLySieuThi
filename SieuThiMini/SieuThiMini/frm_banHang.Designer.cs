namespace SieuThiMini
{
    partial class frm_banHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.lb_quyen = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_thongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_nhapLai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.TongTien = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.txt_slgban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hangtrongkho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_tien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_chietKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.db1 = new System.Windows.Forms.DataGridView();
            this.lb_Tile = new System.Windows.Forms.Label();
            this.dta2 = new System.Windows.Forms.DataGridView();
            this.dta_mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_dangthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_quyen1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta2)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(-23, -30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 22);
            this.label11.TabIndex = 83;
            this.label11.Text = "Xin Chào : ";
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen.ForeColor = System.Drawing.Color.Green;
            this.lb_quyen.Location = new System.Drawing.Point(79, -30);
            this.lb_quyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(20, 22);
            this.lb_quyen.TabIndex = 82;
            this.lb_quyen.Text = "..";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_thongTin,
            this.Menu_thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1611, 28);
            this.menuStrip1.TabIndex = 81;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_thongTin
            // 
            this.Menu_thongTin.Name = "Menu_thongTin";
            this.Menu_thongTin.Size = new System.Drawing.Size(91, 24);
            this.Menu_thongTin.Text = "Thông Tin ";
            this.Menu_thongTin.Click += new System.EventHandler(this.Menu_thongTin_Click);
            // 
            // Menu_thoat
            // 
            this.Menu_thoat.Name = "Menu_thoat";
            this.Menu_thoat.Size = new System.Drawing.Size(59, 24);
            this.Menu_thoat.Text = "Thoát";
            this.Menu_thoat.Click += new System.EventHandler(this.Menu_thoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_nhapLai);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.TongTien);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(778, 588);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(833, 218);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(64, 58);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(133, 52);
            this.btn_Add.TabIndex = 54;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_thoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(250, 130);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(134, 52);
            this.btn_thoat.TabIndex = 57;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_nhapLai
            // 
            this.btn_nhapLai.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nhapLai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapLai.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_nhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhapLai.Location = new System.Drawing.Point(250, 58);
            this.btn_nhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nhapLai.Name = "btn_nhapLai";
            this.btn_nhapLai.Size = new System.Drawing.Size(136, 52);
            this.btn_nhapLai.TabIndex = 56;
            this.btn_nhapLai.Text = "Nhập Lại  ";
            this.btn_nhapLai.UseVisualStyleBackColor = false;
            this.btn_nhapLai.Click += new System.EventHandler(this.btn_nhapLai_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(64, 130);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(133, 52);
            this.btn_Xoa.TabIndex = 55;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // TongTien
            // 
            this.TongTien.BackColor = System.Drawing.Color.LightCyan;
            this.TongTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TongTien.Location = new System.Drawing.Point(451, 60);
            this.TongTien.Margin = new System.Windows.Forms.Padding(4);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(233, 122);
            this.TongTien.TabIndex = 61;
            this.TongTien.Text = "Thanh toán ";
            this.TongTien.UseVisualStyleBackColor = false;
            this.TongTien.Click += new System.EventHandler(this.TongTien_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 74;
            this.label9.Text = "Tìm sản phẩm";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_donvitinh);
            this.groupBox1.Controls.Add(this.txt_slgban);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_hangtrongkho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lb_tien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_chietKhau);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 546);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(770, 254);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_gia
            // 
            this.txt_gia.Enabled = false;
            this.txt_gia.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(147, 132);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(97, 27);
            this.txt_gia.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 138);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 21);
            this.label14.TabIndex = 13;
            this.label14.Text = "Giá Nhập:";
            // 
            // txt_ten
            // 
            this.txt_ten.Enabled = false;
            this.txt_ten.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(412, 36);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(223, 27);
            this.txt_ten.TabIndex = 1;
            // 
            // txt_ma
            // 
            this.txt_ma.Enabled = false;
            this.txt_ma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.Location = new System.Drawing.Point(147, 33);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(95, 27);
            this.txt_ma.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Đơn vị tính:";
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Enabled = false;
            this.txt_donvitinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donvitinh.Location = new System.Drawing.Point(147, 84);
            this.txt_donvitinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(97, 27);
            this.txt_donvitinh.TabIndex = 2;
            // 
            // txt_slgban
            // 
            this.txt_slgban.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slgban.Location = new System.Drawing.Point(149, 177);
            this.txt_slgban.Margin = new System.Windows.Forms.Padding(4);
            this.txt_slgban.Name = "txt_slgban";
            this.txt_slgban.Size = new System.Drawing.Size(95, 27);
            this.txt_slgban.TabIndex = 5;
            this.txt_slgban.Text = "1";
            this.txt_slgban.TextChanged += new System.EventHandler(this.txt_slgban_TextChanged);
            this.txt_slgban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_slgban_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng Nhập:";
            // 
            // txt_hangtrongkho
            // 
            this.txt_hangtrongkho.Enabled = false;
            this.txt_hangtrongkho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hangtrongkho.Location = new System.Drawing.Point(412, 87);
            this.txt_hangtrongkho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hangtrongkho.Name = "txt_hangtrongkho";
            this.txt_hangtrongkho.Size = new System.Drawing.Size(97, 27);
            this.txt_hangtrongkho.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "SLSP hiện có:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = " Mã sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 65;
            this.label8.Text = "( Ngàn Đồng )";
            // 
            // lb_tien
            // 
            this.lb_tien.AutoSize = true;
            this.lb_tien.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tien.Location = new System.Drawing.Point(429, 183);
            this.lb_tien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tien.Name = "lb_tien";
            this.lb_tien.Size = new System.Drawing.Size(132, 29);
            this.lb_tien.TabIndex = 66;
            this.lb_tien.Text = ".................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "Chiếu Khấu:";
            // 
            // txt_chietKhau
            // 
            this.txt_chietKhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chietKhau.Location = new System.Drawing.Point(410, 129);
            this.txt_chietKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chietKhau.Multiline = true;
            this.txt_chietKhau.Name = "txt_chietKhau";
            this.txt_chietKhau.Size = new System.Drawing.Size(51, 30);
            this.txt_chietKhau.TabIndex = 59;
            this.txt_chietKhau.Text = "0";
            this.txt_chietKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_chietKhau_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "Thành Tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(469, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "%";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(231, 101);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(331, 34);
            this.txt_timkiem.TabIndex = 73;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // db1
            // 
            this.db1.BackgroundColor = System.Drawing.Color.White;
            this.db1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db1.Location = new System.Drawing.Point(0, 143);
            this.db1.Margin = new System.Windows.Forms.Padding(4);
            this.db1.Name = "db1";
            this.db1.RowHeadersWidth = 51;
            this.db1.Size = new System.Drawing.Size(770, 402);
            this.db1.TabIndex = 75;
            this.db1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db1_CellContentClick);
            this.db1.Click += new System.EventHandler(this.db1_Click);
            // 
            // lb_Tile
            // 
            this.lb_Tile.AutoSize = true;
            this.lb_Tile.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_Tile.Location = new System.Drawing.Point(565, 28);
            this.lb_Tile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Tile.Name = "lb_Tile";
            this.lb_Tile.Size = new System.Drawing.Size(215, 48);
            this.lb_Tile.TabIndex = 79;
            this.lb_Tile.Text = "Bán Hàng";
            // 
            // dta2
            // 
            this.dta2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dta2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dta_mathuoc,
            this.dta_tenthuoc,
            this.dta_dangthuoc,
            this.dta_giaban,
            this.dta_soluong,
            this.dta_tongTien});
            this.dta2.Location = new System.Drawing.Point(778, 107);
            this.dta2.Margin = new System.Windows.Forms.Padding(4);
            this.dta2.Name = "dta2";
            this.dta2.RowHeadersWidth = 51;
            this.dta2.Size = new System.Drawing.Size(833, 474);
            this.dta2.TabIndex = 77;
            this.dta2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dta2_CellContentClick);
            this.dta2.Click += new System.EventHandler(this.dta2_Click);
            // 
            // dta_mathuoc
            // 
            this.dta_mathuoc.HeaderText = "Mã sản phẩm";
            this.dta_mathuoc.MinimumWidth = 6;
            this.dta_mathuoc.Name = "dta_mathuoc";
            this.dta_mathuoc.Width = 125;
            // 
            // dta_tenthuoc
            // 
            this.dta_tenthuoc.HeaderText = "Tên sản phẩm";
            this.dta_tenthuoc.MinimumWidth = 6;
            this.dta_tenthuoc.Name = "dta_tenthuoc";
            this.dta_tenthuoc.Width = 125;
            // 
            // dta_dangthuoc
            // 
            this.dta_dangthuoc.HeaderText = "Đơn vị tính";
            this.dta_dangthuoc.MinimumWidth = 6;
            this.dta_dangthuoc.Name = "dta_dangthuoc";
            this.dta_dangthuoc.Width = 90;
            // 
            // dta_giaban
            // 
            this.dta_giaban.HeaderText = "Giá bán";
            this.dta_giaban.MinimumWidth = 6;
            this.dta_giaban.Name = "dta_giaban";
            this.dta_giaban.Width = 125;
            // 
            // dta_soluong
            // 
            this.dta_soluong.HeaderText = "Số Lượng";
            this.dta_soluong.MinimumWidth = 6;
            this.dta_soluong.Name = "dta_soluong";
            this.dta_soluong.Width = 80;
            // 
            // dta_tongTien
            // 
            this.dta_tongTien.HeaderText = "Thành Tiền";
            this.dta_tongTien.MinimumWidth = 6;
            this.dta_tongTien.Name = "dta_tongTien";
            this.dta_tongTien.Width = 125;
            // 
            // date1
            // 
            this.date1.CustomFormat = "yyyy-mm-dd hh:mm:ss tt";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(1226, 51);
            this.date1.Margin = new System.Windows.Forms.Padding(4);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(205, 22);
            this.date1.TabIndex = 86;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(20, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 22);
            this.label12.TabIndex = 85;
            this.label12.Text = "Xin Chào : ";
            // 
            // lb_quyen1
            // 
            this.lb_quyen1.AutoSize = true;
            this.lb_quyen1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lb_quyen1.Location = new System.Drawing.Point(122, 51);
            this.lb_quyen1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quyen1.Name = "lb_quyen1";
            this.lb_quyen1.Size = new System.Drawing.Size(20, 22);
            this.lb_quyen1.TabIndex = 84;
            this.lb_quyen1.Text = "..";
            this.lb_quyen1.Click += new System.EventHandler(this.label13_Click);
            // 
            // frm_banHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1611, 801);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_quyen1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_quyen);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.db1);
            this.Controls.Add(this.lb_Tile);
            this.Controls.Add(this.dta2);
            this.Name = "frm_banHang";
            this.Text = "frm_banHang";
            this.Load += new System.EventHandler(this.frm_banHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lb_quyen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_thongTin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_nhapLai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button TongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.TextBox txt_slgban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hangtrongkho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_tien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_chietKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView db1;
        private System.Windows.Forms.Label lb_Tile;
        private System.Windows.Forms.DataGridView dta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_dangthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_tongTien;
        private System.Windows.Forms.ToolStripMenuItem Menu_thoat;
        private System.Windows.Forms.DateTimePicker date1;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lb_quyen1;
    }
}