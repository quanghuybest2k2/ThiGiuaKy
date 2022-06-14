namespace QLMonAn
{
	partial class AdminForm
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
			this.ctmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.xemDanhSáchHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ttAddButton = new System.Windows.Forms.ToolTip(this.components);
			this.btnAddFood = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbbNhom = new System.Windows.Forms.ComboBox();
			this.dgvDsMonAn = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctmsListView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDsMonAn)).BeginInit();
			this.SuspendLayout();
			// 
			// ctmsListView
			// 
			this.ctmsListView.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ctmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.xemDanhSáchHóaĐơnToolStripMenuItem});
			this.ctmsListView.Name = "ctmsListView";
			this.ctmsListView.Size = new System.Drawing.Size(238, 52);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(237, 24);
			this.tsmiDelete.Text = "Xóa tất cả";
			// 
			// xemDanhSáchHóaĐơnToolStripMenuItem
			// 
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Name = "xemDanhSáchHóaĐơnToolStripMenuItem";
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Text = "Xem danh sách hóa đơn";
			// 
			// btnAddFood
			// 
			this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddFood.Location = new System.Drawing.Point(615, 96);
			this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(28, 26);
			this.btnAddFood.TabIndex = 12;
			this.btnAddFood.Text = "+";
			this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.ttAddButton.SetToolTip(this.btnAddFood, "Thêm món ăn");
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(338, 99);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(273, 22);
			this.txtSearch.TabIndex = 11;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(41, 90);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Danh sách món ăn";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(89, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nhóm món ăn";
			// 
			// cbbNhom
			// 
			this.cbbNhom.FormattingEnabled = true;
			this.cbbNhom.Location = new System.Drawing.Point(205, 19);
			this.cbbNhom.Name = "cbbNhom";
			this.cbbNhom.Size = new System.Drawing.Size(419, 24);
			this.cbbNhom.TabIndex = 13;
			this.cbbNhom.SelectedIndexChanged += new System.EventHandler(this.cbbNhom_SelectedIndexChanged);
			// 
			// dgvDsMonAn
			// 
			this.dgvDsMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDsMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvDsMonAn.Location = new System.Drawing.Point(33, 128);
			this.dgvDsMonAn.Name = "dgvDsMonAn";
			this.dgvDsMonAn.RowTemplate.Height = 24;
			this.dgvDsMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDsMonAn.Size = new System.Drawing.Size(615, 274);
			this.dgvDsMonAn.TabIndex = 14;
			this.dgvDsMonAn.DoubleClick += new System.EventHandler(this.dgvDsMonAn_DoubleClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaMonAn";
			this.Column1.HeaderText = "Mã";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenMonAn";
			this.Column2.HeaderText = "Tên món ăn";
			this.Column2.Name = "Column2";
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "DonViTinh";
			this.Column3.HeaderText = "Đơn vị tính";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "DonGia";
			this.Column4.HeaderText = "Đơn giá";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "TenNhom";
			this.Column5.HeaderText = "Nhóm";
			this.Column5.Name = "Column5";
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 465);
			this.Controls.Add(this.dgvDsMonAn);
			this.Controls.Add(this.cbbNhom);
			this.Controls.Add(this.btnAddFood);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.ctmsListView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDsMonAn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip ctmsListView;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripMenuItem xemDanhSáchHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.ToolTip ttAddButton;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbNhom;
		private System.Windows.Forms.DataGridView dgvDsMonAn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}