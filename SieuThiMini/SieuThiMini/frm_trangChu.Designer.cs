namespace SieuThiMini
{
    partial class frm_trangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_ncc = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_banhang = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_doiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_quyen = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_quanly,
            this.mn_banhang,
            this.btn_dangXuat,
            this.mn_thongtin,
            this.mn_doiMatKhau});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menu";
            // 
            // mn_quanly
            // 
            this.mn_quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ql_nhanvien,
            this.ql_ncc,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýĐơnHàngToolStripMenuItem});
            this.mn_quanly.Name = "mn_quanly";
            this.mn_quanly.Size = new System.Drawing.Size(106, 34);
            this.mn_quanly.Text = "&Quản lý ";
            // 
            // ql_nhanvien
            // 
            this.ql_nhanvien.Name = "ql_nhanvien";
            this.ql_nhanvien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.ql_nhanvien.Size = new System.Drawing.Size(374, 32);
            this.ql_nhanvien.Text = "Quản lý tài khoản";
            this.ql_nhanvien.Click += new System.EventHandler(this.ql_nhanvien_Click);
            // 
            // ql_ncc
            // 
            this.ql_ncc.Name = "ql_ncc";
            this.ql_ncc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.ql_ncc.Size = new System.Drawing.Size(374, 32);
            this.ql_ncc.Text = "Quản lý nhà cung cấp";
            this.ql_ncc.Click += new System.EventHandler(this.ql_ncc_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýĐơnHàngToolStripMenuItem
            // 
            this.quảnLýĐơnHàngToolStripMenuItem.Name = "quảnLýĐơnHàngToolStripMenuItem";
            this.quảnLýĐơnHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.quảnLýĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.quảnLýĐơnHàngToolStripMenuItem.Text = "Quản lý đơn hàng";
            this.quảnLýĐơnHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐơnHàngToolStripMenuItem_Click);
            // 
            // mn_banhang
            // 
            this.mn_banhang.Name = "mn_banhang";
            this.mn_banhang.Size = new System.Drawing.Size(115, 34);
            this.mn_banhang.Text = "&Bán hàng";
            this.mn_banhang.Click += new System.EventHandler(this.mn_banhang_Click);
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.btn_dangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(129, 34);
            this.btn_dangXuat.Text = " &Đăng xuất";
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // mn_thongtin
            // 
            this.mn_thongtin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinPhầnMềmToolStripMenuItem,
            this.hỗTrợToolStripMenuItem1});
            this.mn_thongtin.Name = "mn_thongtin";
            this.mn_thongtin.Size = new System.Drawing.Size(116, 34);
            this.mn_thongtin.Text = "&Thông tin";
            this.mn_thongtin.Click += new System.EventHandler(this.mn_thongtin_Click);
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            this.thôngTinPhầnMềmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.thôngTinPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.thôngTinPhầnMềmToolStripMenuItem.Text = " - Thông tin ";
            this.thôngTinPhầnMềmToolStripMenuItem.Click += new System.EventHandler(this.thôngTinPhầnMềmToolStripMenuItem_Click);
            // 
            // hỗTrợToolStripMenuItem1
            // 
            this.hỗTrợToolStripMenuItem1.Name = "hỗTrợToolStripMenuItem1";
            this.hỗTrợToolStripMenuItem1.Size = new System.Drawing.Size(332, 32);
            this.hỗTrợToolStripMenuItem1.Text = " - Hỗ trợ";
            this.hỗTrợToolStripMenuItem1.Click += new System.EventHandler(this.hỗTrợToolStripMenuItem1_Click);
            // 
            // mn_doiMatKhau
            // 
            this.mn_doiMatKhau.Name = "mn_doiMatKhau";
            this.mn_doiMatKhau.Size = new System.Drawing.Size(154, 34);
            this.mn_doiMatKhau.Text = "&Đổi mật khẩu";
            this.mn_doiMatKhau.Click += new System.EventHandler(this.mn_doiMatKhau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(323, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hello ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_quyen.Location = new System.Drawing.Point(13, 84);
            this.lb_quyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(22, 24);
            this.lb_quyen.TabIndex = 72;
            this.lb_quyen.Text = "..";
            this.lb_quyen.Click += new System.EventHandler(this.lb_quyen_Click);
            // 
            // frm_trangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.lb_quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.Name = "frm_trangChu";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.frm_trangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem mn_quanly;
        public System.Windows.Forms.ToolStripMenuItem ql_nhanvien;
        public System.Windows.Forms.ToolStripMenuItem ql_ncc;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐơnHàngToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mn_banhang;
        public System.Windows.Forms.ToolStripMenuItem btn_dangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem mn_thongtin;
        public System.Windows.Forms.ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_quyen;
        private System.Windows.Forms.ToolStripMenuItem mn_doiMatKhau;
    }
}