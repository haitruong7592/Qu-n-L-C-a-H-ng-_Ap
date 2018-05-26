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
    public partial class frmThemSanPham : Form
    {
        Kho kho = new Kho();
        DTO.Size s = new DTO.Size();
        KhoBUS kBus = new KhoBUS();
        BUS.SizeBUS sBus = new BUS.SizeBUS();
        SanPham sp = new SanPham();
        SanPhamBUS spBus = new SanPhamBUS();
        LoaiSP loai = new LoaiSP();
        LoaiSPBUS lBus = new LoaiSPBUS();
        Mau mau = new Mau();
        MauBUS mauBUS = new MauBUS();
        public EventHandler LamMoi;

      


        public frmThemSanPham()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThemSanPham_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = lBus.GetDataID_TenLSP();
            cbLoaiSP.DisplayMember = "tenLSP";
            cbLoaiSP.ValueMember = "maLSP";
            cbSize.DataSource = sBus.GetDataID_TenSize();
            cbSize.DisplayMember = "size";
            cbSize.ValueMember = "maSize";
            cbMau.DataSource = mauBUS.GetDataByID_TenMau();
            cbMau.DisplayMember = "mau";
            cbMau.ValueMember = "maMau";
            dataThem.AllowUserToAddRows = false;


        }

 
           
        private void button1_Click(object sender, EventArgs e)
        {
           
            int sl = int.Parse(numSoLuong.Value.ToString());


            if (dataThem.Rows.Count == 0)
            {
                dataThem.Rows.Add(cbSize.SelectedValue.ToString(), cbMau.SelectedValue, numSoLuong.Value);
            }
            else
            {
                for (int i = 0; i < dataThem.Rows.Count; i++)
                {
                    if (dataThem[0, i].Value.ToString() == cbSize.SelectedValue.ToString() && dataThem[1, i].Value.ToString() == cbMau.SelectedValue.ToString())
                    {
                        sl = sl + Convert.ToInt32(dataThem["cSoLuong", i].Value.ToString());

                        dataThem.Rows.RemoveAt(i);
                      
                    }
  
                }
  
                dataThem.Rows.Add(cbSize.SelectedValue.ToString(), cbMau.SelectedValue, sl);
               
            }

         

        }

        private void dataSize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbLoaiSP.DataSource = spBus.GetData();
            //cbLoaiSP.DisplayMember = "tenLSP";
            //cbLoaiSP.ValueMember = "maLSP";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = dataThem.CurrentRow.Index;
                dataThem.Rows.RemoveAt(RowIndex);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Không thể xóa nữa " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thêm thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    sp.tenSP = txtTenSP.Text;

                    sp.maLSP = int.Parse(cbLoaiSP.SelectedValue.ToString());
                    sp.hangSP = txtHangSP.Text;
                    sp.donGiaSP = double.Parse(txtDonGia.Text);

      

                    spBus.Insert(sp);
                    for (int i = 0; i < dataThem.Rows.Count; i++)
                    {
                        DataTable dt = new DataTable();
                        dt = kBus.GetDataLastID();
                        kho.maSP = int.Parse(dt.Rows[0]["maSP"].ToString());
                        kho.maSize = int.Parse(dataThem[0, i].Value.ToString());
                        kho.maMau = int.Parse(dataThem[1, i].Value.ToString());
                        kho.soLuong = int.Parse(dataThem[2, i].Value.ToString());
                        kBus.Insert(kho);
                    }
                    MessageBox.Show("Thêm thành công");
                    if (LamMoi != null)
                        LamMoi(sender, e);
                    this.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bạn chưa nhập thông tin!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
