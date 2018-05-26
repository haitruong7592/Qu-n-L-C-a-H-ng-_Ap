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
    public partial class frmThongKeTheoMatHang : Form
    {
        public string ID = "";
        public bool IsInsert = false;
        public frmThongKeTheoMatHang()
        {
            InitializeComponent();
        }

        private void frmThongKeTheoMatHang_Load(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                KhoBUS bus = new KhoBUS();
                dataMatHang.DataSource = bus.ThongKeTheoMatHang_SP(ID, txtThang.Text.ToString(), txtNam.Text.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Không có dữ liệu!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmThongKeTheoMatHang_Load(null, null);
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
    }
}
