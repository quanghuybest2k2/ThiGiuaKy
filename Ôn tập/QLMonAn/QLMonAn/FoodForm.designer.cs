namespace QLMonAn
{
	partial class FoodForm
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
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.btnSaveFood = new System.Windows.Forms.Button();
			this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
			this.txtFoodId = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtFoodName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(155, 146);
			this.cbbCategory.Margin = new System.Windows.Forms.Padding(4);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(339, 24);
			this.cbbCategory.TabIndex = 4;
			// 
			// btnSaveFood
			// 
			this.btnSaveFood.Location = new System.Drawing.Point(202, 178);
			this.btnSaveFood.Margin = new System.Windows.Forms.Padding(4);
			this.btnSaveFood.Name = "btnSaveFood";
			this.btnSaveFood.Size = new System.Drawing.Size(100, 33);
			this.btnSaveFood.TabIndex = 6;
			this.btnSaveFood.Text = "Lưu";
			this.btnSaveFood.UseVisualStyleBackColor = true;
			this.btnSaveFood.Click += new System.EventHandler(this.btnSaveFood_Click);
			// 
			// nudUnitPrice
			// 
			this.nudUnitPrice.Location = new System.Drawing.Point(158, 116);
			this.nudUnitPrice.Margin = new System.Windows.Forms.Padding(4);
			this.nudUnitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudUnitPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudUnitPrice.Name = "nudUnitPrice";
			this.nudUnitPrice.Size = new System.Drawing.Size(339, 22);
			this.nudUnitPrice.TabIndex = 2;
			this.nudUnitPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// txtFoodId
			// 
			this.txtFoodId.Location = new System.Drawing.Point(155, 20);
			this.txtFoodId.Margin = new System.Windows.Forms.Padding(4);
			this.txtFoodId.Name = "txtFoodId";
			this.txtFoodId.ReadOnly = true;
			this.txtFoodId.Size = new System.Drawing.Size(341, 22);
			this.txtFoodId.TabIndex = 17;
			this.txtFoodId.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(17, 29);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 17);
			this.label8.TabIndex = 9;
			this.label8.Text = "Mã món ăn/uống";
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(155, 84);
			this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(341, 22);
			this.txtUnit.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(15, 156);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(96, 17);
			this.label14.TabIndex = 13;
			this.label14.Text = "Nhóm món ăn";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(17, 125);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(57, 17);
			this.label11.TabIndex = 11;
			this.label11.Text = "Đơn giá";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(17, 90);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(75, 17);
			this.label10.TabIndex = 10;
			this.label10.Text = "Đơn vị tính";
			// 
			// txtFoodName
			// 
			this.txtFoodName.Location = new System.Drawing.Point(155, 52);
			this.txtFoodName.Margin = new System.Windows.Forms.Padding(4);
			this.txtFoodName.Name = "txtFoodName";
			this.txtFoodName.Size = new System.Drawing.Size(341, 22);
			this.txtFoodName.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(17, 58);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 17);
			this.label9.TabIndex = 15;
			this.label9.Text = "Tên món ăn/uống";
			// 
			// FoodForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 238);
			this.Controls.Add(this.cbbCategory);
			this.Controls.Add(this.btnSaveFood);
			this.Controls.Add(this.nudUnitPrice);
			this.Controls.Add(this.txtFoodId);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtFoodName);
			this.Controls.Add(this.label9);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FoodForm";
			this.Text = "Thông tin món ăn";
			this.Load += new System.EventHandler(this.FoodForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.Button btnSaveFood;
		private System.Windows.Forms.NumericUpDown nudUnitPrice;
		private System.Windows.Forms.TextBox txtFoodId;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtFoodName;
		private System.Windows.Forms.Label label9;
	}
}