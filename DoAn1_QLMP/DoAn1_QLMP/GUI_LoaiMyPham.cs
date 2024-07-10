using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Guna.UI2.WinForms;

namespace DoAn1_QLMP
{
    public partial class GUI_LoaiMyPham : Form
    {
        BUS_LoaiMyPham busLoaiMP = new BUS_LoaiMyPham();
        DataTable dt = new DataTable();
        public GUI_LoaiMyPham()
        {
            InitializeComponent();
        }
        
        private void GUI_LoaiMyPham_Load(object sender, EventArgs e)
        {
            gndgvLoaiMP.DataSource = busLoaiMP.GetLoaiMP();
            dt = busLoaiMP.GetLoaiMP();
            gntxtMa.Text = busLoaiMP.tangMa(dt, "lmp01", "lmp",0, 3);
        }

        private void gnbtnThem_Click(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            string ten = gntxtTen.Text;
            LoaiMyPham lmp = new LoaiMyPham(ma, ten);
            if (busLoaiMP.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã loại mỹ phẩm đã tồn tại!");
            }
            else if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Thông tin loại mỹ phẩm không được để trống!", "Thông tin loại mỹ phẩm trống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (busLoaiMP.themLoaiMP(lmp))
                {
                    //MessageBox.Show("Thêm thành công");
                    gndgvLoaiMP.DataSource = busLoaiMP.GetLoaiMP();
                }
            }
        }

        private void gndgvLoaiMP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            gntxtMa.Text = gndgvLoaiMP[0, hang].Value.ToString();
            gntxtTen.Text = gndgvLoaiMP[1, hang].Value.ToString();
        }

        private void gnbtnSua_Click_1(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            string ten = gntxtTen.Text;
            LoaiMyPham lmp = new LoaiMyPham(ma, ten);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busLoaiMP.suaLoaiMP(lmp))
                {
                    //MessageBox.Show("Sửa thành công");
                    gndgvLoaiMP.DataSource = busLoaiMP.GetLoaiMP();
                }
            }
        }

        private void gnbtnXoa_Click_1(object sender, EventArgs e)
        {
            string ma = gntxtMa.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busLoaiMP.xoaLoaiMP(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    gndgvLoaiMP.DataSource = busLoaiMP.GetLoaiMP();
                }
            }
        }

        private void gnbtnLamMoi_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctr in this.gnpnChucNang.Controls)
            {
                if (ctr is Guna2TextBox)
                {
                    ctr.Text = "";
                }
            }
            dt = busLoaiMP.GetLoaiMP();
            gntxtMa.Text = busLoaiMP.tangMa(dt, "lmp01", "lmp", 0, 3);
        }

        private void gnbtnTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = gndgvLoaiMP.Rows.Count - 1; i >= 0; i--)
            {
                if (gndgvLoaiMP[0, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gndgvLoaiMP[1, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false)
                {
                    gndgvLoaiMP.Rows.RemoveAt(i);
                }
            }
        }

        private void gntxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            GUI_LoaiMyPham_Load(sender, e);
            gnbtnTimKiem_Click(sender, e);
        }

    }
}
