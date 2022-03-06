
namespace PhanMemQLTV
{
    partial class frmQLThuThu
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiemTT = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTenTT = new System.Windows.Forms.RadioButton();
            this.radMaTT = new System.Windows.Forms.RadioButton();
            this.btnLoadDSTT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenTKTT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMKTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNhapGioiTinh = new System.Windows.Forms.Label();
            this.lblNhapDiaChi = new System.Windows.Forms.Label();
            this.lblNhapSDT = new System.Windows.Forms.Label();
            this.lblNhapNgaySinh = new System.Windows.Forms.Label();
            this.lblNhapTenTT = new System.Windows.Forms.Label();
            this.dtmNgaySinhTT = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinhTT = new System.Windows.Forms.ComboBox();
            this.txtDiaChiTT = new System.Windows.Forms.TextBox();
            this.txtSoDTTT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuTT = new System.Windows.Forms.Button();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.btnHuyTT = new System.Windows.Forms.Button();
            this.btnThemTT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSThuThu = new System.Windows.Forms.DataGridView();
            this.colMaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSThuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(69, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm Thủ Thư";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNDTimKiemTT);
            this.groupBox5.Location = new System.Drawing.Point(270, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 60);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nhập thông tin cần Tìm Kiếm";
            // 
            // txtNDTimKiemTT
            // 
            this.txtNDTimKiemTT.Location = new System.Drawing.Point(11, 24);
            this.txtNDTimKiemTT.Name = "txtNDTimKiemTT";
            this.txtNDTimKiemTT.Size = new System.Drawing.Size(332, 20);
            this.txtNDTimKiemTT.TabIndex = 0;
            this.txtNDTimKiemTT.TextChanged += new System.EventHandler(this.txtNDTimKiemTT_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTenTT);
            this.groupBox4.Controls.Add(this.radMaTT);
            this.groupBox4.Location = new System.Drawing.Point(30, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 60);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Theo";
            // 
            // radTenTT
            // 
            this.radTenTT.AutoSize = true;
            this.radTenTT.Location = new System.Drawing.Point(104, 24);
            this.radTenTT.Name = "radTenTT";
            this.radTenTT.Size = new System.Drawing.Size(61, 17);
            this.radTenTT.TabIndex = 1;
            this.radTenTT.TabStop = true;
            this.radTenTT.Text = "Tên TT";
            this.radTenTT.UseVisualStyleBackColor = true;
            // 
            // radMaTT
            // 
            this.radMaTT.AutoSize = true;
            this.radMaTT.Location = new System.Drawing.Point(18, 24);
            this.radMaTT.Name = "radMaTT";
            this.radMaTT.Size = new System.Drawing.Size(57, 17);
            this.radMaTT.TabIndex = 0;
            this.radMaTT.TabStop = true;
            this.radMaTT.Text = "Mã TT";
            this.radMaTT.UseVisualStyleBackColor = true;
            // 
            // btnLoadDSTT
            // 
            this.btnLoadDSTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDSTT.Location = new System.Drawing.Point(350, 139);
            this.btnLoadDSTT.Name = "btnLoadDSTT";
            this.btnLoadDSTT.Size = new System.Drawing.Size(145, 39);
            this.btnLoadDSTT.TabIndex = 9;
            this.btnLoadDSTT.Text = "Load Danh Sách";
            this.btnLoadDSTT.UseVisualStyleBackColor = true;
            this.btnLoadDSTT.Click += new System.EventHandler(this.btnLoadDS_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(259, 139);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 39);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Home";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenTKTT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMKTT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblNhapGioiTinh);
            this.groupBox1.Controls.Add(this.lblNhapDiaChi);
            this.groupBox1.Controls.Add(this.lblNhapSDT);
            this.groupBox1.Controls.Add(this.lblNhapNgaySinh);
            this.groupBox1.Controls.Add(this.lblNhapTenTT);
            this.groupBox1.Controls.Add(this.dtmNgaySinhTT);
            this.groupBox1.Controls.Add(this.cboGioiTinhTT);
            this.groupBox1.Controls.Add(this.txtDiaChiTT);
            this.groupBox1.Controls.Add(this.txtSoDTTT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenTT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaTT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(69, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 151);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Thủ Thư";
            // 
            // txtTenTKTT
            // 
            this.txtTenTKTT.Enabled = false;
            this.txtTenTKTT.Location = new System.Drawing.Point(114, 115);
            this.txtTenTKTT.Name = "txtTenTKTT";
            this.txtTenTKTT.Size = new System.Drawing.Size(169, 20);
            this.txtTenTKTT.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tên TK:";
            // 
            // txtMKTT
            // 
            this.txtMKTT.Location = new System.Drawing.Point(449, 116);
            this.txtMKTT.Name = "txtMKTT";
            this.txtMKTT.Size = new System.Drawing.Size(165, 20);
            this.txtMKTT.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mật Khẩu:";
            // 
            // lblNhapGioiTinh
            // 
            this.lblNhapGioiTinh.AutoSize = true;
            this.lblNhapGioiTinh.Location = new System.Drawing.Point(449, 50);
            this.lblNhapGioiTinh.Name = "lblNhapGioiTinh";
            this.lblNhapGioiTinh.Size = new System.Drawing.Size(0, 13);
            this.lblNhapGioiTinh.TabIndex = 6;
            // 
            // lblNhapDiaChi
            // 
            this.lblNhapDiaChi.AutoSize = true;
            this.lblNhapDiaChi.Location = new System.Drawing.Point(449, 89);
            this.lblNhapDiaChi.Name = "lblNhapDiaChi";
            this.lblNhapDiaChi.Size = new System.Drawing.Size(0, 13);
            this.lblNhapDiaChi.TabIndex = 6;
            // 
            // lblNhapSDT
            // 
            this.lblNhapSDT.AutoSize = true;
            this.lblNhapSDT.Location = new System.Drawing.Point(449, 128);
            this.lblNhapSDT.Name = "lblNhapSDT";
            this.lblNhapSDT.Size = new System.Drawing.Size(0, 13);
            this.lblNhapSDT.TabIndex = 6;
            // 
            // lblNhapNgaySinh
            // 
            this.lblNhapNgaySinh.AutoSize = true;
            this.lblNhapNgaySinh.Location = new System.Drawing.Point(114, 92);
            this.lblNhapNgaySinh.Name = "lblNhapNgaySinh";
            this.lblNhapNgaySinh.Size = new System.Drawing.Size(0, 13);
            this.lblNhapNgaySinh.TabIndex = 6;
            // 
            // lblNhapTenTT
            // 
            this.lblNhapTenTT.AutoSize = true;
            this.lblNhapTenTT.Location = new System.Drawing.Point(114, 64);
            this.lblNhapTenTT.Name = "lblNhapTenTT";
            this.lblNhapTenTT.Size = new System.Drawing.Size(0, 13);
            this.lblNhapTenTT.TabIndex = 6;
            // 
            // dtmNgaySinhTT
            // 
            this.dtmNgaySinhTT.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaySinhTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaySinhTT.Location = new System.Drawing.Point(114, 86);
            this.dtmNgaySinhTT.Name = "dtmNgaySinhTT";
            this.dtmNgaySinhTT.Size = new System.Drawing.Size(169, 20);
            this.dtmNgaySinhTT.TabIndex = 2;
            // 
            // cboGioiTinhTT
            // 
            this.cboGioiTinhTT.FormattingEnabled = true;
            this.cboGioiTinhTT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhTT.Location = new System.Drawing.Point(449, 28);
            this.cboGioiTinhTT.Name = "cboGioiTinhTT";
            this.cboGioiTinhTT.Size = new System.Drawing.Size(165, 21);
            this.cboGioiTinhTT.TabIndex = 3;
            // 
            // txtDiaChiTT
            // 
            this.txtDiaChiTT.Location = new System.Drawing.Point(449, 57);
            this.txtDiaChiTT.Name = "txtDiaChiTT";
            this.txtDiaChiTT.Size = new System.Drawing.Size(165, 20);
            this.txtDiaChiTT.TabIndex = 4;
            // 
            // txtSoDTTT
            // 
            this.txtSoDTTT.Location = new System.Drawing.Point(449, 87);
            this.txtSoDTTT.Name = "txtSoDTTT";
            this.txtSoDTTT.Size = new System.Drawing.Size(165, 20);
            this.txtSoDTTT.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa Chỉ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sinh :";
            // 
            // txtTenTT
            // 
            this.txtTenTT.Location = new System.Drawing.Point(114, 57);
            this.txtTenTT.Name = "txtTenTT";
            this.txtTenTT.Size = new System.Drawing.Size(169, 20);
            this.txtTenTT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Thủ Thư :";
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(114, 28);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(169, 20);
            this.txtMaTT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thủ Thư :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLuuTT
            // 
            this.btnLuuTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuTT.Location = new System.Drawing.Point(441, 341);
            this.btnLuuTT.Name = "btnLuuTT";
            this.btnLuuTT.Size = new System.Drawing.Size(85, 39);
            this.btnLuuTT.TabIndex = 15;
            this.btnLuuTT.Text = "Lưu";
            this.btnLuuTT.UseVisualStyleBackColor = true;
            this.btnLuuTT.Click += new System.EventHandler(this.btnLuuTT_Click);
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTT.Location = new System.Drawing.Point(350, 341);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.Size = new System.Drawing.Size(85, 39);
            this.btnXoaTT.TabIndex = 14;
            this.btnXoaTT.Text = "Xóa";
            this.btnXoaTT.UseVisualStyleBackColor = true;
            this.btnXoaTT.Click += new System.EventHandler(this.btnXoaTT_Click);
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTT.Location = new System.Drawing.Point(259, 341);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(85, 39);
            this.btnSuaTT.TabIndex = 13;
            this.btnSuaTT.Text = "Sửa";
            this.btnSuaTT.UseVisualStyleBackColor = true;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            // 
            // btnHuyTT
            // 
            this.btnHuyTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyTT.Location = new System.Drawing.Point(532, 341);
            this.btnHuyTT.Name = "btnHuyTT";
            this.btnHuyTT.Size = new System.Drawing.Size(85, 39);
            this.btnHuyTT.TabIndex = 16;
            this.btnHuyTT.Text = "Hủy";
            this.btnHuyTT.UseVisualStyleBackColor = true;
            this.btnHuyTT.Click += new System.EventHandler(this.btnHuyTT_Click);
            // 
            // btnThemTT
            // 
            this.btnThemTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTT.Location = new System.Drawing.Point(168, 341);
            this.btnThemTT.Name = "btnThemTT";
            this.btnThemTT.Size = new System.Drawing.Size(85, 39);
            this.btnThemTT.TabIndex = 12;
            this.btnThemTT.Text = "Thêm";
            this.btnThemTT.UseVisualStyleBackColor = true;
            this.btnThemTT.Click += new System.EventHandler(this.btnThemTT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDSThuThu);
            this.groupBox2.Location = new System.Drawing.Point(32, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 200);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Thủ Thư";
            // 
            // dataGridViewDSThuThu
            // 
            this.dataGridViewDSThuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSThuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTT,
            this.colTenTT,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colSDT,
            this.colDiaChi,
            this.colTK,
            this.colMK});
            this.dataGridViewDSThuThu.Location = new System.Drawing.Point(12, 22);
            this.dataGridViewDSThuThu.Name = "dataGridViewDSThuThu";
            this.dataGridViewDSThuThu.Size = new System.Drawing.Size(705, 157);
            this.dataGridViewDSThuThu.TabIndex = 0;
            this.dataGridViewDSThuThu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSThuThu_RowEnter);
            // 
            // colMaTT
            // 
            this.colMaTT.DataPropertyName = "MaTT";
            this.colMaTT.HeaderText = "Mã TT";
            this.colMaTT.Name = "colMaTT";
            // 
            // colTenTT
            // 
            this.colTenTT.DataPropertyName = "TenTT";
            this.colTenTT.HeaderText = "Tên TT";
            this.colTenTT.Name = "colTenTT";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinhTT";
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinhTT";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDTTT";
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.Name = "colSDT";
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChiTT";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colTK
            // 
            this.colTK.DataPropertyName = "TenTaiKhoanTT";
            this.colTK.HeaderText = "Tên TK";
            this.colTK.Name = "colTK";
            // 
            // colMK
            // 
            this.colMK.DataPropertyName = "MatKhauTT";
            this.colMK.HeaderText = "Mật Khẩu";
            this.colMK.Name = "colMK";
            // 
            // frmQLThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLuuTT);
            this.Controls.Add(this.btnXoaTT);
            this.Controls.Add(this.btnSuaTT);
            this.Controls.Add(this.btnHuyTT);
            this.Controls.Add(this.btnThemTT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadDSTT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmQLThuThu";
            this.Text = "frmQLThuThu";
            this.Load += new System.EventHandler(this.frmQLThuThu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSThuThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNDTimKiemTT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTenTT;
        private System.Windows.Forms.RadioButton radMaTT;
        private System.Windows.Forms.Button btnLoadDSTT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenTKTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMKTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNhapGioiTinh;
        private System.Windows.Forms.Label lblNhapDiaChi;
        private System.Windows.Forms.Label lblNhapSDT;
        private System.Windows.Forms.Label lblNhapNgaySinh;
        private System.Windows.Forms.Label lblNhapTenTT;
        private System.Windows.Forms.DateTimePicker dtmNgaySinhTT;
        private System.Windows.Forms.ComboBox cboGioiTinhTT;
        private System.Windows.Forms.TextBox txtDiaChiTT;
        private System.Windows.Forms.TextBox txtSoDTTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuTT;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.Button btnSuaTT;
        private System.Windows.Forms.Button btnHuyTT;
        private System.Windows.Forms.Button btnThemTT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDSThuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMK;
    }
}