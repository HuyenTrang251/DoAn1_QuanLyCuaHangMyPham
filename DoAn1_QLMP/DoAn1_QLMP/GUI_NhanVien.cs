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
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        DataTable dtNV = new DataTable();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            gndgvNV.DataSource = busNV.GetNhanVien();
            dtNV = busNV.GetNhanVien();
            gntxtMa.Text = busNV.tangMa(dtNV, "nv01", "nv",0, 2);
        }

        private void gnbtnThem_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            string ten = gntxtTen.Text;
            string gtinh = gntxtGT.Text;
            string dchi = gntxtDiaChi.Text;
            string sdt = gntxtSĐT.Text;
            NhanVien nv = new NhanVien(ma, ten, gtinh, dchi, sdt);
            if (busNV.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
            }
            else if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(gtinh))
            {
                MessageBox.Show("Thông tin nhân viên trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (busNV.themNV(nv))
                {
                    gndgvNV.DataSource = busNV.GetNhanVien();
                }
            }
        }

        private void gndgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            gntxtMa.Text = gndgvNV[0, hang].Value.ToString();
            gntxtTen.Text = gndgvNV[1, hang].Value.ToString();
            gntxtGT.Text = gndgvNV[2, hang].Value.ToString();
            gntxtDiaChi.Text = gndgvNV[3, hang].Value.ToString();
            gntxtSĐT.Text = gndgvNV[4, hang].Value.ToString();  
        }

        private void gnbtnSua_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            string ten = gntxtTen.Text;
            string gtinh = gntxtGT.Text;
            string dchi = gntxtDiaChi.Text;
            string sdt = gntxtSĐT.Text;
            NhanVien nv = new NhanVien(ma, ten, gtinh, dchi, sdt);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busNV.suaNV(nv))
                {
                    gndgvNV.DataSource = busNV.GetNhanVien();
                }
            }
        }

        private void gnbtnXoa_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busNV.xoaNV(ma))
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    gndgvNV.DataSource = busNV.GetNhanVien();
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
            dtNV = busNV.GetNhanVien();
            gntxtMa.Text = busNV.tangMa(dtNV, "nv01", "nv", 0, 2);
        }

        private void gnbtnTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = gndgvNV.Rows.Count - 1; i >= 0; i--)
            {
                if (gndgvNV[1, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvNV[2, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvNV[3, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false)
                {
                    gndgvNV.Rows.RemoveAt(i);
                }
            }
        }

        private void gntxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            GUI_NhanVien_Load(sender, e);
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
