
namespace De2
{
    partial class frmQuanLyNCC
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
            this.btnXuatJson = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXoaKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvDanhSachNCC = new System.Windows.Forms.DataGridView();
            this.gbDSNhaCC = new System.Windows.Forms.GroupBox();
            this.gbTimkiem = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTheoSDT = new System.Windows.Forms.RadioButton();
            this.rdTheoTen = new System.Windows.Forms.RadioButton();
            this.btnLuuNCC = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNCC)).BeginInit();
            this.gbDSNhaCC.SuspendLayout();
            this.gbTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuatJson
            // 
            this.btnXuatJson.Location = new System.Drawing.Point(634, 193);
            this.btnXuatJson.Name = "btnXuatJson";
            this.btnXuatJson.Size = new System.Drawing.Size(75, 23);
            this.btnXuatJson.TabIndex = 1;
            this.btnXuatJson.Text = "Xuất JSON";
            this.btnXuatJson.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXoaKhachHang});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 26);
            // 
            // tsmiXoaKhachHang
            // 
            this.tsmiXoaKhachHang.Name = "tsmiXoaKhachHang";
            this.tsmiXoaKhachHang.Size = new System.Drawing.Size(159, 22);
            this.tsmiXoaKhachHang.Text = "Xóa khách hàng";
            // 
            // dtgvDanhSachNCC
            // 
            this.dtgvDanhSachNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colSDT,
            this.colDiaChiGD,
            this.Column1});
            this.dtgvDanhSachNCC.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgvDanhSachNCC.Location = new System.Drawing.Point(6, 19);
            this.dtgvDanhSachNCC.Name = "dtgvDanhSachNCC";
            this.dtgvDanhSachNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachNCC.Size = new System.Drawing.Size(729, 168);
            this.dtgvDanhSachNCC.TabIndex = 0;
            this.dtgvDanhSachNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachNCC_CellContentClick);
            // 
            // gbDSNhaCC
            // 
            this.gbDSNhaCC.Controls.Add(this.dtgvDanhSachNCC);
            this.gbDSNhaCC.Controls.Add(this.btnXuatJson);
            this.gbDSNhaCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDSNhaCC.Location = new System.Drawing.Point(0, 231);
            this.gbDSNhaCC.Name = "gbDSNhaCC";
            this.gbDSNhaCC.Size = new System.Drawing.Size(741, 219);
            this.gbDSNhaCC.TabIndex = 9;
            this.gbDSNhaCC.TabStop = false;
            this.gbDSNhaCC.Text = "Danh sách khách hàng";
            // 
            // gbTimkiem
            // 
            this.gbTimkiem.Controls.Add(this.txtTimKiem);
            this.gbTimkiem.Controls.Add(this.rdTheoSDT);
            this.gbTimkiem.Controls.Add(this.rdTheoTen);
            this.gbTimkiem.Location = new System.Drawing.Point(327, 175);
            this.gbTimkiem.Name = "gbTimkiem";
            this.gbTimkiem.Size = new System.Drawing.Size(382, 50);
            this.gbTimkiem.TabIndex = 8;
            this.gbTimkiem.TabStop = false;
            this.gbTimkiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(172, 18);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(188, 20);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdTheoSDT
            // 
            this.rdTheoSDT.AutoSize = true;
            this.rdTheoSDT.Location = new System.Drawing.Point(91, 19);
            this.rdTheoSDT.Name = "rdTheoSDT";
            this.rdTheoSDT.Size = new System.Drawing.Size(75, 17);
            this.rdTheoSDT.TabIndex = 1;
            this.rdTheoSDT.Text = "Theo SDT";
            this.rdTheoSDT.UseVisualStyleBackColor = true;
            // 
            // rdTheoTen
            // 
            this.rdTheoTen.AutoSize = true;
            this.rdTheoTen.Checked = true;
            this.rdTheoTen.Location = new System.Drawing.Point(17, 19);
            this.rdTheoTen.Name = "rdTheoTen";
            this.rdTheoTen.Size = new System.Drawing.Size(68, 17);
            this.rdTheoTen.TabIndex = 0;
            this.rdTheoTen.TabStop = true;
            this.rdTheoTen.Text = "Theo tên";
            this.rdTheoTen.UseVisualStyleBackColor = true;
            // 
            // btnLuuNCC
            // 
            this.btnLuuNCC.Location = new System.Drawing.Point(428, 146);
            this.btnLuuNCC.Name = "btnLuuNCC";
            this.btnLuuNCC.Size = new System.Drawing.Size(75, 23);
            this.btnLuuNCC.TabIndex = 7;
            this.btnLuuNCC.Text = "Lưu";
            this.btnLuuNCC.UseVisualStyleBackColor = true;
            this.btnLuuNCC.Click += new System.EventHandler(this.btnLuuNCC_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(299, 146);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(75, 23);
            this.btnMacDinh.TabIndex = 6;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(464, 14);
            this.mtxtSDT.Mask = "0000000000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(223, 20);
            this.mtxtSDT.TabIndex = 4;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(464, 46);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(223, 81);
            this.txtMoTa.TabIndex = 5;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(132, 46);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(188, 20);
            this.txtTenNCC.TabIndex = 2;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Location = new System.Drawing.Point(132, 11);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(188, 20);
            this.txtMaNCC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(132, 87);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(188, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaNhaCC";
            this.colMaKH.HeaderText = "Mã nhà cung cấp";
            this.colMaKH.Name = "colMaKH";
            // 
            // colTenKH
            // 
            this.colTenKH.DataPropertyName = "TenNhaCC";
            this.colTenKH.HeaderText = "Tên nhà cung cấp";
            this.colTenKH.Name = "colTenKH";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "DiaChi";
            this.colSDT.HeaderText = "Địa chỉ";
            this.colSDT.Name = "colSDT";
            // 
            // colDiaChiGD
            // 
            this.colDiaChiGD.DataPropertyName = "SoDienThoai";
            this.colDiaChiGD.HeaderText = "Số điện thoại";
            this.colDiaChiGD.Name = "colDiaChiGD";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MoTa";
            this.Column1.HeaderText = "Mô tả";
            this.Column1.Name = "Column1";
            // 
            // frmQuanLyNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.gbDSNhaCC);
            this.Controls.Add(this.gbTimkiem);
            this.Controls.Add(this.btnLuuNCC);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyNCC";
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.frmQuanLyNCC_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNCC)).EndInit();
            this.gbDSNhaCC.ResumeLayout(false);
            this.gbTimkiem.ResumeLayout(false);
            this.gbTimkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuatJson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoaKhachHang;
        private System.Windows.Forms.DataGridView dtgvDanhSachNCC;
        private System.Windows.Forms.GroupBox gbDSNhaCC;
        private System.Windows.Forms.GroupBox gbTimkiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTheoSDT;
        private System.Windows.Forms.RadioButton rdTheoTen;
        private System.Windows.Forms.Button btnLuuNCC;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

