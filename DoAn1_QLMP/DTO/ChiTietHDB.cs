using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHDB
    {
        public string MaHDB { get; set; }
        public string MaMP { get; set;}
        public int SlBan { get; set;}
        public int GiamGia { get; set;}
        public double ThanhTien { get; set;}
        public ChiTietHDB() { }
        public ChiTietHDB(string maHDB, string maMP, int slBan, int giamGia, double thanhTien)
        {
            MaHDB = maHDB;
            MaMP = maMP;
            SlBan = slBan;
            GiamGia = giamGia;
            ThanhTien = thanhTien;
        }
    }
}
