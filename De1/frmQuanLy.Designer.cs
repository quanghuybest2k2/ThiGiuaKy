
namespace De1
{
    partial class frmQuanLy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiGH = new System.Windows.Forms.TextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.gbTimkiem = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTheoSDT = new System.Windows.Forms.RadioButton();
            this.rdTheoTen = new System.Windows.Forms.RadioButton();
            this.gbDSKhachHang = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachKH = new System.Windows.Forms.DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXoaKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.gbTimkiem.SuspendLayout();
            this.gbDSKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKH)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(132, 22);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(188, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(132, 57);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(188, 20);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtDiaChiGH
            // 
            this.txtDiaChiGH.Location = new System.Drawing.Point(392, 50);
            this.txtDiaChiGH.Multiline = true;
            this.txtDiaChiGH.Name = "txtDiaChiGH";
            this.txtDiaChiGH.Size = new System.Drawing.Size(317, 61);
            this.txtDiaChiGH.TabIndex = 4;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(132, 98);
            this.mtxtSDT.Mask = "0000000000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(188, 20);
            this.mtxtSDT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ giao hàng";
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.Location = new System.Drawing.Point(417, 136);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(75, 23);
            this.btnLuuKH.TabIndex = 6;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.UseVisualStyleBackColor = true;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(288, 136);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(75, 23);
            this.btnMacDinh.TabIndex = 5;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // gbTimkiem
            // 
            this.gbTimkiem.Controls.Add(this.txtTimKiem);
            this.gbTimkiem.Controls.Add(this.rdTheoSDT);
            this.gbTimkiem.Controls.Add(this.rdTheoTen);
            this.gbTimkiem.Location = new System.Drawing.Point(327, 175);
            this.gbTimkiem.Name = "gbTimkiem";
            this.gbTimkiem.Size = new System.Drawing.Size(382, 50);
            this.gbTimkiem.TabIndex = 7;
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
            // gbDSKhachHang
            // 
            this.gbDSKhachHang.Controls.Add(this.dtgvDanhSachKH);
            this.gbDSKhachHang.Controls.Add(this.btnXuatExcel);
            this.gbDSKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDSKhachHang.Location = new System.Drawing.Point(0, 231);
            this.gbDSKhachHang.Name = "gbDSKhachHang";
            this.gbDSKhachHang.Size = new System.Drawing.Size(741, 219);
            this.gbDSKhachHang.TabIndex = 8;
            this.gbDSKhachHang.TabStop = false;
            this.gbDSKhachHang.Text = "Danh sách khách hàng";
            // 
            // dtgvDanhSachKH
            // 
            this.dtgvDanhSachKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colSDT,
            this.colDiaChiGD});
            this.dtgvDanhSachKH.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgvDanhSachKH.Location = new System.Drawing.Point(6, 19);
            this.dtgvDanhSachKH.Name = "dtgvDanhSachKH";
            this.dtgvDanhSachKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachKH.Size = new System.Drawing.Size(729, 168);
            this.dtgvDanhSachKH.TabIndex = 0;
            this.dtgvDanhSachKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachKH_CellContentClick);
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaKH";
            this.colMaKH.HeaderText = "Mã khách hàng";
            this.colMaKH.Name = "colMaKH";
            // 
            // colTenKH
            // 
            this.colTenKH.DataPropertyName = "TenKH";
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.Name = "colTenKH";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SoDienThoai";
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.Name = "colSDT";
            // 
            // colDiaChiGD
            // 
            this.colDiaChiGD.DataPropertyName = "DiaChiGH";
            this.colDiaChiGD.HeaderText = "Địa chỉ giao hàng";
            this.colDiaChiGD.Name = "colDiaChiGD";
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
            this.tsmiXoaKhachHang.Click += new System.EventHandler(this.tsmiXoaKhachHang_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(634, 193);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(75, 23);
            this.btnXuatExcel.TabIndex = 1;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.gbDSKhachHang);
            this.Controls.Add(this.gbTimkiem);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.btnLuuKH);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.txtDiaChiGH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.gbTimkiem.ResumeLayout(false);
            this.gbTimkiem.PerformLayout();
            this.gbDSKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKH)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChiGH;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.GroupBox gbTimkiem;
        private System.Windows.Forms.RadioButton rdTheoSDT;
        private System.Windows.Forms.RadioButton rdTheoTen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox gbDSKhachHang;
        private System.Windows.Forms.DataGridView dtgvDanhSachKH;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiGD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoaKhachHang;
    }
}

