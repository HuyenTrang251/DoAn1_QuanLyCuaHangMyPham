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
    public class BUS_HoaDonBan: BUS
    {
        DAL_HoaDonBan dalHDB = new DAL_HoaDonBan();
        public DataTable GetHoaDonBan()
        {
            return dalHDB.GetHoaDonBan();
        }
        public DataTable GetHuyHDB()
        {
            return dalHDB.GetHuyHDB();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalHDB.kiemTraMaTrung(ma);
        }
        public bool themHDB(HoaDonBan hdb)
        {
            return dalHDB.themHDB(hdb);
        }
        public bool huyHDB(string ma)
        {
            return dalHDB.huyHDB(ma);
        }
        public bool khoiPhucHDB(string ma)
        {
            return dalHDB.khoiPhucHDB(ma);
        }
        public bool xoaHD(string ma)
        {
            return dalHDB.xoaHDB(ma);
        }
        public bool setTongTien(double tt, string maHD)
        {
            return dalHDB.setTongTien(tt, maHD);
        }
        public DataTable TKDoanhThuTheoThang(string year)
        {
            return dalHDB.TKDoanhThuTheoThang(year);
        }

        public DataTable TKDoanhThu(DateTime d1, DateTime d2)
        {
            return dalHDB.TKDoanhThu(d1, d2);
        }

        public DataTable TKVonNhap(string year)
        {
            return dalHDB.TKVonNhap(year);
        }
        public DataTable TKLoiNhuan(string year)
        {
            return dalHDB.TKLoiNhuan(year);
        }
    }
}
