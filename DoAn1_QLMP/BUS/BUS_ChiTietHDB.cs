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
    public class BUS_ChiTietHDB
    {
        DAL_ChiTietHDB dalCT = new DAL_ChiTietHDB();
        public DataTable GetChiTietHDB(string maHD)
        {
            return dalCT.GetChiTietHDB(maHD);
        }
        public int kiemTraMaTrung(string maHD, string maMP)
        {
            return dalCT.kiemTraMaTrung(maHD, maMP);
        }
        public bool themChiTietHDB(ChiTietHDB ct)
        {
            return dalCT.themChiTietHDB(ct);
        }
        public DataTable getDonGiaBan(string maMP)
        {
            return dalCT.getDonGiaBan(maMP);
        }

        public DataTable getSoLuongTon(string maMP)
        {
            return dalCT.getSoLuongTon(maMP);
        }
        public DataTable getSoLuongBan(string maHD, string maMP)
        {
            return dalCT.getSoLuongBan(maHD, maMP);
        }
        public bool themSoLuongTon(int slt, string maMP)
        {
            return dalCT.themSoLuongTon(slt, maMP);
        }
        public bool setThanhTien(double tt, string maHD, string maMP)
        {
            return dalCT.SetThanhTien(tt, maHD, maMP);
        }
    }
}
