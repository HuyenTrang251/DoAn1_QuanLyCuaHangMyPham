using BUS;
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

namespace DoAn1_QLMP
{
    public partial class GUI_DoanhThu : Form
    {
        BUS_HoaDonBan busHD = new BUS_HoaDonBan();
        DataTable dtDT, dtVN, dtLN = new DataTable();
        public GUI_DoanhThu()
        {
            InitializeComponent();
        }

        private void GUI_DoanhThu_Load(object sender, EventArgs e)
        {
            reportViewer1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();

            Thongke("DoAn1_QLMP.RP_TKDoanhThu.rdlc", busHD.TKDoanhThu(DateTime.Parse("1/1/2023"), DateTime.Now));
            this.reportViewer1.RefreshReport();

            dtDT = busHD.TKDoanhThuTheoThang("2024");
            dtVN = busHD.TKVonNhap("2024");
            dtLN = busHD.TKLoiNhuan("2024");
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số tiền";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series["Doanh Thu"]["DrawingStyle"] = "Cylinder";
            chart1.Series["Vốn Nhập"]["DrawingStyle"] = "Cylinder";
            
            for (int i = 0; i < dtDT.Rows.Count; i++)
            {
                chart1.Series["Doanh Thu"].Points.AddXY(dtDT.Rows[i]["thang"], dtDT.Rows[i]["doanhThu"]);
                chart1.Series["Vốn Nhập"].Points.AddXY(dtVN.Rows[i]["thang"], dtVN.Rows[i]["vonNhap"]);
                chart1.Series["Lợi Nhuận"].Points.AddXY(dtLN.Rows[i]["thang"], dtLN.Rows[i]["loiNhuan"]);
            }
        }
        //DateTime d1 = DateTime.Parse(gndtpDay1.Text);
        //DateTime d2 = DateTime.Parse(gndtpDay2.Text);
        private void Thongke(string sql, DataTable dt)
        {
            reportViewer1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.ReportEmbeddedResource = sql;
            ReportDataSource rpDataSourse = new ReportDataSource();
            rpDataSourse.Name = "DataSet1";
            rpDataSourse.Value = dt;
            reportViewer1.LocalReport.DataSources.Add(rpDataSourse);
            this.reportViewer1.RefreshReport();
        }

        private void gnbtThongKe_Click(object sender, EventArgs e)
        {
            dtDT = busHD.TKDoanhThuTheoThang(gntxtTK.Text);
            dtVN = busHD.TKVonNhap(gntxtTK.Text);
            dtLN = busHD.TKLoiNhuan(gntxtTK.Text);
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số tiền";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //chart1.Series["Doanh Thu"]["DrawingStyle"] = "Cylinder";
            //chart1.Series["Vốn Nhập"]["DrawingStyle"] = "Cylinder";
            chart1.Series["Lợi Nhuận"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series["Doanh Thu"].Points.Clear();
            chart1.Series["Vốn Nhập"].Points.Clear();
            chart1.Series["Lợi Nhuận"].Points.Clear();

            for (int i = 0; i < dtDT.Rows.Count; i++)
            {
                chart1.Series["Doanh Thu"].Points.AddXY(dtDT.Rows[i]["thang"], dtDT.Rows[i]["doanhThu"]);
                chart1.Series["Vốn Nhập"].Points.AddXY(dtVN.Rows[i]["thang"], dtVN.Rows[i]["vonNhap"]);
                chart1.Series["Lợi Nhuận"].Points.AddXY(dtLN.Rows[i]["thang"], dtLN.Rows[i]["loiNhuan"]);
            }
            //
            reportViewer1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();
            Thongke("DoAn1_QLMP.RP_TKDoanhThu.rdlc", busHD.TKDoanhThu(DateTime.Parse(gndtpDay1.Text), DateTime.Parse(gndtpDay2.Text)));
            this.reportViewer1.RefreshReport();
        }
    }
}
