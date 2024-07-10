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
    public class BUS_MyPham: BUS
    {
        DAL_MyPham dalMP = new DAL_MyPham();
        public DataTable GetMyPham()
        {
            return dalMP.GetMypham();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalMP.kiemTraMaTrung(ma);
        }
        public bool themMyPham(MyPham mp)
        {
            return dalMP.themMyPham(mp);
        }
        public bool suaMyPham(MyPham mp)
        {
            return dalMP.suaMyPham(mp);
        }
        public bool xoaMyPham(string ma)
        {
            return dalMP.xoaMyPham(ma);
        }
        public DataTable TKMyPham(int slt)
        {
            return dalMP.TKMypham(slt);
        }
        public DataTable MyPhamBC(DateTime dt1, DateTime dt2)
        {
            return dalMP.MyPhamBC(dt1, dt2);
        }
        public DataTable HSDMyPham()
        {
            return dalMP.HSDMyPham();
        }
        public DataTable HSDMyPham1Nam()
        {
            return dalMP.HSDMyPham1Nam();
        }
    }
}
