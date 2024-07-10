using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDonNhap: clsDatabase
    {
        // Hiển thị danh sách 
        public DataTable GetHoaDonNhap()
        {
            string strGet = "Select donHangNhapID, hoTenNV, hoTenNCC, ngayNhap, tongTien from donHangNhap d Inner join nhanVien n on d.nhanVienID = n.nhanVienID inner join nhaCC nh on d.nhaCCID = nh.nhaCCID";
            return GetDataTable(strGet);
        }

        // Kiểm tra mã trùng
        public int kiemTraMaTrung(string ma)
        {
            string sql = "Select count(*) from donHangNhap where donHangNhapID = '" + ma.Trim() + "'";
            return KiemTraMaTrung(sql);
        }

        // Thêm 
        public bool themHDN(HoaDonNhap hdn)
        {
            string sql = "Insert into donHangNhap values('" + hdn.MaHDN + "', '" + hdn.MaNhanvien + "', '" + hdn.MaNhaCungCap + "', '" + hdn.NgayNhap + "', '"+ hdn.TongTien +"')";
            ThucThi(sql);
            return true;
        }

        // sửa 
        public bool suaHDN(HoaDonNhap hdn)
        {
            string sql = "Update donHangNhap set nhanVienID = '" + hdn.MaNhanvien + "', nhaCCID = '" + hdn.MaNhaCungCap + "', ngayNhap = '" + hdn.NgayNhap + "', tongTien = "+ hdn.TongTien +" where donHangNhapID = '" + hdn.MaHDN + "'";
            ThucThi(sql);
            return true;
        }

        // xóa 
        public bool xoaHDN(string ma)
        {
            string sql = "Delete from donHangNhap where donHangNhapID = '" + ma + "'";
            ThucThi(sql);
            return true;
        }
        public bool setTongTien(double tt, string maHD)
        {
            string sql = "UPDATE donHangNhap SET tongTien = "+ tt +" WHERE donHangNhapID = '" + maHD + "'";
            ThucThi(sql);
            return true;
        }
    }
}
