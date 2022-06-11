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

namespace De3
{
    public partial class frmQuanLyShop : Form
    {
        public frmQuanLyShop()
        {
            InitializeComponent();
        }

        private void frmQuanLyShop_Load(object sender, EventArgs e)
        {
            HienThiMatHang();
            LoadMatHang();
        }
        private void HienThiMatHang()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBANHANGDE3;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from LoaiMatHang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            cbbLoaiMH.DisplayMember = "TenLoai";
            cbbLoaiMH.ValueMember = "MaLoai";
            cbbLoaiMH.DataSource = tb;
        }
        private void LoadMatHang()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBANHANGDE3;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select MaMatHang, TenMatHang, TenLoai, SoLuongTon, DonGia from MatHang mh, LoaiMatHang lmh where lmh.MaLoai = mh.MaMatHang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            dtgvDanhSachMH.DataSource = tb;
        }

        // them
        private void test()
        {
            //try
            //{
            //    //DESKTOP-QDTENRH\SQLEXPRESS
            //    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBANHANGDE3;Integrated Security=True");
            //    SqlCommand cmd = conn.CreateCommand();
            //    cmd.CommandText = "exec ThemMatHang @mamh output,@TenMH, @loaiMH, @slTon, @donGia";
            //    cmd.Parameters.Add("@mamh", SqlDbType.Int);
            //    cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar, 1000);
            //    cmd.Parameters.Add("@loaiMH", SqlDbType.Int);
            //    cmd.Parameters.Add("@slTon", SqlDbType.Int);
            //    cmd.Parameters.Add("@donGia", SqlDbType.Int);

            //    cmd.Parameters["@mamh"].Direction = ParameterDirection.Output;
            //    // tham so
            //    cmd.Parameters["TenMH"].Value = txtMaMH.Text;
            //    cmd.Parameters["loaiMH"].Value = int.Parse(txtTenMH.Text);
            //    cmd.Parameters["slTon"].Value = int.Parse(nrudSoLuong.Text);
            //    cmd.Parameters["donGia"].Value = int.Parse(nrudDonGia.Text);
            //    conn.Open();
            //    int numRowAffected = cmd.ExecuteNonQuery();
            //    if (numRowAffected > 0)
            //    {
            //        string maMH = cmd.Parameters["@mamh"].Value.ToString();
            //        MessageBox.Show("Thành công!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Lỗi xảy ra!");
            //    }
            //    conn.Close();
            //    conn.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Sql Error!");
            //}
        }
        private void dtgvDanhSachMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDanhSachMH.Rows.Count>0)
            {
                DataGridViewRow row = dtgvDanhSachMH.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells[0].Value.ToString();
                txtTenMH.Text = row.Cells[1].Value.ToString();
                cbbLoaiMH.Text = row.Cells[2].Value.ToString();
                nrudSoLuong.Text = row.Cells[3].Value.ToString();
                nrudDonGia.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
