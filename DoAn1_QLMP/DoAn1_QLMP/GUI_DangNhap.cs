using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace DoAn1_QLMP
{
    public partial class GUI_DangNhap : Form
    {
        public static Form frmDangNhap;
        BUS_DangNhap busDN = new BUS_DangNhap();
        public GUI_DangNhap()
        {
            InitializeComponent();
            frmDangNhap = this;
        }
        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {
            frmDangNhap = this;
        }

        private void gnbtDangNhap_Click(object sender, EventArgs e)
        {
            gnbtDangNhap.BackColor = Color.Blue;
            string ten = gntxtTenTK.Text;
            string mk = gntxtMK.Text;
            DataTable dtDN = busDN.GetTaiKhoan(ten);
            if (dtDN.Rows.Count == 1 && mk.Trim() == dtDN.Rows[0][1].ToString().Trim())
            {
                //MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG!", "ĐĂNG NHẬP");
                this.Hide();
                GUI_TrangChu gTC = new GUI_TrangChu(dtDN.Rows[0][0].ToString(), dtDN.Rows[0][1].ToString(), dtDN.Rows[0][2].ToString());
                gTC.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("TÀI KHOẢN HOẶC MẬT KHẨU KHÔNG ĐÚNG.XIN MỜI NHẬP LẠI!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gntxtTenTK_Leave(object sender, EventArgs e)
        {
            if (gntxtTenTK.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(gntxtTenTK, "Không được để trống!");
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
    }
}
