using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace QuanLyCuaHang
{
    public partial class frmLogin : Form
    {
        NguoiDungBUS ndBus = new NguoiDungBUS();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tài khoản", "Thông báo");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo");
            }
            else
            {
                NguoiDungBUS nguoiDung = new NguoiDungBUS();
                string userName = txtTaiKhoan.Text;
                string passWord = txtMatKhau.Text;

                if (nguoiDung.Login(userName, passWord) == true)
                {
                    frmManHinhChinh f = new frmManHinhChinh();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                //NHỚ CHECK CSDL  ???

                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
         
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           

        }

        


    }
}
