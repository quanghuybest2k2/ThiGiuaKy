﻿using System;
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
        public static string StrCon = @"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QLBANHANGDE3;Integrated Security=True";
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
            SqlConnection conn = new SqlConnection(StrCon);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from LoaiMatHang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            conn.Dispose();
            cbbLoaiMH.DisplayMember = "TenLoai";
            cbbLoaiMH.ValueMember = "MaLoai";
            cbbLoaiMH.DataSource = tb;
        }
        private void LoadMatHang()
        {
            SqlConnection conn = new SqlConnection(StrCon);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select MaMatHang, TenMatHang, TenLoai, SoLuongTon, DonGia from MatHang, LoaiMatHang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            conn.Open();
            adapter.Fill(tb);
            conn.Close();
            dtgvDanhSachMH.DataSource = tb;
        }
        private void dtgvDanhSachMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDanhSachMH.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvDanhSachMH.Rows[e.RowIndex];
                //txtMaMH.Text = row.Cells[0].Value.ToString();
                //txtTenMH.Text = row.Cells[1].Value.ToString();
                //cbbLoaiMH.Text = row.Cells[2].Value.ToString();
                //nrudSoLuong.Value = decimal.Parse(row.Cells[3].Value.ToString());
                //nrudDonGia.Value = decimal.Parse(row.Cells[4].Value.ToString());
                string maHH = row.Cells[0].Value.ToString();
                string TenMH = row.Cells[1].Value.ToString();
                string loaiMH = row.Cells[2].Value.ToString();
                decimal soLuong = decimal.Parse(row.Cells[3].Value.ToString());
                decimal donGia = decimal.Parse(row.Cells[4].Value.ToString());
                frmHienThi frmHienThi = new frmHienThi(maHH, TenMH, loaiMH, soLuong, donGia);
                frmHienThi.ShowDialog();
            }
        }
        private void Reset()
        {
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            cbbLoaiMH.ResetText();
            nrudSoLuong.ResetText();
            nrudDonGia.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text != "")
            {
                this.Reset();
            }
            else if (txtMaMH.Text == "" && txtTenMH.Text == ""&&cbbLoaiMH.Text==""&&nrudSoLuong.Value==0&&nrudDonGia.Value==0)
            {
                MessageBox.Show("Vui lòng nhập thông tin!!!");
                return;
            }
            else
            {
                try
                {

                    //DESKTOP-QDTENRH\SQLEXPRESS
                    SqlConnection conn = new SqlConnection(StrCon);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "exec ThemMatHang @mamh output, @TenMH, @loaiMH, @slTon, @donGia";
                    cmd.Parameters.Add("@mamh", SqlDbType.Int);
                    cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar, 1000);
                    cmd.Parameters.Add("@loaiMH", SqlDbType.Int);
                    cmd.Parameters.Add("@slTon", SqlDbType.Int);
                    cmd.Parameters.Add("@donGia", SqlDbType.Int);

                    cmd.Parameters["@mamh"].Direction = ParameterDirection.Output;
                    //
                    cmd.Parameters["@TenMH"].Value = txtTenMH.Text;
                    cmd.Parameters["@loaiMH"].Value = cbbLoaiMH.SelectedValue;
                    cmd.Parameters["@slTon"].Value = nrudSoLuong.Value;
                    cmd.Parameters["@donGia"].Value = nrudDonGia.Value;

                    conn.Open();
                    int numRowAffected = cmd.ExecuteNonQuery();
                    if (numRowAffected > 0)
                    {
                        string maMH = cmd.Parameters["@mamh"].Value.ToString();
                        MessageBox.Show("Thêm thành công! Mã mặt hàng: " + maMH);
                        LoadMatHang();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi xảy ra!");
                    }
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sql Error!");
                }
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(StrCon);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "exec CapNhatMatHang @mamh, @TenMH, @loaiMH, @slTon, @donGia";
                cmd.Parameters.Add("@mamh", SqlDbType.Int);
                cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@loaiMH", SqlDbType.Int);
                cmd.Parameters.Add("@slTon", SqlDbType.Int);
                cmd.Parameters.Add("@donGia", SqlDbType.Int);
                ///
                cmd.Parameters["@mamh"].Value = int.Parse(txtMaMH.Text);
                cmd.Parameters["@TenMH"].Value = txtTenMH.Text;
                cmd.Parameters["@loaiMH"].Value = cbbLoaiMH.SelectedValue;
                cmd.Parameters["@slTon"].Value = nrudSoLuong.Value;
                cmd.Parameters["@donGia"].Value = nrudSoLuong.Value;

                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadMatHang();
                }
                else
                {
                    MessageBox.Show("Thất bại!");
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
            frmThemLoaiMH frmLoai = new frmThemLoaiMH();
            frmLoai.FormClosed += new FormClosedEventHandler(frmthemloaimh_formclosed);
            frmLoai.Show(this);
        }
        private void frmthemloaimh_formclosed(object sender, EventArgs e)
        {
            HienThiMatHang();
            cbbLoaiMH.Text = frmThemLoaiMH.MHMoiThem;
        }

        private void dtgvDanhSachMH_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                
            }
        }
    }
}
