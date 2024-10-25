namespace QL_QuanAn
{
    partial class Form_MainQuanLy
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labe_name = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.daytime = new System.Windows.Forms.Label();
            this.lbe_tieude = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_doanhthu = new System.Windows.Forms.Button();
            this.btn_monan = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.labe_name);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.daytime);
            this.panel2.Controls.Add(this.lbe_tieude);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(158, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 90);
            this.panel2.TabIndex = 2;
            // 
            // labe_name
            // 
            this.labe_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labe_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labe_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labe_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_name.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labe_name.Location = new System.Drawing.Point(781, 18);
            this.labe_name.Name = "labe_name";
            this.labe_name.ReadOnly = true;
            this.labe_name.Size = new System.Drawing.Size(187, 19);
            this.labe_name.TabIndex = 4;
            this.labe_name.Text = "Admin ";
            this.labe_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(974, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // daytime
            // 
            this.daytime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.daytime.AutoSize = true;
            this.daytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daytime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.daytime.Location = new System.Drawing.Point(856, 60);
            this.daytime.Name = "daytime";
            this.daytime.Size = new System.Drawing.Size(150, 18);
            this.daytime.TabIndex = 2;
            this.daytime.Text = "00:00:00  dd/MM/yyyy";
            // 
            // lbe_tieude
            // 
            this.lbe_tieude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbe_tieude.AutoSize = true;
            this.lbe_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbe_tieude.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbe_tieude.Location = new System.Drawing.Point(383, 28);
            this.lbe_tieude.Name = "lbe_tieude";
            this.lbe_tieude.Size = new System.Drawing.Size(212, 39);
            this.lbe_tieude.TabIndex = 0;
            this.lbe_tieude.Text = "V T P Eatery";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.panel_main.Controls.Add(this.panel_form);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1176, 611);
            this.panel_main.TabIndex = 3;
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.DarkGray;
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_form.Location = new System.Drawing.Point(158, 90);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(1018, 521);
            this.panel_form.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_doanhthu);
            this.panel1.Controls.Add(this.btn_monan);
            this.panel1.Controls.Add(this.btn_hoadon);
            this.panel1.Controls.Add(this.btn_khachhang);
            this.panel1.Controls.Add(this.btn_nhanvien);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 611);
            this.panel1.TabIndex = 1;
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_thoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(0, 400);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_thoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_thoat.Size = new System.Drawing.Size(158, 60);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "   Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_doanhthu
            // 
            this.btn_doanhthu.AutoSize = true;
            this.btn_doanhthu.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_doanhthu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_doanhthu.FlatAppearance.BorderSize = 0;
            this.btn_doanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doanhthu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_doanhthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doanhthu.Location = new System.Drawing.Point(0, 340);
            this.btn_doanhthu.Name = "btn_doanhthu";
            this.btn_doanhthu.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_doanhthu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_doanhthu.Size = new System.Drawing.Size(158, 60);
            this.btn_doanhthu.TabIndex = 6;
            this.btn_doanhthu.Text = "   Doanh thu";
            this.btn_doanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doanhthu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_doanhthu.UseVisualStyleBackColor = false;
            this.btn_doanhthu.Click += new System.EventHandler(this.btn_doanhthu_Click);
            // 
            // btn_monan
            // 
            this.btn_monan.AutoSize = true;
            this.btn_monan.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_monan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_monan.FlatAppearance.BorderSize = 0;
            this.btn_monan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monan.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_monan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_monan.Location = new System.Drawing.Point(0, 280);
            this.btn_monan.Name = "btn_monan";
            this.btn_monan.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_monan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_monan.Size = new System.Drawing.Size(158, 60);
            this.btn_monan.TabIndex = 4;
            this.btn_monan.Text = "   Món Ăn";
            this.btn_monan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_monan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_monan.UseVisualStyleBackColor = false;
            this.btn_monan.Click += new System.EventHandler(this.btn_monan_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.AutoSize = true;
            this.btn_hoadon.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hoadon.FlatAppearance.BorderSize = 0;
            this.btn_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hoadon.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.Location = new System.Drawing.Point(0, 220);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_hoadon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_hoadon.Size = new System.Drawing.Size(158, 60);
            this.btn_hoadon.TabIndex = 3;
            this.btn_hoadon.Text = "   Hoá đơn";
            this.btn_hoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hoadon.UseVisualStyleBackColor = false;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.AutoSize = true;
            this.btn_khachhang.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_khachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_khachhang.FlatAppearance.BorderSize = 0;
            this.btn_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khachhang.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.Location = new System.Drawing.Point(0, 160);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_khachhang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_khachhang.Size = new System.Drawing.Size(158, 60);
            this.btn_khachhang.TabIndex = 2;
            this.btn_khachhang.Text = "   Khách hàng";
            this.btn_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_khachhang.UseVisualStyleBackColor = false;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.AutoSize = true;
            this.btn_nhanvien.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_nhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(0, 90);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_nhanvien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_nhanvien.Size = new System.Drawing.Size(158, 70);
            this.btn_nhanvien.TabIndex = 1;
            this.btn_nhanvien.Text = "   Nhân viên";
            this.btn_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhanvien.UseVisualStyleBackColor = false;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(158, 90);
            this.panelLogo.TabIndex = 0;
            // 
            // Form_MainQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 611);
            this.Controls.Add(this.panel_main);
            this.Name = "Form_MainQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Quán Ăn";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbe_tieude;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Label daytime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox labe_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_doanhthu;
        private System.Windows.Forms.Button btn_monan;
        private System.Windows.Forms.Button btn_hoadon;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Panel panelLogo;
    }
}

