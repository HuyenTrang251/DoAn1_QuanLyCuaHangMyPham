namespace DoAn1_QLMP
{
    partial class GUI_LichSuHuy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTD = new System.Windows.Forms.Label();
            this.pnHDB = new System.Windows.Forms.Panel();
            this.gnbtXoa = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtKhoiPhuc = new Guna.UI2.WinForms.Guna2Button();
            this.gntxtMaHDB = new Guna.UI2.WinForms.Guna2TextBox();
            this.gndgvHDB = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaDHB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayHuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCT = new System.Windows.Forms.Panel();
            this.gndgvCTHDB = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaHDB2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSlg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnHDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gndgvHDB)).BeginInit();
            this.pnCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gndgvCTHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTD
            // 
            this.lbTD.BackColor = System.Drawing.Color.Snow;
            this.lbTD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTD.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTD.Location = new System.Drawing.Point(0, 0);
            this.lbTD.Name = "lbTD";
            this.lbTD.Size = new System.Drawing.Size(1182, 94);
            this.lbTD.TabIndex = 0;
            this.lbTD.Text = "Lịch sử hủy hóa đơn bán";
            this.lbTD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnHDB
            // 
            this.pnHDB.Controls.Add(this.gnbtXoa);
            this.pnHDB.Controls.Add(this.gnbtKhoiPhuc);
            this.pnHDB.Controls.Add(this.gntxtMaHDB);
            this.pnHDB.Controls.Add(this.gndgvHDB);
            this.pnHDB.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnHDB.Location = new System.Drawing.Point(0, 94);
            this.pnHDB.Name = "pnHDB";
            this.pnHDB.Size = new System.Drawing.Size(674, 709);
            this.pnHDB.TabIndex = 1;
            // 
            // gnbtXoa
            // 
            this.gnbtXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gnbtXoa.BorderRadius = 20;
            this.gnbtXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtXoa.ForeColor = System.Drawing.Color.Black;
            this.gnbtXoa.Location = new System.Drawing.Point(499, 648);
            this.gnbtXoa.Name = "gnbtXoa";
            this.gnbtXoa.Size = new System.Drawing.Size(142, 45);
            this.gnbtXoa.TabIndex = 6;
            this.gnbtXoa.Text = "Xóa";
            this.gnbtXoa.Click += new System.EventHandler(this.gnbtXoa_Click);
            // 
            // gnbtKhoiPhuc
            // 
            this.gnbtKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gnbtKhoiPhuc.BorderRadius = 20;
            this.gnbtKhoiPhuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtKhoiPhuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtKhoiPhuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtKhoiPhuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtKhoiPhuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtKhoiPhuc.ForeColor = System.Drawing.Color.Black;
            this.gnbtKhoiPhuc.Location = new System.Drawing.Point(272, 648);
            this.gnbtKhoiPhuc.Name = "gnbtKhoiPhuc";
            this.gnbtKhoiPhuc.Size = new System.Drawing.Size(142, 45);
            this.gnbtKhoiPhuc.TabIndex = 6;
            this.gnbtKhoiPhuc.Text = "Khôi phục";
            this.gnbtKhoiPhuc.Click += new System.EventHandler(this.gnbtKhoiPhuc_Click);
            // 
            // gntxtMaHDB
            // 
            this.gntxtMaHDB.BorderColor = System.Drawing.Color.Gray;
            this.gntxtMaHDB.BorderRadius = 15;
            this.gntxtMaHDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtMaHDB.DefaultText = "";
            this.gntxtMaHDB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtMaHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtMaHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMaHDB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMaHDB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMaHDB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gntxtMaHDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gntxtMaHDB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMaHDB.Location = new System.Drawing.Point(32, 648);
            this.gntxtMaHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtMaHDB.Name = "gntxtMaHDB";
            this.gntxtMaHDB.PasswordChar = '\0';
            this.gntxtMaHDB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.gntxtMaHDB.PlaceholderText = "mã hóa đơn ";
            this.gntxtMaHDB.SelectedText = "";
            this.gntxtMaHDB.Size = new System.Drawing.Size(162, 48);
            this.gntxtMaHDB.TabIndex = 5;
            // 
            // gndgvHDB
            // 
            this.gndgvHDB.AllowUserToAddRows = false;
            this.gndgvHDB.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gndgvHDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gndgvHDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gndgvHDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gndgvHDB.ColumnHeadersHeight = 35;
            this.gndgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaDHB,
            this.clTenNV,
            this.clTenKH,
            this.clNgayBan,
            this.clTongTien,
            this.clNgayHuy});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gndgvHDB.DefaultCellStyle = dataGridViewCellStyle3;
            this.gndgvHDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.gndgvHDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvHDB.Location = new System.Drawing.Point(0, 0);
            this.gndgvHDB.Name = "gndgvHDB";
            this.gndgvHDB.ReadOnly = true;
            this.gndgvHDB.RowHeadersVisible = false;
            this.gndgvHDB.RowHeadersWidth = 51;
            this.gndgvHDB.RowTemplate.Height = 24;
            this.gndgvHDB.Size = new System.Drawing.Size(674, 631);
            this.gndgvHDB.TabIndex = 4;
            this.gndgvHDB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvHDB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gndgvHDB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gndgvHDB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gndgvHDB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gndgvHDB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gndgvHDB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvHDB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gndgvHDB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gndgvHDB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvHDB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gndgvHDB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvHDB.ThemeStyle.HeaderStyle.Height = 35;
            this.gndgvHDB.ThemeStyle.ReadOnly = true;
            this.gndgvHDB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvHDB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gndgvHDB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvHDB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gndgvHDB.ThemeStyle.RowsStyle.Height = 24;
            this.gndgvHDB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvHDB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gndgvHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gndgvHDB_CellClick);
            // 
            // clMaDHB
            // 
            this.clMaDHB.DataPropertyName = "donHangBanID";
            this.clMaDHB.HeaderText = "Mã đơn hàng bán";
            this.clMaDHB.MinimumWidth = 6;
            this.clMaDHB.Name = "clMaDHB";
            this.clMaDHB.ReadOnly = true;
            // 
            // clTenNV
            // 
            this.clTenNV.DataPropertyName = "hoTenNV";
            this.clTenNV.HeaderText = "Tên nhân viên";
            this.clTenNV.MinimumWidth = 6;
            this.clTenNV.Name = "clTenNV";
            this.clTenNV.ReadOnly = true;
            // 
            // clTenKH
            // 
            this.clTenKH.DataPropertyName = "hoTenKH";
            this.clTenKH.HeaderText = "Tên khách hàng";
            this.clTenKH.MinimumWidth = 6;
            this.clTenKH.Name = "clTenKH";
            this.clTenKH.ReadOnly = true;
            // 
            // clNgayBan
            // 
            this.clNgayBan.DataPropertyName = "ngayBan";
            this.clNgayBan.HeaderText = "Ngày bán";
            this.clNgayBan.MinimumWidth = 6;
            this.clNgayBan.Name = "clNgayBan";
            this.clNgayBan.ReadOnly = true;
            // 
            // clTongTien
            // 
            this.clTongTien.DataPropertyName = "tongTien";
            this.clTongTien.HeaderText = "Tổng tiền";
            this.clTongTien.MinimumWidth = 6;
            this.clTongTien.Name = "clTongTien";
            this.clTongTien.ReadOnly = true;
            // 
            // clNgayHuy
            // 
            this.clNgayHuy.DataPropertyName = "tgHuy";
            this.clNgayHuy.HeaderText = "Thời gian hủy";
            this.clNgayHuy.MinimumWidth = 6;
            this.clNgayHuy.Name = "clNgayHuy";
            this.clNgayHuy.ReadOnly = true;
            // 
            // pnCT
            // 
            this.pnCT.Controls.Add(this.gndgvCTHDB);
            this.pnCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCT.Location = new System.Drawing.Point(674, 94);
            this.pnCT.Name = "pnCT";
            this.pnCT.Size = new System.Drawing.Size(508, 709);
            this.pnCT.TabIndex = 2;
            // 
            // gndgvCTHDB
            // 
            this.gndgvCTHDB.AllowUserToAddRows = false;
            this.gndgvCTHDB.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gndgvCTHDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gndgvCTHDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gndgvCTHDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gndgvCTHDB.ColumnHeadersHeight = 35;
            this.gndgvCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvCTHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaHDB2,
            this.clMaMP,
            this.clSlg,
            this.clDonGia,
            this.clGiamGia,
            this.clThanhTien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gndgvCTHDB.DefaultCellStyle = dataGridViewCellStyle6;
            this.gndgvCTHDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gndgvCTHDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvCTHDB.Location = new System.Drawing.Point(0, 0);
            this.gndgvCTHDB.Name = "gndgvCTHDB";
            this.gndgvCTHDB.ReadOnly = true;
            this.gndgvCTHDB.RowHeadersVisible = false;
            this.gndgvCTHDB.RowHeadersWidth = 51;
            this.gndgvCTHDB.RowTemplate.Height = 24;
            this.gndgvCTHDB.Size = new System.Drawing.Size(508, 709);
            this.gndgvCTHDB.TabIndex = 7;
            this.gndgvCTHDB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvCTHDB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gndgvCTHDB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gndgvCTHDB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gndgvCTHDB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gndgvCTHDB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gndgvCTHDB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvCTHDB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gndgvCTHDB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gndgvCTHDB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvCTHDB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gndgvCTHDB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvCTHDB.ThemeStyle.HeaderStyle.Height = 35;
            this.gndgvCTHDB.ThemeStyle.ReadOnly = true;
            this.gndgvCTHDB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvCTHDB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gndgvCTHDB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvCTHDB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gndgvCTHDB.ThemeStyle.RowsStyle.Height = 24;
            this.gndgvCTHDB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvCTHDB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clMaHDB2
            // 
            this.clMaHDB2.DataPropertyName = "donHangBanID";
            this.clMaHDB2.HeaderText = "Mã hóa đơn bán";
            this.clMaHDB2.MinimumWidth = 6;
            this.clMaHDB2.Name = "clMaHDB2";
            this.clMaHDB2.ReadOnly = true;
            // 
            // clMaMP
            // 
            this.clMaMP.DataPropertyName = "tenMyPham";
            this.clMaMP.HeaderText = "Tên mỹ phẩm";
            this.clMaMP.MinimumWidth = 6;
            this.clMaMP.Name = "clMaMP";
            this.clMaMP.ReadOnly = true;
            // 
            // clSlg
            // 
            this.clSlg.DataPropertyName = "slBan";
            this.clSlg.HeaderText = "Số lượng";
            this.clSlg.MinimumWidth = 6;
            this.clSlg.Name = "clSlg";
            this.clSlg.ReadOnly = true;
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "dgBan";
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.MinimumWidth = 6;
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            // 
            // clGiamGia
            // 
            this.clGiamGia.DataPropertyName = "giamGia";
            this.clGiamGia.HeaderText = "Giảm giá";
            this.clGiamGia.MinimumWidth = 6;
            this.clGiamGia.Name = "clGiamGia";
            this.clGiamGia.ReadOnly = true;
            // 
            // clThanhTien
            // 
            this.clThanhTien.DataPropertyName = "thanhTien";
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.MinimumWidth = 6;
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            // 
            // GUI_LichSuHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.pnCT);
            this.Controls.Add(this.pnHDB);
            this.Controls.Add(this.lbTD);
            this.Name = "GUI_LichSuHuy";
            this.Text = "GUI_LichSuHuy";
            this.Load += new System.EventHandler(this.GUI_LichSuHuy_Load);
            this.pnHDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gndgvHDB)).EndInit();
            this.pnCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gndgvCTHDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTD;
        private System.Windows.Forms.Panel pnHDB;
        private System.Windows.Forms.Panel pnCT;
        private Guna.UI2.WinForms.Guna2DataGridView gndgvCTHDB;
        private Guna.UI2.WinForms.Guna2DataGridView gndgvHDB;
        private Guna.UI2.WinForms.Guna2TextBox gntxtMaHDB;
        private Guna.UI2.WinForms.Guna2Button gnbtKhoiPhuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDHB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayHuy;
        private Guna.UI2.WinForms.Guna2Button gnbtXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHDB2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSlg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
    }
}