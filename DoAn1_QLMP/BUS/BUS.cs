using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS
    {
        // tăng mã tự động
        public string tangMa(DataTable dt, string maBD, string tienTo, int i, int vt)
        {
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = maBD;
            }
            else
            {
                int k;
                ma = tienTo;
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count -1][i].ToString().Substring(vt));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "0";
                }
                
                ma = ma + k.ToString();
            }
            return ma;
        }
    }
}
