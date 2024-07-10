namespace DoAn1_QLMP
{
    partial class GUI_DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnTDe = new System.Windows.Forms.Panel();
            this.gndtpDay1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gndtpDay2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gntxtTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.gnbtThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnRight = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTDe.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTDe
            // 
            this.pnTDe.BackColor = System.Drawing.Color.Snow;
            this.pnTDe.Controls.Add(this.gndtpDay1);
            this.pnTDe.Controls.Add(this.gndtpDay2);
            this.pnTDe.Controls.Add(this.gntxtTK);
            this.pnTDe.Controls.Add(this.gnbtThongKe);
            this.pnTDe.Controls.Add(this.lbTieuDe);
            this.pnTDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTDe.Location = new System.Drawing.Point(0, 0);
            this.pnTDe.Name = "pnTDe";
            this.pnTDe.Size = new System.Drawing.Size(1140, 104);
            this.pnTDe.TabIndex = 1;
            // 
            // gndtpDay1
            // 
            this.gndtpDay1.BorderRadius = 20;
            this.gndtpDay1.Checked = true;
            this.gndtpDay1.FillColor = System.Drawing.Color.White;
            this.gndtpDay1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndtpDay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gndtpDay1.Location = new System.Drawing.Point(315, 26);
            this.gndtpDay1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gndtpDay1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gndtpDay1.Name = "gndtpDay1";
            this.gndtpDay1.Size = new System.Drawing.Size(200, 45);
            this.gndtpDay1.TabIndex = 4;
            this.gndtpDay1.Value = new System.DateTime(2024, 1, 1, 11, 7, 0, 0);
            // 
            // gndtpDay2
            // 
            this.gndtpDay2.BorderRadius = 20;
            this.gndtpDay2.Checked = true;
            this.gndtpDay2.FillColor = System.Drawing.Color.White;
            this.gndtpDay2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndtpDay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gndtpDay2.Location = new System.Drawing.Point(549, 26);
            this.gndtpDay2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gndtpDay2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gndtpDay2.Name = "gndtpDay2";
            this.gndtpDay2.Size = new System.Drawing.Size(200, 45);
            this.gndtpDay2.TabIndex = 3;
            this.gndtpDay2.Value = new System.DateTime(2024, 5, 30, 11, 7, 26, 895);
            // 
            // gntxtTK
            // 
            this.gntxtTK.BorderRadius = 20;
            this.gntxtTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTK.DefaultText = "";
            this.gntxtTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTK.Location = new System.Drawing.Point(777, 26);
            this.gntxtTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTK.Name = "gntxtTK";
            this.gntxtTK.PasswordChar = '\0';
            this.gntxtTK.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gntxtTK.PlaceholderText = "Nhập năm";
            this.gntxtTK.SelectedText = "";
            this.gntxtTK.Size = new System.Drawing.Size(160, 45);
            this.gntxtTK.TabIndex = 2;
            // 
            // gnbtThongKe
            // 
            this.gnbtThongKe.BorderRadius = 20;
            this.gnbtThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtThongKe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtThongKe.ForeColor = System.Drawing.Color.Black;
            this.gnbtThongKe.Location = new System.Drawing.Point(943, 26);
            this.gnbtThongKe.Name = "gnbtThongKe";
            this.gnbtThongKe.Size = new System.Drawing.Size(155, 45);
            this.gnbtThongKe.TabIndex = 1;
            this.gnbtThongKe.Text = "Thống kê";
            this.gnbtThongKe.Click += new System.EventHandler(this.gnbtThongKe_Click);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTieuDe.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(197, 104);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Doanh thu";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.reportViewer1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLeft.Location = new System.Drawing.Point(0, 104);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(515, 553);
            this.pnLeft.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Snow;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(515, 553);
            this.reportViewer1.TabIndex = 0;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.chart1);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(515, 104);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(625, 553);
            this.pnRight.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Snow;
            this.chart1.BorderlineWidth = 2;
            chartArea2.BackColor = System.Drawing.Color.Snow;
            chartArea2.BorderColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.PaleGreen;
            series4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Doanh Thu";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series5.Legend = "Legend1";
            series5.Name = "Vốn Nhập";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Red;
            series6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.IsValueShownAsLabel = true;
            series6.LabelForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            series6.Legend = "Legend1";
            series6.Name = "Lợi Nhuận";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(625, 553);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Thống kê theo tháng";
            // 
            // GUI_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 657);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTDe);
            this.Name = "GUI_DoanhThu";
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.GUI_DoanhThu_Load);
            this.pnTDe.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTDe;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button gnbtThongKe;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2DateTimePicker gndtpDay1;
        private Guna.UI2.WinForms.Guna2DateTimePicker gndtpDay2;
    }
}