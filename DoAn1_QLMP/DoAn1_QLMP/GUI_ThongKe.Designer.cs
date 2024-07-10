namespace DoAn1_QLMP
{
    partial class GUI_ThongKe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmnMyPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnMyPhamTon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnMyPhamBanChay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnHanSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gnbtTK = new Guna.UI2.WinForms.Guna2Button();
            this.gntxtTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.gnbtTKBC = new Guna.UI2.WinForms.Guna2Button();
            this.gndtp1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gndtp2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rvFullHan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvHan1Nam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnMyPham});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 20);
            this.menuStrip1.Size = new System.Drawing.Size(1182, 85);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmnMyPham
            // 
            this.tsmnMyPham.BackColor = System.Drawing.Color.Snow;
            this.tsmnMyPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnMyPhamTon,
            this.tsmnMyPhamBanChay,
            this.tsmnHanSuDung});
            this.tsmnMyPham.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmnMyPham.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.tsmnMyPham.Name = "tsmnMyPham";
            this.tsmnMyPham.Padding = new System.Windows.Forms.Padding(7);
            this.tsmnMyPham.Size = new System.Drawing.Size(145, 48);
            this.tsmnMyPham.Text = "Mỹ phẩm";
            // 
            // tsmnMyPhamTon
            // 
            this.tsmnMyPhamTon.BackColor = System.Drawing.Color.Snow;
            this.tsmnMyPhamTon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmnMyPhamTon.Name = "tsmnMyPhamTon";
            this.tsmnMyPhamTon.Size = new System.Drawing.Size(299, 28);
            this.tsmnMyPhamTon.Text = "Mỹ phẩm tồn";
            this.tsmnMyPhamTon.Click += new System.EventHandler(this.tsmnMyPhamTon_Click);
            // 
            // tsmnMyPhamBanChay
            // 
            this.tsmnMyPhamBanChay.BackColor = System.Drawing.Color.Snow;
            this.tsmnMyPhamBanChay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmnMyPhamBanChay.Name = "tsmnMyPhamBanChay";
            this.tsmnMyPhamBanChay.Size = new System.Drawing.Size(299, 28);
            this.tsmnMyPhamBanChay.Text = "Mỹ phẩm bán chạy ";
            this.tsmnMyPhamBanChay.Click += new System.EventHandler(this.tsmnMyPhamBanChay_Click);
            // 
            // tsmnHanSuDung
            // 
            this.tsmnHanSuDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmnHanSuDung.Name = "tsmnHanSuDung";
            this.tsmnHanSuDung.Size = new System.Drawing.Size(299, 28);
            this.tsmnHanSuDung.Text = "Hạn sử dụng mỹ phẩm";
            this.tsmnHanSuDung.Click += new System.EventHandler(this.tsmnHanSuDung_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Snow;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1182, 718);
            this.reportViewer1.TabIndex = 1;
            // 
            // gnbtTK
            // 
            this.gnbtTK.BorderRadius = 20;
            this.gnbtTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtTK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtTK.ForeColor = System.Drawing.Color.Black;
            this.gnbtTK.Location = new System.Drawing.Point(1008, 23);
            this.gnbtTK.Name = "gnbtTK";
            this.gnbtTK.Size = new System.Drawing.Size(150, 45);
            this.gnbtTK.TabIndex = 2;
            this.gnbtTK.Text = "Thống kê";
            this.gnbtTK.Click += new System.EventHandler(this.gnbtTK_Click);
            // 
            // gntxtTK
            // 
            this.gntxtTK.BorderRadius = 10;
            this.gntxtTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTK.DefaultText = "";
            this.gntxtTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTK.Location = new System.Drawing.Point(723, 26);
            this.gntxtTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTK.Name = "gntxtTK";
            this.gntxtTK.PasswordChar = '\0';
            this.gntxtTK.PlaceholderText = "";
            this.gntxtTK.SelectedText = "";
            this.gntxtTK.Size = new System.Drawing.Size(198, 42);
            this.gntxtTK.TabIndex = 3;
            // 
            // gnbtTKBC
            // 
            this.gnbtTKBC.BorderRadius = 20;
            this.gnbtTKBC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtTKBC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtTKBC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtTKBC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtTKBC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtTKBC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtTKBC.ForeColor = System.Drawing.Color.Black;
            this.gnbtTKBC.Location = new System.Drawing.Point(849, 23);
            this.gnbtTKBC.Name = "gnbtTKBC";
            this.gnbtTKBC.Size = new System.Drawing.Size(129, 45);
            this.gnbtTKBC.TabIndex = 2;
            this.gnbtTKBC.Text = "Thống kê";
            this.gnbtTKBC.Click += new System.EventHandler(this.gnbtTKBC_Click);
            // 
            // gndtp1
            // 
            this.gndtp1.BorderRadius = 15;
            this.gndtp1.Checked = true;
            this.gndtp1.FillColor = System.Drawing.Color.White;
            this.gndtp1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gndtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gndtp1.Location = new System.Drawing.Point(288, 26);
            this.gndtp1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gndtp1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gndtp1.Name = "gndtp1";
            this.gndtp1.Size = new System.Drawing.Size(200, 36);
            this.gndtp1.TabIndex = 4;
            this.gndtp1.Value = new System.DateTime(2024, 1, 1, 10, 12, 0, 0);
            // 
            // gndtp2
            // 
            this.gndtp2.BorderRadius = 15;
            this.gndtp2.Checked = true;
            this.gndtp2.FillColor = System.Drawing.Color.White;
            this.gndtp2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gndtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gndtp2.Location = new System.Drawing.Point(564, 26);
            this.gndtp2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gndtp2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gndtp2.Name = "gndtp2";
            this.gndtp2.Size = new System.Drawing.Size(200, 36);
            this.gndtp2.TabIndex = 5;
            this.gndtp2.Value = new System.DateTime(2024, 5, 25, 10, 12, 31, 525);
            // 
            // rvFullHan
            // 
            this.rvFullHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvFullHan.Location = new System.Drawing.Point(0, 85);
            this.rvFullHan.Name = "rvFullHan";
            this.rvFullHan.ServerReport.BearerToken = null;
            this.rvFullHan.Size = new System.Drawing.Size(1182, 718);
            this.rvFullHan.TabIndex = 6;
            // 
            // rvHan1Nam
            // 
            this.rvHan1Nam.Dock = System.Windows.Forms.DockStyle.Right;
            this.rvHan1Nam.Location = new System.Drawing.Point(288, 85);
            this.rvHan1Nam.Name = "rvHan1Nam";
            this.rvHan1Nam.ServerReport.BearerToken = null;
            this.rvHan1Nam.Size = new System.Drawing.Size(894, 718);
            this.rvHan1Nam.TabIndex = 7;
            // 
            // GUI_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.rvHan1Nam);
            this.Controls.Add(this.rvFullHan);
            this.Controls.Add(this.gndtp2);
            this.Controls.Add(this.gndtp1);
            this.Controls.Add(this.gntxtTK);
            this.Controls.Add(this.gnbtTKBC);
            this.Controls.Add(this.gnbtTK);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.GUI_ThongKe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmnMyPham;
        private System.Windows.Forms.ToolStripMenuItem tsmnMyPhamTon;
        private System.Windows.Forms.ToolStripMenuItem tsmnMyPhamBanChay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button gnbtTK;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTK;
        private Guna.UI2.WinForms.Guna2Button gnbtTKBC;
        private Guna.UI2.WinForms.Guna2DateTimePicker gndtp1;
        private Guna.UI2.WinForms.Guna2DateTimePicker gndtp2;
        private System.Windows.Forms.ToolStripMenuItem tsmnHanSuDung;
        private Microsoft.Reporting.WinForms.ReportViewer rvFullHan;
        private Microsoft.Reporting.WinForms.ReportViewer rvHan1Nam;
    }
}