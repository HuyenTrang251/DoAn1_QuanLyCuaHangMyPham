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
    public partial class GUI_DoiMatKhau : Form
    {
        BUS_DangNhap busDN = new BUS_DangNhap();
        public GUI_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void gntxtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            if (gntxtNhapLaiMK.Text.Trim() != gntxtMKMoi.Text.Trim())
            {
                this.errorProvider1.SetError(gntxtNhapLaiMK, "Mật khẩu không trùng khớp!");
            }
            else this.errorProvider1.Clear();
        }

        private void gntxtNhapLaiMK_Leave(object sender, EventArgs e)
        {
            if (gntxtNhapLaiMK.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(gntxtNhapLaiMK, "Không được để trống!");
            }
            else this.errorProvider1.Clear();
        }

        private void gntxtTen_Leave(object sender, EventArgs e)
        {
            if (gntxtTen.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(gntxtTen, "Không được để trống!");
            }
            else this.errorProvider1.Clear();
        }

        private void gntxtMKCu_Leave(object sender, EventArgs e)
        {
            if (gntxtMKCu.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(gntxtMKCu, "Không được để trống!");
            }
            else this.errorProvider1.Clear();
        }

        private void gnbtOK_Click(object sender, EventArgs e)
        {
            string ten = gntxtTen.Text;
            string mk = gntxtMKCu.Text;
            string mkm = gntxtMKMoi.Text;
            DataTable dtDN = busDN.GetTaiKhoan(ten);
            if (dtDN.Rows.Count == 1 && mk.Trim() == dtDN.Rows[0][1].ToString().Trim())
            {
                if (busDN.SetDangNhap(ten, mkm))
                {
                    MessageBox.Show("Đã đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("TÀI KHOẢN HOẶC MẬT KHẨU KHÔNG ĐÚNG.XIN MỜI NHẬP LẠI!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
