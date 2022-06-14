using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De3
{
    public partial class frmHienThi : Form
    {
        private string maMH { get; set; }
        private string TenMH { get; set; }
        private string loaiMH { get; set; }
        private decimal soLuong { get; set; }
        private decimal donGia { get; set; }
        public frmHienThi(string _maMH, string _tenMH, string _loaiMH, decimal _soLuong, decimal _donGia)
        {
            this.maMH = _maMH;
            this.TenMH = _tenMH;
            this.loaiMH = _loaiMH;
            this.soLuong = _soLuong;
            this.donGia = _donGia;
            InitializeComponent();
        }

        private void frmHienThi_Load(object sender, EventArgs e)
        {
            this.txtMaMH.Text = this.maMH;
            this.txtTenMH.Text = this.TenMH;
            this.cbbLoaiMH.Text = this.loaiMH;
            this.nrudSoLuong.Value = this.soLuong;
            this.nrudDonGia.Value = this.donGia;
        }
    }
}
