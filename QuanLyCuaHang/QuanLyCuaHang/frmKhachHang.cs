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
    public partial class frmKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        KhachHangBUS khBus = new KhachHangBUS();
        LoaiKhachHangBUS LoaiBus = new LoaiKhachHangBUS();
        void LoadDataKhachHang()
        {
            dataKhachHang.DataSource = khBus.GetData();
        }
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataKhachHang();
            //cbLoaiKhachHang.DataSource = LoaiBus.GetDataID_Ten();
            //cbLoaiKhachHang.DisplayMember = "tenLKH";
            //cbLoaiKhachHang.ValueMember = "maLKH";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            f.LamMoi += new EventHandler(frmKhachHang_Load);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaKhachHang frm = new frmSuaKhachHang();
            frm.IsInsert = false;
            frm.ID = dataKhachHang.CurrentRow.Cells[0].Value.ToString();
            frm.LamMoi += new EventHandler(frmKhachHang_Load);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmKhachHang_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataKhachHang_DoubleClick(object sender, EventArgs e)
        {
            frmSuaKhachHang frm = new frmSuaKhachHang();
            frm.IsInsert = false;
            frm.ID = dataKhachHang.CurrentRow.Cells[0].Value.ToString();
            frm.LamMoi += new EventHandler(frmKhachHang_Load);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int CurrentIndex = dataKhachHang.CurrentCell.RowIndex;
                    string MaKH = Convert.ToString(dataKhachHang.Rows[CurrentIndex].Cells[0].Value.ToString());
                    khBus.Delete(MaKH);
                    MessageBox.Show("Đã xóa thông tin thành công");

                    LoadDataKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông báo lỗi: " + ex.Message);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == null)
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                ///bắt đầu tìm kiếm
                DataTable dt = new DataTable();
                dt = khBus.Search(txtTimKiem.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dataKhachHang.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Bạn tìm" + txtTimKiem.Text + "không có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frmKhachHang_Load(null, null);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
