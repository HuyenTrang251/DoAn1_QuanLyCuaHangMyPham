namespace DoAn1_QLMP
{
    partial class GUI_KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gntxtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.gnbtnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.lbKH = new System.Windows.Forms.Label();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.gnbtnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnSua = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnThem = new Guna.UI2.WinForms.Guna2Button();
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.gntxtSĐT = new Guna.UI2.WinForms.Guna2TextBox();
            this.gntxtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.gntxtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.gntxtMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSĐt = new System.Windows.Forms.Label();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gndgvKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnChucNang.SuspendLayout();
            this.pnThongTin.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gndgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.gntxtTimKiem);
            this.panel1.Controls.Add(this.gnbtnTimKiem);
            this.panel1.Controls.Add(this.lbKH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 73);
            this.panel1.TabIndex = 0;
            // 
            // gntxtTimKiem
            // 
            this.gntxtTimKiem.BorderRadius = 10;
            this.gntxtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTimKiem.DefaultText = "";
            this.gntxtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gntxtTimKiem.ForeColor = System.Drawing.Color.Silver;
            this.gntxtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTimKiem.Location = new System.Drawing.Point(348, 13);
            this.gntxtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTimKiem.Name = "gntxtTimKiem";
            this.gntxtTimKiem.PasswordChar = '\0';
            this.gntxtTimKiem.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gntxtTimKiem.PlaceholderText = "Nhập từ khóa tìm kiếm";
            this.gntxtTimKiem.SelectedText = "";
            this.gntxtTimKiem.Size = new System.Drawing.Size(629, 48);
            this.gntxtTimKiem.TabIndex = 0;
            this.gntxtTimKiem.TextChanged += new System.EventHandler(this.gntxtTimKiem_TextChanged);
            // 
            // gnbtnTimKiem
            // 
            this.gnbtnTimKiem.BorderRadius = 20;
            this.gnbtnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtnTimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.gnbtnTimKiem.Location = new System.Drawing.Point(1017, 12);
            this.gnbtnTimKiem.Name = "gnbtnTimKiem";
            this.gnbtnTimKiem.Size = new System.Drawing.Size(137, 45);
            this.gnbtnTimKiem.TabIndex = 1;
            this.gnbtnTimKiem.Text = "Tìm kiếm";
            this.gnbtnTimKiem.Click += new System.EventHandler(this.gnbtnTimKiem_Click);
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKH.Location = new System.Drawing.Point(56, 24);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(160, 30);
            this.lbKH.TabIndex = 0;
            this.lbKH.Text = "Khách hàng";
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnChucNang.Controls.Add(this.gnbtnLamMoi);
            this.pnChucNang.Controls.Add(this.gnbtnXoa);
            this.pnChucNang.Controls.Add(this.gnbtnSua);
            this.pnChucNang.Controls.Add(this.gnbtnThem);
            this.pnChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnChucNang.Location = new System.Drawing.Point(0, 609);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1182, 94);
            this.pnChucNang.TabIndex = 1;
            // 
            // gnbtnLamMoi
            // 
            this.gnbtnLamMoi.BorderRadius = 20;
            this.gnbtnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtnLamMoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.gnbtnLamMoi.Location = new System.Drawing.Point(960, 27);
            this.gnbtnLamMoi.Name = "gnbtnLamMoi";
            this.gnbtnLamMoi.Size = new System.Drawing.Size(124, 45);
            this.gnbtnLamMoi.TabIndex = 3;
            this.gnbtnLamMoi.Text = "Làm mới";
            this.gnbtnLamMoi.Click += new System.EventHandler(this.gnbtnLamMoi_Click);
            // 
            // gnbtnXoa
            // 
            this.gnbtnXoa.BorderRadius = 20;
            this.gnbtnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnXoa.ForeColor = System.Drawing.Color.Black;
            this.gnbtnXoa.Location = new System.Drawing.Point(671, 27);
            this.gnbtnXoa.Name = "gnbtnXoa";
            this.gnbtnXoa.Size = new System.Drawing.Size(124, 45);
            this.gnbtnXoa.TabIndex = 2;
            this.gnbtnXoa.Text = "Xóa";
            this.gnbtnXoa.Click += new System.EventHandler(this.gnbtnXoa_Click);
            // 
            // gnbtnSua
            // 
            this.gnbtnSua.BorderRadius = 20;
            this.gnbtnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnSua.ForeColor = System.Drawing.Color.Black;
            this.gnbtnSua.Location = new System.Drawing.Point(358, 27);
            this.gnbtnSua.Name = "gnbtnSua";
            this.gnbtnSua.Size = new System.Drawing.Size(124, 45);
            this.gnbtnSua.TabIndex = 1;
            this.gnbtnSua.Text = "Sửa ";
            this.gnbtnSua.Click += new System.EventHandler(this.gnbtnSua_Click);
            // 
            // gnbtnThem
            // 
            this.gnbtnThem.BorderRadius = 20;
            this.gnbtnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnThem.ForeColor = System.Drawing.Color.Black;
            this.gnbtnThem.Location = new System.Drawing.Point(81, 27);
            this.gnbtnThem.Name = "gnbtnThem";
            this.gnbtnThem.Size = new System.Drawing.Size(124, 45);
            this.gnbtnThem.TabIndex = 0;
            this.gnbtnThem.Text = "Thêm ";
            this.gnbtnThem.Click += new System.EventHandler(this.gnbtnThem_Click);
            // 
            // pnThongTin
            // 
            this.pnThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnThongTin.Controls.Add(this.gntxtSĐT);
            this.pnThongTin.Controls.Add(this.gntxtDiaChi);
            this.pnThongTin.Controls.Add(this.gntxtTen);
            this.pnThongTin.Controls.Add(this.gntxtMa);
            this.pnThongTin.Controls.Add(this.lbSĐt);
            this.pnThongTin.Controls.Add(this.lbDiachi);
            this.pnThongTin.Controls.Add(this.lbTen);
            this.pnThongTin.Controls.Add(this.lbMa);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnThongTin.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThongTin.ForeColor = System.Drawing.Color.Black;
            this.pnThongTin.Location = new System.Drawing.Point(861, 73);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(321, 536);
            this.pnThongTin.TabIndex = 2;
            // 
            // gntxtSĐT
            // 
            this.gntxtSĐT.BorderRadius = 10;
            this.gntxtSĐT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtSĐT.DefaultText = "";
            this.gntxtSĐT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtSĐT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtSĐT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtSĐT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtSĐT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtSĐT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtSĐT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtSĐT.Location = new System.Drawing.Point(60, 438);
            this.gntxtSĐT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtSĐT.Name = "gntxtSĐT";
            this.gntxtSĐT.PasswordChar = '\0';
            this.gntxtSĐT.PlaceholderText = "";
            this.gntxtSĐT.SelectedText = "";
            this.gntxtSĐT.Size = new System.Drawing.Size(229, 48);
            this.gntxtSĐT.TabIndex = 4;
            this.gntxtSĐT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gntxtSĐT_KeyPress);
            // 
            // gntxtDiaChi
            // 
            this.gntxtDiaChi.BorderRadius = 10;
            this.gntxtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtDiaChi.DefaultText = "";
            this.gntxtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtDiaChi.Location = new System.Drawing.Point(60, 310);
            this.gntxtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtDiaChi.Name = "gntxtDiaChi";
            this.gntxtDiaChi.PasswordChar = '\0';
            this.gntxtDiaChi.PlaceholderText = "";
            this.gntxtDiaChi.SelectedText = "";
            this.gntxtDiaChi.Size = new System.Drawing.Size(229, 48);
            this.gntxtDiaChi.TabIndex = 3;
            // 
            // gntxtTen
            // 
            this.gntxtTen.BorderRadius = 10;
            this.gntxtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTen.DefaultText = "";
            this.gntxtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTen.Location = new System.Drawing.Point(60, 182);
            this.gntxtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTen.Name = "gntxtTen";
            this.gntxtTen.PasswordChar = '\0';
            this.gntxtTen.PlaceholderText = "";
            this.gntxtTen.SelectedText = "";
            this.gntxtTen.Size = new System.Drawing.Size(229, 48);
            this.gntxtTen.TabIndex = 2;
            // 
            // gntxtMa
            // 
            this.gntxtMa.BorderRadius = 10;
            this.gntxtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtMa.DefaultText = "";
            this.gntxtMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMa.Location = new System.Drawing.Point(60, 67);
            this.gntxtMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtMa.Name = "gntxtMa";
            this.gntxtMa.PasswordChar = '\0';
            this.gntxtMa.PlaceholderText = "";
            this.gntxtMa.SelectedText = "";
            this.gntxtMa.Size = new System.Drawing.Size(229, 48);
            this.gntxtMa.TabIndex = 1;
            // 
            // lbSĐt
            // 
            this.lbSĐt.AutoSize = true;
            this.lbSĐt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSĐt.ForeColor = System.Drawing.Color.Black;
            this.lbSĐt.Location = new System.Drawing.Point(32, 403);
            this.lbSĐt.Name = "lbSĐt";
            this.lbSĐt.Size = new System.Drawing.Size(143, 22);
            this.lbSĐt.TabIndex = 0;
            this.lbSĐt.Text = "Số điện thoại KH";
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiachi.ForeColor = System.Drawing.Color.Black;
            this.lbDiachi.Location = new System.Drawing.Point(30, 273);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(161, 22);
            this.lbDiachi.TabIndex = 0;
            this.lbDiachi.Text = "Địa chỉ khách hàng";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.Black;
            this.lbTen.Location = new System.Drawing.Point(32, 146);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(160, 22);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Họ tên khách hàng";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMa.ForeColor = System.Drawing.Color.Black;
            this.lbMa.Location = new System.Drawing.Point(32, 30);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(130, 22);
            this.lbMa.TabIndex = 0;
            this.lbMa.Text = "Mã khách hàng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gndgvKH);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(861, 536);
            this.panel4.TabIndex = 3;
            // 
            // gndgvKH
            // 
            this.gndgvKH.AllowUserToAddRows = false;
            this.gndgvKH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gndgvKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gndgvKH.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gndgvKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gndgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gndgvKH.ColumnHeadersHeight = 40;
            this.gndgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clTen,
            this.clDiaChi,
            this.clSĐT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gndgvKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.gndgvKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gndgvKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvKH.Location = new System.Drawing.Point(0, 0);
            this.gndgvKH.Name = "gndgvKH";
            this.gndgvKH.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gndgvKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gndgvKH.RowHeadersVisible = false;
            this.gndgvKH.RowHeadersWidth = 50;
            this.gndgvKH.RowTemplate.Height = 24;
            this.gndgvKH.Size = new System.Drawing.Size(861, 536);
            this.gndgvKH.TabIndex = 0;
            this.gndgvKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gndgvKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gndgvKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gndgvKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gndgvKH.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gndgvKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gndgvKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gndgvKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gndgvKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvKH.ThemeStyle.HeaderStyle.Height = 40;
            this.gndgvKH.ThemeStyle.ReadOnly = true;
            this.gndgvKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gndgvKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gndgvKH.ThemeStyle.RowsStyle.Height = 24;
            this.gndgvKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gndgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gndgvKH_CellClick);
            // 
            // clMa
            // 
            this.clMa.DataPropertyName = "khachHangID";
            this.clMa.HeaderText = "Mã khách hàng";
            this.clMa.MinimumWidth = 6;
            this.clMa.Name = "clMa";
            this.clMa.ReadOnly = true;
            // 
            // clTen
            // 
            this.clTen.DataPropertyName = "hoTenKH";
            this.clTen.HeaderText = "Họ tên khách hàng";
            this.clTen.MinimumWidth = 6;
            this.clTen.Name = "clTen";
            this.clTen.ReadOnly = true;
            // 
            // clDiaChi
            // 
            this.clDiaChi.DataPropertyName = "diaChiKH";
            this.clDiaChi.HeaderText = "Địa chỉ khách hàng";
            this.clDiaChi.MinimumWidth = 6;
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.ReadOnly = true;
            // 
            // clSĐT
            // 
            this.clSĐT.DataPropertyName = "sdtKH";
            this.clSĐT.HeaderText = "Số điện thoại KH";
            this.clSĐT.MinimumWidth = 6;
            this.clSĐT.Name = "clSĐT";
            this.clSĐT.ReadOnly = true;
            // 
            // GUI_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnThongTin);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_KhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.GUI_KhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnChucNang.ResumeLayout(false);
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gndgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTimKiem;
        private Guna.UI2.WinForms.Guna2Button gnbtnTimKiem;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.Panel pnChucNang;
        private Guna.UI2.WinForms.Guna2Button gnbtnLamMoi;
        private Guna.UI2.WinForms.Guna2Button gnbtnXoa;
        private Guna.UI2.WinForms.Guna2Button gnbtnSua;
        private Guna.UI2.WinForms.Guna2Button gnbtnThem;
        private System.Windows.Forms.Panel pnThongTin;
        private Guna.UI2.WinForms.Guna2TextBox gntxtSĐT;
        private Guna.UI2.WinForms.Guna2TextBox gntxtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTen;
        private Guna.UI2.WinForms.Guna2TextBox gntxtMa;
        private System.Windows.Forms.Label lbSĐt;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView gndgvKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSĐT;
    }
}