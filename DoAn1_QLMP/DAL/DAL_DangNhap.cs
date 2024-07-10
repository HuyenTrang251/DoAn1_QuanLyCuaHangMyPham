using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DangNhap: clsDatabase
    {
        DangNhap dn = new DangNhap();
        public DataTable GetTaiKhoan(string ten)
        {
            string sql = "SELECT * FROM dangNhap WHERE tenTK = '" + ten + "'";
            return GetDataTable(sql);
        }

        public bool SetDangNhap(string ten, string ma)
        {
            string strMK = "UPDATE dangNhap SET matKhau = '"+ ma +"' WHERE tenTK = '"+ ten +"'";
            ThucThi(strMK);
            return true;
        }
    }
}
