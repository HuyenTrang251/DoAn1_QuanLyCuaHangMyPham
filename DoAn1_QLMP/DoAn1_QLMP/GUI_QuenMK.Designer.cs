namespace DoAn1_QLMP
{
    partial class GUI_QuenMK
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gntxtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.gntxtMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.gntxtNhapLaiMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.gnbtOK = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtQuayLai = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại mật khẩu: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(820, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gntxtTen
            // 
            this.gntxtTen.BorderColor = System.Drawing.Color.Silver;
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
            this.gntxtTen.Location = new System.Drawing.Point(286, 126);
            this.gntxtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTen.Name = "gntxtTen";
            this.gntxtTen.PasswordChar = '\0';
            this.gntxtTen.PlaceholderText = "";
            this.gntxtTen.SelectedText = "";
            this.gntxtTen.Size = new System.Drawing.Size(413, 48);
            this.gntxtTen.TabIndex = 1;
            this.gntxtTen.TextChanged += new System.EventHandler(this.gntxtTen_TextChanged);
            this.gntxtTen.Leave += new System.EventHandler(this.gntxtTen_Leave);
            // 
            // gntxtMK
            // 
            this.gntxtMK.BorderColor = System.Drawing.Color.Silver;
            this.gntxtMK.BorderRadius = 10;
            this.gntxtMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtMK.DefaultText = "";
            this.gntxtMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtMK.Location = new System.Drawing.Point(286, 195);
            this.gntxtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtMK.Name = "gntxtMK";
            this.gntxtMK.PasswordChar = '\0';
            this.gntxtMK.PlaceholderText = "";
            this.gntxtMK.SelectedText = "";
            this.gntxtMK.Size = new System.Drawing.Size(413, 48);
            this.gntxtMK.TabIndex = 2;
            this.gntxtMK.Leave += new System.EventHandler(this.gntxtMK_Leave);
            // 
            // gntxtNhapLaiMK
            // 
            this.gntxtNhapLaiMK.BorderColor = System.Drawing.Color.Silver;
            this.gntxtNhapLaiMK.BorderRadius = 10;
            this.gntxtNhapLaiMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtNhapLaiMK.DefaultText = "";
            this.gntxtNhapLaiMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtNhapLaiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtNhapLaiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtNhapLaiMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtNhapLaiMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtNhapLaiMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtNhapLaiMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtNhapLaiMK.Location = new System.Drawing.Point(286, 266);
            this.gntxtNhapLaiMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtNhapLaiMK.Name = "gntxtNhapLaiMK";
            this.gntxtNhapLaiMK.PasswordChar = '\0';
            this.gntxtNhapLaiMK.PlaceholderText = "";
            this.gntxtNhapLaiMK.SelectedText = "";
            this.gntxtNhapLaiMK.Size = new System.Drawing.Size(413, 48);
            this.gntxtNhapLaiMK.TabIndex = 3;
            this.gntxtNhapLaiMK.TextChanged += new System.EventHandler(this.gntxtNhapLaiMK_TextChanged);
            this.gntxtNhapLaiMK.Leave += new System.EventHandler(this.gntxtNhapLaiMK_Leave);
            // 
            // gnbtOK
            // 
            this.gnbtOK.BorderRadius = 15;
            this.gnbtOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnbtOK.ForeColor = System.Drawing.Color.Black;
            this.gnbtOK.Location = new System.Drawing.Point(286, 368);
            this.gnbtOK.Name = "gnbtOK";
            this.gnbtOK.Size = new System.Drawing.Size(132, 45);
            this.gnbtOK.TabIndex = 4;
            this.gnbtOK.Text = "OK";
            this.gnbtOK.Click += new System.EventHandler(this.gnbtOK_Click);
            // 
            // gnbtQuayLai
            // 
            this.gnbtQuayLai.BorderRadius = 15;
            this.gnbtQuayLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtQuayLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtQuayLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtQuayLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtQuayLai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnbtQuayLai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnbtQuayLai.ForeColor = System.Drawing.Color.Black;
            this.gnbtQuayLai.Location = new System.Drawing.Point(567, 368);
            this.gnbtQuayLai.Name = "gnbtQuayLai";
            this.gnbtQuayLai.Size = new System.Drawing.Size(132, 45);
            this.gnbtQuayLai.TabIndex = 5;
            this.gnbtQuayLai.Text = "Quay lại";
            this.gnbtQuayLai.Click += new System.EventHandler(this.gnbtQuayLai_Click);
            // 
            // GUI_QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.gnbtQuayLai);
            this.Controls.Add(this.gnbtOK);
            this.Controls.Add(this.gntxtNhapLaiMK);
            this.Controls.Add(this.gntxtMK);
            this.Controls.Add(this.gntxtTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_QuenMK";
            this.Text = "Quên mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button gnbtQuayLai;
        private Guna.UI2.WinForms.Guna2Button gnbtOK;
        private Guna.UI2.WinForms.Guna2TextBox gntxtNhapLaiMK;
        private Guna.UI2.WinForms.Guna2TextBox gntxtMK;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTen;
    }
}