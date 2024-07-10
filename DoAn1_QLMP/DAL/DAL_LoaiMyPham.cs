using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class DAL_LoaiMyPham : clsDatabase
    {
        LoaiMyPham lmp = new LoaiMyPham();
        // Hiển thị danh sách loại mỹ phẩm
        public DataTable GetLoaiMP() 
        {
            string strGetLoaiMP = "Select loaiMyPhamID, tenLoaiMP from loaiMyPham where trangThai = "+ 1 +"";
            return GetDataTable(strGetLoaiMP);
        }

        // Kiểm tra mã trùng
        public int kiemTraMaTrung(string ma)
        {
            string sql = "Select count(*) from loaiMyPham where loaiMyPhamID = '" + ma.Trim() + "'";
            return KiemTraMaTrung(sql);
        }

        // Thêm loại mỹ phẩm
        public bool themLoaiMP(LoaiMyPham lmp)
        {
            string sql = "Insert into loaiMyPham values('"+ lmp.MaLoaiMP +"', N'"+ lmp.TenLoaiMP +"', "+ 1 +")";
            ThucThi(sql);
            return true;
        }

        // sửa loại mỹ phẩm
        public bool suaLoaiMP(LoaiMyPham lmp)
        {
            string sql = "Update loaiMyPham set tenLoaiMP = N'" + lmp.TenLoaiMP + "' where loaiMyPhamID = '" + lmp.MaLoaiMP +"'";
            ThucThi(sql);
            return true;
        }

        // xóa 
        public bool xoaLoaiMP(string ma)
        {
            //string sql = "Delete from loaiMyPham where loaiMyPhamID = '" + ma + "'";
            string sql = "Update loaiMyPham set trangThai = "+ 0 +" where loaiMyPhamID = '" + ma + "'";
            ThucThi(sql);
            return true;
        }
    }
}
