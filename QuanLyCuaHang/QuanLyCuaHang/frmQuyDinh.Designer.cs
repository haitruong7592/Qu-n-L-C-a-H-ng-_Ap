namespace QuanLyCuaHang
{
    partial class frmQuyDinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataSize = new System.Windows.Forms.DataGridView();
            this.btnSuaSize = new System.Windows.Forms.Button();
            this.btnXoaSize = new System.Windows.Forms.Button();
            this.btnThemSize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataMau = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSuaMau = new System.Windows.Forms.Button();
            this.btnXoaMau = new System.Windows.Forms.Button();
            this.btnThemMau = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataLoaiSP = new System.Windows.Forms.DataGridView();
            this.btnSuaLSP = new System.Windows.Forms.Button();
            this.btnXoaLSP = new System.Windows.Forms.Button();
            this.btnThemLSP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.cMaSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctenLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSize)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMau)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTroVe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 478);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUY ĐỊNH";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 420);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 414);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSize);
            this.panel5.Controls.Add(this.dataSize);
            this.panel5.Controls.Add(this.btnSuaSize);
            this.panel5.Controls.Add(this.btnXoaSize);
            this.panel5.Controls.Add(this.btnThemSize);
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 354);
            this.panel5.TabIndex = 4;
            // 
            // dataSize
            // 
            this.dataSize.AllowUserToAddRows = false;
            this.dataSize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaSize,
            this.cTenSize});
            this.dataSize.Location = new System.Drawing.Point(1, 2);
            this.dataSize.Name = "dataSize";
            this.dataSize.Size = new System.Drawing.Size(274, 205);
            this.dataSize.TabIndex = 0;
            this.dataSize.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSize_CellContentClick);
            this.dataSize.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSize_RowEnter);
            this.dataSize.Click += new System.EventHandler(this.dataSize_Click);
            this.dataSize.DoubleClick += new System.EventHandler(this.dataSize_DoubleClick);
            // 
            // btnSuaSize
            // 
            this.btnSuaSize.Location = new System.Drawing.Point(188, 292);
            this.btnSuaSize.Name = "btnSuaSize";
            this.btnSuaSize.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSize.TabIndex = 3;
            this.btnSuaSize.Text = "Sửa";
            this.btnSuaSize.UseVisualStyleBackColor = true;
            this.btnSuaSize.Click += new System.EventHandler(this.btnSuaSize_Click);
            // 
            // btnXoaSize
            // 
            this.btnXoaSize.Location = new System.Drawing.Point(99, 292);
            this.btnXoaSize.Name = "btnXoaSize";
            this.btnXoaSize.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSize.TabIndex = 2;
            this.btnXoaSize.Text = "Xóa";
            this.btnXoaSize.UseVisualStyleBackColor = true;
            this.btnXoaSize.Click += new System.EventHandler(this.btnXoaSize_Click);
            // 
            // btnThemSize
            // 
            this.btnThemSize.Location = new System.Drawing.Point(9, 292);
            this.btnThemSize.Name = "btnThemSize";
            this.btnThemSize.Size = new System.Drawing.Size(75, 23);
            this.btnThemSize.TabIndex = 1;
            this.btnThemSize.Text = "Thêm";
            this.btnThemSize.UseVisualStyleBackColor = true;
            this.btnThemSize.Click += new System.EventHandler(this.btnThemSize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "SIZE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(285, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 414);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtMau);
            this.panel6.Controls.Add(this.dataMau);
            this.panel6.Controls.Add(this.btnSuaMau);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.btnXoaMau);
            this.panel6.Controls.Add(this.btnThemMau);
            this.panel6.Location = new System.Drawing.Point(-2, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 352);
            this.panel6.TabIndex = 7;
            // 
            // dataMau
            // 
            this.dataMau.AllowUserToAddRows = false;
            this.dataMau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaMau,
            this.cTenMau});
            this.dataMau.Location = new System.Drawing.Point(2, 1);
            this.dataMau.Name = "dataMau";
            this.dataMau.Size = new System.Drawing.Size(259, 206);
            this.dataMau.TabIndex = 8;
            this.dataMau.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMau_RowEnter);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(267, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 166);
            this.panel7.TabIndex = 7;
            // 
            // btnSuaMau
            // 
            this.btnSuaMau.Location = new System.Drawing.Point(183, 292);
            this.btnSuaMau.Name = "btnSuaMau";
            this.btnSuaMau.Size = new System.Drawing.Size(75, 23);
            this.btnSuaMau.TabIndex = 6;
            this.btnSuaMau.Text = "Sửa";
            this.btnSuaMau.UseVisualStyleBackColor = true;
            this.btnSuaMau.Click += new System.EventHandler(this.btnSuaMau_Click);
            // 
            // btnXoaMau
            // 
            this.btnXoaMau.Location = new System.Drawing.Point(95, 292);
            this.btnXoaMau.Name = "btnXoaMau";
            this.btnXoaMau.Size = new System.Drawing.Size(75, 23);
            this.btnXoaMau.TabIndex = 5;
            this.btnXoaMau.Text = "Xóa";
            this.btnXoaMau.UseVisualStyleBackColor = true;
            this.btnXoaMau.Click += new System.EventHandler(this.btnXoaMau_Click);
            // 
            // btnThemMau
            // 
            this.btnThemMau.Location = new System.Drawing.Point(5, 292);
            this.btnThemMau.Name = "btnThemMau";
            this.btnThemMau.Size = new System.Drawing.Size(75, 23);
            this.btnThemMau.TabIndex = 4;
            this.btnThemMau.Text = "Thêm";
            this.btnThemMau.UseVisualStyleBackColor = true;
            this.btnThemMau.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "MÀU";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(551, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 414);
            this.panel4.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtLoaiSP);
            this.panel8.Controls.Add(this.dataLoaiSP);
            this.panel8.Controls.Add(this.btnSuaLSP);
            this.panel8.Controls.Add(this.btnThemLSP);
            this.panel8.Controls.Add(this.btnXoaLSP);
            this.panel8.Location = new System.Drawing.Point(0, 61);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(256, 351);
            this.panel8.TabIndex = 7;
            // 
            // dataLoaiSP
            // 
            this.dataLoaiSP.AllowUserToAddRows = false;
            this.dataLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaLSP,
            this.ctenLSP});
            this.dataLoaiSP.Location = new System.Drawing.Point(0, 0);
            this.dataLoaiSP.Name = "dataLoaiSP";
            this.dataLoaiSP.Size = new System.Drawing.Size(256, 207);
            this.dataLoaiSP.TabIndex = 0;
            this.dataLoaiSP.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLoaiSP_RowEnter);
            // 
            // btnSuaLSP
            // 
            this.btnSuaLSP.Location = new System.Drawing.Point(178, 291);
            this.btnSuaLSP.Name = "btnSuaLSP";
            this.btnSuaLSP.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLSP.TabIndex = 6;
            this.btnSuaLSP.Text = "Sửa";
            this.btnSuaLSP.UseVisualStyleBackColor = true;
            this.btnSuaLSP.Click += new System.EventHandler(this.btnSuaLSP_Click);
            // 
            // btnXoaLSP
            // 
            this.btnXoaLSP.Location = new System.Drawing.Point(92, 291);
            this.btnXoaLSP.Name = "btnXoaLSP";
            this.btnXoaLSP.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLSP.TabIndex = 5;
            this.btnXoaLSP.Text = "Xóa";
            this.btnXoaLSP.UseVisualStyleBackColor = true;
            this.btnXoaLSP.Click += new System.EventHandler(this.btnXoaLSP_Click);
            // 
            // btnThemLSP
            // 
            this.btnThemLSP.Location = new System.Drawing.Point(7, 291);
            this.btnThemLSP.Name = "btnThemLSP";
            this.btnThemLSP.Size = new System.Drawing.Size(75, 23);
            this.btnThemLSP.TabIndex = 4;
            this.btnThemLSP.Text = "Thêm";
            this.btnThemLSP.UseVisualStyleBackColor = true;
            this.btnThemLSP.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "LOẠI SẢN PHẨM";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(89, 242);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 4;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(83, 242);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(100, 20);
            this.txtMau.TabIndex = 9;
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(82, 241);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(100, 20);
            this.txtLoaiSP.TabIndex = 7;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(12, 17);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 2;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // cMaSize
            // 
            this.cMaSize.DataPropertyName = "maSize";
            this.cMaSize.HeaderText = "Mã Size";
            this.cMaSize.Name = "cMaSize";
            this.cMaSize.ReadOnly = true;
            // 
            // cTenSize
            // 
            this.cTenSize.DataPropertyName = "size";
            this.cTenSize.HeaderText = "Tên Size";
            this.cTenSize.Name = "cTenSize";
            this.cTenSize.ReadOnly = true;
            // 
            // cMaMau
            // 
            this.cMaMau.DataPropertyName = "maMau";
            this.cMaMau.HeaderText = "Mã Màu";
            this.cMaMau.Name = "cMaMau";
            this.cMaMau.ReadOnly = true;
            // 
            // cTenMau
            // 
            this.cTenMau.DataPropertyName = "mau";
            this.cTenMau.HeaderText = "Tên Màu";
            this.cTenMau.Name = "cTenMau";
            this.cTenMau.ReadOnly = true;
            // 
            // cMaLSP
            // 
            this.cMaLSP.DataPropertyName = "maLSP";
            this.cMaLSP.HeaderText = "Mã Loại Sản Phẩm";
            this.cMaLSP.Name = "cMaLSP";
            this.cMaLSP.ReadOnly = true;
            // 
            // ctenLSP
            // 
            this.ctenLSP.DataPropertyName = "tenLSP";
            this.ctenLSP.HeaderText = "Tên Loại Sản Phẩm";
            this.ctenLSP.Name = "ctenLSP";
            this.ctenLSP.ReadOnly = true;
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(813, 478);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmQuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmQuyDinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMau)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuaSize;
        private System.Windows.Forms.Button btnXoaSize;
        private System.Windows.Forms.Button btnThemSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSuaMau;
        private System.Windows.Forms.Button btnXoaMau;
        private System.Windows.Forms.Button btnThemMau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSuaLSP;
        private System.Windows.Forms.Button btnXoaLSP;
        private System.Windows.Forms.Button btnThemLSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataSize;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataMau;
        private System.Windows.Forms.DataGridView dataLoaiSP;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctenLSP;
    }
}