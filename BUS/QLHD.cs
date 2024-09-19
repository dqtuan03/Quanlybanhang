using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
namespace BUS
{
    public class QLHD
    {
        private SQLQuanLyHoaDon sql = new SQLQuanLyHoaDon();
        public void load_data(ref ListView listView1, string txtSearchTenNV , string txtSearchTenKH, DateTimePicker dtTo, DateTimePicker dtFrom)
        {
            sql.load_data(ref listView1, txtSearchTenNV, txtSearchTenKH, dtTo, dtFrom);
        }

        public void getIfKH(string tenKH, ref TextBox txtMaKH, ref TextBox txtTenKH, ref TextBox txtDcKH, ref TextBox txtSdtKH)
        {
            sql.getIfKH(tenKH, ref txtMaKH, ref txtTenKH, ref txtDcKH, ref txtSdtKH);
        }

        public void getIfNV(string tenNV, ref TextBox txtMaNV, ref TextBox txtTenNV, ref TextBox txtDcNV, ref TextBox txtSdtNV)
        {
            sql.getIfNV(tenNV, ref txtMaNV, ref txtTenNV, ref txtDcNV, ref txtSdtNV);
        }

        public void getSP(string maHD, ref ListView listSP)
        {
            sql.getSP(maHD, ref listSP);
        }

        public void xoaHD(ref TextBox txtXoa, ref TextBox txtMaKH, ref TextBox txtTenKH, ref TextBox txtDcKH, ref TextBox txtSdtKH, ref TextBox txtMaNV, ref TextBox txtTenNV, ref TextBox txtDcNV, ref TextBox txtSdtNV, ref TextBox txtTongTien, ref ListView listSP)
        {
            sql.xoaHD(txtXoa);
            txtXoa.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDcKH.Text = "";
            txtSdtKH.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDcNV.Text = "";
            txtSdtNV.Text = "";
            txtTongTien.Text = "";
            listSP.Items.Clear();
        }

        public void ThemHoaDon()
        {

        }
    }
}
