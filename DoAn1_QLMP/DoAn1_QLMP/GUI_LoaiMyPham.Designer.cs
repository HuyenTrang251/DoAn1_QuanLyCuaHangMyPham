namespace DoAn1_QLMP
{
    partial class GUI_LoaiMyPham
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.gnbtnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.gntxtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.gnbtnThem = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnSua = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.gnpnChucNang = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.gntxtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.gntxtMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.gndgvLoaiMP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaLMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.pnChucNang.SuspendLayout();
            this.gnpnChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gndgvLoaiMP)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Snow;
            this.guna2Panel1.Controls.Add(this.lblTieuDe);
            this.guna2Panel1.Controls.Add(this.gnbtnTimKiem);
            this.guna2Panel1.Controls.Add(this.gntxtTimKiem);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1182, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.White;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(18, 33);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(186, 30);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "Loại Mỹ Phẩm";
            // 
            // gnbtnTimKiem
            // 
            this.gnbtnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gnbtnTimKiem.BorderRadius = 20;
            this.gnbtnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtnTimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.gnbtnTimKiem.Location = new System.Drawing.Point(1013, 29);
            this.gnbtnTimKiem.Name = "gnbtnTimKiem";
            this.gnbtnTimKiem.Size = new System.Drawing.Size(136, 45);
            this.gnbtnTimKiem.TabIndex = 1;
            this.gnbtnTimKiem.Text = "Tìm kiếm";
            this.gnbtnTimKiem.Click += new System.EventHandler(this.gnbtnTimKiem_Click);
            // 
            // gntxtTimKiem
            // 
            this.gntxtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gntxtTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gntxtTimKiem.BorderRadius = 10;
            this.gntxtTimKiem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gntxtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTimKiem.DefaultText = "";
            this.gntxtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gntxtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTimKiem.Location = new System.Drawing.Point(262, 33);
            this.gntxtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTimKiem.Name = "gntxtTimKiem";
            this.gntxtTimKiem.PasswordChar = '\0';
            this.gntxtTimKiem.PlaceholderText = "Nhập từ khóa tìm khóa";
            this.gntxtTimKiem.SelectedText = "";
            this.gntxtTimKiem.Size = new System.Drawing.Size(728, 41);
            this.gntxtTimKiem.TabIndex = 0;
            this.gntxtTimKiem.TextChanged += new System.EventHandler(this.gntxtTimKiem_TextChanged);
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.Color.Snow;
            this.pnChucNang.Controls.Add(this.gnbtnThem);
            this.pnChucNang.Controls.Add(this.gnbtnSua);
            this.pnChucNang.Controls.Add(this.gnbtnXoa);
            this.pnChucNang.Controls.Add(this.gnbtnLamMoi);
            this.pnChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnChucNang.Location = new System.Drawing.Point(0, 595);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1182, 108);
            this.pnChucNang.TabIndex = 4;
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
            this.gnbtnThem.Location = new System.Drawing.Point(86, 26);
            this.gnbtnThem.Name = "gnbtnThem";
            this.gnbtnThem.Size = new System.Drawing.Size(95, 53);
            this.gnbtnThem.TabIndex = 2;
            this.gnbtnThem.Text = "Thêm";
            this.gnbtnThem.Click += new System.EventHandler(this.gnbtnThem_Click);
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
            this.gnbtnSua.Location = new System.Drawing.Point(382, 26);
            this.gnbtnSua.Name = "gnbtnSua";
            this.gnbtnSua.Size = new System.Drawing.Size(95, 53);
            this.gnbtnSua.TabIndex = 3;
            this.gnbtnSua.Text = "Sửa";
            this.gnbtnSua.Click += new System.EventHandler(this.gnbtnSua_Click_1);
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
            this.gnbtnXoa.Location = new System.Drawing.Point(702, 26);
            this.gnbtnXoa.Name = "gnbtnXoa";
            this.gnbtnXoa.Size = new System.Drawing.Size(95, 53);
            this.gnbtnXoa.TabIndex = 4;
            this.gnbtnXoa.Text = "Xóa";
            this.gnbtnXoa.Click += new System.EventHandler(this.gnbtnXoa_Click_1);
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
            this.gnbtnLamMoi.Location = new System.Drawing.Point(937, 26);
            this.gnbtnLamMoi.Name = "gnbtnLamMoi";
            this.gnbtnLamMoi.Size = new System.Drawing.Size(163, 53);
            this.gnbtnLamMoi.TabIndex = 5;
            this.gnbtnLamMoi.Text = "Làm mới";
            this.gnbtnLamMoi.Click += new System.EventHandler(this.gnbtnLamMoi_Click_1);
            // 
            // gnpnChucNang
            // 
            this.gnpnChucNang.BackColor = System.Drawing.Color.Snow;
            this.gnpnChucNang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gnpnChucNang.BorderRadius = 50;
            this.gnpnChucNang.Controls.Add(this.lblTen);
            this.gnpnChucNang.Controls.Add(this.lblMa);
            this.gnpnChucNang.Controls.Add(this.gntxtTen);
            this.gnpnChucNang.Controls.Add(this.gntxtMa);
            this.gnpnChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.gnpnChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnpnChucNang.Location = new System.Drawing.Point(817, 100);
            this.gnpnChucNang.Name = "gnpnChucNang";
            this.gnpnChucNang.Size = new System.Drawing.Size(365, 495);
            this.gnpnChucNang.TabIndex = 5;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Black;
            this.lblTen.Location = new System.Drawing.Point(22, 165);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(171, 24);
            this.lblTen.TabIndex = 13;
            this.lblTen.Text = "Tên loại mỹ phẩm";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.Black;
            this.lblMa.Location = new System.Drawing.Point(22, 37);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(163, 24);
            this.lblMa.TabIndex = 12;
            this.lblMa.Text = "Mã loại mỹ phẩm";
            // 
            // gntxtTen
            // 
            this.gntxtTen.BorderRadius = 15;
            this.gntxtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTen.DefaultText = "";
            this.gntxtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTen.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gntxtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTen.Location = new System.Drawing.Point(38, 199);
            this.gntxtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTen.Name = "gntxtTen";
            this.gntxtTen.PasswordChar = '\0';
            this.gntxtTen.PlaceholderText = "";
            this.gntxtTen.SelectedText = "";
            this.gntxtTen.Size = new System.Drawing.Size(298, 37);
            this.gntxtTen.TabIndex = 1;
            // 
            // gntxtMa
            // 
            this.gntxtMa.BorderRadius = 15;
            this.gntxtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtMa.DefaultText = "";
            this.gntxtMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMa.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gntxtMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMa.Location = new System.Drawing.Point(38, 72);
            this.gntxtMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtMa.Name = "gntxtMa";
            this.gntxtMa.PasswordChar = '\0';
            this.gntxtMa.PlaceholderText = "";
            this.gntxtMa.SelectedText = "";
            this.gntxtMa.Size = new System.Drawing.Size(298, 37);
            this.gntxtMa.TabIndex = 0;
            // 
            // gndgvLoaiMP
            // 
            this.gndgvLoaiMP.AllowUserToAddRows = false;
            this.gndgvLoaiMP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gndgvLoaiMP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gndgvLoaiMP.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gndgvLoaiMP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gndgvLoaiMP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gndgvLoaiMP.ColumnHeadersHeight = 40;
            this.gndgvLoaiMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvLoaiMP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLMP,
            this.tenLMP});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gndgvLoaiMP.DefaultCellStyle = dataGridViewCellStyle3;
            this.gndgvLoaiMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gndgvLoaiMP.GridColor = System.Drawing.Color.Silver;
            this.gndgvLoaiMP.Location = new System.Drawing.Point(0, 100);
            this.gndgvLoaiMP.Name = "gndgvLoaiMP";
            this.gndgvLoaiMP.ReadOnly = true;
            this.gndgvLoaiMP.RowHeadersVisible = false;
            this.gndgvLoaiMP.RowHeadersWidth = 51;
            this.gndgvLoaiMP.RowTemplate.Height = 24;
            this.gndgvLoaiMP.Size = new System.Drawing.Size(817, 495);
            this.gndgvLoaiMP.TabIndex = 6;
            this.gndgvLoaiMP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvLoaiMP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gndgvLoaiMP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gndgvLoaiMP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gndgvLoaiMP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gndgvLoaiMP.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gndgvLoaiMP.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.gndgvLoaiMP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gndgvLoaiMP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gndgvLoaiMP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvLoaiMP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gndgvLoaiMP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gndgvLoaiMP.ThemeStyle.HeaderStyle.Height = 40;
            this.gndgvLoaiMP.ThemeStyle.ReadOnly = true;
            this.gndgvLoaiMP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gndgvLoaiMP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gndgvLoaiMP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndgvLoaiMP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gndgvLoaiMP.ThemeStyle.RowsStyle.Height = 24;
            this.gndgvLoaiMP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gndgvLoaiMP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gndgvLoaiMP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gndgvLoaiMP_CellClick_1);
            // 
            // MaLMP
            // 
            this.MaLMP.DataPropertyName = "loaiMyPhamID";
            this.MaLMP.HeaderText = "Mã loại mỹ phẩm";
            this.MaLMP.MinimumWidth = 6;
            this.MaLMP.Name = "MaLMP";
            this.MaLMP.ReadOnly = true;
            // 
            // tenLMP
            // 
            this.tenLMP.DataPropertyName = "tenLoaiMP";
            this.tenLMP.HeaderText = "Tên loại mỹ phẩm";
            this.tenLMP.MinimumWidth = 6;
            this.tenLMP.Name = "tenLMP";
            this.tenLMP.ReadOnly = true;
            // 
            // GUI_LoaiMyPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.gndgvLoaiMP);
            this.Controls.Add(this.gnpnChucNang);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "GUI_LoaiMyPham";
            this.Text = "Loại mỹ phẩm";
            this.Load += new System.EventHandler(this.GUI_LoaiMyPham_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnChucNang.ResumeLayout(false);
            this.gnpnChucNang.ResumeLayout(false);
            this.gnpnChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gndgvLoaiMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button gnbtnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTimKiem;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnChucNang;
        private Guna.UI2.WinForms.Guna2Button gnbtnThem;
        private Guna.UI2.WinForms.Guna2Button gnbtnSua;
        private Guna.UI2.WinForms.Guna2Button gnbtnXoa;
        private Guna.UI2.WinForms.Guna2Button gnbtnLamMoi;
        private Guna.UI2.WinForms.Guna2Panel gnpnChucNang;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTen;
        private Guna.UI2.WinForms.Guna2TextBox gntxtMa;
        private Guna.UI2.WinForms.Guna2DataGridView gndgvLoaiMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLMP;
    }
}