
namespace PhanMemQLTV
{
    partial class frmQLTaiLieu
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
            this.btnLoadDS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTheLoai = new System.Windows.Forms.RadioButton();
            this.radTenTG = new System.Windows.Forms.RadioButton();
            this.radTenTaiLieu = new System.Windows.Forms.RadioButton();
            this.radMaTaiLieu = new System.Windows.Forms.RadioButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSTaiLieu = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNhapTheLoai = new System.Windows.Forms.Label();
            this.lblNhapDonGia = new System.Windows.Forms.Label();
            this.lblNhapTenNXB = new System.Windows.Forms.Label();
            this.lblNhapTenTaiLieu = new System.Windows.Forms.Label();
            this.lblNhapTenTG = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTaiLieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTaiLieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colMaTaiLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTaiLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSTaiLieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadDS
            // 
            this.btnLoadDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDS.Location = new System.Drawing.Point(389, 156);
            this.btnLoadDS.Name = "btnLoadDS";
            this.btnLoadDS.Size = new System.Drawing.Size(145, 39);
            this.btnLoadDS.TabIndex = 10;
            this.btnLoadDS.Text = "Load Danh Sách";
            this.btnLoadDS.UseVisualStyleBackColor = true;
            this.btnLoadDS.Click += new System.EventHandler(this.btnLoadDS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(71, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 97);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm Tài Liệu";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNDTimKiem);
            this.groupBox5.Location = new System.Drawing.Point(397, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 60);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nhập thông tin cần Tìm Kiếm";
            // 
            // txtNDTimKiem
            // 
            this.txtNDTimKiem.Location = new System.Drawing.Point(11, 24);
            this.txtNDTimKiem.Name = "txtNDTimKiem";
            this.txtNDTimKiem.Size = new System.Drawing.Size(205, 20);
            this.txtNDTimKiem.TabIndex = 0;
            this.txtNDTimKiem.TextChanged += new System.EventHandler(this.txtNDTimKiem_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTheLoai);
            this.groupBox4.Controls.Add(this.radTenTG);
            this.groupBox4.Controls.Add(this.radTenTaiLieu);
            this.groupBox4.Controls.Add(this.radMaTaiLieu);
            this.groupBox4.Location = new System.Drawing.Point(30, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 60);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Theo";
            // 
            // radTheLoai
            // 
            this.radTheLoai.AutoSize = true;
            this.radTheLoai.Location = new System.Drawing.Point(270, 24);
            this.radTheLoai.Name = "radTheLoai";
            this.radTheLoai.Size = new System.Drawing.Size(63, 17);
            this.radTheLoai.TabIndex = 3;
            this.radTheLoai.TabStop = true;
            this.radTheLoai.Text = "Thể loại";
            this.radTheLoai.UseVisualStyleBackColor = true;
            // 
            // radTenTG
            // 
            this.radTenTG.AutoSize = true;
            this.radTenTG.Location = new System.Drawing.Point(187, 24);
            this.radTenTG.Name = "radTenTG";
            this.radTenTG.Size = new System.Drawing.Size(79, 17);
            this.radTenTG.TabIndex = 2;
            this.radTenTG.TabStop = true;
            this.radTenTG.Text = "Tên tác giả";
            this.radTenTG.UseVisualStyleBackColor = true;
            // 
            // radTenTaiLieu
            // 
            this.radTenTaiLieu.AutoSize = true;
            this.radTenTaiLieu.Location = new System.Drawing.Point(104, 24);
            this.radTenTaiLieu.Name = "radTenTaiLieu";
            this.radTenTaiLieu.Size = new System.Drawing.Size(77, 17);
            this.radTenTaiLieu.TabIndex = 1;
            this.radTenTaiLieu.TabStop = true;
            this.radTenTaiLieu.Text = "Tên tài liệu";
            this.radTenTaiLieu.UseVisualStyleBackColor = true;
            // 
            // radMaTaiLieu
            // 
            this.radMaTaiLieu.AutoSize = true;
            this.radMaTaiLieu.Location = new System.Drawing.Point(18, 24);
            this.radMaTaiLieu.Name = "radMaTaiLieu";
            this.radMaTaiLieu.Size = new System.Drawing.Size(73, 17);
            this.radMaTaiLieu.TabIndex = 0;
            this.radMaTaiLieu.TabStop = true;
            this.radMaTaiLieu.Text = "Mã tài liệu";
            this.radMaTaiLieu.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(464, 357);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 39);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(373, 357);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 39);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(282, 357);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 39);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(298, 156);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 39);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Home";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDSTaiLieu);
            this.groupBox2.Location = new System.Drawing.Point(18, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 204);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Độc Giả";
            // 
            // dataGridViewDSTaiLieu
            // 
            this.dataGridViewDSTaiLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSTaiLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTaiLieu,
            this.colTenTaiLieu,
            this.colTheLoai,
            this.colTacGia,
            this.colNXB,
            this.colNamXB,
            this.colDonGia,
            this.colGhiChu});
            this.dataGridViewDSTaiLieu.Location = new System.Drawing.Point(5, 19);
            this.dataGridViewDSTaiLieu.Name = "dataGridViewDSTaiLieu";
            this.dataGridViewDSTaiLieu.Size = new System.Drawing.Size(748, 179);
            this.dataGridViewDSTaiLieu.TabIndex = 0;
            this.dataGridViewDSTaiLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSTaiLieu_CellContentClick);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(555, 357);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 39);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(191, 357);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 39);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTheLoai);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNamXB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblNhapTheLoai);
            this.groupBox1.Controls.Add(this.lblNhapDonGia);
            this.groupBox1.Controls.Add(this.lblNhapTenNXB);
            this.groupBox1.Controls.Add(this.lblNhapTenTaiLieu);
            this.groupBox1.Controls.Add(this.lblNhapTenTG);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenTaiLieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaTaiLieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(71, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 150);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Liệu";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Items.AddRange(new object[] {
            "Công Nghệ",
            "Kinh Tế",
            "Khoa Học",
            "Tiểu Thuyết",
            "Tài Liệu",
            "Khác"});
            this.cboTheLoai.Location = new System.Drawing.Point(449, 27);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(165, 21);
            this.cboTheLoai.TabIndex = 16;
            // 
            // txtNXB
            // 
            this.txtNXB.Enabled = false;
            this.txtNXB.Location = new System.Drawing.Point(114, 87);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(169, 20);
            this.txtNXB.TabIndex = 15;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(449, 117);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(165, 20);
            this.txtGhiChu.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ghi Chú:";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Enabled = false;
            this.txtNamXB.Location = new System.Drawing.Point(114, 115);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(169, 20);
            this.txtNamXB.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Năm Xuất Bản:";
            // 
            // lblNhapTheLoai
            // 
            this.lblNhapTheLoai.AutoSize = true;
            this.lblNhapTheLoai.Location = new System.Drawing.Point(449, 50);
            this.lblNhapTheLoai.Name = "lblNhapTheLoai";
            this.lblNhapTheLoai.Size = new System.Drawing.Size(0, 13);
            this.lblNhapTheLoai.TabIndex = 6;
            // 
            // lblNhapDonGia
            // 
            this.lblNhapDonGia.AutoSize = true;
            this.lblNhapDonGia.Location = new System.Drawing.Point(449, 89);
            this.lblNhapDonGia.Name = "lblNhapDonGia";
            this.lblNhapDonGia.Size = new System.Drawing.Size(0, 13);
            this.lblNhapDonGia.TabIndex = 6;
            // 
            // lblNhapTenNXB
            // 
            this.lblNhapTenNXB.AutoSize = true;
            this.lblNhapTenNXB.Location = new System.Drawing.Point(449, 128);
            this.lblNhapTenNXB.Name = "lblNhapTenNXB";
            this.lblNhapTenNXB.Size = new System.Drawing.Size(0, 13);
            this.lblNhapTenNXB.TabIndex = 6;
            // 
            // lblNhapTenTaiLieu
            // 
            this.lblNhapTenTaiLieu.AutoSize = true;
            this.lblNhapTenTaiLieu.Location = new System.Drawing.Point(114, 92);
            this.lblNhapTenTaiLieu.Name = "lblNhapTenTaiLieu";
            this.lblNhapTenTaiLieu.Size = new System.Drawing.Size(0, 13);
            this.lblNhapTenTaiLieu.TabIndex = 6;
            // 
            // lblNhapTenTG
            // 
            this.lblNhapTenTG.AutoSize = true;
            this.lblNhapTenTG.Location = new System.Drawing.Point(114, 64);
            this.lblNhapTenTG.Name = "lblNhapTenTG";
            this.lblNhapTenTG.Size = new System.Drawing.Size(0, 13);
            this.lblNhapTenTG.TabIndex = 6;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(449, 57);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(165, 20);
            this.txtTacGia.TabIndex = 4;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(449, 87);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(165, 20);
            this.txtDonGia.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tác Giả :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thể Loại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà Xuất Bản:";
            // 
            // txtTenTaiLieu
            // 
            this.txtTenTaiLieu.Location = new System.Drawing.Point(114, 57);
            this.txtTenTaiLieu.Name = "txtTenTaiLieu";
            this.txtTenTaiLieu.Size = new System.Drawing.Size(169, 20);
            this.txtTenTaiLieu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Tài Liệu :";
            // 
            // txtMaTaiLieu
            // 
            this.txtMaTaiLieu.Location = new System.Drawing.Point(114, 28);
            this.txtMaTaiLieu.Name = "txtMaTaiLieu";
            this.txtMaTaiLieu.Size = new System.Drawing.Size(169, 20);
            this.txtMaTaiLieu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tài Liệu :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colMaTaiLieu
            // 
            this.colMaTaiLieu.DataPropertyName = "MaTaiLieu";
            this.colMaTaiLieu.HeaderText = "Mã Tài Liệu";
            this.colMaTaiLieu.Name = "colMaTaiLieu";
            // 
            // colTenTaiLieu
            // 
            this.colTenTaiLieu.DataPropertyName = "TenTaiLieu";
            this.colTenTaiLieu.HeaderText = "Tên Tài Liệu";
            this.colTenTaiLieu.Name = "colTenTaiLieu";
            // 
            // colTheLoai
            // 
            this.colTheLoai.DataPropertyName = "TheLoai";
            this.colTheLoai.HeaderText = "Thể Loại";
            this.colTheLoai.Name = "colTheLoai";
            // 
            // colTacGia
            // 
            this.colTacGia.DataPropertyName = "TacGia";
            this.colTacGia.HeaderText = "Tác Giả";
            this.colTacGia.Name = "colTacGia";
            // 
            // colNXB
            // 
            this.colNXB.DataPropertyName = "NXB";
            this.colNXB.HeaderText = "Nhà Xuất Bản";
            this.colNXB.Name = "colNXB";
            // 
            // colNamXB
            // 
            this.colNamXB.DataPropertyName = "NamXB";
            this.colNamXB.HeaderText = "Năm Xuất Bản";
            this.colNamXB.Name = "colNamXB";
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            // 
            // frmQLTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.btnLoadDS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLTaiLieu";
            this.Text = "frmQLTaiLieu";
            this.Load += new System.EventHandler(this.frmQLTaiLieu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSTaiLieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadDS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTenTaiLieu;
        private System.Windows.Forms.RadioButton radMaTaiLieu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label lblNhapTheLoai;
        private System.Windows.Forms.Label lblNhapDonGia;
        private System.Windows.Forms.Label lblNhapTenNXB;
        private System.Windows.Forms.Label lblNhapTenTaiLieu;
        private System.Windows.Forms.Label lblNhapTenTG;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTaiLieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTaiLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTheLoai;
        private System.Windows.Forms.RadioButton radTenTG;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDSTaiLieu;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTaiLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTaiLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}