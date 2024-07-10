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
    public class BUS_HoaDonNhap: BUS
    {
        DAL_HoaDonNhap dalHdn = new DAL_HoaDonNhap();
        public DataTable GetHoaDonNhap()
        {
            return dalHdn.GetHoaDonNhap();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalHdn.kiemTraMaTrung(ma);
        }
        public bool themHDN(HoaDonNhap hdn)
        {
            return dalHdn.themHDN(hdn);
        }
        public bool suaHDN(HoaDonNhap hdn)
        {
            return dalHdn.suaHDN(hdn);
        }
        public bool xoaHDN(string ma)
        {
            return dalHdn.xoaHDN(ma);
        }
        public bool setTongTien(double tt, string maHD)
        {
            return dalHdn.setTongTien(tt, maHD);
        }
    }
}
