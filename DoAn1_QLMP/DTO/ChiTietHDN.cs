using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHDN
    {
        public string MaHDN2 { get; set; }
        public string MaMP { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        //public double GiamGia { get; set; }
        public double ThanhTien { get; set; }
        public ChiTietHDN() { }
        public ChiTietHDN(string maHDN2, string maMP, int soLuong, double donGia, double thanhTien)
        {
            MaHDN2 = maHDN2;
            MaMP = maMP;
            SoLuong = soLuong;
            DonGia = donGia;
            //GiamGia = giamGia;
            ThanhTien = thanhTien;
        }
    }
}
