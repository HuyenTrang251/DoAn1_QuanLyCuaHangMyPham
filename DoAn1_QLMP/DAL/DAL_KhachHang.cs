using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang : clsDatabase
    {
        // Hiển thị danh sách 
        public DataTable GetKhachHang()
        {
            string strGetKH = "Select khachHangID, hoTenKH, diaChiKH, sdtKH from khachHang where trangthai = "+ 1 +"";
            return GetDataTable(strGetKH);
        }

        // Kiểm tra mã trùng
        public int kiemTraMaTrung(string ma)
        {
            string sql = "Select count(*) from khachHang where khachHangID = '" + ma.Trim() + "'";
            return KiemTraMaTrung(sql);
        }

        // Thêm 
        public bool themKH(KhachHang kh)
        {
            string sql = "Insert into khachHang values('" + kh.MaKhachHang + "', N'" + kh.TenKhachHang + "', N'" + kh.DiaChiKH + "', '" + kh.SdtKH + "' , "+ 1 +")";
            ThucThi(sql);
            return true;
        }

        // sửa 
        public bool suaKH(KhachHang kh)
        { 
            string sql = "Update khachHang set hoTenKH = N'" + kh.TenKhachHang + "', diaChiKH = N'" + kh.DiaChiKH + "', sdtKH = '" + kh.SdtKH + "' where khachHangID = '" + kh.MaKhachHang + "'";
            ThucThi(sql);
            return true;
        }

        // xóa 
        public bool xoaKH(string ma)
        {
            //string sql = "Delete from khachHang where khachHangID = '" + ma + "'";
            string sql = "Update khachHang set trangthai = " + 0 + " where khachHangID = '" + ma + "'";
            ThucThi(sql);
            return true;
        }
        public DataTable GetSdtKH(string ma)
        {
            string strGetKH = "Select sdtKH from khachHang where khachHangID = '"+ ma +"'";
            return GetDataTable(strGetKH);
        }
    }
}
