using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_QLMP
{
    public partial class GUI_LichSuHuy : Form
    {
        BUS_HoaDonBan busHDB = new BUS_HoaDonBan();
        BUS_ChiTietHDB busCT = new BUS_ChiTietHDB();
        public GUI_LichSuHuy()
        {
            InitializeComponent();
        }
        string maHD;
        private void GUI_LichSuHuy_Load(object sender, EventArgs e)
        {
            gndgvHDB.DataSource = busHDB.GetHuyHDB();

        }

        private void gndgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            gntxtMaHDB.Text = gndgvHDB[0, hang].Value.ToString();
            maHD = gntxtMaHDB.Text;
            gndgvCTHDB.DataSource = busCT.GetChiTietHDB(maHD);
        }

        private void gnbtKhoiPhuc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn khôi phục không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busHDB.khoiPhucHDB(maHD))
                {
                    MessageBox.Show("Khôi phục hóa đơn thành công");
                }
            }
            gndgvHDB.DataSource = busHDB.GetHuyHDB();
        }

        private void gnbtXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa vĩnh viễn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busHDB.khoiPhucHDB(maHD))
                {
                    MessageBox.Show("Đã xóa hóa đơn thành công");
                }
            }
            gndgvHDB.DataSource = busHDB.GetHuyHDB();
        }
    }
}
