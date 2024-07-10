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
    public partial class GUI_QuenMK : Form
    {
        BUS_DangNhap busDN = new BUS_DangNhap();
        public GUI_QuenMK()
        {
            InitializeComponent();
        }

        private void gntxtTen_Leave(object sender, EventArgs e)
        {
            if (gntxtTen.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(gntxtTen, "Không được để trống!");
            }
            else this.errorProvider1.Clear();
        }

        private void gntxtMK_Leave(object sender, EventArgs e)
        {
            if (gntxtMK.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(gntxtMK, "Không được để trống!");
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

        private void gntxtTen_TextChanged(object sender, EventArgs e)
        {
            DataTable dtTen = busDN.GetTaiKhoan(gntxtTen.Text);
            if (dtTen.Rows.Count < 1)
            {
                this.errorProvider1.SetError(gntxtTen, "Tên đăng nhập không tồn tại!");
            }
            else this.errorProvider1.Clear();
        }

        private void gntxtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            if (gntxtNhapLaiMK.Text.Trim() != gntxtMK.Text.Trim())
            {
                this.errorProvider1.SetError(gntxtNhapLaiMK, "Mật khẩu không trùng khớp!");
            }
            else this.errorProvider1.Clear();
        }

        private void gnbtOK_Click(object sender, EventArgs e)
        {
            string ten = gntxtTen.Text;
            string mk = gntxtMK.Text;
            if (busDN.SetDangNhap(ten, mk))
            {
                MessageBox.Show("Đã lấy mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gnbtQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_DangNhap ftc = new GUI_DangNhap();
            ftc.ShowDialog();
            this.Close();
        }
    }
}
