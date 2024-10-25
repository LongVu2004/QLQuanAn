namespace QL_QuanAn
{
    partial class Form_HoaDon
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
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemDonHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmTimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.AllowUserToAddRows = false;
            this.dgvDSHoaDon.AllowUserToDeleteRows = false;
            this.dgvDSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.DanhMuc,
            this.Gia,
            this.TongTien});
            this.dgvDSHoaDon.Location = new System.Drawing.Point(12, 79);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.ReadOnly = true;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(776, 349);
            this.dgvDSHoaDon.TabIndex = 2;
            // 
            // MaMonAn
            // 
            this.MaMonAn.HeaderText = "Mã hóa đơn";
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.ReadOnly = true;
            // 
            // TenMonAn
            // 
            this.TenMonAn.HeaderText = "Mã khách hàng";
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.ReadOnly = true;
            // 
            // DanhMuc
            // 
            this.DanhMuc.HeaderText = "Tên khách hàng";
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Ngày lập";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm đơn hàng";
            // 
            // txtTimKiemDonHang
            // 
            this.txtTimKiemDonHang.Location = new System.Drawing.Point(160, 32);
            this.txtTimKiemDonHang.Name = "txtTimKiemDonHang";
            this.txtTimKiemDonHang.Size = new System.Drawing.Size(151, 20);
            this.txtTimKiemDonHang.TabIndex = 4;
            this.txtTimKiemDonHang.TextChanged += new System.EventHandler(this.txtTimKiemDonHang_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // cbmTimKiem
            // 
            this.cbmTimKiem.FormattingEnabled = true;
            this.cbmTimKiem.Items.AddRange(new object[] {
            "Hóa đơn",
            "Khách hàng"});
            this.cbmTimKiem.Location = new System.Drawing.Point(451, 31);
            this.cbmTimKiem.Name = "cbmTimKiem";
            this.cbmTimKiem.Size = new System.Drawing.Size(131, 21);
            this.cbmTimKiem.TabIndex = 5;
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbmTimKiem);
            this.Controls.Add(this.txtTimKiemDonHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSHoaDon);
            this.Name = "Form_HoaDon";
            this.Text = "Form_HoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmTimKiem;
    }
}