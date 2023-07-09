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
    public partial class frm_XuatHoaDon : Form
    {
        public frm_XuatHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XuatHoaDon xhd = new XuatHoaDon();
            crystalReportViewer1.ReportSource = xhd;
            crystalReportViewer1.Refresh();
        }
    }
}
