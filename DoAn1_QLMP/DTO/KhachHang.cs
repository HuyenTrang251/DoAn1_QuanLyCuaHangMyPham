using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string TenKhachHang {get; set; }
        public string DiaChiKH {get; set; }
        public string SdtKH { get; set; }
        public KhachHang() { }
        public KhachHang(string maKhachHang, string tenKhachHang, string diaChiKH, string sdtKH)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            DiaChiKH = diaChiKH;
            SdtKH = sdtKH;
        }
    }
}
