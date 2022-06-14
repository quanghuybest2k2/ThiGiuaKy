
namespace De2
{
    partial class frmHoaNhap
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
            this.btnThemNhCC = new System.Windows.Forms.Button();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.nrudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.txtPhaiTra = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnChonHD = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.lblPhanTram = new System.Windows.Forms.Label();
            this.cbbNhaCC = new System.Windows.Forms.ComboBox();
            this.dtgvMatHang = new System.Windows.Forms.DataGridView();
            this.lblPhaiTra = new System.Windows.Forms.Label();
            this.lblPhanTramGD = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.lblNhaCC = new System.Windows.Forms.Label();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.lblHoaDonBH = new System.Windows.Forms.Label();
            this.colTenHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nrudGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemNhCC
            // 
            this.btnThemNhCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhCC.Location = new System.Drawing.Point(532, 61);
            this.btnThemNhCC.Name = "btnThemNhCC";
            this.btnThemNhCC.Size = new System.Drawing.Size(44, 23);
            this.btnThemNhCC.TabIndex = 26;
            this.btnThemNhCC.Text = "+";
            this.btnThemNhCC.UseVisualStyleBackColor = true;
            this.btnThemNhCC.Click += new System.EventHandler(this.btnThemNhCC_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(88, 64);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(161, 20);
            this.dtpNgayNhap.TabIndex = 24;
            // 
            // nrudGiamGia
            // 
            this.nrudGiamGia.Location = new System.Drawing.Point(290, 327);
            this.nrudGiamGia.Name = "nrudGiamGia";
            this.nrudGiamGia.Size = new System.Drawing.Size(56, 20);
            this.nrudGiamGia.TabIndex = 23;
            // 
            // txtPhaiTra
            // 
            this.txtPhaiTra.Enabled = false;
            this.txtPhaiTra.Location = new System.Drawing.Point(458, 326);
            this.txtPhaiTra.Name = "txtPhaiTra";
            this.txtPhaiTra.Size = new System.Drawing.Size(119, 20);
            this.txtPhaiTra.TabIndex = 22;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(88, 329);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(119, 20);
            this.txtTongTien.TabIndex = 21;
            // 
            // btnChonHD
            // 
            this.btnChonHD.Location = new System.Drawing.Point(467, 359);
            this.btnChonHD.Name = "btnChonHD";
            this.btnChonHD.Size = new System.Drawing.Size(124, 23);
            this.btnChonHD.TabIndex = 19;
            this.btnChonHD.Text = "Chọn HĐ bán";
            this.btnChonHD.UseVisualStyleBackColor = true;
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Location = new System.Drawing.Point(332, 359);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(97, 23);
            this.btnHuyHoaDon.TabIndex = 18;
            this.btnHuyHoaDon.Text = "Hủy hóa đơn";
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(218, 359);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnLuuHoaDon.TabIndex = 20;
            this.btnLuuHoaDon.Text = "Lưu";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // lblPhanTram
            // 
            this.lblPhanTram.AutoSize = true;
            this.lblPhanTram.Location = new System.Drawing.Point(352, 329);
            this.lblPhanTram.Name = "lblPhanTram";
            this.lblPhanTram.Size = new System.Drawing.Size(15, 13);
            this.lblPhanTram.TabIndex = 16;
            this.lblPhanTram.Text = "%";
            // 
            // cbbNhaCC
            // 
            this.cbbNhaCC.FormattingEnabled = true;
            this.cbbNhaCC.Location = new System.Drawing.Point(371, 63);
            this.cbbNhaCC.Name = "cbbNhaCC";
            this.cbbNhaCC.Size = new System.Drawing.Size(155, 21);
            this.cbbNhaCC.TabIndex = 25;
            // 
            // dtgvMatHang
            // 
            this.dtgvMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenHang,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.dtgvMatHang.Location = new System.Drawing.Point(30, 116);
            this.dtgvMatHang.Name = "dtgvMatHang";
            this.dtgvMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMatHang.Size = new System.Drawing.Size(561, 192);
            this.dtgvMatHang.TabIndex = 17;
            this.dtgvMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMatHang_CellContentClick);
            // 
            // lblPhaiTra
            // 
            this.lblPhaiTra.AutoSize = true;
            this.lblPhaiTra.Location = new System.Drawing.Point(409, 329);
            this.lblPhaiTra.Name = "lblPhaiTra";
            this.lblPhaiTra.Size = new System.Drawing.Size(43, 13);
            this.lblPhaiTra.TabIndex = 14;
            this.lblPhaiTra.Text = "Phải trả";
            // 
            // lblPhanTramGD
            // 
            this.lblPhanTramGD.AutoSize = true;
            this.lblPhanTramGD.Location = new System.Drawing.Point(225, 329);
            this.lblPhanTramGD.Name = "lblPhanTramGD";
            this.lblPhanTramGD.Size = new System.Drawing.Size(59, 13);
            this.lblPhanTramGD.TabIndex = 13;
            this.lblPhanTramGD.Text = "% Giảm giá";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(30, 332);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(52, 13);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Location = new System.Drawing.Point(27, 100);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(93, 13);
            this.lblChiTiet.TabIndex = 11;
            this.lblChiTiet.Text = "Chi tiết hàng nhập";
            // 
            // lblNhaCC
            // 
            this.lblNhaCC.AutoSize = true;
            this.lblNhaCC.Location = new System.Drawing.Point(290, 66);
            this.lblNhaCC.Name = "lblNhaCC";
            this.lblNhaCC.Size = new System.Drawing.Size(75, 13);
            this.lblNhaCC.TabIndex = 10;
            this.lblNhaCC.Text = "Nhà cung cấp";
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Location = new System.Drawing.Point(27, 66);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(59, 13);
            this.lblNgayXuat.TabIndex = 15;
            this.lblNgayXuat.Text = "Ngày nhập";
            // 
            // lblHoaDonBH
            // 
            this.lblHoaDonBH.AutoSize = true;
            this.lblHoaDonBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonBH.Location = new System.Drawing.Point(140, 10);
            this.lblHoaDonBH.Name = "lblHoaDonBH";
            this.lblHoaDonBH.Size = new System.Drawing.Size(327, 31);
            this.lblHoaDonBH.TabIndex = 9;
            this.lblHoaDonBH.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // colTenHang
            // 
            this.colTenHang.HeaderText = "Tên hàng";
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá nhập";
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            // 
            // frmHoaNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 393);
            this.Controls.Add(this.btnThemNhCC);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.nrudGiamGia);
            this.Controls.Add(this.txtPhaiTra);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnChonHD);
            this.Controls.Add(this.btnHuyHoaDon);
            this.Controls.Add(this.btnLuuHoaDon);
            this.Controls.Add(this.lblPhanTram);
            this.Controls.Add(this.cbbNhaCC);
            this.Controls.Add(this.dtgvMatHang);
            this.Controls.Add(this.lblPhaiTra);
            this.Controls.Add(this.lblPhanTramGD);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.lblNhaCC);
            this.Controls.Add(this.lblNgayXuat);
            this.Controls.Add(this.lblHoaDonBH);
            this.Name = "frmHoaNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaNhap";
            this.Load += new System.EventHandler(this.frmHoaNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrudGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemNhCC;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.NumericUpDown nrudGiamGia;
        private System.Windows.Forms.TextBox txtPhaiTra;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnChonHD;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Label lblPhanTram;
        private System.Windows.Forms.ComboBox cbbNhaCC;
        private System.Windows.Forms.DataGridView dtgvMatHang;
        private System.Windows.Forms.Label lblPhaiTra;
        private System.Windows.Forms.Label lblPhanTramGD;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.Label lblNhaCC;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.Label lblHoaDonBH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}