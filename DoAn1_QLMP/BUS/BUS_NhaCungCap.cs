using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhaCungCap: BUS
    {
        DAL_NhaCungCap dalNCC = new DAL_NhaCungCap();
        public DataTable GetNhaCungCap()
        {
            return dalNCC.GetNhaCungCap();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalNCC.kiemTraMaTrung(ma);
        }
        public bool themNCC(NhaCungCap ncc)
        {
            return dalNCC.themNCC(ncc);
        }
        public bool suaNCC(NhaCungCap ncc)
        {
            return dalNCC.suaNCC(ncc);
        }
        public bool xoaNCC(string ma)
        {
            return dalNCC.xoaNCC(ma);
        }
    }
}
