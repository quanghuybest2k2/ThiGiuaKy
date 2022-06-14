using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace De1
{
    public partial class frmQuanLy : Form
    {
        public static string KHMoiThem;
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            loadKhachHang();
        }
        private void loadKhachHang()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from KhachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            dtgvDanhSachKH.DataSource = tb;
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            mtxtSDT.Text = "";
            txtDiaChiGH.Text = "";
        }

        private void dtgvDanhSachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDanhSachKH.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvDanhSachKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                mtxtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChiGH.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            if (txtMaKH.Text == "")
            {
                cmd.CommandText = "INSERT into KhachHang VALUES (@TenKH,@SoDienThoai, @DiaChiGH)";
                conn.Open();
                cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", mtxtSDT.Text);
                cmd.Parameters.AddWithValue("@DiaChiGH", txtDiaChiGH.Text);
                //
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công!");
                KHMoiThem = txtTenKH.Text;
                conn.Close();
                loadKhachHang();
                btnMacDinh.PerformClick();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //update khachhang set TenKH = N'Đoàn Quang Huy', SoDienThoai = 9874561230, diachigh = N'Phan Rang' where makh = 26
                cmd.CommandText = "update khachhang set TenKH = @tenkh, SoDienThoai = @sdt, DiaChiGH = @diachigh where MaKH = @makh";
                conn.Open();
                cmd.Parameters.AddWithValue("@tenkh", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@sdt", mtxtSDT.Text);
                cmd.Parameters.AddWithValue("@diachigh", txtDiaChiGH.Text);
                cmd.Parameters.AddWithValue("@makh", txtMaKH.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                conn.Close();
                loadKhachHang();
                btnMacDinh.PerformClick();
            }

        }
        private void tsmiXoaKhachHang_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            if (txtMaKH.Text != "")
            {
                cmd.CommandText = "Delete FROM KhachHang where MaKH=@makh";
                conn.Open();
                cmd.Parameters.AddWithValue("@makh", txtMaKH.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa khách hàng thành công!!!");
                conn.Close();
                loadKhachHang();
                btnMacDinh.PerformClick();
            }
            else
            {
                MessageBox.Show("Chọn khách hàng để xóa");
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoTen.Checked)
            {
                if (rdTheoTen.Checked)
                {
                    //sử dụng thuộc tính RowFilter để tìm kiếm theo tên "TenKH"
                    string rowFilter = string.Format("{0} like '{1}'", "TenKH", "*" + txtTimKiem.Text + "*");
                    (dtgvDanhSachKH.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                }
                if (rdTheoSDT.Checked)
                {
                    //sử dụng thuộc tính RowFilter để tìm kiếm theo sdt "SoDienThoai"
                    string rowFilter = string.Format("{0} like '{1}'", "SoDienThoai", "*" + txtTimKiem.Text + "*");
                    (dtgvDanhSachKH.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                }
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvDanhSachKH.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dtgvDanhSachKH.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgvDanhSachKH.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvDanhSachKH.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dtgvDanhSachKH.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file!\n" + ex.Message);
                }
            }
        }
    }
}
