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
    public class BUS_ChiTietHDN
    {
        DAL_ChiTietHDN dalCT = new DAL_ChiTietHDN();
        public DataTable GetChiTietHDN(string maHD)
        {
            return dalCT.GetChiTietHDN(maHD);
        }
        public int kiemTraMaTrung(string maHD, string maMP)
        {
            return dalCT.kiemTraMaTrung(maHD, maMP);
        }
        public bool themChiTietHDN(ChiTietHDN ct)
        {
            return dalCT.themChiTietHDN(ct);
        }
        public bool suaChiTietHDN(ChiTietHDN ct)
        {
            return dalCT.suaChiTietHDN(ct);
        }
        public DataTable setSoLuongTon(string maMP)
        {
            return dalCT.setSoLuongTon(maMP);
        }
        public bool themSoLuongTon(int slt,  string maMP)
        {
            return dalCT.themSoLuongTon(slt, maMP);
        }
        public bool setThanhTien(double tt, string maHD, string maMP)
        {
            return dalCT.SetThanhTien(tt, maHD, maMP);
        }
    }
}
