using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiMyPham
    {
		public string MaLoaiMP { get; set; }
		public string TenLoaiMP { get; set; }

        public LoaiMyPham()
        {

        }
        public LoaiMyPham(string maLoaiMP, string tenLoaiMP)
        {
            MaLoaiMP = maLoaiMP;
            TenLoaiMP = tenLoaiMP;
        }
    }
}
