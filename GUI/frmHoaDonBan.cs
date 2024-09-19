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
using DAO;

namespace GUI
{
    public partial class frmHoaDonBan : Form
    {
        private string maHD = "", maNV, tenNV, maKH,tenKH, dcKH, sdtKH;
        public void setTT(string mHD, string maNV, string tenNV, string maKH, string tenKH, string dcKH, string sdtKH, string tongTien)
        {
            this.maHD = mHD;
            txtMaHDBan.Text = this.maHD;
            cboMaNhanVien.DropDownStyle = ComboBoxStyle.DropDown;
            cboMaNhanVien.DropDownStyle = ComboBoxStyle.DropDown;
            cboMaNhanVien.Text = maNV;
            txtTenNhanVien.Text = tenNV;
            txtMaKH.Text = maKH;
            txtTenKhach.Text = tenKH;
            txtDiaChi.Text = dcKH;
            txtSDT.Text = sdtKH;
            txtTongTien.Text = tongTien;
            cthd.getListSP(this.maHD, ref dgvHDBanHang);
        }
        public frmHoaDonBan()
        {
            InitializeComponent();
        }
        private CTHD cthd = new CTHD();
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            if(this.maHD == "")
            {
                txtMaHDBan.Text = cthd.create_MHD();
                btnLuuHoaDon.Visible = false;
                cthd.setMaSP(ref cboMaSanPham);
            }
            else
            {
                btnXoaHD.Visible = true;
                btnThemHoaDon.Visible = false;
                btnHuyHoaDon.Visible = false;
                btnThemSP.Visible = false;
                btnDong.Visible = false;
            }
            cthd.setMaNV(ref cboMaNhanVien);
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cboMaNhanVien.Items[cboMaNhanVien.SelectedIndex].ToString();
            cthd.getTenNV(ref txtTenNhanVien,maNV);
        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {
            if(this.maHD == "")
            {
                cthd.searchTenKH(ref txtMaKH, ref txtTenKhach, ref txtSDT, ref txtDiaChi);
            }
        }

        private void cboMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnThemSP.Visible = true;
            string MaSP = cboMaSanPham.Items[cboMaSanPham.SelectedIndex].ToString();
            cthd.getIFSP(MaSP,ref txtTenSanPham, ref txtDonGiaBan);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            cthd.updateGia(cboMaSanPham, txtDonGiaBan,ref txtSoLuong, ref txtThanhTien,ref label1);
        }


        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if(txtTenSanPham.ReadOnly == true)
            {
                txtTenSanPham.ReadOnly = false;
            }
            if(txtThanhTien.Text == "" || txtThanhTien.Text == "0")
            {
                MessageBox.Show("CHưa có thông tin sản phẩm");
            }
            else
            {
                cthd.themSP(ref dgvHDBanHang, ref cboMaSanPham, ref txtTenSanPham, ref txtSoLuong, ref txtDonGiaBan, ref txtThanhTien);
                reset_value();
                cthd.upDateTien(dgvHDBanHang, ref txtTongTien);
            }
        }

        private void txtDonGiaBan_TextChanged(object sender, EventArgs e)
        {
            cthd.updateGia(cboMaSanPham, txtDonGiaBan, ref txtSoLuong, ref txtThanhTien, ref label1);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Bạn có muốn xóa hóa đơn này??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                SQLQuanLyHoaDon qlhd = new SQLQuanLyHoaDon();
                qlhd.xoaHD(txtMaHDBan);
                this.Hide();
                var form2 = new frmQuanLyHoaDon();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            lbTenKH.Visible = false;
            lbDcKH.Visible = false;
            lbDtKH.Visible = false;
            lbMaNV.Visible = false;
            if (txtTenKhach.Text == "")
            {
                lbTenKH.Visible = true;
            }
            if (txtDiaChi.Text == "")
            {
                lbDcKH.Visible = true;
            }
            if (txtSDT.Text == "")
            {
                lbDtKH.Visible = true;
            }
            if (cboMaNhanVien.Text == "")
            {
                lbMaNV.Visible = true;
            }
            if (lbTenKH.Visible == false && lbDcKH.Visible == false && lbDtKH.Visible == false && lbMaNV.Visible == false)
            {
                cthd.suaHD(this.maHD, cboMaNhanVien.Text, txtMaKH.Text, txtTenKhach.Text, txtDiaChi.Text, txtSDT.Text, txtTongTien.Text);
                this.Hide();
                var form2 = new frmQuanLyHoaDon();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            dtpNgayBan.ResetText();
            cboMaNhanVien.Items.Clear();
            txtTenNhanVien.Clear();
            txtTenKhach.Clear();
            txtMaKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            dgvHDBanHang.Rows.Clear();
            reset_value();
        }

        private void suaSanPham_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text != "")
            {
                if(this.maHD != "")
                {
                    cthd.updateSPSQL(this.maHD, cboMaSanPham.Text, txtSoLuong.Text, txtThanhTien.Text);
                }
                btnXoaSP.Visible = false;
                suaSanPham.Visible = false;
                cthd.updateSP(ref dgvHDBanHang, ref cboMaSanPham, ref txtTenSanPham, ref txtSoLuong, ref txtDonGiaBan, ref txtThanhTien);
                reset_value();
                cthd.upDateTien(dgvHDBanHang, ref txtTongTien);
            }
            else
            {
                MessageBox.Show("Nhập số lượng");
            }
        }

        private void dgvHDBanHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHDBanHang.CurrentCell.RowIndex != dgvHDBanHang.RowCount - 1)
            {
                txtTenSanPham.ReadOnly = true;
                btnXoaSP.Visible = true;
                suaSanPham.Visible = true;
                cthd.showSP(dgvHDBanHang.Rows[dgvHDBanHang.CurrentCell.RowIndex], ref cboMaSanPham, ref txtTenSanPham, ref txtSoLuong, ref txtDonGiaBan, ref txtThanhTien);
            }
        }

        private void reset_value()
        {
            cboMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtSoLuong.Text = "0";
            txtDonGiaBan.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if(this.maHD != "")
            {
                if(dgvHDBanHang.RowCount <= 2)
                {
                    var a = MessageBox.Show("Bạn có muốn xóa hóa đơn này??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(a == DialogResult.Yes)
                    {
                        SQLQuanLyHoaDon qlhd = new SQLQuanLyHoaDon();
                        qlhd.xoaHD(txtMaHDBan);
                        this.Hide();
                        var form2 = new frmQuanLyHoaDon();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                    
                }
                else
                {
                    cthd.xoaSPSQL(this.maHD, cboMaSanPham.Text);
                }
            }
            suaSanPham.Visible = false;
            btnXoaSP.Visible = false;
            cthd.xoaSP(ref dgvHDBanHang, cboMaSanPham);
            reset_value();
            cthd.upDateTien(dgvHDBanHang, ref txtTongTien);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Bạn có muốn thoát chương trình.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            string listSP = "";
            lbTenKH.Visible = false;
            lbDcKH.Visible =false;
            lbDtKH.Visible =false;
            lbMaNV.Visible = false;
            if(txtTenKhach.Text == "")
            {
                lbTenKH.Visible = true;
            }
            if(txtDiaChi.Text == "")
            {
                lbDcKH.Visible = true;
            }
            if(txtSDT.Text == "")
            {
                lbDtKH.Visible = true;
            }
            if(cboMaNhanVien.Text == "")
            {
                lbMaNV.Visible = true;
            }
            if(dgvHDBanHang.RowCount == 1)
            {
                MessageBox.Show("Chưa có sản phẩm");
            }
            else
            {
                for(int i = 0; i < dgvHDBanHang.Rows.Count - 1; i++)
                {
                    DataGridViewRow dr = dgvHDBanHang.Rows[i];
                    listSP += "('" + txtMaHDBan.Text + "','" + dr.Cells[0].Value.ToString() + "'," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + ")";
                    if(i < dgvHDBanHang.Rows.Count - 2)
                    {
                        listSP += ",";
                    }
                }
            }
            if(lbTenKH.Visible == false && lbDcKH.Visible == false && lbDtKH.Visible == false && lbMaNV.Visible == false && listSP != "")
            {
                cthd.themHD(txtMaHDBan, cboMaNhanVien, dtpNgayBan, txtMaKH, txtTenKhach,txtDiaChi,txtSDT, txtTongTien, listSP);
                this.Close();
            }
        }
    }
}
