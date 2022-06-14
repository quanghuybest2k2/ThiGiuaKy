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

namespace GiaiLaiDe3
{
    public partial class frmQuanLyMH : Form
    {
        public frmQuanLyMH()
        {
            InitializeComponent();
            //dtgvDanhSachMH.AutoGenerateColumns = false;
        }

        private void frmQuanLyMH_Load(object sender, EventArgs e)
        {
            LoadLoaiMatHang();
            LoadMatHang();
        }
        private void LoadLoaiMatHang()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBANHANGDE3;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from loaimathang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            conn.Dispose();
            cbbLoaiMH.DataSource = tb;
            cbbLoaiMH.DisplayMember = "TenLoai";
            cbbLoaiMH.ValueMember = "MaLoai";
        }
        private void Reset()
        {
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            cbbLoaiMH.ResetText();
            nrudSoLuong.ResetText();
            nrudDonGia.ResetText();
        }
        private void LoadMatHang()
        {
            try
            {

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBANHANGDE3;Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select MaMatHang, TenMatHang, TenLoai, SoLuongTon, DonGia from MatHang, LoaiMatHang";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                conn.Open();
                adapter.Fill(tb);
                conn.Close();
                conn.Dispose();
                dtgvDanhSachMH.DataSource = tb;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL ERROR!!!");
            }

        }

        private void dtgvDanhSachMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDanhSachMH.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvDanhSachMH.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells[0].Value.ToString();
                txtTenMH.Text = row.Cells[1].Value.ToString();
                cbbLoaiMH.Text = row.Cells[2].Value.ToString();
                nrudSoLuong.Value = decimal.Parse(row.Cells[3].Value.ToString());
                nrudDonGia.Value = decimal.Parse(row.Cells[4].Value.ToString());

            }
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBANHANGDE3;Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "exec ThemMatHang @mamh output,@TenMH, @loaiMH, @slTon, @donGia";
                cmd.Parameters.Add("@mamh", SqlDbType.Int);
                cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@loaiMH", SqlDbType.Int);
                cmd.Parameters.Add("@slTon", SqlDbType.Int);
                cmd.Parameters.Add("@donGia", SqlDbType.Int);

                cmd.Parameters["@mamh"].Direction = ParameterDirection.Output;
                ///
                cmd.Parameters["@TenMH"].Value = txtTenMH.Text;
                cmd.Parameters["@loaiMH"].Value = cbbLoaiMH.SelectedValue;
                cmd.Parameters["@slTon"].Value = nrudSoLuong.Value;
                cmd.Parameters["@donGia"].Value = nrudDonGia.Value;
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    string MaMH = cmd.Parameters["@mamh"].Value.ToString();
                    LoadMatHang();
                    MessageBox.Show("Thêm thành công!!! Mã mặt hàng: " + MaMH);
                    this.Reset();

                }
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL ERROR!!!");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBANHANGDE3;Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "exec CapNhatMatHang @mamh, @TenMH,@loaiMH,@slTon,@donGia";
                cmd.Parameters.Add("@mamh", SqlDbType.Int);
                cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@loaiMH", SqlDbType.Int);
                cmd.Parameters.Add("@slTon", SqlDbType.Int);
                cmd.Parameters.Add("@donGia", SqlDbType.Int);
                ///
                cmd.Parameters["@mamh"].Value = txtMaMH.Text;
                cmd.Parameters["@TenMH"].Value = txtTenMH.Text;
                cmd.Parameters["@loaiMH"].Value = cbbLoaiMH.SelectedValue;
                cmd.Parameters["@slTon"].Value = nrudSoLuong.Value;
                cmd.Parameters["@donGia"].Value = nrudDonGia.Value;
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    
                    MessageBox.Show("Cập nhật thành công!!!");
                    LoadMatHang();
                    this.Reset();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!!!");
                }
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL ERROR!!!");
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            frmThemLoaiMH frm = new frmThemLoaiMH();
            frm.FormClosed += new FormClosedEventHandler(frmThemLoaiMH_FormClosed);
            frm.Show(this);
        }
        private void frmThemLoaiMH_FormClosed(object sender, EventArgs e)
        {
            LoadLoaiMatHang();
        }
    }
}
