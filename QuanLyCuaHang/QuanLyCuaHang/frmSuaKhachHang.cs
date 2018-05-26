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
    public partial class frmSuaKhachHang : Form
    {
        public bool IsInsert = false;
        public EventHandler LamMoi;
        public string ID = "";
        KhachHang kh = new KhachHang();
        KhachHangBUS khBus = new KhachHangBUS();
        public frmSuaKhachHang()
        {
            InitializeComponent();
        }

        private void frmSuaKhachHang_Load(object sender, EventArgs e)
        {

            if (IsInsert == false)
            {
                DataTable dt = new DataTable();
                dt = khBus.GetDataByID(ID);

                txtTenKH.Text = dt.Rows[0]["tenKH"].ToString();
                txtSDT.Text = dt.Rows[0]["sdtKH"].ToString();
                txtEmail.Text = dt.Rows[0]["emailKH"].ToString();
                //cbLoaiSP.DisplayMember = dt.Rows[0]["maLSP"].ToString();
                //cbLoaiSP.ValueMember = dt.Rows[0]["tenLSP"].ToString();
                //cbLoaiSP.DataSource = dt;
                txtDiaChi.Text = dt.Rows[0]["diachiKH"].ToString();
                txtGhiChu.Text = dt.Rows[0]["ghichuKH"].ToString();
                LoaiKhachHangBUS LoaiBus = new LoaiKhachHangBUS();
                cbLoaiKH.DataSource = LoaiBus.GetDataID_Ten();
                cbLoaiKH.DisplayMember = "tenLKH";
                cbLoaiKH.ValueMember = "maLKH";

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
               
                    kh.maKH = int.Parse(ID);
                    kh.tenKH = txtTenKH.Text;
                    kh.sDT = txtSDT.Text;
                    if (rBtnNam.Checked == true)
                        kh.gioiTinh = "Nam";
                    if (rBtnNu.Checked == true)
                        kh.gioiTinh = "Nữ";
                    kh.ngSinh = dateTimeNgSinh.Value;
                    kh.email = txtEmail.Text;
                    kh.maLKH = int.Parse(cbLoaiKH.SelectedValue.ToString());
                    kh.diaChi = txtDiaChi.Text;
                    kh.ghiChu = txtGhiChu.Text;
                   

                    khBus.Update(kh);

                    MessageBox.Show("Update thành công");
                    if (LamMoi != null)
                        LamMoi(sender, e);
     
                    this.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Update Bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
