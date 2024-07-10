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
    public class BUS_KhachHang: BUS
    {
        DAL_KhachHang dalKH = new DAL_KhachHang();
        public DataTable GetKhachHang()
        {
            return dalKH.GetKhachHang();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalKH.kiemTraMaTrung(ma);
        }
        public bool themKH(KhachHang kh)
        {
            return dalKH.themKH(kh);
        }
        public bool suaKH(KhachHang kh)
        {
            return dalKH.suaKH(kh);
        }
        public bool xoaKH(string ma)
        {
            return dalKH.xoaKH(ma);
        }
        public DataTable GetSdtKH(string ma)
        {
            return dalKH.GetSdtKH(ma);
        }
    }
}
