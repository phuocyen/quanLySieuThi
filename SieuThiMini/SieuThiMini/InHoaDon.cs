using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini
{
    public partial class InHoaDon : Form
    {
        public static string sqlcon = @"Data Source=LAPTOP-UG51KT2A\SQLEXPRESS;Initial Catalog=QLST_TT;Integrated Security= True";
        string sql;
        public InHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            //cn = new SqlConnection(sqlcon);
            //sql="select * from chitietdonhang where chitietdonhang.maphieuxuat=N'""'"
            HoaDon rpt = new HoaDon();
            rpt.SetDatabaseLogon("sa","123","LAPTOP-UG51KT2A\\SQLEXPRESS","QLST_TT");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
