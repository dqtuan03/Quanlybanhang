using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class frmQuanLyHoaDon : Form
    {
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        public QLHD qlhd = new QLHD();
        private DataTable dt = new DataTable();

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            qlhd.getIfNV(listView1.Items[e.ItemIndex].SubItems[2].Text, ref txtMaNV, ref txtTenNV, ref txtDcNV, ref txtSdtNV);
            qlhd.getIfKH(listView1.Items[e.ItemIndex].SubItems[1].Text, ref txtMaKH, ref txtTenKH, ref txtDcKH, ref txtSdtKH);
            qlhd.getSP(listView1.Items[e.ItemIndex].SubItems[0].Text, ref listSP);
            txtMaHD.Text = listView1.Items[e.ItemIndex].SubItems[0].Text;
            txtTongTien.Text = listView1.Items[e.ItemIndex].SubItems[4].Text;

        }

        private void txtSearchTenNV_TextChanged(object sender, EventArgs e)
        {
            qlhd.load_data(ref listView1, txtSearchTenNV.Text, txtSearchTenKH.Text, dtTo, dtFrom);
        }

        private void txtSearchTenKH_TextChanged(object sender, EventArgs e)
        {
            qlhd.load_data(ref listView1, txtSearchTenNV.Text, txtSearchTenKH.Text, dtTo, dtFrom);
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            qlhd.load_data(ref listView1, txtSearchTenNV.Text, txtSearchTenKH.Text, dtTo, dtFrom);
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            qlhd.load_data(ref listView1, txtSearchTenNV.Text, txtSearchTenKH.Text, dtTo, dtFrom);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var re = MessageBox.Show("Bạn có muốn xóa hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                qlhd.xoaHD(ref txtMaHD, ref txtMaKH, ref txtTenKH, ref txtDcKH, ref txtSdtKH, ref txtMaNV, ref txtTenNV, ref txtDcNV, ref txtSdtNV, ref txtTongTien, ref listSP);
                qlhd.load_data(ref listView1, txtSearchTenNV.Text, txtSearchTenKH.Text, dtTo, dtFrom);
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frmHoaDonBan();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            qlhd.load_data(ref listView1, "", "", dtTo, dtFrom);
        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text != "")
            {
                this.Hide();
                var frm = new frmHoaDonBan();
                frm.setTT(txtMaHD.Text, txtMaNV.Text, txtTenNV.Text, txtMaKH.Text, txtTenKH.Text, txtDcKH.Text, txtSdtKH.Text, txtTongTien.Text);
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }
        }
    }
}
