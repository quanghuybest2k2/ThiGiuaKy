using System;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace QLMonAn
{
	public partial class FoodForm : Form
	{
		public int NhomMA = 0;
		private int _maMonAn;
		
		private string connectionString = "";
		public FoodForm(int ma=0)
		{
			_maMonAn = ma;
			InitializeComponent();
			connectionString = ConfigurationManager
				.ConnectionStrings["default"].ConnectionString;
		}

		private void FoodForm_Load(object sender, EventArgs e)
		{
			HienThiNhomMonAn();
			if (_maMonAn > 0)
			{
				LayMonAnTheoMa(_maMonAn);
			}
		}

		private void HienThiNhomMonAn()
		{
			var conn = new SqlConnection(connectionString);
			var command = conn.CreateCommand();
			command.CommandText = "SELECT * FROM NhomMonAn";

			var adapter = new SqlDataAdapter(command);
			var table = new DataTable("NhomMonAn");

			conn.Open();
			adapter.Fill(table);
			conn.Close();

			cbbCategory.DisplayMember = "TenNhom";
			cbbCategory.ValueMember = "MaNhom";
			cbbCategory.DataSource = table;
		}

		private void btnSaveFood_Click(object sender, EventArgs e)
		{
			var ma = int.Parse(txtFoodId.Text);
			var ten = txtFoodName.Text;
			var dvt = txtUnit.Text;
			var donGia = Convert.ToInt32(nudUnitPrice.Value);
			var nhom = Convert.ToInt32(cbbCategory.SelectedValue);

			if (string.IsNullOrWhiteSpace(ten))
			{
				MessageBox.Show("Cần điền đầy đủ thông tin", "Thông báo");
				return;
			}

			var conn = new SqlConnection(connectionString);
			var command = conn.CreateCommand();
			
			//INSERT [dbo].[MonAn]
			//VALUES (N'Gỏi thập cẩm', N'Dĩa', 120000, 1)
			if (ma == 0)
			{
				//Thêm
				//command.CommandText = "INSERT [dbo].[MonAn] VALUES (N'"
				//	+ ten + "', N'" + dvt + ", " + donGia + ", " + nhom + ")";
				command.CommandText = "INSERT MonAn VALUES(@TenMonAn, @DonViTinh, " +
				                      "@DonGia, @Nhom)";
			}
			else
			{
				//Cập nhật
				command.CommandText = "UPDATE MonAn SET TenMonAn = @TenMonAn, " +
				                      "DonViTinh = @DonViTinh, DonGia = @DonGia, " +
				                      "Nhom = @Nhom WHERE MaMonAn = @MaMonAn";
			}

			command.Parameters.AddWithValue("@TenMonAn", ten);
			command.Parameters.AddWithValue("@DonViTinh", dvt);
			command.Parameters.AddWithValue("@DonGia", donGia);
			command.Parameters.AddWithValue("@Nhom", nhom);
			command.Parameters.AddWithValue("@MaNhom", ma);

			conn.Open();
			var soDong = command.ExecuteNonQuery();
			if (soDong > 0)
			{
				MessageBox.Show("Thành công", "Thông báo");
				NhomMA = nhom;
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Có lỗi", "Thông báo");
			}
			conn.Close();
		}

		private void LayMonAnTheoMa(int ma)
		{
			var conn = new SqlConnection(connectionString);
			var command = conn.CreateCommand();
			command.CommandText = "SELECT * " +
			                      "FROM MonAn " +
			                      "WHERE MaMonAn = " + ma;

			conn.Open();
			var reader = command.ExecuteReader();

			while (reader.Read())
			{
				txtFoodId.Text = _maMonAn.ToString();
				txtFoodName.Text = reader["TenMonAn"].ToString();
				txtUnit.Text = reader["DonViTinh"].ToString();
				nudUnitPrice.Text = reader["DonGia"].ToString();
				cbbCategory.SelectedValue = Convert.ToInt32(reader["Nhom"]);
			}
			conn.Close();
		}
	}
}
