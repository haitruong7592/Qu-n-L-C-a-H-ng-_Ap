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
    public partial class frmQuyDinh : Form
    {
        DTO.Size s = new DTO.Size();
        SizeBUS sBus = new SizeBUS();
        Mau m = new Mau();
        MauBUS mBus = new MauBUS();
        LoaiSP l = new LoaiSP();
        LoaiSPBUS lBus = new LoaiSPBUS();
        string idSize;
        string idMau;
        string idLoaiSP;
        public frmQuyDinh()
        {
            InitializeComponent();
        }
        void LoadSize()
        {
            dataSize.DataSource = sBus.GetData();
        }
        void LoadMau()
        {
            dataMau.DataSource = mBus.GetData();
        }
        void LoadLoaiSP()
        { 
            dataLoaiSP.DataSource = lBus.GetData();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thêm thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {

                    m.mauSP= txtMau.Text;
                    mBus.Insert(m);

                    MessageBox.Show("Thêm thành công");
                    LoadMau();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bạn chưa nhập thông tin!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thêm thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {

                    l.tenLSP = txtLoaiSP.Text;
                    lBus.Insert(l);

                    MessageBox.Show("Thêm thành công");
                    LoadLoaiSP();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bạn chưa nhập thông tin!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            LoadSize();
            LoadMau();
            LoadLoaiSP();
        }

        private void dataSize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public string LoadID()
        //{
        //    return 
        //}
        private void btnSuaSize_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có muốn sửa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    idSize = dataSize.CurrentRow.Cells[0].Value.ToString();
                    s.maSize = int.Parse(idSize);
                    s.sizeSP = txtSize.Text;

                    sBus.Update(s);

                    MessageBox.Show("Sửa thành công");
                    LoadSize();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bạn chưa nhập thông tin!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaSize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int CurrentIndex = dataSize.CurrentCell.RowIndex;
                    string MaSize = Convert.ToString(dataSize.Rows[CurrentIndex].Cells[0].Value.ToString());
                    sBus.Delete(MaSize);
                    MessageBox.Show("Đã xóa thông tin thành công");

                    LoadSize();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông báo lỗi: " + ex.Message);

                }
            }
        }

        private void btnXoaMau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int CurrentIndex = dataMau.CurrentCell.RowIndex;
                    string MaMau = Convert.ToString(dataMau.Rows[CurrentIndex].Cells[0].Value.ToString());
                    mBus.Delete(MaMau);
                    MessageBox.Show("Đã xóa thông tin thành công");

                    LoadMau();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông báo lỗi: " + ex.Message);

                }
            }
        }

        private void btnXoaLSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int CurrentIndex = dataLoaiSP.CurrentCell.RowIndex;
                    string MaLSP = Convert.ToString(dataLoaiSP.Rows[CurrentIndex].Cells[0].Value.ToString());
                    lBus.Delete(MaLSP);
                    MessageBox.Show("Đã xóa thông tin thành công");

                    LoadLoaiSP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông báo lỗi: " + ex.Message);

                }
            }
        }

        private void btnThemSize_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có muốn thêm thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    
                    s.sizeSP = txtSize.Text;            
                    sBus.Insert(s);

                    MessageBox.Show("Thêm thành công");
                    LoadSize();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bạn chưa nhập thông tin!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
      
        private void dataSize_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtSize.Text = dataSize["cTenSize", index].Value.ToString();
        }

        private void dataSize_Click(object sender, EventArgs e)
        {

        }

        private void dataSize_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaMau_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn sửa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    idMau = dataMau.CurrentRow.Cells[0].Value.ToString();
                    m.maMau = int.Parse(idMau);
                    m.mauSP = txtMau.Text;

                    mBus.Update(m);

                    MessageBox.Show("Sửa thành công");
                    LoadMau();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bạn chưa nhập thông tin!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSuaLSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    idLoaiSP = dataLoaiSP.CurrentRow.Cells[0].Value.ToString();
                    l.maLSP = int.Parse(idLoaiSP);
                    l.tenLSP = txtLoaiSP.Text;

                    lBus.Update(l);

                    MessageBox.Show("Sửa thành công");
                    LoadLoaiSP();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bạn chưa nhập thông tin!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataMau_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtMau.Text = dataMau["cTenMau", index].Value.ToString();
        }

        private void dataLoaiSP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtLoaiSP.Text = dataLoaiSP["ctenLSP", index].Value.ToString();
        }
    }
}
