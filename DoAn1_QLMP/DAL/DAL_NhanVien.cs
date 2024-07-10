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
    public class DAL_NhanVien : clsDatabase
    {
        // Hiển thị danh sách 
        public DataTable GetNhanVien()
        {
            string strGetNV = "Select nhanVienID, hoTenNV, gioiTinh, diaChiNV, sdtNV, quyen from nhanVien n inner join dangNhap d on n.nhanVienID = d.tenTK where trangThai = " + 1 +"";
            return GetDataTable(strGetNV);
        }

        // Kiểm tra mã trùng
        public int kiemTraMaTrung(string ma)
        {
            string sql = "Select count(*) from nhanVien where nhanVienID = '" + ma.Trim() + "'";
            return KiemTraMaTrung(sql);
        }

        // Thêm 
        public bool themNV(NhanVien nv)
        {
            string sql = "Insert into nhanVien values('" + nv.MaNhanVien + "', N'" + nv.TenNhanVien + "', N'" + nv.GioiTinh + "', N'"+nv.DiaChiNV + "', '"+ nv.SdtNV +"', "+ 1 +")";
            ThucThi(sql);
            string strTK = "Insert into dangNhap values('" + nv.MaNhanVien + "', '" + nv.MaNhanVien + "', '" + "NV" + "')";
            ThucThi(strTK);
            return true;
        }

        // sửa 
        public bool suaNV(NhanVien nv)
        {
            string sql = "Update nhanVien set hoTenNV = N'" + nv.TenNhanVien + "', gioiTinh = '"+ nv.GioiTinh +"', diaChiNV = N'" + nv.DiaChiNV + "', sdtNV = '" + nv.SdtNV + "' where nhanVienID = '" + nv.MaNhanVien + "'";
            ThucThi(sql);
            return true;
        }

        // xóa 
        public bool xoaNV(string ma)
        {
            //string sql = "Delete from nhanVien where nhanVienID = '" + ma + "'";
            string sql = "Update nhanVien set trangThai = " + 0 + " where nhanVienID = '"+ ma +"'";
            ThucThi(sql);
            return true;
        }
    }
}
