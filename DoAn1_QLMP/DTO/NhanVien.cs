using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNhanVien {get; set;}
        public string TenNhanVien { get; set; }
        public string GioiTinh {get; set;}
        public string DiaChiNV {get; set;}
        public string SdtNV {get; set;}
        
        public NhanVien() { }
        public NhanVien(string maNhanVien, string tenNhanVien, string gioiTinh, string diaChiNV, string sdtNV)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            GioiTinh = gioiTinh;
            DiaChiNV = diaChiNV;
            SdtNV = sdtNV;
        }
    }
}
