using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonNhap
    {
        public string MaHDN { get; set; }
        public string MaNhanvien { get; set; }
        public string MaNhaCungCap { get; set; }
        public DateTime NgayNhap { get; set; }
        public double TongTien { get; set; }
        public HoaDonNhap() { }
        public HoaDonNhap (string maHDN, string maNV, string maNCC, DateTime ngayNhap, double tongTien)
        {
            MaHDN = maHDN;
            MaNhanvien = maNV;
            MaNhaCungCap = maNCC;
            NgayNhap = ngayNhap;
            TongTien = tongTien;
        }
    }
}
