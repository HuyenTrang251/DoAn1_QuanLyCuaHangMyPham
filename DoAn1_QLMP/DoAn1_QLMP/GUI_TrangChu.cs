using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DoAn1_QLMP
{
    public partial class GUI_TrangChu : Form
    {
        DangNhap dn = new DangNhap();
        
        BUS_DangNhap busDN = new BUS_DangNhap();
        BUS_HoaDonBan busHDB = new BUS_HoaDonBan();
        BUS_ChiTietHDB busCT = new BUS_ChiTietHDB();
        BUS_NhanVien busNV = new BUS_NhanVien();
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_MyPham busMP = new BUS_MyPham();
        DangNhap DangNhap = new DangNhap();
        DataTable dtNV, dtKH, dtMP, dtCT, dtHDB, dtSLT, dtSLB, dtDG = new DataTable();

        string strNV, strKH, strMP;

        public GUI_TrangChu(string tenTK, string mK, string quyen)
        {
            InitializeComponent();
            custonizeDesing();
            this.dn = new DangNhap(tenTK, mK, quyen);
        }
        
        // Tạo menu chức năng
        private void custonizeDesing()
        {
            pnMenuMP.Visible = false;
            pnMenuQuanLy.Visible = false;
            pnMenuHeThong.Visible = false;
            pnMenuThongKe.Visible = false;
        }
        private void hideMenu()
        {
            if (pnMenuMP.Visible)
            {
                pnMenuMP.Visible = false;
            }
            if (pnMenuQuanLy.Visible)
            {
                pnMenuQuanLy.Visible = false;
            }
            if (pnMenuThongKe.Visible)
            {
                pnMenuThongKe.Visible = false;
            }
            if (pnMenuHeThong.Visible)
            {
                pnMenuHeThong.Visible = false;
            }
        }
        private void showMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hideMenu(); 
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btnMenuMP_Click(object sender, EventArgs e)
        {
            showMenu(pnMenuMP);
        }

        private void btnMenuQL_Click(object sender, EventArgs e)
        {
            showMenu(pnMenuQuanLy);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dn.Quyen.Trim() == "AM")
            {
                showMenu(pnMenuThongKe);
            }
            else MessageBox.Show("Bạn không có quyền thống kê");
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showMenu(pnMenuHeThong);
        }

        // Tạo form con form cha
        private Form currentFormChild;
        private void OpenChildForm(Form ChildF)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildF;
            ChildF.TopLevel = false;
            ChildF.FormBorderStyle = FormBorderStyle.None;
            ChildF.Dock = DockStyle.Fill;
            pnBody.Controls.Add(ChildF);
            pnBody.Tag = ChildF;
            ChildF.BringToFront();
            ChildF.Show();
        }

        private void btnLoaiMP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_LoaiMyPham());
            //hideMenu();
        }

        private void btnMyPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_MyPham());
            //hideMenu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_KhachHang());
            //hideMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (dn.Quyen.Trim() == "AM")
            {
                OpenChildForm(new GUI_NhanVien());
                //hideMenu();
            }
            else MessageBox.Show("Bạn không có quyền mở nhân viên");
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_NhaCungCap());
            //hideMenu();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_HoaDonNhap());
        }

        private void btTKMyPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_ThongKe());
        }

        private void btTKDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_DoanhThu());
        }
        private void btnĐMK_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_DoiMatKhau());
        }

        private void btnLS_Click_1(object sender, EventArgs e)
        {
            if (dn.Quyen.Trim() == "AM")
            {
                OpenChildForm(new GUI_LichSuHuy());
            }
            else MessageBox.Show("Bạn không có quyền :D !");
        }

        private void btĐX_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GUI_DangNhap gDN = new GUI_DangNhap();
            gDN.ShowDialog();
            this.Close();
        }

        private void gnbtnTrangChu_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void GUI_TrangChu_Load(object sender, EventArgs e)
        {
            gndgvHDB.DataSource = busHDB.GetHoaDonBan();

            dtHDB = busHDB.GetHoaDonBan();
            gntxtMaHDB.Text = busHDB.tangMa(dtHDB, "hdb01", "hdb", 0, 3);

            dtNV = busNV.GetNhanVien();
            gncbxMaNV.DataSource = dtNV;
            gncbxMaNV.DisplayMember = "hoTenNV";

            dtKH = busKH.GetKhachHang();
            gncbxMaKH.DataSource = dtKH;
            gncbxMaKH.DisplayMember = "hoTenKH";

            dtMP = busMP.GetMyPham();
            gncbxMaMP.DataSource = dtMP;
            gncbxMaMP.DisplayMember = "TenMyPham";
        }
       
        private void gndgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            gntxtMaHDB.Text = gndgvHDB[0, hang].Value.ToString();
            gncbxMaNV.Text = gndgvHDB[1, hang].Value.ToString().Trim();
            //string strMaNV = gndgvHDB[1, hang].Value.ToString().Trim();
            //for (int i = 0; i < dtNV.Rows.Count -1; i++)
            //{
            //    if (dtNV.Rows[i][0].ToString().Trim() == strMaNV)
            //    {
            //        gncbxMaNV.Text = dtNV.Rows[i][1].ToString();
            //    }
            //}
            gncbxMaKH.Text = gndgvHDB[2, hang].Value.ToString().Trim();
            //string strMaKH = gndgvHDB[2, hang].Value.ToString().Trim();
            //for (int i = 0; i < dtKH.Rows.Count -1; i++)
            //{
            //    if (dtKH.Rows[i][0].ToString().Trim() == strMaKH)
            //    {
            //        gncbxMaKH.Text = dtKH.Rows[i][1].ToString();
            //    }
            //}
            gndtNgayBan.Text = gndgvHDB[3, hang].Value.ToString();
            gntxtTongTien.Text = gndgvHDB[4, hang].Value.ToString();
            string maHD = gntxtMaHDB.Text;
            gndgvCTHDB.DataSource = busCT.GetChiTietHDB(maHD);
        }
        private void gndgvCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            //string strMaMP = gndgvCTHDB[1, hang].Value.ToString().Trim();
            //for (int i = 0; i < dtMP.Rows.Count - 1; i++)
            //{
            //    if (dtMP.Rows[i][1].ToString().Trim() == strMaMP)
            //    {
            //        gncbxMaMP.Text = dtMP.Rows[i][2].ToString();
            //    }
            //}
            gncbxMaMP.Text = gndgvCTHDB[1, hang].Value.ToString().Trim();
            gntxtSlg.Text = gndgvCTHDB[2, hang].Value.ToString().Trim();
            gntxtDonGia.Text = gndgvCTHDB[3, hang].Value.ToString().Trim();
            gntxtGiamGia.Text = gndgvCTHDB[4, hang].Value.ToString();
            gntxtThanhTien.Text = gndgvCTHDB[5, hang].Value.ToString().Trim();
        }
        void SetTongTien()
        {
            string maHD = gntxtMaHDB.Text;
            dtCT = busCT.GetChiTietHDB(maHD);
            double tongMoi = 0;
            for (int i = 0; i < gndgvCTHDB.Rows.Count; i++)
            {
                tongMoi += double.Parse(dtCT.Rows[i][5].ToString());
            }
            gntxtTongTien.Text = tongMoi.ToString();
            busHDB.setTongTien(tongMoi, maHD);
        }
       
        private void gntxtGiamGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (gntxtSlg.Text == "")
                sl = 0;
            else
                sl = int.Parse(gntxtSlg.Text);
            if (gntxtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(gntxtDonGia.Text);
            if (gntxtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(gntxtGiamGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            gntxtThanhTien.Text = tt.ToString();
        }

        private void gnbtHuyHD_Click(object sender, EventArgs e)
        {
            string maHD = gntxtMaHDB.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busHDB.huyHDB(maHD))
                {
                    MessageBox.Show("Hủy hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gndgvHDB.DataSource = busHDB.GetHoaDonBan();
                }
            }
            //dtCT = busCT.GetChiTietHDB(maHD);
            //for (int i =0; i< dtCT.Rows.Count; i++)
            //{
            //    string maMP = dtCT.Rows[i][1].ToString();
            //    dtSLT = busCT.getSoLuongTon(maMP);
            //    dtSLB = busCT.getSoLuongBan(maHD, maMP);
            //    int slt = int.Parse(dtSLT.Rows[0][0].ToString());
            //    int slb = int.Parse(dtSLB.Rows[0][0].ToString());
            //    slt = slt + slb;
            //    busCT.themSoLuongTon(slt, maMP);
            //}
            gndgvHDB.DataSource = busHDB.GetHoaDonBan();
        }
        private void gncbxMaMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ChiSoHangMP = gncbxMaMP.SelectedIndex;
            strMP = dtMP.Rows[ChiSoHangMP][1].ToString();
            dtDG = busCT.getDonGiaBan(strMP);
            gntxtDonGia.Text = dtDG.Rows[0][0].ToString();
        }

        private void gntxtSlg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void gntxtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gntxtDonGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi đơn giá thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (gntxtSlg.Text == "")
                sl = 0;
            else
                sl = int.Parse(gntxtSlg.Text);
            if (gntxtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(gntxtDonGia.Text);
            if (gntxtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(gntxtGiamGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            gntxtThanhTien.Text = tt.ToString();

            // Dấu phẩy động
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(gntxtDonGia.Text, NumberStyles.AllowThousands);
            gntxtDonGia.Text = String.Format(culture, "{0:N0}", value);
            gntxtDonGia.Select(gntxtDonGia.Text.Length, 0);
        }

        private void gntxtSlg_TextChanged_1(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (gntxtSlg.Text == "")
                sl = 0;
            else
                sl = int.Parse(gntxtSlg.Text);
            if (gntxtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(gntxtDonGia.Text);
            if (gntxtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(gntxtGiamGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            gntxtThanhTien.Text = tt.ToString();
        }

        private void gnbtThemHD_Click(object sender, EventArgs e)
        {
            string maHD = gntxtMaHDB.Text;
            int ChiSoHang1 = gncbxMaNV.SelectedIndex;
            strNV = dtNV.Rows[ChiSoHang1][0].ToString();

            int ChiSoHang2 = gncbxMaKH.SelectedIndex;
            strKH = dtKH.Rows[ChiSoHang2][0].ToString();

            DateTime ngayBan = DateTime.Parse(gndtNgayBan.Text);
            int trangThai = 1;
            double tong = double.Parse(gntxtTongTien.Text);
            DateTime tgHuy = DateTime.Parse("1/1/2024");

            HoaDonBan hdb = new HoaDonBan(maHD, strNV, strKH, ngayBan, trangThai, tong, tgHuy);

            if (string.IsNullOrWhiteSpace(maHD) || string.IsNullOrWhiteSpace(strNV) || string.IsNullOrWhiteSpace(strKH))
            {
                MessageBox.Show("Thông tin hóa đơn không được để trống!", "Thông báo", MessageBoxButtons.OK);
            }
            
            int ChiSoHang3 = gncbxMaMP.SelectedIndex;
            strMP = dtMP.Rows[ChiSoHang3][1].ToString();
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            dtSLT = busCT.getSoLuongTon(strMP);
            int slt = int.Parse(dtSLT.Rows[0][0].ToString());
            int sl = int.Parse(gntxtSlg.Text);
            if (sl > slt)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + slt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gntxtSlg.Text = "";
                gntxtSlg.Focus();
                return;
            }
            
            if (busHDB.kiemTraMaTrung(maHD) == 0)
            {
                if (busHDB.themHDB(hdb))
                {
                    gndgvHDB.DataSource = busHDB.GetHoaDonBan();
                }
            }
            
            // Thêm chi tiết hdn
            double donGia = double.Parse(gntxtDonGia.Text);
            int giamGia = int.Parse(gntxtGiamGia.Text);
            double thanhTien = double.Parse(gntxtThanhTien.Text);
            ChiTietHDB cthdb = new ChiTietHDB(maHD, strMP, sl, giamGia, thanhTien);

            if (string.IsNullOrWhiteSpace(maHD) || string.IsNullOrWhiteSpace(strMP))
            {
                MessageBox.Show("Thông tin chi tiết hóa đơn không được để trống!", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                if (busCT.themChiTietHDB(cthdb))
                {
                    gndgvCTHDB.DataSource = busCT.GetChiTietHDB(maHD);
                }
            }
            
            // Cập nhật lại số lượng của mặt hàng vào bảng myPham
            slt = slt - sl;
            busCT.themSoLuongTon(slt, strMP);

            // Cập nhật lại tổng tiền cho hóa đơn bán
            SetTongTien();
            gndgvHDB.DataSource = busHDB.GetHoaDonBan();

        }

        private void gnbtTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = gndgvHDB.Rows.Count - 2; i >= 0; i--)
            {
                if (gndgvHDB[0, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvHDB[1, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvHDB[2, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvHDB[3, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false)
                {
                    gndgvHDB.Rows.RemoveAt(i);
                }
            }
        }
        private void gntxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            gndgvHDB.DataSource = busHDB.GetHoaDonBan();
            gnbtTimKiem_Click(sender, e);
        }

        private void gnbtLamMoi_Click(object sender, EventArgs e)
        {
            dtHDB = busHDB.GetHoaDonBan();
            gntxtMaHDB.Text = busHDB.tangMa(dtHDB, "hdb01", "hdb", 0, 3);

            //foreach (Control ctr in this.groupBox1.Controls)
            //{
            //    if (ctr is Guna2TextBox)
            //    {
            //        ctr.Text = "";
            //    }
            //}

            gntxtSlg.Text = "";
            gntxtGiamGia.Text = "";

        }

        // in hóa đơn
        private void pdHD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string tenShop = "MỸ PHẨM TRANG NHI";
            string diaChi = "Địa chỉ: Số 25 Nguyễn Thiện Thuật - Mỹ Hào - Hưng Yên";
            string sdt = "Điện thoại: 0999999999";
            string maHD = gntxtMaHDB.Text;
            string tenKH = gncbxMaKH.Text;
            //
            int ChiSoHang2 = gncbxMaKH.SelectedIndex;
            strKH = dtKH.Rows[ChiSoHang2][0].ToString();
            DataTable dtSdtKH = busKH.GetSdtKH(strKH);
            string sdtKH = dtSdtKH.Rows[0][0].ToString();
            //
            DateTime ngayBan = DateTime.Parse(gndtNgayBan.Text);
            // lấy bề rộng hóa đơn
            var w = pdHD.DefaultPageSettings.PaperSize.Width;

            // vẽ header bill hóa đơn
            e.Graphics.DrawString(tenShop, new Font("Courier New", 25, FontStyle.Bold), Brushes.Black, new Point(230, 50));
            e.Graphics.DrawString(diaChi, new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString(sdt, new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(275, 135));

            // định dạng bút vẽ
            Pen blackPen = new Pen(Color.Black, 1);

            // tọa độ chiều dọc
            var y = 170;

            // định nghĩa 2 điểm để vẽ đường thẳng
            Point p1 = new Point(250, y);
            Point p2 = new Point(w - 260, y);

            // kẻ đường thẳng thứ 1
            e.Graphics.DrawLine(blackPen, p1, p2);

            e.Graphics.DrawString("BILL THANH TOÁN", new Font("Courier New", 20, FontStyle.Bold), Brushes.Black, new Point(285, 200));
            e.Graphics.DrawString(maHD, new Font("Courier New", 20, FontStyle.Bold), Brushes.Black, new Point(w - 170, 200));

            e.Graphics.DrawString(string.Format("Tên khách hàng:    {0}", tenKH), new Font("Tahoma", 15, FontStyle.Regular), Brushes.Black, new Point(70, 260));
            e.Graphics.DrawString(string.Format("Số điện thoại:         {0}", sdtKH), new Font("Tahoma", 15, FontStyle.Regular), Brushes.Black, new Point(70, 295));
            e.Graphics.DrawString(string.Format("Ngày bán:              {0}/{1}/{2}", ngayBan.Day, ngayBan.Month, ngayBan.Year), new Font("Tahoma", 15, FontStyle.Regular), Brushes.Black, new Point(70, 330));

            y = 390;

            // định nghĩa 2 điểm để vẽ đường thẳng
            Point p3 = new Point(10, y);
            Point p4 = new Point(w - 10, y);

            // kẻ đường thẳng thứ 1
            e.Graphics.DrawLine(blackPen, p3, p4);

            // vẽ chi tiết hóa đơn
            y += 20;
            e.Graphics.DrawString("STT", new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(20, y));
            e.Graphics.DrawString("Tên mỹ phẩm", new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(80, y));
            e.Graphics.DrawString("SL", new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(w/2, y));
            e.Graphics.DrawString("ĐG", new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(w/2 + 75, y));
            e.Graphics.DrawString("Giảm(%)", new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(w/2 + 155, y));
            e.Graphics.DrawString("Thành tiền", new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(w-165, y));

            // tọa độ chiều dọc
            y += 40;

            // định nghĩa 2 điểm để vẽ đường thẳng
            Point p5 = new Point(10, y);
            Point p6 = new Point(w - 10, y);

            // kẻ đường thẳng thứ 1
            e.Graphics.DrawLine(blackPen, p5, p6);

            // lấy dữ liệu chi tiết hóa đơn
            dtCT = busCT.GetChiTietHDB(maHD);

            int i = 1;
            y += 30;
            for (int h = 0; h < dtCT.Rows.Count; h++)
            {
                e.Graphics.DrawString(string.Format("{0}", i++), new Font("Courier New", 15, FontStyle.Regular), Brushes.Black, new Point(30, y));
                e.Graphics.DrawString(dtCT.Rows[h][1].ToString(), new Font("Courier New", 15, FontStyle.Regular), Brushes.Black, new Point(80, y));
                e.Graphics.DrawString(dtCT.Rows[h][2].ToString(), new Font("Courier New", 15, FontStyle.Regular), Brushes.Black, new Point(w / 2, y));

                decimal value1 = decimal.Parse(dtCT.Rows[h][3].ToString(), NumberStyles.AllowThousands);
                e.Graphics.DrawString(string.Format("{0:N0}", value1), new Font("Courier New", 15, FontStyle.Regular), Brushes.Black, new Point(w / 2 + 55, y));
                e.Graphics.DrawString(dtCT.Rows[h][4].ToString(), new Font("Courier New", 15, FontStyle.Regular), Brushes.Black, new Point(w / 2 + 188, y));

                decimal value2 = decimal.Parse(dtCT.Rows[h][5].ToString(), NumberStyles.AllowThousands);
                e.Graphics.DrawString(string.Format("{0:N0}", value2), new Font("Courier New", 15, FontStyle.Regular), Brushes.Black, new Point(w - 140, y));
                y += 40;
            }

            y += 30;
            Point p7 = new Point(10, y);
            Point p8 = new Point(w - 10, y);

            // kẻ đường thẳng thứ 1
            e.Graphics.DrawLine(blackPen, p7, p8);

            // tổng tiền thanh toán
            y += 30;
            e.Graphics.DrawString("Tổng tiền: ", new Font("Courier New", 20, FontStyle.Bold), Brushes.Black, new Point(20, y));
            e.Graphics.DrawString(gntxtTongTien.Text, new Font("Courier New", 20, FontStyle.Bold), Brushes.Black, new Point(w-200, y));

            y += 60;
            e.Graphics.DrawString("Xin chân thành cảm ơn quý khách!", new Font("Courier New", 20, FontStyle.Italic), Brushes.Black, new Point(115, y));

        }
        private void InHoaDon()
        {
            ppdHD.Document = pdHD;
            ppdHD.ShowDialog();
        }
        private void gnbtThanhToan_Click(object sender, EventArgs e)
        {
            InHoaDon();
        }

    }
}
