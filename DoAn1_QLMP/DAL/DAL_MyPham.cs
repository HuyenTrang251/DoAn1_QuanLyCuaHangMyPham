using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace DAL
{
    public class DAL_MyPham: clsDatabase
    {
        // Hiển thị danh sách 
        public DataTable GetMypham()
        {
            string strGetMP = "Select tenLoaiMP, myPhamID, tenMyPham, dvTinh, hangMyPham, xuatXu, hanSuDung, dgBan, slTon from myPham m inner join loaiMyPham l on m.loaiMyPhamID = l.loaiMyPhamID where m.trangThai = " + 1 +"";
            return GetDataTable(strGetMP);
        }

        public DataTable TKMypham(int slt)
        {
            string strGetMP = "Select loaiMyPhamID, myPhamID, tenMyPham, hanSuDung, dgBan, slTon from myPham where slTon <= "+ slt +"";
            return GetDataTable(strGetMP);
        }
        public DataTable MyPhamBC(DateTime dt1, DateTime dt2)
        {
            string sql = "SELECT * FROM dbo.MyPhamCoSoLuongBanChay('"+ dt1 +"', '"+ dt2 +"')";
            return GetDataTable(sql);
        }
        public DataTable HSDMyPham()
        {
            string sql = "SELECT * FROM SoNgayMyPhamConHan()";
            return GetDataTable(sql);
        }

        public DataTable HSDMyPham1Nam()
        {
            string sql = "SELECT * FROM MyPhamCoHanDuoiMotNam()";
            return GetDataTable(sql);
        }

        // Kiểm tra mã trùng
        public int kiemTraMaTrung(string ma)
        {
            string sql = "Select count(*) from myPham where myPhamID = '" + ma.Trim() + "'";
            return KiemTraMaTrung(sql);
        }
        
        // Thêm 
        public bool themMyPham(MyPham mp)
        {
            string han = string.Format("{0}-{1}-{2}", mp.HanSuDung.Year, mp.HanSuDung.Month, mp.HanSuDung.Day);
            string sql = "Insert into myPham values('" + mp.MaLoaiMP + "', '" + mp.MaMyPham + "', N'"+ mp.TenMyPham +"', N'"+ mp.DonViTinh +"', N'"+ mp.HangMyPham +"', N'"+ mp.XuatXu +"', '"+ han +"', "+ mp.DonGiaBan +", '"+ mp.SoLuongTon +"', "+ 1 +")";
            ThucThi(sql);
            return true;
        }
            
        // sửa
        public bool suaMyPham(MyPham mp)
        {
            string han = string.Format("{0}-{1}-{2}", mp.HanSuDung.Year, mp.HanSuDung.Month, mp.HanSuDung.Day);
            string sql = "Update myPham set loaiMyPhamID = '"+ mp.MaLoaiMP +"', tenMyPham = N'" + mp.TenMyPham + "', dvTinh = N'"+ mp.DonViTinh + "', hangMyPham = N'"+ mp.HangMyPham + "', xuatXu = N'"+ mp.XuatXu + "', hanSuDung = '"+ han + "', dgBan = "+ mp.DonGiaBan +", slTon = '"+ mp.SoLuongTon +"' where myPhamID = '" + mp.MaMyPham +"'";
            ThucThi(sql);
            return true;
        }

        // xóa 
        public bool xoaMyPham(string ma)
        {
            //string sql = "Delete from myPham where myPhamID = '" + ma + "'";
            string sql = "Update myPham set trangThai = " + 0 + " where myPhamID = '"+ ma +"'"; 
            ThucThi(sql);
            return true;
        }
    }
}
