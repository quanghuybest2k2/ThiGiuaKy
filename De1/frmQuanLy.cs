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

namespace De1
{
    public partial class frmQuanLy : Form
    {
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
            if (dtgvDanhSachKH.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvDanhSachKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                mtxtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChiGH.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
