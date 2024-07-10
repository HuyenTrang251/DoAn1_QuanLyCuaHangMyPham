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
    public class BUS_NhanVien: BUS
    {
        DAL_NhanVien dalNV = new DAL_NhanVien();
        public DataTable GetNhanVien()
        {
            return dalNV.GetNhanVien();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalNV.kiemTraMaTrung(ma);
        }
        public bool themNV(NhanVien nv)
        { 
            return dalNV.themNV(nv);
        }
        public bool suaNV(NhanVien nv)
        {
            return dalNV.suaNV(nv);
        }
        public bool xoaNV(string ma)
        {
            return dalNV.xoaNV(ma);
        }
    }
}
