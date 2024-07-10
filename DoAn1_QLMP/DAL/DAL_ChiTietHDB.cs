using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHDB: clsDatabase
    {
        // Hiển thị danh sách 
        public DataTable GetChiTietHDB(string maHD)
        {
            string strGet = "Select donHangBanID, tenMyPham, slBan, dgBan, giamGia, thanhTien from chiTietDHB c inner join myPham m on c.myPhamID = m.myPhamID Where donHangBanID = '" + maHD + "'";
            return GetDataTable(strGet);
        }

        // Kiểm tra mã trùng
        public int kiemTraMaTrung(string maHD, string maMP)
        {
            string sql = "Select count(*) from chiTietDHB where donHangBanID = '" + maHD.Trim() + "' and myPhamID = '" + maMP.Trim() + "'";
            return KiemTraMaTrung(sql);
        }

        // Thêm 
        public bool themChiTietHDB(ChiTietHDB ct)
        {
            string sql = "Insert into chiTietDHB values('" + ct.MaHDB + "', '" + ct.MaMP + "', '" + ct.SlBan + "', " + ct.GiamGia +", "+ ct.ThanhTien +")";
            ThucThi(sql);
            return true;
        }

        // Lấy đơn giá bán
        public DataTable getDonGiaBan(string maMP)
        {
            string sql = "Select dgBan from myPham where myPhamID = '" + maMP + "'";
            return GetDataTable(sql);
        }

        // Lấy số lượng tồn
        public DataTable getSoLuongTon(string maMP)
        {
            string sql = "Select slTon from myPham where myPhamID = '"+ maMP+"'";
            return GetDataTable(sql);
        }

        // Lấy số lượng tồn
        public DataTable getSoLuongBan(string maHD, string maMP)
        {
            string sql = "Select slBan from chiTietDHB where donHangBanID = '" + maHD.Trim() + "' and myPhamID = '" + maMP.Trim() + "'";
            return GetDataTable(sql);
        }

        // Cập nhật số lượng tồn khi nhập
        public bool themSoLuongTon(int slt, string maMP)
        {
            string sql = "UPDATE myPham SET slTon = "+ slt +" WHERE myPhamID = '" + maMP + "'";
            ThucThiPKN(sql);
            return true;
        }

        public bool SetThanhTien(double tt, string maHD, string maMP)
        {
            string sql = "UPDATE chiTietDHB SET thanhTien = '" + tt + "' WHERE donHangBanID = '" + maHD + "' and myPhamID = '" + maMP + "'";
            ThucThiPKN(sql);
            return true;
        }
    }
}
