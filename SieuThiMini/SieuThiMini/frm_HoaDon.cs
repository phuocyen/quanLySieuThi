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
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            CrystalReport1 hd = new CrystalReport1();
            crpHoaDon.ReportSource = hd;
            crpHoaDon.Refresh();
        }
    }
}
