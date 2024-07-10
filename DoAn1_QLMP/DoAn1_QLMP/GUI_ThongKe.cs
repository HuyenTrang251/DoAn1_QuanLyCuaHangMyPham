using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace DoAn1_QLMP
{
    public partial class GUI_ThongKe : Form
    {

        BUS_MyPham busMP = new BUS_MyPham();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
            gndtp1.Visible = false;
            gndtp2.Visible = false;
            gntxtTK.Visible = false;
            gnbtTK.Visible = false;
            gnbtTKBC.Visible = false;
            //
            rvFullHan.Clear();
            Thongke(rvFullHan, "DoAn1_QLMP.RP_HanSuDung.rdlc", busMP.HSDMyPham());
            
            //
            rvHan1Nam.Clear();
            Thongke(rvHan1Nam, "DoAn1_QLMP.RP_MPHetHan.rdlc", busMP.HSDMyPham1Nam());
            
            //
            this.reportViewer1.RefreshReport();
            this.rvFullHan.RefreshReport();
            this.rvHan1Nam.RefreshReport();
        }
        
        private void Thongke(ReportViewer rp, string sql, DataTable dt)
        {
            rp.Clear();
            rp.LocalReport.DataSources.Clear();

            rp.LocalReport.ReportEmbeddedResource = sql;
            ReportDataSource rpDataSourse = new ReportDataSource();
            rpDataSourse.Name = "DataSet1";
            rpDataSourse.Value = dt;
            rp.LocalReport.DataSources.Add(rpDataSourse);
        }
        private void tsmnMyPhamTon_Click(object sender, EventArgs e)
        {
            reportViewer1.Clear();
            rvFullHan.Visible = false;
            rvHan1Nam.Visible = false;
            //
            gndtp1.Visible = false;
            gndtp2.Visible = false;
            gnbtTKBC.Visible = false;
            //
            gntxtTK.Visible = true;
            gnbtTK.Visible = true;
        }

        private void tsmnMyPhamBanChay_Click(object sender, EventArgs e)
        {
            reportViewer1.Clear();
            rvFullHan.Visible = false;
            rvHan1Nam.Visible = false;
            //
            gntxtTK.Visible = false;
            gnbtTK.Visible = false;
            //
            gndtp1.Visible = true;
            gndtp2.Visible = true;
            gnbtTKBC.Visible = true;
        }

        private void gnbtTK_Click(object sender, EventArgs e)
        {
            reportViewer1.Clear();
            Thongke(reportViewer1, "DoAn1_QLMP.RP_MyPhamTon.rdlc", busMP.TKMyPham(int.Parse(gntxtTK.Text)));
            this.reportViewer1.RefreshReport();
        }

        private void gnbtTKBC_Click(object sender, EventArgs e)
        {
            reportViewer1.Clear();
            Thongke(reportViewer1, "DoAn1_QLMP.RP_MyPhamBC.rdlc", busMP.MyPhamBC(DateTime.Parse(gndtp1.Text), DateTime.Parse(gndtp2.Text)));
            this.reportViewer1.RefreshReport();
        }

        private void tsmnHanSuDung_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            rvFullHan.Visible = true;
            rvHan1Nam.Visible = true;
            GUI_ThongKe_Load(sender, e);
        }
    }
}
