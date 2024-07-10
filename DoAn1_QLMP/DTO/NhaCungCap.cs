using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChiNCC { get; set; }
        public string SdtNCC { get; set; }
       
        public NhaCungCap()
        {

        }
        public NhaCungCap(string maNCC, string tenNCC, string diaChiNCC, string sdtNCC)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChiNCC = diaChiNCC;
            SdtNCC = sdtNCC;
        }
    }
}
