
namespace De3
{
    partial class frmHienThi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nrudDonGia = new System.Windows.Forms.NumericUpDown();
            this.nrudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbLoaiMH = new System.Windows.Forms.ComboBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nrudDonGia);
            this.groupBox1.Controls.Add(this.nrudSoLuong);
            this.groupBox1.Controls.Add(this.cbbLoaiMH);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết mặt hàng";
            // 
            // nrudDonGia
            // 
            this.nrudDonGia.Location = new System.Drawing.Point(128, 139);
            this.nrudDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nrudDonGia.Name = "nrudDonGia";
            this.nrudDonGia.Size = new System.Drawing.Size(230, 20);
            this.nrudDonGia.TabIndex = 5;
            // 
            // nrudSoLuong
            // 
            this.nrudSoLuong.Location = new System.Drawing.Point(128, 111);
            this.nrudSoLuong.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nrudSoLuong.Name = "nrudSoLuong";
            this.nrudSoLuong.Size = new System.Drawing.Size(230, 20);
            this.nrudSoLuong.TabIndex = 4;
            // 
            // cbbLoaiMH
            // 
            this.cbbLoaiMH.FormattingEnabled = true;
            this.cbbLoaiMH.Location = new System.Drawing.Point(128, 83);
            this.cbbLoaiMH.Name = "cbbLoaiMH";
            this.cbbLoaiMH.Size = new System.Drawing.Size(230, 21);
            this.cbbLoaiMH.TabIndex = 3;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(128, 55);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(230, 20);
            this.txtTenMH.TabIndex = 2;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(128, 26);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(230, 20);
            this.txtMaMH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên mặt hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã mặt hàng";
            // 
            // frmHienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 200);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHienThi";
            this.Text = "Thông tin mặt hàng";
            this.Load += new System.EventHandler(this.frmHienThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nrudDonGia;
        private System.Windows.Forms.NumericUpDown nrudSoLuong;
        private System.Windows.Forms.ComboBox cbbLoaiMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}