using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyCuaHang
{
    public partial class frmManHinhChinh : Form
    {

        HoaDon hd = new HoaDon();
        HoaDonBUS hdBus = new HoaDonBUS();
       
        public void LoadDataSanPham()
        {
            
            SanPhamBUS sp = new SanPhamBUS();
            dataSanPham.DataSource = sp.GetData();

        }
        void LoadDataHoaDon()
        {
            dataHoaDon.DataSource = hdBus.GetData();
        }

        public void TimTheoHoaDonTheoKhoangThoiGian()
        {
            DateTime TuNgay = dataTimeTuNgay.Value;
            DateTime DenNgay = dataTimeDenNgay.Value;
            DataTable dt = new DataTable();
            dt = hdBus.GetDataDistanceTime(TuNgay, DenNgay);
            if (dt.Rows.Count > 0)
            {
                dataHoaDon.DataSource = dt;
            }
            else
            {

                MessageBox.Show("Không tìm thấy dữ liệu trong khoảng thời gian này!");
                dataHoaDon.DataSource = null;
            }
        }
        public void TimHoaDonTheoKhoangTG_Ten()
        {
            DateTime TuNgay = dataTimeTuNgay.Value;
            DateTime DenNgay = dataTimeDenNgay.Value;
            string TenKH = txtTimKiemHD.Text;
            DataTable dt = new DataTable();
            dt = hdBus.GetDataDistanceTime_TenKH(TuNgay, DenNgay,TenKH);
            if (dt.Rows.Count > 0)
            {
                dataHoaDon.DataSource = dt;
            }
            else
            {
                dataHoaDon.DataSource = null;
                MessageBox.Show("Thông tin tìm kiếm không tìm thấy!");
            }
        }
        public void TimHoaDonTheoTenKH()
        {
            string TenKH = txtTimKiemHD.Text;
            DataTable dt = new DataTable();
            dt = hdBus.GetDataByTenKH(TenKH);
            if (dt.Rows.Count > 0)
            {
                dataHoaDon.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Bạn tìm" + txtTimKiem.Text + "không có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public frmManHinhChinh()
        {
            InitializeComponent();


           



        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanPhamBUS sp = new SanPhamBUS();
            if(txtTimKiem.Text.Trim() == null)
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DataTable dt = new DataTable();
                dt = sp.Search(txtTimKiem.Text.Trim());
                if(dt.Rows.Count > 0)
                {
                    dataSanPham.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Bạn tìm" + txtTimKiem.Text + "không có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frmManHinhChinh_Load(null, null);
                }
            }


        }
        BindingSource SanPhamSourse = new BindingSource();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            LoadDataSanPham();
            LoadDataHoaDon();
        }

        private void textTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSanPham f = new frmThemSanPham();
            this.Hide();
            f.LamMoi += new EventHandler(btnLamMoi_Click);
            f.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int CurrentIndex = dataSanPham.CurrentCell.RowIndex;
                    string MaSP = Convert.ToString(dataSanPham.Rows[CurrentIndex].Cells[0].Value.ToString());
                    SanPhamBUS bus = new SanPhamBUS();
                    bus.Delete(MaSP);
                    MessageBox.Show("Đã xóa thông tin thành công");

                    LoadDataSanPham();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thông báo lỗi: " +ex.Message);

                }
            }

        
    }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmQuyDinh f = new frmQuyDinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            frmNguoiDung f = new frmNguoiDung();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            frmSuaSanPham frm = new frmSuaSanPham();
            frm.IsInsert = false;
            frm.ID = dataSanPham.CurrentRow.Cells[0].Value.ToString();
            frm.LamMoi += new EventHandler(btnLamMoi_Click);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiemHD_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmThemHoaDon f = new frmThemHoaDon();
            this.Hide();
            f.LamMoi += new EventHandler(btnLamMoi_Click);
            f.ShowDialog();
            this.Show();
        }

        private void tabQuanLy_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
 
        private void dataSanPham_DoubleClick(object sender, EventArgs e)
        {
            SanPhamBUS sp = new SanPhamBUS();
            frmSuaSanPham frm = new frmSuaSanPham();
            frm.IsInsert = false;
            frm.ID = dataSanPham.CurrentRow.Cells[0].Value.ToString();
            frm.LamMoi += new EventHandler(btnLamMoi_Click);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tabTrangChinh_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDataSanPham();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmQuyDinh f = new frmQuyDinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void rBtnTimKiemHD_CheckedChanged(object sender, EventArgs e)
        {
            DateTime TuNgay = dataTimeTuNgay.Value;
            DateTime DenNgay = dataTimeDenNgay.Value;
            DataTable dt = new DataTable();
            dt= hdBus.GetDataDistanceTime(TuNgay, DenNgay);
            if (dt.Rows.Count > 0)
            {
                dataHoaDon.DataSource = dt;
            }
            else
            {
                frmManHinhChinh_Load(null, null);
            }

        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SanPhamBUS spBus = new SanPhamBUS();
                dataThongKeSP.DataSource = spBus.ThongKeSanPham(txtThang.Text.ToString(), txtNam.Text.ToString() );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmManHinhChinh_Load(null, null);

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnTheoKH_Click(object sender, EventArgs e)
        {
            frmThongKeKhachHang f = new frmThongKeKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dataThongKeSP_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmThongKeTheoMatHang frm = new frmThongKeTheoMatHang();
                frm.IsInsert = false;
                frm.ID = dataThongKeSP.CurrentRow.Cells[0].Value.ToString();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Chưa có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && txtTimKiemHD.Text == null)
                TimTheoHoaDonTheoKhoangThoiGian();
            else if (checkBox1.Checked == true && txtTimKiemHD.Text != null)
                TimHoaDonTheoKhoangTG_Ten();
            else if (checkBox1.Checked == false && txtTimKiemHD.Text != null)
                TimHoaDonTheoTenKH();
            else
               // frmManHinhChinh_Load(null, null);
        }
    }
}
