using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PhanMemQLTV
{
    public partial class frmQLTaiLieu : Form
    {
        public frmQLTaiLieu()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlDataAdapter myDataAdapter;
        private DataTable myTable;
        private SqlCommand myCommand;

        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSTaiLieu.DataSource = myTable;
            return myTable;
        }

        private void setControls(bool edit)
        {
            txtTenTaiLieu.Enabled = edit;
            cboTheLoai.Enabled = edit;
            txtTacGia.Enabled = edit;
            txtNXB.Enabled = edit;
            txtNamXB.Enabled = edit;
            txtDonGia.Enabled = edit;
            txtGhiChu.Enabled = edit;
        }

        //Load
        private void frmQLTaiLieu_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblTaiLieu";
            dataGridViewDSTaiLieu.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSTaiLieu.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSTaiLieu.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaTaiLieu.Enabled = false;
        }

        //Tăng mã tự động
        public string tangMaTuDong()
        {
            string cauTruyVan = "select * from tblTaiLieu";
            dataGridViewDSTaiLieu.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSTaiLieu.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "TL001";
            }
            else
            {
                int k;
                maTuDong = "TL";
                k = Convert.ToInt32(myTable.Rows[myTable.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    maTuDong = maTuDong + "00";
                }
                else if (k < 100)
                {
                    maTuDong = maTuDong + "0";
                }
                maTuDong = maTuDong + k.ToString();
            }
            return maTuDong;
        }

        public string maTaiLieu, tenTaiLieu, tacGia, theLoai, nXB, namXB,  donGia, ghiChu;


        //Load datagrid
        private void dataGridViewDSTaiLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaTaiLieu.Text = myTable.Rows[row]["MaTaiLieu"].ToString();
                maTaiLieu = txtMaTaiLieu.Text;
                txtTenTaiLieu.Text = myTable.Rows[row]["TenTaiLieu"].ToString();
                tenTaiLieu = txtTenTaiLieu.Text;
                cboTheLoai.Text = myTable.Rows[row]["TheLoai"].ToString();
                theLoai = cboTheLoai.Text;
                txtTacGia.Text = myTable.Rows[row]["TacGia"].ToString();
                tacGia = txtTacGia.Text;
                txtNXB.Text = myTable.Rows[row]["NXB"].ToString();
                nXB = txtNXB.Text;
                txtNamXB.Text = myTable.Rows[row]["NamXB"].ToString();
                namXB = txtNamXB.Text;
                txtDonGia.Text = myTable.Rows[row]["DonGia"].ToString();
                donGia = txtDonGia.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;
            }
            catch
            {

            }
        }

        public int xuly;


        //btn Home
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //btn Load danh sách
        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            lblNhapTheLoai.Text = "";
            lblNhapDonGia.Text = "";
            lblNhapTenNXB.Text = "";
            lblNhapTenTaiLieu.Text = "";
            lblNhapTenTG.Text = "";
            setControls(false);
            txtNDTimKiem.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            string cauTruyVan = "select * from tblTaiLieu";
            dataGridViewDSTaiLieu.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSTaiLieu.AutoGenerateColumns = false;
            myConnection.Close();
        }

        //Tìm kiếm
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            if (radMaTaiLieu.Checked)
            {
                string timkiemMS = "select * from tblTaiLieu where MaTaiLieu like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSTaiLieu.DataSource = myTable;
                dataGridViewDSTaiLieu.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenTaiLieu.Checked)
            {
                string timkiemTS = "select * from tblTaiLieu where TenTaiLieu like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemTS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSTaiLieu.DataSource = ketnoi(timkiemTS);
                dataGridViewDSTaiLieu.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenTG.Checked)
            {
                string timkiemMS = "select * from tblTaiLieu where TacGia like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSTaiLieu.DataSource = myTable;
                dataGridViewDSTaiLieu.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTheLoai.Checked)
            {
                string timkiemMS = "select * from tblTaiLieu where TheLoai like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSTaiLieu.DataSource = myTable;
                dataGridViewDSTaiLieu.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }


        //btn Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTaiLieu.Text = tangMaTuDong();
            txtTenTaiLieu.Text = "";
            cboTheLoai.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            txtNamXB.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";

            setControls(true);
            dataGridViewDSTaiLieu.Enabled = false;
            txtTenTaiLieu.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            xuly = 0;
        }

        //Sửa tài liệu
        private void suaTaiLieu()
        {
            try
            {
                string capnhatdong;
                capnhatdong = "update tblTaiLieu set TenTaiLieu=N'" + txtTenTaiLieu.Text + "',TheLoai=N'" + cboTheLoai.Text + "',TacGia=N'" + 
                    txtTacGia.Text + "',NXB=N'" + txtNXB.Text + "',NamXB='" + txtNamXB.Text + "',DonGia='" + txtDonGia.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaTaiLieu='" + txtMaTaiLieu.Text + "'";
                
                ketnoi(capnhatdong);
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công.", "Thông Báo");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setControls(true);
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            dataGridViewDSTaiLieu.Enabled = false;
            txtTenTaiLieu.Focus();
            xuly = 1;
        }

        //Xóa tài liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongSql;
                    xoadongSql = "DELETE FROM tblTaiLieu WHERE MaTaiLieu='" + txtMaTaiLieu.Text + "'";
                    ketnoi(xoadongSql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại.\nSách này đang được mượn.", "Thông Báo");
                }
            }
            string cauTruyVan = "select * from tblTaiLieu";
            dataGridViewDSTaiLieu.DataSource = ketnoi(cauTruyVan);
            myConnection.Close();
        }


        //btn Lưu
        private void themTaiLieu()
        {
            try
            {

                string themdongSql;
                themdongSql = "insert into tblTaiLieu values ('" + txtMaTaiLieu.Text + "',N'" + txtTenTaiLieu.Text + "',N'" + cboTheLoai.Text + "',N'" 
                    + txtTacGia.Text + "',N'" + txtNXB.Text + "','" + txtNamXB.Text + "','" + txtDonGia.Text + "',N'" + txtGhiChu.Text + "')";
                ketnoi(themdongSql);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch
            {
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int ktNamXB, ktDonGia;
            bool isNumberDonGia = int.TryParse(txtDonGia.Text, out ktDonGia);
            bool isNumberNamXB = int.TryParse(txtNamXB.Text, out ktNamXB);
            if (isNumberDonGia == false || isNumberNamXB == false)
            {
                MessageBox.Show("Vui lòng nhập số trong các ô: Năm Xuất Bản, Đơn Giá.", "Thông Báo");
            }
            if (txtTenTaiLieu.Text.Length > 0 && txtTacGia.Text.Length > 0 && txtNXB.Text.Length > 0 && cboTheLoai.Text.Length > 0 && isNumberDonGia == true && isNumberNamXB == true)
            {
                if (xuly == 0)
                {
                    themTaiLieu();
                }
                else if (xuly == 1)
                {
                    suaTaiLieu();

                }
                string cauTruyVan = "select * from tblTaiLieu";
                dataGridViewDSTaiLieu.DataSource = ketnoi(cauTruyVan);
                dataGridViewDSTaiLieu.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                setControls(false);
                dataGridViewDSTaiLieu.Enabled = true;

            }
            else
            {
                if (txtTenTaiLieu.Text.Length == 0 || cboTheLoai.Text.Length == 0 || txtTacGia.Text.Length == 0 || txtNXB.Text.Length == 0 || txtDonGia.MaxLength == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    txtTenTaiLieu.Focus();
                }
                else if (txtTenTaiLieu.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên tài liệu");
                    txtTenTaiLieu.Focus();
                }
                else if (cboTheLoai.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn thể loại.");
                    cboTheLoai.Focus();
                }
                else if (txtTacGia.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên tác giả.");
                    txtTacGia.Focus();
                }
                else if (txtNXB.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập nhà xuất bản.");
                    txtNXB.Focus();
                }
                else if (txtNamXB.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập năm xuất bản.");
                    txtNamXB.Focus();
                }
                else if (txtDonGia.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đơn giá.");
                    txtDonGia.Focus();
                }
            }
        }


        //btn Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTaiLieu.Text = maTaiLieu;
            txtTenTaiLieu.Text = tenTaiLieu;
            cboTheLoai.Text = theLoai;
            txtTacGia.Text = tacGia;
            txtNXB.Text = nXB;
            txtDonGia.Text = donGia;
            txtGhiChu.Text = ghiChu;
            setControls(false);
            dataGridViewDSTaiLieu.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

    }
}
