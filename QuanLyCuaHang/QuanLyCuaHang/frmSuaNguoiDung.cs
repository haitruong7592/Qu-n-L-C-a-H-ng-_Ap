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
    public partial class frmSuaNguoiDung : Form
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungBUS ndBus = new NguoiDungBUS();
        VaiTroBUS vtBus = new VaiTroBUS();
        public bool IsInsert = false;
        public EventHandler LamMoi;
        public string ID = "";
        public frmSuaNguoiDung()
        {
            InitializeComponent();
        }

        private void rBtnNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSuaNguoiDung_Load(object sender, EventArgs e)
        {
            if (IsInsert == false)
            {
                DataTable dt = new DataTable();
                dt = ndBus.GetDataByID(ID);

                txtTenND.Text = dt.Rows[0]["tenND"].ToString();
                txtTaiKhoan.Text = dt.Rows[0]["taikhoanND"].ToString();
                txtMatKhau.Text = dt.Rows[0]["matkhauND"].ToString();
                txtGhiChu.Text = dt.Rows[0]["ghichuND"].ToString();
                if (dt.Rows[0]["gioitinhND"].ToString() == "Nam")
                    rBtnNam.AutoCheck = true;
                else
                    rBtnNam.AutoCheck = true;
               
                cbVaiTro.DataSource = vtBus.GetDataID_TenVT();
                cbVaiTro.DisplayMember = "tenVT";
                cbVaiTro.ValueMember = "maVT";
              

            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    nd.maND = int.Parse(ID);
                    nd.tenND = txtTenND.Text;
                    if (rBtnNam.Checked == true)
                        nd.gioiTinhND = "Nam";
                    if(rBtnNu.Checked == true)
                        nd.gioiTinhND = "Nữ";
                    nd.ngaySinhND = dataTimeNgSinh.Value;
                    nd.ngayLam = dateTimeNgLam.Value;
                    nd.maVT = int.Parse(cbVaiTro.SelectedValue.ToString());
                    nd.taiKhoan = txtTaiKhoan.Text;
                    nd.matKhau = txtMatKhau.Text;
                    nd.ghiChu = txtGhiChu.Text;

                    ndBus.Update(nd);

                    MessageBox.Show("Sửa thành công");
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


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
