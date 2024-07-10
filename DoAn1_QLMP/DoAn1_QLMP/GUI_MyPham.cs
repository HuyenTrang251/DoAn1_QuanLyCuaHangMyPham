using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_QLMP
{
    public partial class GUI_MyPham : Form
    {
        BUS_MyPham busMP = new BUS_MyPham();
        BUS_LoaiMyPham busLMP = new BUS_LoaiMyPham();
        DataTable dtLMP, dtMP = new DataTable();
        string strLoaiMP;
        public GUI_MyPham()
        {
            InitializeComponent();
        }
        private void GUI_MyPham_Load(object sender, EventArgs e)
        {
            gnDgvMyPham.DataSource = busMP.GetMyPham();
            dtLMP = busLMP.GetLoaiMP();
            gncbxLMP.DataSource = dtLMP;
            gncbxLMP.DisplayMember = "TenLoaiMP";

            dtMP = busMP.GetMyPham();
            gntxtMaMP.Text = busMP.tangMa(dtMP, "mp01", "mp", 1, 2);
        }

        private void gnbtnThem_Click(object sender, EventArgs e)
        {
            int ChiSoHang = gncbxLMP.SelectedIndex;
            strLoaiMP = dtLMP.Rows[ChiSoHang][0].ToString();
            string maMP = gntxtMaMP.Text;
            string ten = gntxtTen.Text;
            string dvTinh = gntxtDvTinh.Text;
            string hang = gntxtHang.Text;
            string xxu = gntxtXXu.Text;
            DateTime han = DateTime.Parse(dtHan.Value.ToShortDateString());
            double dgBan = double.Parse(gntxtDgBan.Text);
            int sl = int.Parse(gntxtSlTon.Text);
            
            MyPham mp = new MyPham(strLoaiMP, maMP, ten, dvTinh, hang, xxu, han, dgBan, sl);
            if (busMP.kiemTraMaTrung(maMP) == 1)
            {
                MessageBox.Show("Mã mỹ phẩm đã tồn tại!");
            }
            else if (string.IsNullOrWhiteSpace(maMP))
            {
                MessageBox.Show("ID mỹ phẩm không được để trống!", "ID mỹ phẩm trống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (busMP.themMyPham(mp))
                {
                    //MessageBox.Show("Thêm thành công");
                    gnDgvMyPham.DataSource = busMP.GetMyPham();
                }
            }
        }

        private void gnDgvMyPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            //string strTenLMP = "";
            //string strMaLMP = gnDgvMyPham[0, hang].Value.ToString().Trim();
            //for (int i = 0; i < dtLMP.Rows.Count; i++)
            //{
            //    if (dtLMP.Rows[i][0].ToString().Trim() == strMaLMP)
            //    {
            //        strTenLMP = dtLMP.Rows[i][1].ToString();
            //    }
            //}
            //gncbxLMP.Text = strTenLMP;
            gncbxLMP.Text = gnDgvMyPham[0, hang].Value.ToString().Trim();
            gntxtMaMP.Text = gnDgvMyPham[1, hang].Value.ToString();
            gntxtTen.Text = gnDgvMyPham[2, hang].Value.ToString();
            gntxtDvTinh.Text = gnDgvMyPham[3, hang].Value.ToString();
            gntxtHang.Text = gnDgvMyPham[4, hang].Value.ToString();
            gntxtXXu.Text = gnDgvMyPham[5, hang].Value.ToString();
            dtHan.Text = gnDgvMyPham[6, hang].Value.ToString();
            gntxtDgBan.Text = gnDgvMyPham[7, hang].Value.ToString();
            gntxtSlTon.Text = gnDgvMyPham[8, hang].Value.ToString();
        }

        private void gnbtnSua_Click(object sender, EventArgs e)
        {
            int ChiSoHang = gncbxLMP.SelectedIndex;
            strLoaiMP = dtLMP.Rows[ChiSoHang][0].ToString();
            string maMP = gntxtMaMP.Text;
            string ten = gntxtTen.Text;
            string dvTinh = gntxtDvTinh.Text;
            string hang = gntxtHang.Text;
            string xxu = gntxtXXu.Text;
            DateTime han = DateTime.Parse(dtHan.Value.ToShortDateString());
            double dgBan = double.Parse(gntxtDgBan.Text);
            int sl = int.Parse(gntxtSlTon.Text);
            MyPham mp = new MyPham(strLoaiMP, maMP, ten, dvTinh, hang, xxu, han, dgBan, sl);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busMP.suaMyPham(mp))
                {
                    //MessageBox.Show("Sửa thành công");
                    gnDgvMyPham.DataSource = busMP.GetMyPham();
                }
            }
        }

        private void gnbtnXoa_Click(object sender, EventArgs e)
        {
            string ma = gntxtMaMP.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busMP.xoaMyPham(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    gnDgvMyPham.DataSource = busMP.GetMyPham();
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
            dtMP = busMP.GetMyPham();
            gntxtMaMP.Text = busMP.tangMa(dtMP, "mp01", "mp", 1, 2);
        }

        private void gnbtnTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = gnDgvMyPham.Rows.Count - 2; i >= 0; i--)
            {
                if (gnDgvMyPham[1, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gnDgvMyPham[2, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gnDgvMyPham[4, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false && gnDgvMyPham[5, i].Value.ToString().ToUpper().Contains(gntxtTimKiem.Text.ToUpper()) == false)
                {
                    gnDgvMyPham.Rows.RemoveAt(i);
                }
            }
        }

        private void gntxtDgBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void gntxtSlTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void gntxtDgBan_TextChanged(object sender, EventArgs e)
        {
            // Dấu phẩy động
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(gntxtDgBan.Text, NumberStyles.AllowThousands);
            gntxtDgBan.Text = String.Format(culture, "{0:N0}", value);
            gntxtDgBan.Select(gntxtDgBan.Text.Length, 0);
        }

        private void gntxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            GUI_MyPham_Load(sender, e);
            gnbtnTimKiem_Click(sender, e);
        }
    }
}
