using BUS;
using DTO;
using Guna.UI2.WinForms;
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
    public partial class GUI_KhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        DataTable dt = new DataTable();
        public GUI_KhachHang()
        {
            InitializeComponent();
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            gndgvKH.DataSource = busKH.GetKhachHang();
            dt = busKH.GetKhachHang();
            gntxtMa.Text = busKH.tangMa(dt, "kh01", "kh", 0, 2);
        }

        private void gnbtnThem_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            string ten = gntxtTen.Text;
            string dchi = gntxtDiaChi.Text;
            string sdt = gntxtSĐT.Text;
            KhachHang kh = new KhachHang(ma, ten, dchi, sdt);
            if (busKH.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
            }
            else if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Thông tin khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (busKH.themKH(kh))
                {
                    gndgvKH.DataSource = busKH.GetKhachHang();
                }
            }
        }

        private void gndgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            gntxtMa.Text = gndgvKH[0, hang].Value.ToString();
            gntxtTen.Text = gndgvKH[1, hang].Value.ToString();
            gntxtDiaChi.Text = gndgvKH[2, hang].Value.ToString();
            gntxtSĐT.Text = gndgvKH[3, hang].Value.ToString();
        }

        private void gnbtnSua_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            string ten = gntxtTen.Text;
            string dchi = gntxtDiaChi.Text;
            string sdt = gntxtSĐT.Text;
            KhachHang kh = new KhachHang(ma, ten, dchi, sdt);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busKH.suaKH(kh))
                {
                    MessageBox.Show("Sửa khách hàng thành công!");
                    gndgvKH.DataSource = busKH.GetKhachHang();
                }
            }
        }

        private void gnbtnXoa_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busKH.xoaKH(ma))
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    gndgvKH.DataSource = busKH.GetKhachHang();
                }
            }
        }

        private void gnbtnLamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.pnThongTin.Controls)
            {
                if (ctr is Guna2TextBox)
                {
                    ctr.Text = "";
                }
            }
            dt = busKH.GetKhachHang();
            gntxtMa.Text = busKH.tangMa(dt, "kh01", "kh", 0, 2);
        }

        private void gnbtnTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = gndgvKH.Rows.Count - 2; i >= 0; i--)
            {
                if (gndgvKH[1, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvKH[2, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false)
                {
                    gndgvKH.Rows.RemoveAt(i);
                }
            }
        }

        private void gntxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            GUI_KhachHang_Load(sender, e);
            gnbtnTimKiem_Click(sender, e);
        }

        private void gntxtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
    }
}
