using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_QLMP
{
    public partial class GUI_HoaDonNhap : Form
    {
        BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();
        BUS_ChiTietHDN busCT = new BUS_ChiTietHDN();
        BUS_NhanVien busNV = new BUS_NhanVien();
        BUS_NhaCungCap busNCC = new BUS_NhaCungCap();
        BUS_MyPham busMP = new BUS_MyPham();

        DataTable dtNV, dtNCC, dtMP, dtCT, dtHDN, dtSL, dtDG = new DataTable();

        string strNV, strNCC, strMP;
        public GUI_HoaDonNhap()
        {
            InitializeComponent();
        }
        private void GUI_HoaDonNhap_Load(object sender, EventArgs e)
        {
            gndgvHDN.DataSource = busHDN.GetHoaDonNhap();

            dtHDN = busHDN.GetHoaDonNhap();
            gntxtMaHDN.Text = busHDN.tangMa(dtHDN, "hdn01", "hdn", 0, 3);

            dtNV = busNV.GetNhanVien();
            gncbxMaNV.DataSource = dtNV;
            gncbxMaNV.DisplayMember = "hoTenNV";

            dtNCC = busNCC.GetNhaCungCap();
            gncbxMaNCC.DataSource = dtNCC;
            gncbxMaNCC.DisplayMember = "hoTenNCC";

            dtMP = busMP.GetMyPham();
            gncbxMaMP.DataSource = dtMP;
            gncbxMaMP.DisplayMember = "tenMyPham";
        }

        void SetTongTien()
        {
            string maHD = gntxtMaHDN.Text;
            dtCT = busCT.GetChiTietHDN(maHD);
            double tongMoi = 0;
            for (int i = 0; i < gndgvCTHDN.Rows.Count; i++)
            {
                tongMoi += double.Parse(dtCT.Rows[i][4].ToString());
            }
            gntxtTongTien.Text = tongMoi.ToString();
            busHDN.setTongTien(tongMoi, maHD);
        }

        private void gnbtXoaHD_Click(object sender, EventArgs e)
        {
            string ma = gntxtMaHDN.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busHDN.xoaHDN(ma) /*== true && busCT.xoaChiTietHDN(ma) == true*/)
                {
                    MessageBox.Show("Xóa hóa đơn thành công!");
                    gndgvHDN.DataSource = busHDN.GetHoaDonNhap();
                }
            }
        }

        private void gnbtSuaHD_Click(object sender, EventArgs e)
        {
            string maHD = gntxtMaHDN.Text;
            int ChiSoHang1 = gncbxMaNV.SelectedIndex;
            strNV = dtNV.Rows[ChiSoHang1][0].ToString();

            int ChiSoHang2 = gncbxMaNCC.SelectedIndex;
            strNCC = dtNCC.Rows[ChiSoHang2][0].ToString();

            DateTime ngaynhap = DateTime.Parse(gndtNgayNhap.Value.ToShortDateString());
            double tong = double.Parse(gntxtTongTien.Text);
            HoaDonNhap hdn = new HoaDonNhap(maHD, strNV, strNCC, ngaynhap, tong);

            int ChiSoHang3 = gncbxMaMP.SelectedIndex;
            strMP = dtMP.Rows[ChiSoHang3][1].ToString();
            int sl = int.Parse(gntxtSlg.Text);
            double donGia = double.Parse(gntxtDonGia.Text);
            double thanhTien = double.Parse(gntxtThanhTien.Text);
            ChiTietHDN cthdn = new ChiTietHDN(maHD, strMP, sl, donGia, thanhTien);

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn sửa hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busCT.suaChiTietHDN(cthdn))
                {
                    if (busHDN.suaHDN(hdn))
                    {
                        MessageBox.Show("Sửa hóa đơn thành công!");
                        gndgvHDN.DataSource = busHDN.GetHoaDonNhap();
                        gndgvCTHDN.DataSource = busCT.GetChiTietHDN(maHD);
                    }
                }
            }
            SetTongTien();
            gndgvHDN.DataSource = busHDN.GetHoaDonNhap();
        }

        private void gndgvHDN_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            gntxtMaHDN.Text = gndgvHDN[0, hang].Value.ToString();
            gncbxMaNV.Text = gndgvHDN[1, hang].Value.ToString().Trim();
            gncbxMaNCC.Text = gndgvHDN[2, hang].Value.ToString().Trim();
            gndtNgayNhap.Text = gndgvHDN[3, hang].Value.ToString();
            gntxtTongTien.Text = gndgvHDN[4, hang].Value.ToString();
            string maHD = gntxtMaHDN.Text;
            gndgvCTHDN.DataSource = busCT.GetChiTietHDN(maHD);
        }

        private void gndgvCTHDN_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            //string strMaMP = gndgvCTHDN[1, hang].Value.ToString().Trim();
            //for (int i = 0; i < dtMP.Rows.Count - 1; i++)
            //{
            //    if (dtMP.Rows[i][1].ToString().Trim() == strMaMP)
            //    {
            //        gncbxMaMP.Text = dtMP.Rows[i][2].ToString();
            //    }
            //}
            gncbxMaMP.Text = gndgvCTHDN[1, hang].Value.ToString().Trim();
            gntxtSlg.Text = gndgvCTHDN[2, hang].Value.ToString().Trim();
            gntxtDonGia.Text = gndgvCTHDN[3, hang].Value.ToString().Trim();
            gntxtThanhTien.Text = gndgvCTHDN[4, hang].Value.ToString().Trim();
        }

        private void gntxtSlg_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void gntxtThanhTien_TextChanged(object sender, EventArgs e)
        {
            // Dấu phẩy động
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(gntxtThanhTien.Text, NumberStyles.AllowThousands);
            gntxtThanhTien.Text = String.Format(culture, "{0:N0}", value);
            gntxtThanhTien.Select(gntxtThanhTien.Text.Length, 0);
        }

        private void gntxtTongTien_TextChanged(object sender, EventArgs e)
        {
            // Dấu phẩy động
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(gntxtTongTien.Text, NumberStyles.AllowThousands);
            gntxtTongTien.Text = String.Format(culture, "{0:N0}", value);
            gntxtTongTien.Select(gntxtTongTien.Text.Length, 0);
        }

        private void gntxtSlg_TextChanged_1(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg;
            if (gntxtSlg.Text == "")
                sl = 0;
            else
                sl = int.Parse(gntxtSlg.Text);
            if (gntxtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(gntxtDonGia.Text);
            tt = sl * dg;
            gntxtThanhTien.Text = tt.ToString();
        }

        private void gntxtDonGia_TextChanged_1(object sender, EventArgs e)
        {
            //Khi thay đổi đơn giá thì thực hiện tính lại thành tiền
            double tt, sl, dg;
            if (gntxtSlg.Text == "")
                sl = 0;
            else
                sl = int.Parse(gntxtSlg.Text);
            if (gntxtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(gntxtDonGia.Text);
            tt = sl * dg;
            gntxtThanhTien.Text = tt.ToString();

            // Dấu phẩy động
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(gntxtDonGia.Text, NumberStyles.AllowThousands);
            gntxtDonGia.Text = String.Format(culture, "{0:N0}", value);
            gntxtDonGia.Select(gntxtDonGia.Text.Length, 0);
        }

        private void gnbtLamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if(ctr is Guna2TextBox)
                {
                    ctr.Text = "";
                }
            }
            gntxtSlg.Text = "";
            gntxtDonGia.Text = "0";

            dtHDN = busHDN.GetHoaDonNhap();
            gntxtMaHDN.Text = busHDN.tangMa(dtHDN, "hdn01", "hdn", 0, 3);
        }

        private void gnbtTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = gndgvHDN.Rows.Count - 2; i >= 0; i--)
            {
                if (gndgvHDN[0, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvHDN[1, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvHDN[2, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvHDN[3, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false)
                {
                    gndgvHDN.Rows.RemoveAt(i);
                }
            }
        }

        private void gntxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            gndgvHDN.DataSource = busHDN.GetHoaDonNhap();
            gnbtTimKiem_Click(sender, e);
        }

        private void gnbtThemHD_Click(object sender, EventArgs e)
        {
            string maHD = gntxtMaHDN.Text;
            int ChiSoHang1 = gncbxMaNV.SelectedIndex;
            strNV = dtNV.Rows[ChiSoHang1][0].ToString();

            int ChiSoHang2 = gncbxMaNCC.SelectedIndex;
            strNCC = dtNCC.Rows[ChiSoHang2][0].ToString();

            DateTime ngaynhap = DateTime.Parse(gndtNgayNhap.Value.ToShortDateString());
            double tong = double.Parse(gntxtTongTien.Text);
            
            HoaDonNhap hdn = new HoaDonNhap(maHD, strNV, strNCC, ngaynhap, tong);

            if (string.IsNullOrWhiteSpace(maHD) || string.IsNullOrWhiteSpace(strNV) || string.IsNullOrWhiteSpace(strNCC))
            {
                MessageBox.Show("Thông tin hóa đơn không được để trống!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (busHDN.kiemTraMaTrung(maHD) == 0)
                {
                    if (busHDN.themHDN(hdn))
                    {
                        gndgvHDN.DataSource = busHDN.GetHoaDonNhap();
                    }
                }
            }
            int sl = int.Parse(gntxtSlg.Text);
            // Thêm chi tiết hdn
            int ChiSoHang3 = gncbxMaMP.SelectedIndex;
            strMP = dtMP.Rows[ChiSoHang3][1].ToString();
            double donGia = double.Parse(gntxtDonGia.Text);
            // double giamGia = double.Parse(gntxtGiamGia.Text);
            double thanhTien = double.Parse(gntxtThanhTien.Text);
            ChiTietHDN cthdn = new ChiTietHDN(maHD, strMP, sl, donGia, thanhTien);
            if (busCT.kiemTraMaTrung(maHD, strMP) == 1)
            {
                MessageBox.Show("Mã mỹ phẩm đã tồn tại!");
            }
            else if (string.IsNullOrWhiteSpace(maHD) || string.IsNullOrWhiteSpace(strMP))
            {
                MessageBox.Show("Thông tin chi tiết hóa đơn không được để trống!", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                if (busCT.themChiTietHDN(cthdn))
                {
                    gndgvCTHDN.DataSource = busCT.GetChiTietHDN(maHD);
                }
            }
            

            // Cập nhật lại số lượng của mặt hàng vào bảng myPham
            dtSL = busCT.setSoLuongTon(strMP);
            int slt = int.Parse(dtSL.Rows[0][0].ToString());
            slt = slt + sl;
            busCT.themSoLuongTon(slt, strMP);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            SetTongTien();
            gndgvHDN.DataSource = busHDN.GetHoaDonNhap();
        }
    }
}
