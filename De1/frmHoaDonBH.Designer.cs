
namespace De1
{
    partial class frmHoaDonBH
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
            this.lblHoaDonBH = new System.Windows.Forms.Label();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblPhanTramGD = new System.Windows.Forms.Label();
            this.lblPhaiTra = new System.Windows.Forms.Label();
            this.dtgvMatHang = new System.Windows.Forms.DataGridView();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnChonHD = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.nrudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.lblPhanTram = new System.Windows.Forms.Label();
            this.txtPhaiTra = new System.Windows.Forms.TextBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.colTenHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrudGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoaDonBH
            // 
            this.lblHoaDonBH.AutoSize = true;
            this.lblHoaDonBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonBH.Location = new System.Drawing.Point(142, 9);
            this.lblHoaDonBH.Name = "lblHoaDonBH";
            this.lblHoaDonBH.Size = new System.Drawing.Size(306, 31);
            this.lblHoaDonBH.TabIndex = 0;
            this.lblHoaDonBH.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Location = new System.Drawing.Point(29, 65);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(55, 13);
            this.lblNgayXuat.TabIndex = 1;
            this.lblNgayXuat.Text = "Ngày xuất";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(302, 65);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(65, 13);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Location = new System.Drawing.Point(29, 99);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(87, 13);
            this.lblChiTiet.TabIndex = 1;
            this.lblChiTiet.Text = "Chi tiết bán hàng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(32, 331);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(52, 13);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // lblPhanTramGD
            // 
            this.lblPhanTramGD.AutoSize = true;
            this.lblPhanTramGD.Location = new System.Drawing.Point(227, 328);
            this.lblPhanTramGD.Name = "lblPhanTramGD";
            this.lblPhanTramGD.Size = new System.Drawing.Size(59, 13);
            this.lblPhanTramGD.TabIndex = 1;
            this.lblPhanTramGD.Text = "% Giảm giá";
            // 
            // lblPhaiTra
            // 
            this.lblPhaiTra.AutoSize = true;
            this.lblPhaiTra.Location = new System.Drawing.Point(411, 328);
            this.lblPhaiTra.Name = "lblPhaiTra";
            this.lblPhaiTra.Size = new System.Drawing.Size(43, 13);
            this.lblPhaiTra.TabIndex = 1;
            this.lblPhaiTra.Text = "Phải trả";
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
            this.dtgvMatHang.Location = new System.Drawing.Point(32, 115);
            this.dtgvMatHang.Name = "dtgvMatHang";
            this.dtgvMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMatHang.Size = new System.Drawing.Size(561, 192);
            this.dtgvMatHang.TabIndex = 2;
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(220, 358);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnLuuHoaDon.TabIndex = 3;
            this.btnLuuHoaDon.Text = "Lưu";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Location = new System.Drawing.Point(334, 358);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(97, 23);
            this.btnHuyHoaDon.TabIndex = 3;
            this.btnHuyHoaDon.Text = "Hủy hóa đơn";
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnChonHD
            // 
            this.btnChonHD.Location = new System.Drawing.Point(469, 358);
            this.btnChonHD.Name = "btnChonHD";
            this.btnChonHD.Size = new System.Drawing.Size(124, 23);
            this.btnChonHD.TabIndex = 3;
            this.btnChonHD.Text = "Chọn HĐ bán";
            this.btnChonHD.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(90, 328);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(119, 20);
            this.txtTongTien.TabIndex = 4;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // nrudGiamGia
            // 
            this.nrudGiamGia.Location = new System.Drawing.Point(292, 326);
            this.nrudGiamGia.Name = "nrudGiamGia";
            this.nrudGiamGia.Size = new System.Drawing.Size(56, 20);
            this.nrudGiamGia.TabIndex = 5;
            // 
            // lblPhanTram
            // 
            this.lblPhanTram.AutoSize = true;
            this.lblPhanTram.Location = new System.Drawing.Point(354, 328);
            this.lblPhanTram.Name = "lblPhanTram";
            this.lblPhanTram.Size = new System.Drawing.Size(15, 13);
            this.lblPhanTram.TabIndex = 1;
            this.lblPhanTram.Text = "%";
            // 
            // txtPhaiTra
            // 
            this.txtPhaiTra.Enabled = false;
            this.txtPhaiTra.Location = new System.Drawing.Point(460, 325);
            this.txtPhaiTra.Name = "txtPhaiTra";
            this.txtPhaiTra.Size = new System.Drawing.Size(119, 20);
            this.txtPhaiTra.TabIndex = 4;
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayXuat.Enabled = false;
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuat.Location = new System.Drawing.Point(91, 65);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(161, 20);
            this.dtpNgayXuat.TabIndex = 6;
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(373, 62);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(155, 21);
            this.cbbKhachHang.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(534, 60);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(44, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "+";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // colTenHang
            // 
            this.colTenHang.DataPropertyName = "MaMatHang";
            this.colTenHang.HeaderText = "Tên hàng";
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "thanhtien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            // 
            // frmHoaDonBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 393);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbKhachHang);
            this.Controls.Add(this.dtpNgayXuat);
            this.Controls.Add(this.nrudGiamGia);
            this.Controls.Add(this.txtPhaiTra);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnChonHD);
            this.Controls.Add(this.btnHuyHoaDon);
            this.Controls.Add(this.btnLuuHoaDon);
            this.Controls.Add(this.dtgvMatHang);
            this.Controls.Add(this.lblPhanTram);
            this.Controls.Add(this.lblPhaiTra);
            this.Controls.Add(this.lblPhanTramGD);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.lblNgayXuat);
            this.Controls.Add(this.lblHoaDonBH);
            this.Name = "frmHoaDonBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHoaDonBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrudGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoaDonBH;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblPhanTramGD;
        private System.Windows.Forms.Label lblPhaiTra;
        private System.Windows.Forms.DataGridView dtgvMatHang;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnChonHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.NumericUpDown nrudGiamGia;
        private System.Windows.Forms.Label lblPhanTram;
        private System.Windows.Forms.TextBox txtPhaiTra;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}