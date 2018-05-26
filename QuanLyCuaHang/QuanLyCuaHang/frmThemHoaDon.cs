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
    public partial class frmThemHoaDon : Form
    {
    
        NguoiDung nd = new NguoiDung();
        NguoiDungBUS ndBus = new NguoiDungBUS();
        KhachHang kh = new KhachHang();
        KhachHangBUS khBus = new KhachHangBUS();
        Kho K = new Kho();
        KhoBUS kBus = new KhoBUS();
        HoaDon hd = new HoaDon();
        HoaDonBUS hdBus = new HoaDonBUS();
        CTHD ct = new CTHD();
        CTHDBUS ctBus = new CTHDBUS();
        public EventHandler LamMoi;
        public frmThemHoaDon()
        {
            InitializeComponent();
 
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDTKH_TextChanged(object sender, EventArgs e)
        {
            if (txtSDTKH.Text.Trim() == null)
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                ///bắt đầu tìm kiếm
                DataTable dt = new DataTable();
                dt = khBus.SearchuBySDT(txtSDTKH.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    txtKhachHang.Text = dt.Rows[0]["tenKH"].ToString();
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = dataThemMH.CurrentRow.Index;
                dataThemMH.Rows.RemoveAt(RowIndex);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Không thể hũy nữa " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmThemHoaDon_Load(object sender, EventArgs e)
        {
            //NguoiDungBUS nguoiDung = new NguoiDungBUS();
            cbNhanVien.DataSource = ndBus.GetDataID_Ten();
            cbNhanVien.DisplayMember = "tenND";
            cbNhanVien.ValueMember = "maND";
            cbMaMatHang.DataSource = kBus.GetDataID_TenSP();
            cbMaMatHang.DisplayMember = "maMH";
            cbMaMatHang.ValueMember = "maMH";
           // dataThemMH.DataSource = kBus.GetDataThemMH(cbMaMatHang.SelectedValue.ToString());
            
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataThemMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int indexRow = dataThemMH.Rows.Count - 1;

            DataTable dt = new DataTable();
            dt = kBus.GetDataThemMH(cbMaMatHang.SelectedValue.ToString());
            //int countx = 0;
            int sl = int.Parse(numSoLuong.Value.ToString());
            //Int32.TryParse(txtsoluong.Text, out sl);
            double DonGia = double.Parse(dt.Rows[0]["dongiaSP"].ToString());
            double SoLuong = double.Parse(numSoLuong.Value.ToString());
            double ThanhTien;
            if (indexRow == 0)
            {
                ThanhTien = DonGia * SoLuong;
                dataThemMH.Rows.Add(dt.Rows[0]["maMH"].ToString(), dt.Rows[0]["tenSP"].ToString(), dt.Rows[0]["size"].ToString(), dt.Rows[0]["mau"].ToString(), numSoLuong.Value, dt.Rows[0]["dongiaSP"].ToString(),    ThanhTien);
            }
            else
            {
                for (int i = 0; i < indexRow; i++)
                {
                    if (dataThemMH[0, i].Value.ToString() == cbMaMatHang.SelectedValue.ToString())
                    {
                        sl = sl + Convert.ToInt32(dataThemMH["cSoLuong", i].Value.ToString());
                        //dataThem["cSize", i].Value.ToString() = cbSize.Text;
                        //dataThem["cMau", i].Value.ToString() = cbMau.Text;
                        dataThemMH.Rows.RemoveAt(i);
                        //break;
                    }
                    //else
                    //{
                    //    countx = 10;

                    //}
                }
                //if (countx == 10)
                //{
                ThanhTien = DonGia *sl;
                dataThemMH.Rows.Add(dt.Rows[0]["maMH"].ToString(), dt.Rows[0]["tenSP"].ToString(), dt.Rows[0]["size"].ToString(), dt.Rows[0]["mau"].ToString(), sl, dt.Rows[0]["dongiaSP"].ToString(), ThanhTien);
                //}

 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataThemMH.DataSource = kBus.GetDataThemMH(cbMaMatHang.SelectedValue.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTongTien()
        {
            try
            {
                double TongTien = 0;
                    for(int i = 0; i < dataThemMH.Rows.Count -1; i++)
                    {
                        TongTien += double.Parse(dataThemMH["cThanhTien", i].Value.ToString());
                    }
                txtTongTien.Text = TongTien.ToString("###,###");
            }
            catch (Exception)
            {

                
            }
        }
        private void dataThemMH_TabIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void dataThemMH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void dataThemMH_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            UpdateTongTien();
        }

        private void dataThemMH_VisibleChanged(object sender, EventArgs e)
        {
            UpdateTongTien();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            //{
            if (MessageBox.Show("Bạn có muốn nhập hóa đơn này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                  

                    hd.maND = int.Parse(cbNhanVien.SelectedValue.ToString());
                    DataTable data = khBus.SearchuBySDT(txtSDTKH.Text);
                    hd.maKH = int.Parse(data.Rows[0]["maKH"].ToString());
                    hd.ngayHD = dataNgayHD.Value;
                    hd.tongTien = double.Parse(txtTongTien.Text);
                    hd.trangThaiHD = "Chưa xử lý";
                    hdBus.Insert(hd);


                    

                    for (int i = 0; i < dataThemMH.Rows.Count -1; i++)
                    {
                        DataTable dt = new DataTable();
                        dt = ctBus.GetDataLastID();
                        ct.maHD = int.Parse(dt.Rows[0]["maHD"].ToString());
                        ct.maMH = int.Parse(dataThemMH[0, i].Value.ToString());
                        ct.soLuong = int.Parse(dataThemMH["cSoLuong", i].Value.ToString());
                        ct.donGia = int.Parse(dataThemMH["cThanhTien", i].Value.ToString());
                        ctBus.Insert(ct);
                        string MaMHUpdate = dataThemMH[0, i].Value.ToString();
                        string SoLuongUpdate = dataThemMH["cSoLuong", i].Value.ToString();
                        kBus.UpdateSoLuong(MaMHUpdate, SoLuongUpdate);

                    }
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

        private void btnTaoIn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn nhập hóa đơn này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {


                    hd.maND = int.Parse(cbNhanVien.SelectedValue.ToString());
                    DataTable data = khBus.SearchuBySDT(txtSDTKH.Text);
                    hd.maKH = int.Parse(data.Rows[0]["maKH"].ToString());
                    hd.ngayHD = dataNgayHD.Value;
                    hd.tongTien = double.Parse(txtTongTien.Text);
                    hd.trangThaiHD = "Đã Xử Lý";
                    hdBus.Insert(hd);


                  

                    for (int i = 0; i < dataThemMH.Rows.Count - 1; i++)
                    {
                        DataTable dt = new DataTable();
                        dt = ctBus.GetDataLastID();
                        ct.maHD = int.Parse(dt.Rows[0]["maHD"].ToString());
                        ct.maMH = int.Parse(dataThemMH[0, i].Value.ToString());
                        ct.soLuong = int.Parse(dataThemMH["cSoLuong", i].Value.ToString());
                        ct.donGia = int.Parse(dataThemMH["cThanhTien", i].Value.ToString());
                        ctBus.Insert(ct);
                        string MaMHUpdate = dataThemMH[0, i].Value.ToString();
                        string SoLuongUpdate = dataThemMH["cSoLuong", i].Value.ToString();
                        kBus.UpdateSoLuong(MaMHUpdate, SoLuongUpdate);

                    }
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
    }
}
