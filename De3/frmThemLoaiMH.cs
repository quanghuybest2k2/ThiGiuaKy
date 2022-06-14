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
    public partial class frmThemLoaiMH : Form
    {
        public static string MHMoiThem;
        public frmThemLoaiMH()
        {
            InitializeComponent();
        }

        private void btnThemLoaiMH_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(frmQuanLyShop.StrCon);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "exec ThemLoaiMH @maloai output, @TenLoai";
                cmd.Parameters.Add("@maloai", SqlDbType.Int);
                cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar, 1000);

                cmd.Parameters["@maloai"].Direction = ParameterDirection.Output;
                ///
                cmd.Parameters["@TenLoai"].Value = txtTenLoai.Text;
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    string MaLoai = cmd.Parameters["@maloai"].Value.ToString();
                    MessageBox.Show("Thêm loại mặt hàng thành công! Mã loại = "+MaLoai);
                    MHMoiThem = txtTenLoai.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi rồi!");
                }
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL ERROR!");
            }
        }
    }
}
