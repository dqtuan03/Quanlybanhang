using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

		//string strcon = @"Data Source=TUAN;Initial Catalog=QuanLyBanHangTapHoa;Integrated Security=True";
		string strcon = Properties.Settings.Default.chuoiketnoi;

		private void HienThi()
        {
            btnThemKhachHang.Enabled = true;
            btnSuaKhachHang.Enabled = false;
            btnXoaKhachHang.Enabled = false;
            btnHuyTimKiem.Enabled = false;
            btnTimKiem.Enabled = true;
            SqlConnection con = new SqlConnection(strcon);
            string sql = "SELECT * FROM KhachHang";
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvKhachHang.DataSource = dt;
            con.Close();
        }

        private void reset_value()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemKhachHang.Enabled = false;
            btnSuaKhachHang.Enabled = true;
            btnXoaKhachHang.Enabled = true;
            txtMaKhachHang.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            sosMaKhachHang.Enabled = false;
            sosTenKhachHang.Enabled = false;
            sosDiaChi.Enabled = false;
            sosDienThoai.Enabled = false;

            if (txtMaKhachHang.Text == "")
            {
                sosMaKhachHang.Enabled = true;
            }    
            if (txtTenKhachHang.Text == "")
            {
                sosTenKhachHang.Enabled = true;
            }
            if (txtDiaChi.Text == "")
            {
                sosDiaChi.Enabled = true;
            }
            if (txtDienThoai.Text == "")
            {
                sosDienThoai.Enabled = true;
            }

            if (sosTenKhachHang.Enabled == false && sosDiaChi.Enabled == false && sosDienThoai.Enabled == false) 
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    string sql = "insert into KhachHang values ('" + txtMaKhachHang.Text + "', N'" + txtTenKhachHang.Text + "', N'" + txtDiaChi.Text + "' ,'" + txtDienThoai.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    int ret = cmd.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công!");
                    }
                    con.Close();
                    HienThi();
                    reset_value();
                }
                catch 
                {
                    txtMaKhachHang.Text = "";
                    MessageBox.Show("Trùng mã khách hàng!");
                }
            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            string sql = "update KhachHang set TenKhachHang = N'" + txtTenKhachHang.Text + "', DiaChi = N'" + txtDiaChi.Text + "' , DienThoai = '" + txtDienThoai.Text + "' where MaKhachHang = '" + txtMaKhachHang.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Thêm khách hàng không thành công!");
            }
            con.Close();
            HienThi();
            reset_value();
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            btnThemKhachHang.Enabled = true;
            btnSuaKhachHang.Enabled = false;
            btnXoaKhachHang.Enabled = false;
            SqlConnection con = new SqlConnection(strcon);
            string sql = "delete KhachHang where MaKhachHang = '" + txtMaKhachHang.Text + "'";
            string sql1 = "delete HoaDon where MaKhachHang = '" + txtMaKhachHang.Text + "'";
            SqlCommand cmd = new SqlCommand(sql1, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            HienThi();
            reset_value();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            reset_value();
            HienThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con= new SqlConnection(strcon);
            string sql = "select MaKhachHang, TenKhachHang, DiaChi, DienThoai from KhachHang where TenKhachHang like N'%" + txtTimKiem.Text + "%'";
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvKhachHang.DataSource = dt;
            btnTimKiem.Enabled = false;
            btnHuyTimKiem.Enabled = true;
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            HienThi();
        }
    }
}
