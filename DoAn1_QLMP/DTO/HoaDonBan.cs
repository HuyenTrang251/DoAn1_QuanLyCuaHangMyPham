using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBan
    {
        public string MaHDB { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayBan { get; set; }
        public int TrangThai { get; set; }
        public double TongTien { get; set; }
        public DateTime TgHuy { get; set; }

        public HoaDonBan() { }
        public HoaDonBan(string maHDB, string maNV, string maKH, DateTime ngayBan, int trangThai, double tongTien, DateTime tgHuy)
        {
            MaHDB = maHDB;
            MaNV = maNV;
            MaKH = maKH;
            NgayBan = ngayBan;
            TrangThai = trangThai;
            TongTien = tongTien;
            TgHuy = tgHuy;
        }
    }
}
