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
    public class BUS_DangNhap
    {
        DAL_DangNhap dalDN = new DAL_DangNhap();
        public DataTable GetTaiKhoan(string ten) 
        {
            return dalDN.GetTaiKhoan(ten);
        }

        public bool SetDangNhap(string ten, string mk)
        {
            return dalDN.SetDangNhap(ten, mk);
        }
    }
}
