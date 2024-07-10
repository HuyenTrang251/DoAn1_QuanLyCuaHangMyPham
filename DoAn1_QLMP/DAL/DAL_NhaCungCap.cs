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
    public class DAL_NhaCungCap : clsDatabase
    {
        // Hiển thị danh sách 
        public DataTable GetNhaCungCap()
        {
            string strGetNCC = "Select nhaCCID, hoTenNCC, diaChiNCC, sdtNCC from nhaCC where trangThai = "+ 1 +"";
            return GetDataTable(strGetNCC);
        }

        // Kiểm tra mã trùng
        public int kiemTraMaTrung(string ma)
        {
            string sql = "Select count(*) from nhaCC where nhaCCID = '" + ma.Trim() + "'";
            return KiemTraMaTrung(sql);
        }

        // Thêm 
        public bool themNCC(NhaCungCap ncc)
        {
            string sql = "Insert into nhaCC values('" + ncc.MaNCC + "', N'" + ncc.TenNCC + "', N'" + ncc.DiaChiNCC +"', '"+ ncc.SdtNCC +"', "+ 1 +")";
            ThucThi(sql);
            return true;
        }

        // sửa 
        public bool suaNCC(NhaCungCap ncc)
        {
            string sql = "Update nhaCC set hoTenNCC = N'" + ncc.TenNCC + "', diaChiNCC = N'"+ ncc.DiaChiNCC +"', sdtNCC = '"+ ncc.SdtNCC +"' where nhaCCID = '" + ncc.MaNCC + "'";
            ThucThi(sql);
            return true;
        }

        // xóa 
        public bool xoaNCC(string ma)
        {
            //string sql = "Delete from nhaCC where nhaCCID = '" + ma + "'";
            string sql = "Update nhaCC set trangThai = " + 0 + " where nhaCCID = '" + ma + "'";
            ThucThi(sql);
            return true;
        }
    }
}
