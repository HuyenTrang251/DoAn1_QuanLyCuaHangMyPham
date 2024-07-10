using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MyPham
    {
        public string MaLoaiMP { get; set; }
        public string MaMyPham { get; set; }
        public string TenMyPham { get; set; }
        public string DonViTinh { get; set; }
        public string HangMyPham { get; set; }
        public string XuatXu { get; set; }
        public DateTime HanSuDung { get; set; }
        public double DonGiaBan { get; set; }
        public int SoLuongTon { get; set; }

        public MyPham()
        {

        }
        public MyPham(string maLoaiMP, string maMyPham, string tenMyPham, string donViTinh, string hangMyPham, string xuatXu, DateTime hanSuDung, double donGiaBan, int soLuongTon)
        {
            MaLoaiMP = maLoaiMP;
            MaMyPham = maMyPham;
            TenMyPham = tenMyPham;
            DonViTinh = donViTinh;
            HangMyPham = hangMyPham;
            XuatXu = xuatXu;
            HanSuDung = hanSuDung;
            DonGiaBan = donGiaBan; 
            SoLuongTon = soLuongTon;
        }
    }
}
