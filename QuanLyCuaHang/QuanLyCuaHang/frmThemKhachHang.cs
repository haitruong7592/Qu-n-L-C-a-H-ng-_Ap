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
    public partial class frmThemKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        KhachHangBUS khBus = new KhachHangBUS();
        public EventHandler LamMoi;
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            LoaiKhachHangBUS bus = new LoaiKhachHangBUS();
            cbLoaiKH.DataSource = bus.GetDataID_Ten();
            cbLoaiKH.DisplayMember = "tenLKH";
            cbLoaiKH.ValueMember = "maLKH";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    kh.tenKH = txtTenKH.Text;
                    kh.sDT = txtSDT.Text;
                    if (rBtnNam.Checked == true)
                        kh.gioiTinh = "Nam";
                    if(rBtnNu.Checked == true)
                        kh.gioiTinh = "Nữ";
                    kh.ngSinh = dateTimeNgSinh.Value;
                    kh.email = txtEmail.Text;
                    kh.maLKH = int.Parse(cbLoaiKH.SelectedValue.ToString());
                    kh.diaChi = txtDiaChi.Text;
                    kh.ghiChu = txtGhiChu.Text;

                    khBus.Insert(kh);

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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
