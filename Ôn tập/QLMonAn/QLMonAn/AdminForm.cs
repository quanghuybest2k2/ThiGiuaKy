using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLMonAn
{
	public partial class AdminForm : Form
	{
		private string connectionString = "";
		public AdminForm()
		{
			InitializeComponent();
			dgvDsMonAn.AutoGenerateColumns = false;
			connectionString = ConfigurationManager
				.ConnectionStrings["default"].ConnectionString;
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			HienThiNhomMonAn();
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

			cbbNhom.DisplayMember = "TenNhom";
			cbbNhom.ValueMember = "MaNhom";
			cbbNhom.DataSource = table;
		}

		private void HienThiDsMonAnTheoLoai(int maNhom)
		{
			var conn = new SqlConnection(connectionString);
			var command = conn.CreateCommand();
			command.CommandText = "SELECT m.*, TenNhom " +
			                      "FROM MonAn m, NhomMonAn nma " +
			                      "WHERE m.Nhom = nma.MaNhom and " +
			                      "m.Nhom = " + maNhom;

			var adapter = new SqlDataAdapter(command);
			var table = new DataTable("MonAn");
			conn.Open();
			adapter.Fill(table);
			conn.Close();

			dgvDsMonAn.DataSource = table;
		}
		private void cbbNhom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			var ma = Convert.ToInt32(cbbNhom.SelectedValue);

			HienThiDsMonAnTheoLoai(ma);
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			var vanBanTim = txtSearch.Text;

			var conn = new SqlConnection(connectionString);
			var command = conn.CreateCommand();
			command.CommandText = "SELECT m.*, TenNhom " +
			                      "FROM MonAn m, NhomMonAn nma " +
			                      "WHERE m.Nhom = nma.MaNhom and " +
			                      "m.TenMonAn like '%" + vanBanTim + "%'";

			var adapter = new SqlDataAdapter(command);
			var table = new DataTable("MonAn");
			conn.Open();
			adapter.Fill(table);
			conn.Close();

			dgvDsMonAn.DataSource = table;
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			var form = new FoodForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				var nhom = form.NhomMA;
				HienThiDsMonAnTheoLoai(nhom);
			}
		}

		private void dgvDsMonAn_DoubleClick(object sender, EventArgs e)
		{
			if (dgvDsMonAn.SelectedRows.Count > 0)
			{
				var maMonAn = Convert.ToInt32(dgvDsMonAn.SelectedRows[0].Cells[0].Value);

				var form = new FoodForm(maMonAn);
				if (form.ShowDialog() == DialogResult.OK)
				{
					var nhom = form.NhomMA;
					HienThiDsMonAnTheoLoai(nhom);
				}
			} 
		}
	}
}
