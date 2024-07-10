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
    public partial class GUI_NhaCungCap : Form
    {
        BUS_NhaCungCap busNCC = new BUS_NhaCungCap();
        DataTable dt = new DataTable();
        public GUI_NhaCungCap()
        {
            InitializeComponent();
        }

        private void GUI_NhaCungCap_Load(object sender, EventArgs e)
        {
            gndgvNCC.DataSource = busNCC.GetNhaCungCap();
            dt = busNCC.GetNhaCungCap();
            gntxtMa.Text = busNCC.tangMa(dt, "ncc01", "ncc",0, 3);
        }

        private void gnbtnThem_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            string ten = gntxtTen.Text;
            string diachi = gntxtDiaChi.Text;
            string sdt = gntxtSĐT.Text;
            NhaCungCap ncc = new NhaCungCap(ma, ten, diachi, sdt);
            if (busNCC.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại");
            }
            else if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Mã và tên nhà cung cấp không được trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (busNCC.themNCC(ncc))
                {
                    gndgvNCC.DataSource = busNCC.GetNhaCungCap();
                }
            }
        }

        private void gndgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            gntxtMa.Text = gndgvNCC[0, hang].Value.ToString();
            gntxtTen.Text = gndgvNCC[1, hang].Value.ToString();
            gntxtDiaChi.Text = gndgvNCC[2, hang].Value.ToString();
            gntxtSĐT.Text = gndgvNCC[3, hang].Value.ToString();
        }

        private void gnbtnSua_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            string ten = gntxtTen.Text;
            string diachi = gntxtDiaChi.Text;
            string sdt = gntxtSĐT.Text;
            NhaCungCap ncc = new NhaCungCap(ma, ten, diachi, sdt);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busNCC.suaNCC(ncc))
                {
                    gndgvNCC.DataSource = busNCC.GetNhaCungCap();
                }
            }
        }
        private void gnbtnXoa_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busNCC.xoaNCC(ma))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    gndgvNCC.DataSource = busNCC.GetNhaCungCap();
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
            dt = busNCC.GetNhaCungCap();
            gntxtMa.Text = busNCC.tangMa(dt, "ncc01", "ncc",0, 3);
        }

        private void gnbtnTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = gndgvNCC.Rows.Count - 2; i >= 0; i--)
            {
                if (gndgvNCC[1, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvNCC[2, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false)
                {
                    gndgvNCC.Rows.RemoveAt(i);
                }
            }
        }

        private void gntxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            GUI_NhaCungCap_Load(sender, e);
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
