using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class SQLChiTietHoaDon
    {
		//private string stringConnect = @"Data Source=TUAN;Initial Catalog=QuanLyBanHangTapHoa;Integrated Security=True";
		private string stringConnect = Properties.Settings.Default.chuoiketnoi;

		public string getListMaNV()
        {
            string query = "SELECT MaNhanVien from NhanVien";
            string listMNV = "";
            using(SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query,con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listMNV += dr["MaNhanVien"].ToString() + " ";
                }
                con.Close();
            }
            return listMNV;
        }

        public string getTenNV(string maNV)
        {
            string query = "SELECT TenNhanVien from NhanVien where MaNhanVien = '"+maNV+"'";
            string tenNV = "";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tenNV += dr["TenNhanVien"].ToString();
                }
                con.Close();
            }
            return tenNV;
        }

        public string SearchTenKH(string tenKH)
        {
            string query = "SELECT * from KhachHang where TenKhachHang = N'" + tenKH + "'";
            string TenKH = "";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TenKH += dr["MaKhachHang"].ToString() + ";";
                        TenKH += dr["TenKhachHang"].ToString() + ";";
                        TenKH += dr["DienThoai"].ToString() + ";";
                        TenKH += dr["DiaChi"].ToString() + ";";
                    }
                }
                else
                {
                    TenKH = "0";
                }
                con.Close();
            }
            return TenKH;
        }

        public string getListMaSP()
        {
            string query = "SELECT MaSanPham from SanPham";
            string result = "";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand (query, con);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    result += sqlDataReader["MaSanPham"].ToString() + " ";
                }
                con.Close ();
            }
            return result;
        }

        public string getIFSP(string MaSP)
        {
            string result = "";
            string query = "SELECT * FROM SanPham WHERE MaSanPham = '" + MaSP + "'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open ();
                SqlCommand CMD = new SqlCommand (query, con);
                SqlDataReader rd = CMD.ExecuteReader ();
                while (rd.Read())
                {
                    result += rd["TenSanPham"].ToString() + ";";
                    result += rd["DonGiaBan"].ToString() + ";";
                }
                con.Close () ;
            }
            return result;
        }

        public void themHD(string MaHD, string MaNV, string ngayBan, string MaKH, string tenKH, string dcKH, string sdtKH, string tongTien, string listSP)
        {
            string query = "insert into HoaDon values\r\n('"+MaHD+"','"+MaNV+"','"+ngayBan+"','"+MaKH+"',"+tongTien+");\r\ninsert into ChiTietHoaDon values " + listSP;
            string searchKH = "SELECT * FROM KhachHang WHERE MaKhachHang = '" + MaKH + "'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand CMD = new SqlCommand (searchKH, con);
                SqlDataReader r = CMD.ExecuteReader ();
                if (r.HasRows == false)
                {
                    themKH(MaKH, tenKH, dcKH, sdtKH);
                }
                con.Close ();
                con.Open ();
                CMD = new SqlCommand(query, con);
                CMD.ExecuteNonQuery();
                con.Close();

            }
        }

        private void themKH(string maKH, string tenKH, string dcKH, string sdtKH)
        {
            string query = "INSERT INTO KhachHang VALUES ('" + maKH + "',N'" + tenKH + "',N'" + dcKH + "','" + sdtKH + "')";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand CMD = new SqlCommand(query, con);
                CMD.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable getListSP(string maHD)
        {
            DataTable dt = new DataTable();
            string query = "select ChiTietHoaDon.MaSanPham,TenSanPham,ChiTietHoaDon.SoLuong,DonGia,ThanhTien from ChiTietHoaDon, SanPham\r\nwhere TenSanPham in (SELECT TenSanPham FROM SanPham WHERE ChiTietHoaDon.MaSanPham = SanPham.MaSanPham) and MaHoaDon = '"+maHD+"'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                con.Close() ;
            }
            return dt;
        }

        public void updateSP(string maHD, string maSP, string soLuong, string thanhTien)
        {
            string query = "UPDATE ChiTietHoaDon SET  SoLuong = " + soLuong + ", ThanhTien = " + thanhTien + " WHERE MaHoaDon = '" + maHD + "' AND MaSanPham = '" + maSP + "'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void xoaSP(string maHD, string maSP)
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE MaHoaDon = '" + maHD + "' AND MaSanPham = '" + maSP + "'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void suaHD (string maHD, string maNV, string maKH, string tenKH, string dcKH, string sdtKH, string tongTien)
        {
            this.updateKH(maKH, tenKH, dcKH, sdtKH);
            string query = "UPDATE HoaDon SET  MaNhanVien = '" + maNV + "', MaKhachHang = '" + maKH + "', TongTien = '" + tongTien + "' WHERE MaHoaDon = '" + maHD + "'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void updateKH(string maKH, string tenKH, string dcKH, string sdtKH)
        {
            string query = "UPDATE KhachHang SET  TenKhachHang = N'" + tenKH + "', DiaChi = N'" + dcKH + "', DienThoai = '"+sdtKH+"' WHERE MaKhachHang = '" + maKH + "'";
            using (SqlConnection con = new SqlConnection(this.stringConnect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
