namespace DoAn1_QLMP
{
    partial class GUI_DangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.pnPic = new System.Windows.Forms.Panel();
            this.gnbtDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.gntxtMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.gntxtTenTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbTenTK = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1209, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPic
            // 
            this.pnPic.Controls.Add(this.gnbtDangNhap);
            this.pnPic.Controls.Add(this.gntxtMK);
            this.pnPic.Controls.Add(this.gntxtTenTK);
            this.pnPic.Controls.Add(this.lbMK);
            this.pnPic.Controls.Add(this.lbTenTK);
            this.pnPic.Controls.Add(this.guna2PictureBox1);
            this.pnPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPic.Location = new System.Drawing.Point(0, 90);
            this.pnPic.Name = "pnPic";
            this.pnPic.Size = new System.Drawing.Size(1209, 534);
            this.pnPic.TabIndex = 2;
            // 
            // gnbtDangNhap
            // 
            this.gnbtDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gnbtDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtDangNhap.BorderRadius = 20;
            this.gnbtDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtDangNhap.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gnbtDangNhap.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtDangNhap.ForeColor = System.Drawing.Color.Black;
            this.gnbtDangNhap.Location = new System.Drawing.Point(581, 348);
            this.gnbtDangNhap.Name = "gnbtDangNhap";
            this.gnbtDangNhap.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.gnbtDangNhap.Size = new System.Drawing.Size(240, 62);
            this.gnbtDangNhap.TabIndex = 3;
            this.gnbtDangNhap.Text = "Đăng nhập";
            this.gnbtDangNhap.Click += new System.EventHandler(this.gnbtDangNhap_Click);
            // 
            // gntxtMK
            // 
            this.gntxtMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gntxtMK.BackColor = System.Drawing.Color.Pink;
            this.gntxtMK.BorderColor = System.Drawing.Color.Silver;
            this.gntxtMK.BorderRadius = 10;
            this.gntxtMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtMK.DefaultText = "123456@";
            this.gntxtMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMK.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gntxtMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMK.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gntxtMK.ForeColor = System.Drawing.Color.Black;
            this.gntxtMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMK.Location = new System.Drawing.Point(493, 253);
            this.gntxtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtMK.Name = "gntxtMK";
            this.gntxtMK.PasswordChar = '*';
            this.gntxtMK.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gntxtMK.PlaceholderText = "";
            this.gntxtMK.SelectedText = "";
            this.gntxtMK.Size = new System.Drawing.Size(452, 50);
            this.gntxtMK.TabIndex = 2;
            this.gntxtMK.Leave += new System.EventHandler(this.gntxtMK_Leave);
            // 
            // gntxtTenTK
            // 
            this.gntxtTenTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gntxtTenTK.BackColor = System.Drawing.Color.Pink;
            this.gntxtTenTK.BorderColor = System.Drawing.Color.Silver;
            this.gntxtTenTK.BorderRadius = 10;
            this.gntxtTenTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTenTK.DefaultText = "nv00";
            this.gntxtTenTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTenTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTenTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTenTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTenTK.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gntxtTenTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTenTK.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gntxtTenTK.ForeColor = System.Drawing.Color.Black;
            this.gntxtTenTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTenTK.Location = new System.Drawing.Point(493, 160);
            this.gntxtTenTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTenTK.Name = "gntxtTenTK";
            this.gntxtTenTK.PasswordChar = '\0';
            this.gntxtTenTK.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gntxtTenTK.PlaceholderText = "Nhập tên tài khoản";
            this.gntxtTenTK.SelectedText = "";
            this.gntxtTenTK.Size = new System.Drawing.Size(452, 50);
            this.gntxtTenTK.TabIndex = 1;
            this.gntxtTenTK.Leave += new System.EventHandler(this.gntxtTenTK_Leave);
            // 
            // lbMK
            // 
            this.lbMK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMK.AutoSize = true;
            this.lbMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbMK.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.ForeColor = System.Drawing.Color.Black;
            this.lbMK.Location = new System.Drawing.Point(256, 253);
            this.lbMK.Name = "lbMK";
            this.lbMK.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.lbMK.Size = new System.Drawing.Size(154, 50);
            this.lbMK.TabIndex = 0;
            this.lbMK.Text = "Mật khẩu";
            // 
            // lbTenTK
            // 
            this.lbTenTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenTK.AutoSize = true;
            this.lbTenTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTenTK.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTK.ForeColor = System.Drawing.Color.Black;
            this.lbTenTK.Location = new System.Drawing.Point(240, 160);
            this.lbTenTK.Name = "lbTenTK";
            this.lbTenTK.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.lbTenTK.Size = new System.Drawing.Size(205, 50);
            this.lbTenTK.TabIndex = 0;
            this.lbTenTK.Text = "Tên tài khoản";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1209, 534);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 624);
            this.Controls.Add(this.pnPic);
            this.Controls.Add(this.label1);
            this.Name = "GUI_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.GUI_DangNhap_Load);
            this.pnPic.ResumeLayout(false);
            this.pnPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPic;
        private Guna.UI2.WinForms.Guna2Button gnbtDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox gntxtMK;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTenTK;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label lbTenTK;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}