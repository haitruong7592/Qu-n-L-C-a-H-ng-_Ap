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

namespace QuanLyCuaHang
{
    public partial class frmThemNguoiDung : Form
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungBUS ndBus = new NguoiDungBUS();
        VaiTro vt = new VaiTro();
        VaiTroBUS vtBus = new VaiTroBUS();
        public EventHandler LamMoi;
        private void XoaHuy()
        {
            txtTenND.Text = String.Empty;
            txtTaiKhoan.Text = String.Empty;
            txtMatKhau.Text = String.Empty;
        }
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            cbVaiTro.DataSource = vtBus.GetDataID_TenVT();
            cbVaiTro.DisplayMember = "tenvt";
            cbVaiTro.ValueMember = "mavt";
        }

        private void cbVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaHuy();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    nd.tenND = txtTenND.Text;
                    if (rBtnNam.Checked == true)
                        nd.gioiTinhND = "Nam";
                    if (rBtnNu.Checked == true)
                        nd.gioiTinhND = "Nữ";
                    nd.ngaySinhND = dateTimeNgaySinh.Value;
                    nd.ngayLam = datTimeNgayLam.Value;
                    nd.maVT = int.Parse(cbVaiTro.SelectedValue.ToString());
                    nd.taiKhoan = txtTaiKhoan.Text;
                    nd.matKhau = txtMatKhau.Text;
                    nd.ghiChu = txtGhiChu.Text;
                    
                    ndBus.Insert(nd);
                    
                    MessageBox.Show("Thêm thành công");
                    if (LamMoi != null)
                        LamMoi(sender, e);
                    //XoaText();
                    this.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bạn chưa nhập thông tin!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void rBtnNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTenND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
