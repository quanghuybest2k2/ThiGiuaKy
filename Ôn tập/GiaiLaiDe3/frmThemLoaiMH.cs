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
    public partial class frmThemLoaiMH : Form
    {
        public frmThemLoaiMH()
        {
            InitializeComponent();
        }

        private void btnThemLoaiMH_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBANHANGDE3;Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into LoaiMatHang values(@TenLoai)";
                //cmd.CommandText = "Exec ThemMatHang @MaLoai ouput, @TenLoai";
                cmd.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text);
                cmd.Parameters.AddWithValue("@TenLoai", txtTenLoai.Text);
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num>0)
                {
                    MessageBox.Show("Thêm loại mặt hàng thành công!!!");
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

    }
}
