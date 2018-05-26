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
    public partial class frmSuaSanPham : Form
    {
        Kho k = new Kho();
        KhoBUS kBus = new KhoBUS();
        public bool IsInsert = false;
        public EventHandler LamMoi;
        public string ID = "";
        SanPham sp = new SanPham();
        SanPhamBUS spBus = new SanPhamBUS();
        LoaiSPBUS lBus = new LoaiSPBUS();
        public frmSuaSanPham()
        {
            InitializeComponent();
        }

        private void frmSuaSanPham_Load(object sender, EventArgs e)
        {

            dataKho.DataSource = kBus.GetData();
            if (IsInsert == false)
            {
                DataTable dt = new DataTable();
                dt = spBus.GetDataByID(ID);
               
                txtTenSP.Text = dt.Rows[0]["tenSP"].ToString();
                txtHangSP.Text = dt.Rows[0]["hangSP"].ToString();
                txtDonGia.Text = dt.Rows[0]["dongiaSP"].ToString();

                cbLoaiSP.DataSource = lBus.GetDataID_TenLSP();
                cbLoaiSP.DisplayMember = "tenLSP";
                cbLoaiSP.ValueMember = "maLSP";


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {


                txtTenSP.Text = String.Empty;
                txtHangSP.Text = String.Empty;
                txtDonGia.Text = String.Empty;
            
        }

        private void cbLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbLoaiSP_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    sp.maSP = int.Parse(ID);
                    sp.tenSP = txtTenSP.Text;

                    sp.maLSP = int.Parse(cbLoaiSP.SelectedValue.ToString());
                    sp.hangSP = txtHangSP.Text;
                    sp.donGiaSP = double.Parse(txtDonGia.Text);

 

                    spBus.Update(sp);

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

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
