using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap
    {
        public string TenTK { get; set; }
        public string MK { get; set;}
        public string Quyen { get; set; }
        public DangNhap() { }
        public DangNhap(string TenTK, string MK, string quyen)
        {
            string tenTK = TenTK;
            string mK = MK;
            Quyen = quyen;
        }
    }
}
