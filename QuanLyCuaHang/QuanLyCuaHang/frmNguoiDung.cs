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
    public partial class frmNguoiDung : Form
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungBUS ndBus = new NguoiDungBUS();
        public frmNguoiDung()
        {
            InitializeComponent();
        }
        void LoadDataNguoiDung()
        {
            dataNguoiDung.DataSource = ndBus.GetDataNguoiDung();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int CurrentIndex = dataNguoiDung.CurrentCell.RowIndex;
                    string MaND = Convert.ToString(dataNguoiDung.Rows[CurrentIndex].Cells[0].Value.ToString());
                    NguoiDungBUS bus = new NguoiDungBUS();
                    bus.Delete(MaND);
                    MessageBox.Show("Đã xóa thông tin thành công");

                    LoadDataNguoiDung();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông báo lỗi: " + ex.Message);

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaNguoiDung frm = new frmSuaNguoiDung();
            frm.IsInsert = false;
            frm.ID = dataNguoiDung.CurrentRow.Cells[0].Value.ToString();
            frm.LamMoi += new EventHandler(frmNguoiDung_Load);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataNguoiDung();
        }

        private void tnThem_Click(object sender, EventArgs e)
        {
            frmThemNguoiDung f = new frmThemNguoiDung();
            f.LamMoi += new EventHandler(frmNguoiDung_Load);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dataNguoiDung_DoubleClick(object sender, EventArgs e)
        {
            frmSuaNguoiDung frm = new frmSuaNguoiDung();
            frm.IsInsert = false;
            frm.ID = dataNguoiDung.CurrentRow.Cells[0].Value.ToString();
            frm.LamMoi += new EventHandler(frmNguoiDung_Load);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
