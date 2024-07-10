using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDonBan: clsDatabase
    {
        // Hiển thị danh sách 
        public DataTable GetHoaDonBan()
        {
            string strGet = "Select donHangBanID, hoTenNV, hoTenKH, ngayBan, tongTien from donHangBan d Inner join nhanVien n on d.nhanVienID = n.nhanVienID inner join khachHang k on d.khachHangID = k.khachHangID  where d.trangThai = "+ 1 +"";
            return GetDataTable(strGet);
        }
        // Lấy danh sách hdb bị hủy
        public DataTable GetHuyHDB()
        {
            string strGet = "Select donHangBanID, hoTenNV, hoTenKH, ngayBan, tongTien, tgHuy from donHangBan d Inner join nhanVien n on d.nhanVienID = n.nhanVienID inner join khachHang k on d.khachHangID = k.khachHangID where d.trangThai = " + 0 + "";
            return GetDataTable(strGet);
        }

        // Kiểm tra mã trùng
        public int kiemTraMaTrung(string ma)
        {
            string sql = "Select count(*) from donHangBan where donHangBanID = '" + ma.Trim() + "'";
            return KiemTraMaTrung(sql);
        }

        // Thêm 
        public bool themHDB(HoaDonBan hdb)
        {
            string sql = "Insert into donHangBan values('" + hdb.MaHDB + "', '" + hdb.MaNV + "', '" + hdb.MaKH + "', '" + hdb.NgayBan + "', '" + hdb.TrangThai +"', '" + hdb.TongTien + "', '" + hdb.TgHuy +"')";
            ThucThi(sql);
            return true;
        }

        // Hủy
        public bool huyHDB(string ma)
        {
            string sql = "Update donHangBan set trangThai = "+ 0 +", tgHuy = '"+ DateTime.Now +"' where donHangBanID = '" + ma + "'";
            ThucThi(sql);
            return true;
        }

        // Khôi phục
        public bool khoiPhucHDB(string ma)
        {
            DateTime day = DateTime.Parse("2024-1-1");
            string sql = "Update donHangBan set trangThai = " + 1 + ", tgHuy = '" + day + "' where donHangBanID = '" + ma + "'";
            ThucThi(sql);
            return true;
        }

        // xóa 
        public bool xoaHDB(string ma)
        {
            string sql = "Delete from donHangBan where donHangBanID = '" + ma + "'";
            ThucThi(sql);
            return true;
        }

        public bool setTongTien(double tt, string maHD)
        {
            string sql = "UPDATE donHangBan SET tongTien = " + tt + " WHERE donHangBanID = '" + maHD + "'";
            ThucThi(sql);
            return true;
        }

        public DataTable TKDoanhThuTheoThang(string year)
        {
            string strGet = "SELECT * FROM ThongKeDoanhThuTheoThang('"+ year +"') ORDER BY thang";
            return GetDataTable(strGet);
        }

        public DataTable TKDoanhThu(DateTime d1, DateTime d2)
        {
            string strGet = "SELECT * FROM fn_ThongKeDoanhThu('"+ d1 +"', '"+ d2 +"')";
            return GetDataTable(strGet);
        }
        public DataTable TKVonNhap(string year)
        {
            string strGet = "SELECT * FROM ThongKeVonNhapTheoThang('" + year + "') ORDER BY thang";
            return GetDataTable(strGet);
        }

        public DataTable TKLoiNhuan(string year)
        {
            string strGet = "SELECT * FROM ThongKeLoiNhuan('" + year + "') ORDER BY thang";
            return GetDataTable(strGet);
        }
    }
}
