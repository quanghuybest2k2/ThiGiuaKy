using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace De2
{
    public partial class frmHoaNhap : Form
    {
        public frmHoaNhap()
        {
            InitializeComponent();
        }
        private void frmHoaNhap_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();

        }
        private void LoadNhaCungCap()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select MaNhaCC, TenNhaCC from NhaCungCap";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            conn.Dispose();
            cbbNhaCC.DataSource = tb;
            cbbNhaCC.DisplayMember = "TenNhaCC";
            cbbNhaCC.ValueMember = "MaNhaCC";
        }
        private void btnThemNhCC_Click(object sender, EventArgs e)
        {
            frmQuanLyNCC frm = new frmQuanLyNCC();
            frm.FormClosed += new FormClosedEventHandler(frmQuanLyNCC_FormClosed);
            frm.Show(this);
        }
        private void frmQuanLyNCC_FormClosed(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            //cbbNhaCC.SelectedValue = frmQuanLyNCC.NhaCCMoiThem;

        }

        private void dtgvMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
