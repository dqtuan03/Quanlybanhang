using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAO
{
    public class SQLQuanLyHoaDon
    {
		//private string stringConnect = @"Data Source=TUAN;Initial Catalog=QuanLyBanHangTapHoa;Integrated Security=True";
		private string stringConnect = Properties.Settings.Default.chuoiketnoi;
		public void load_data(ref ListView listView1, string txtSearchTenNV, string txtSearchTenKH, DateTimePicker dtTo, DateTimePicker dtFrom)
        {
            string query = "select MaHoaDon,TenKhachHang,TenNhanVien,NgayBan,TongTien from HoaDon, KhachHang, NhanVien \r\nwhere TenNhanVien in (select TenNhanVien from NhanVien where HoaDon.MaNhanVien = NhanVien.MaNhanVien) and TenKhachHang in (select TenKhachHang from KhachHang where HoaDon.MaKhachHang = KhachHang.MaKhachHang) and TenNhanVien like N'%" + txtSearchTenNV + "%'\r\nand TenKhachHang like N'%" + txtSearchTenKH + "%' and NgayBan <= '" + dtTo.Text + "' and NgayBan >= '" + dtFrom.Text + "' order by HoaDon.MaHoaDon";
            using (SqlConnection con = new SqlConnection(stringConnect))
            {
                listView1.Items.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MaHoaDon"].ToString());
                    item.SubItems.Add(reader["TenKhachHang"].ToString());
                    item.SubItems.Add(reader["TenNhanVien"].ToString());
                    string date = format_Date(reader["NgayBan"].ToString().Split(' ')[0]);
                    item.SubItems.Add(date);
                    item.SubItems.Add(reader["TongTien"].ToString());
                    listView1.Items.Add(item);
                }
                con.Close();
            }
        }

        public void getIfKH(string tenKH, ref TextBox txtMaKH, ref TextBox txtTenKH, ref TextBox txtDcKH, ref TextBox txtSdtKH)
        {
            string query = "SELECT * FROM KhachHang WHERE TenKhachHang = N'" + tenKH + "'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtMaKH.Text = reader["MaKhachHang"].ToString();
                    txtTenKH.Text = reader["TenKhachHang"].ToString();
                    txtDcKH.Text = reader["DiaChi"].ToString();
                    txtSdtKH.Text = reader["DienThoai"].ToString();
                }
                con.Close();
            }
        }

        public void getIfNV(string tenNV, ref TextBox txtMaNV, ref TextBox txtTenNV, ref TextBox txtDcNV, ref TextBox txtSdtNV)
        {
            string query = "SELECT * FROM NhanVien WHERE TenNhanVien = N'" + tenNV + "'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtMaNV.Text = reader["MaNhanVien"].ToString();
                    txtTenNV.Text = reader["TenNhanVien"].ToString();
                    txtDcNV.Text = reader["DiaChi"].ToString();
                    txtSdtNV.Text = reader["DienThoai"].ToString();
                }
                con.Close();
            }
        }

        public void getSP(string maHD, ref ListView listSP)
        {
            listSP.Items.Clear();
            string query = "select TenSanPham, ChiTietHoaDon.SoLuong, ThanhTien from SanPham,ChiTietHoaDon\r\nwhere TenSanPham in (Select TenSanPham from SanPham where ChiTietHoaDon.MaSanPham = SanPham.MaSanPham) and MaHoaDon = '" + maHD + "' order by SoLuong";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["TenSanPham"].ToString());
                    item.SubItems.Add(reader["SoLuong"].ToString());
                    item.SubItems.Add(reader["ThanhTien"].ToString());
                    listSP.Items.Add(item);
                }
                con.Close();
            }
        }

        public void xoaHD(TextBox txtXoa)
        {
            string query = "delete from ChiTietHoaDon where MaHoaDon = '" + txtXoa.Text + "';delete from HoaDon where MaHoaDon = '" + txtXoa.Text + "'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private string format_Date(string date)
        {
            string dt = date;
            string day = date.Split('/')[1];
            string month = date.Split('/')[0];
            string year = date.Split('/')[2];
            dt = "";
            dt = day + "/" + month + "/" + year;
            return dt;
        }

    }
}
