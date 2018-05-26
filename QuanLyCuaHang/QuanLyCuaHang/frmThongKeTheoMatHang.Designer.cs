namespace QuanLyCuaHang
{
    partial class frmThongKeTheoMatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataMatHang = new System.Windows.Forms.DataGridView();
            this.cMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ THEO TỪNG MẶT HÀNG CỦA SẢN PHẨM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 430);
            this.panel1.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(619, 115);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 18;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(619, 89);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 17;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(437, 89);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 20);
            this.txtThang.TabIndex = 16;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(555, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Nhập Năm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nhập Tháng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataMatHang);
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 279);
            this.panel2.TabIndex = 1;
            // 
            // dataMatHang
            // 
            this.dataMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaMH,
            this.cTenSP,
            this.cSize,
            this.cMau,
            this.cSL,
            this.cTongTien});
            this.dataMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMatHang.Location = new System.Drawing.Point(0, 0);
            this.dataMatHang.Name = "dataMatHang";
            this.dataMatHang.Size = new System.Drawing.Size(730, 279);
            this.dataMatHang.TabIndex = 0;
            // 
            // cMaMH
            // 
            this.cMaMH.DataPropertyName = "maMH";
            this.cMaMH.HeaderText = "Mã Mặt Hàng";
            this.cMaMH.Name = "cMaMH";
            this.cMaMH.ReadOnly = true;
            // 
            // cTenSP
            // 
            this.cTenSP.DataPropertyName = "tenSP";
            this.cTenSP.HeaderText = "Tên Sản Phẩm";
            this.cTenSP.Name = "cTenSP";
            this.cTenSP.ReadOnly = true;
            // 
            // cSize
            // 
            this.cSize.DataPropertyName = "size";
            this.cSize.HeaderText = "Size";
            this.cSize.Name = "cSize";
            this.cSize.ReadOnly = true;
            // 
            // cMau
            // 
            this.cMau.DataPropertyName = "mau";
            this.cMau.HeaderText = "Màu";
            this.cMau.Name = "cMau";
            this.cMau.ReadOnly = true;
            // 
            // cSL
            // 
            this.cSL.DataPropertyName = "sl";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.cSL.DefaultCellStyle = dataGridViewCellStyle1;
            this.cSL.HeaderText = "Số Lượng";
            this.cSL.Name = "cSL";
            this.cSL.ReadOnly = true;
            // 
            // cTongTien
            // 
            this.cTongTien.DataPropertyName = "tongtien";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.cTongTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.cTongTien.HeaderText = "Tổng Tiền";
            this.cTongTien.Name = "cTongTien";
            this.cTongTien.ReadOnly = true;
            // 
            // frmThongKeTheoMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 430);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKeTheoMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThongKeTheoMatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTongTien;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}