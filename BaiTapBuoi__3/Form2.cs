using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi__3
{
    public partial class Form2 : Form
    {
        // Đặt các thuộc tính bên ngoài hàm khởi tạo
        public string MSNV { get; set; }
        public string Ten { get; set; }
        public string Luong { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        // Hàm khởi tạo với tham số
        public Form2(string msnv, string ten, string luong) : this()
        {
            MSNV = msnv;
            Ten = ten;
            Luong = luong;
            txbMSNV.Text = MSNV; // Sửa lại tên TextBox cho đúng
            txbTen.Text = Ten;    // Sửa lại tên TextBox cho đúng
            txbLuong.Text = Luong;
        }
        private void txbMSNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXBTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            MSNV = txbMSNV.Text;
            Ten = txbTen.Text;
            Luong = txbLuong.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
