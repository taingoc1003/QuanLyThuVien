using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PhanMemQLTV
{
    public partial class frmQLThuThu : Form
    {
        public frmQLThuThu()
        {
            InitializeComponent();
        }

        // Khai báo 
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn

        // Phương thức kết nối
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSThuThu.DataSource = myTable;
            return myTable;
        }

        // Phương thức thiết lập Controls
        private void setControls(bool edit)
        {
            txtTenTT.Enabled = edit;
            dtmNgaySinhTT.Enabled = edit;
            cboGioiTinhTT.Enabled = edit;
            txtDiaChiTT.Enabled = edit;
            txtSoDTTT.Enabled = edit;
            txtTenTKTT.Enabled = edit;
            txtMKTT.Enabled = edit;
        }

        //Load
        private void frmQLThuThu_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblThuThu";
            dataGridViewDSThuThu.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSThuThu.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSThuThu.Enabled = true;
            btnLuuTT.Enabled = false;
            btnHuyTT.Enabled = false;
            txtMaTT.Enabled = false;
        }


        // Phương thức hiển thị các thuộc tính bảng Thủ THư lên txt
        public string maTT, tenTT, gioiTinhTT, ngaySinhTT, diaChiTT, sdtTT, tenTKTT, mkTT;
        public int xuly;
        private void dataGridViewDSThuThu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaTT.Text = myTable.Rows[row]["MaTT"].ToString();
                maTT = txtMaTT.Text;
                txtTenTT.Text = myTable.Rows[row]["TenTT"].ToString();
                tenTT = txtTenTT.Text;
                cboGioiTinhTT.Text = myTable.Rows[row]["GioiTinhTT"].ToString();
                gioiTinhTT = cboGioiTinhTT.Text;
                dtmNgaySinhTT.Text = myTable.Rows[row]["NgaySinhTT"].ToString();
                ngaySinhTT = dtmNgaySinhTT.Text;
                txtSoDTTT.Text = myTable.Rows[row]["SDTTT"].ToString();
                sdtTT = txtSoDTTT.Text;
                txtDiaChiTT.Text = myTable.Rows[row]["DiaChiTT"].ToString();
                diaChiTT = txtDiaChiTT.Text;
                txtTenTKTT.Text = myTable.Rows[row]["TenTaiKhoanTT"].ToString();
                tenTKTT = txtTenTKTT.Text;
                txtMKTT.Text = myTable.Rows[row]["MatKhauTT"].ToString();
                mkTT = txtMKTT.Text;
            }
            catch
            {

            }
        }

        // Phương thức tăng mã TT tự động
        public string setMaTT()
        {
            string cauTruyVan = "select * from tblThuThu";
            dataGridViewDSThuThu.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSThuThu.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "TT001";
            }
            else
            {
                int k;
                maTuDong = "TT";
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

        
        //btn Thêm Thủ Thư
        private void btnThemTT_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtMaTT.Text = setMaTT();
            txtTenTT.Text = "";
            txtSoDTTT.Text = "";
            txtDiaChiTT.Text = "";
            cboGioiTinhTT.Text = "Nam";
            dtmNgaySinhTT.Text = "";
            txtTenTKTT.Text = txtMaTT.Text;
            txtTenTKTT.Enabled = false;
            txtMKTT.Text = "";
            txtTenTT.Focus();
            btnSuaTT.Enabled = false;
            btnXoaTT.Enabled = false;
            btnThemTT.Enabled = false;
            btnLuuTT.Enabled = true;
            btnHuyTT.Enabled = true;
            xuly = 0;
            dataGridViewDSThuThu.Enabled = false;
        }


        //btn Sửa
        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            setControls(true);
            btnXoaTT.Enabled = false;
            btnSuaTT.Enabled = false;
            btnLuuTT.Enabled = true;
            btnHuyTT.Enabled = true;
            btnThemTT.Enabled = false;
            txtTenTT.Focus();
            dataGridViewDSThuThu.Enabled = false;
            txtTenTKTT.Enabled = false;
            xuly = 1;
        }

        //btn Xóa
        private void xoaTT()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string xoadongsql = "delete from tblThuThu where MaTT='" + txtMaTT.Text + "'";
                ketnoi(xoadongsql);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "Thông Báo");
            }
            string cauTruyVan = "select * from tblThuThu";
            dataGridViewDSThuThu.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSThuThu.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            xoaTT();
        }


        //btn Lưu
        private void themTT()
        {
            try
            {
                string themdongsql = "insert into tblThuThu values ('" + txtMaTT.Text + "',N'" + txtTenTT.Text + "',N'" 
                    + cboGioiTinhTT.Text + "','" + dtmNgaySinhTT.Text + "','" + txtSoDTTT.Text + "',N'" + txtDiaChiTT.Text + "','" + txtTenTKTT.Text + "','" + txtMKTT.Text + "')";
                ketnoi(themdongsql);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            int ktSDTTT;
            bool isNumberSDT = int.TryParse(txtSoDTTT.Text, out ktSDTTT);
            if (isNumberSDT == false || txtSoDTTT.Text.Length > 12)
            {
                MessageBox.Show("Nhập SĐT không đúng, vui lòng nhập lại.");
                txtSoDTTT.Focus();
            }

            DateTime bday = DateTime.Parse(dtmNgaySinhTT.Text);
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            if (age < 18)
            {
                MessageBox.Show("Số tuổi phải >= 18, vui lòng nhập lại.");
                dtmNgaySinhTT.Focus();
            }

            if (txtMaTT.Text.Length > 0 && txtTenTT.Text.Length > 0 && txtDiaChiTT.Text.Length > 0 && isNumberSDT == true && age > 18 && cboGioiTinhTT.Text.Length > 0 && txtTenTKTT.Text.Length > 0 && txtMKTT.Text.Length > 0 )
            {
                if (xuly == 0)
                {
                    themTT();
                }
                else if (xuly == 1)
                {
                    try
                    {
                        string capnhatdongsql;
                        capnhatdongsql = "update tblThuThu set TenTT=N'" + txtTenTT.Text + "',GioiTinhTT=N'" + cboGioiTinhTT.Text + "',NgaySinhTT='" + dtmNgaySinhTT.Text + "',DiaChiTT=N'" + txtDiaChiTT.Text + "',SDTTT='" + txtSoDTTT.Text + "',TenTaiKhoanTT='" + txtTenTKTT.Text + "',MatKhauTT='" + txtMKTT.Text + "' where MaTT='" + txtMaTT.Text + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công.", "Thông Báo");
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
                    }
                }
                string cauTruyVan = "select * from tblThuThu";
                dataGridViewDSThuThu.DataSource = ketnoi(cauTruyVan);
                dataGridViewDSThuThu.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuuTT.Enabled = false;
                btnHuyTT.Enabled = false;
                btnThemTT.Enabled = true;
                btnSuaTT.Enabled = true;
                btnXoaTT.Enabled = true;
                setControls(false);
                dataGridViewDSThuThu.Enabled = true;
            }
            else
            {

                if (txtTenTT.Text.Length == 0 || txtDiaChiTT.Text.Length == 0 || txtTenTKTT.Text.Length == 0 || txtMKTT.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    txtTenTT.Focus();
                }

                else if (txtTenTT.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập họ và tên.");
                    txtTenTT.Focus();
                }
                else if (txtDiaChiTT.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ.");
                    txtDiaChiTT.Focus();
                }
                else if (txtTenTKTT.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản.");
                    txtTenTKTT.Focus();
                }
                else if (txtMKTT.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập nhập khẩu.");
                    txtMKTT.Focus();
                }
            }
        }

        //btn Hủy
        private void btnHuyTT_Click(object sender, EventArgs e)
        {
            txtMaTT.Text = maTT;
            txtTenTT.Text = tenTT;
            txtSoDTTT.Text = sdtTT;
            txtDiaChiTT.Text = diaChiTT;
            cboGioiTinhTT.Text = gioiTinhTT;
            dtmNgaySinhTT.Text = ngaySinhTT;
            txtTenTKTT.Text = tenTKTT;
            txtMKTT.Text = mkTT;
            btnLuuTT.Enabled = false;
            btnHuyTT.Enabled = false;
            btnThemTT.Enabled = true;
            btnSuaTT.Enabled = true;
            btnXoaTT.Enabled = true;
            setControls(false);
            dataGridViewDSThuThu.Enabled = true;
        }

        //thoát form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //tìm kiếm
        private void txtNDTimKiemTT_TextChanged(object sender, EventArgs e)
        {
            btnThemTT.Enabled = false;
            if (radMaTT.Checked)
            {
                string timkiem = "select * from tblThuThu where MaTT like '%" + txtNDTimKiemTT.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSThuThu.DataSource = ketnoi(timkiem);
                dataGridViewDSThuThu.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenTT.Checked)
            {
                string timkiem = "select * from tblThuThu where TenTT like N'%" + txtNDTimKiemTT.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSThuThu.DataSource = ketnoi(timkiem);
                dataGridViewDSThuThu.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }


        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            lblNhapTenTT.Text = "";
            lblNhapNgaySinh.Text = "";
            lblNhapGioiTinh.Text = "";
            lblNhapSDT.Text = "";
            lblNhapDiaChi.Text = "";
            setControls(false);
            txtNDTimKiemTT.Text = "";
            string cauTruyVan = "select * from tblThuThu";
            dataGridViewDSThuThu.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSThuThu.AutoGenerateColumns = false;
            myConnection.Close();
            btnThemTT.Enabled = true;
            btnSuaTT.Enabled = true;
            btnXoaTT.Enabled = true;
        }



    }
}
