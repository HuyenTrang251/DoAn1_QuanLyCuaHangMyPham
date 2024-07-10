using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHDN: clsDatabase
    {
        // Hiển thị danh sách 
        public DataTable GetChiTietHDN(string maHD)
        {
            string strGet = "Select donHangNhapID, tenMyPham, slNhap, dgNhap, thanhTien from chiTietDHN c inner join myPham m on c.myPhamID = m.myPhamID Where donHangNhapID = '"+ maHD +"'";
            return GetDataTable(strGet);
        }

        // Kiểm tra mã trùng
        public int kiemTraMaTrung(string maHD, string maMP)
        {
            string sql = "Select count(*) from chiTietDHN where donHangNhapID = '" + maHD.Trim() + "' and myPhamID = '"+ maMP.Trim() +"'";
            return KiemTraMaTrung(sql);
        }
        
        // Thêm 
        public bool themChiTietHDN(ChiTietHDN ct)
        {
            string sql = "Insert into chiTietDHN values('" + ct.MaHDN2 + "', '" + ct.MaMP + "', '" + ct.SoLuong + "', '"+ ct.DonGia + "', '"+ ct.ThanhTien + "')";
            ThucThi(sql);
            return true;
        }

        // sửa 
        public bool suaChiTietHDN(ChiTietHDN ct)
        {
            string sql = "Update chiTietDHN set slNhap = '" + ct.SoLuong + "', dgNhap = '" + ct.DonGia + "', thanhTien = '" + ct.ThanhTien + "' where donHangNhapID = '" + ct.MaHDN2 + "' and myPhamID = '"+ ct.MaMP +"'";
            ThucThi(sql);
            return true;
        }

        // lấy số lượng tồn
        public DataTable setSoLuongTon(string maMP)
        {
            string sql = "Select slTon from myPham where myPhamID = '" + maMP + "'";
            return GetDataTable(sql);
        }

        // Cập nhật số lượng tồn khi nhập
        public bool themSoLuongTon(int slt, string maMP)
        {
            string sql = "UPDATE myPham SET slTon =" + slt + " WHERE myPhamID = '" + maMP + "'";
            ThucThiPKN(sql);
            return true;
        }

        public bool SetThanhTien(double tt, string maHD, string maMP)
        {
            string sql = "UPDATE chiTietDHN SET thanhTien = '" + tt + "' WHERE donHangNhapID = '" + maHD + "' and myPhamID = '" + maMP + "'";
            ThucThiPKN(sql);
            return true;
        }
    }
}
