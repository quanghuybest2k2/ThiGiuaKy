using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace De2
{
    public partial class frmQuanLyNCC : Form
    {
        //public static int NhaCCMoiThem;
        public frmQuanLyNCC()
        {
            InitializeComponent();
        }
        private void frmQuanLyNCC_Load(object sender, EventArgs e)
        {
            LoadNhaCC();
        }
        private void LoadNhaCC()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from NhaCungCap";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            conn.Dispose();
            dtgvDanhSachNCC.DataSource = tb;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoTen.Checked)
            {
                string rowFilter = string.Format("{0} like '{1}'", "TenNhaCC", "*" + txtTimKiem.Text + "*");
                (dtgvDanhSachNCC.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            if (rdTheoSDT.Checked)
            {
                string rowFilter = string.Format("{0} like '{1}'", "SoDienThoai", "*" + txtTimKiem.Text + "*");
                (dtgvDanhSachNCC.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }

        }

        private void dtgvDanhSachNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDanhSachNCC.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvDanhSachNCC.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                mtxtSDT.Text = row.Cells[3].Value.ToString();
                txtMoTa.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            mtxtSDT.ResetText();
            txtMoTa.ResetText();
        }

        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "exec ThemNhaCungCap @MaNhaCC output, @TenNhaCC, @DiaChi, @SoDienThoai, @MoTa";
                    cmd.Parameters.Add("@MaNhaCC", SqlDbType.Int);
                    cmd.Parameters.Add("@TenNhaCC", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 11);
                    cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, 100);

                    cmd.Parameters["@MaNhaCC"].Direction = ParameterDirection.Output;
                    ///
                    cmd.Parameters["@TenNhaCC"].Value = txtTenNCC.Text;
                    cmd.Parameters["@DiaChi"].Value = txtDiaChi.Text;
                    cmd.Parameters["@SoDienThoai"].Value = mtxtSDT.Text;
                    cmd.Parameters["@MoTa"].Value = txtMoTa.Text;
                    conn.Open();
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Thêm thành công!!!");
                        LoadNhaCC();
                        btnMacDinh.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại rồi!!!");
                    }
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi SQL");
                }
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "exec CapNhatNhaCungCap @MaNhaCC, @TenNhaCC, @DiaChi, @SoDienThoai, @MoTa";
                    cmd.Parameters.Add("@MaNhaCC", SqlDbType.Int);
                    cmd.Parameters.Add("@TenNhaCC", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 11);
                    cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, 100);
                    ///
                    cmd.Parameters["@MaNhaCC"].Value = int.Parse(txtMaNCC.Text);
                    cmd.Parameters["@TenNhaCC"].Value = txtTenNCC.Text;
                    cmd.Parameters["@DiaChi"].Value = txtDiaChi.Text;
                    cmd.Parameters["@SoDienThoai"].Value = mtxtSDT.Text;
                    cmd.Parameters["@MoTa"].Value = txtMoTa.Text;
                    conn.Open();
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!!!");
                        LoadNhaCC();
                        btnMacDinh.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại rồi!!!");
                    }
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi SQL");
                }
            }
        }
    }
}
