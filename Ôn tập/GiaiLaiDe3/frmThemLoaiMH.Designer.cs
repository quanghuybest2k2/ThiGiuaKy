
namespace GiaiLaiDe3
{
    partial class frmThemLoaiMH
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
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.btnThemLoaiMH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(43, 38);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(41, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Mã loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(106, 35);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(168, 20);
            this.txtMaLoai.TabIndex = 1;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(106, 73);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(168, 20);
            this.txtTenLoai.TabIndex = 2;
            // 
            // btnThemLoaiMH
            // 
            this.btnThemLoaiMH.Location = new System.Drawing.Point(106, 116);
            this.btnThemLoaiMH.Name = "btnThemLoaiMH";
            this.btnThemLoaiMH.Size = new System.Drawing.Size(168, 33);
            this.btnThemLoaiMH.TabIndex = 3;
            this.btnThemLoaiMH.Text = "Thêm loại mặt hàng";
            this.btnThemLoaiMH.UseVisualStyleBackColor = true;
            this.btnThemLoaiMH.Click += new System.EventHandler(this.btnThemLoaiMH_Click);
            // 
            // frmThemLoaiMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 181);
            this.Controls.Add(this.btnThemLoaiMH);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Name = "frmThemLoaiMH";
            this.Text = "Thêm loại mặt hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Button btnThemLoaiMH;
    }
}