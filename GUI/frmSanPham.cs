using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace GUI
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

		//string strcon = @"Data Source=TUAN;Initial Catalog=QuanLyBanHangTapHoa;Integrated Security=True";
		string strcon = Properties.Settings.Default.chuoiketnoi;
		private void Hienthi()
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btnHuyTimKiem.Enabled = false;
            btTimKiem.Enabled = true;
			SqlConnection con = new SqlConnection(strcon);
			con.Open();
            SqlCommand com = new SqlCommand("select MaSanPham, TenSanPham, DonViTinh, DonGiaBan from SanPham", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
			con.Close();
            dgvSanPham.DataSource = dt;

        }

        private void reset_value()
        {
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtDonViTinh.Clear();
            txtDonGia.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            sosMaSanPham.Enabled = false;
            sosTenSanPham.Enabled = false;
            sosDonViTinh.Enabled = false;
            sosDonGia.Enabled = false;

            if (txtMaSanPham.Text == "")
            {
                sosMaSanPham.Enabled = true;
            }
            if (txtTenSanPham.Text == "")
            {
                sosTenSanPham.Enabled = true;
            }
            if (txtDonViTinh.Text == "")
            {
                sosDonViTinh.Enabled = true;
            }
            if (txtDonGia.Text == "")
            {
                sosDonGia.Enabled = true;
            }

            if (sosTenSanPham.Enabled == false && sosDonViTinh.Enabled == false && sosDonGia.Enabled == false)
            {
                try
                {
					SqlConnection con = new SqlConnection(strcon);

                    string sql = "insert into SanPham values ('" + txtMaSanPham.Text + "', N'" + txtTenSanPham.Text + "', 10, N'" + txtDonViTinh.Text + "' ,'" + txtDonGia.Text + "')";
                    SqlCommand com = new SqlCommand(sql, con);
					con.Open();
					com.ExecuteNonQuery();
					con.Close();
                    Hienthi();
                    reset_value();
                }
                catch
                {
                    txtMaSanPham.Text = "";
                    MessageBox.Show("Trùng mã sản phẩm!");
                }
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvSanPham.CurrentCell.RowIndex;
            txtMaSanPham.Text = dgvSanPham.Rows[t].Cells[0].Value.ToString();
            txtTenSanPham.Text = dgvSanPham.Rows[t].Cells[1].Value.ToString();
            txtDonViTinh.Text = dgvSanPham.Rows[t].Cells[2].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[t].Cells[3].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(strcon);
			con.Open();
            string sql = "update SanPham set TenSanPham = N'" + txtTenSanPham.Text + "', DonViTinh = N'" + txtDonViTinh.Text + "' , DonGiaBan = '" + txtDonGia.Text + "' where MaSanPham = '" + txtMaSanPham.Text + "' ";
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
			con.Close();
            Hienthi();
            reset_value();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(strcon);
			btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
			con.Open();
            string sql = "delete SanPham where MaSanPham= '" + txtMaSanPham.Text + "'";
            string sql1 = "delete ChiTietHoaDon where MaSanPham= '" + txtMaSanPham.Text + "'";
            SqlCommand com = new SqlCommand(sql1, con);
            com.ExecuteNonQuery();
            com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
			con.Close();
            Hienthi();
            reset_value();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(strcon);
			con.Open();
            string sql = "select MaSanPham, TenSanPham, DonViTinh, DonGiaBan from SanPham where MaSanPham like N'%" + txtTimKiem.Text + "%'";
            SqlCommand com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt); con.Close();
            dgvSanPham.DataSource = dt;
            btTimKiem.Enabled = false;
            btnHuyTimKiem.Enabled = true;

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
            txtMaSanPham.Text = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSanPham.Text = dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDonViTinh.Text = dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            Hienthi();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            reset_value();
            Hienthi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
