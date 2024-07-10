using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_LoaiMyPham: BUS
    {
        DAL_LoaiMyPham dalLoaiMP = new DAL_LoaiMyPham();
        public DataTable GetLoaiMP()
        {
            return dalLoaiMP.GetLoaiMP();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalLoaiMP.kiemTraMaTrung(ma);
        }
        public bool themLoaiMP(LoaiMyPham lmp)
        {
            return dalLoaiMP.themLoaiMP(lmp);
        }
        public bool suaLoaiMP(LoaiMyPham lmp)
        {
            return dalLoaiMP.suaLoaiMP(lmp);
        }
        public bool xoaLoaiMP(string ma)
        {
            return dalLoaiMP.xoaLoaiMP(ma);
        }
    }
}
