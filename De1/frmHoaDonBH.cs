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
using System.Collections;

namespace De1
{
    public partial class frmHoaDonBH : Form
    {
        public frmHoaDonBH()
        {
            InitializeComponent();
        }

        private void frmHoaDonBH_Load(object sender, EventArgs e)
        {
            displayKhachHang();
            displayMatHang();
        }
        private void displayKhachHang()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from khachhang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            conn.Dispose();
            cbbKhachHang.DataSource = tb;
            cbbKhachHang.DisplayMember = "TenKH";
            cbbKhachHang.ValueMember = "MaKH";
        }
        private void displayMatHang()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select MaMathang,TenMatHang, SoLuong, DonGia, DonGia * SoLuong as ThanhTien from MatHang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            dtgvMatHang.DataSource = tb;
            ////
            var combo = (DataGridViewComboBoxColumn)dtgvMatHang.Columns["colTenHang"];
            combo.DisplayMember = "TenMatHang";
            combo.ValueMember = "MaMatHang";
            combo.DataSource = tb;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmQuanLy frm = new frmQuanLy();
            frm.ShowDialog();
            
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            if (dtgvMatHang.Rows.Count>0)
            {
                string TongTien;

                TongTien = txtTongTien.Text;
            }
        }
    }
}
