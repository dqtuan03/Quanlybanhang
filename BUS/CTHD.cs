using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace BUS
{

    public class CTHD
    {
        private SQLChiTietHoaDon sqlcthd = new SQLChiTietHoaDon();
        public string create_MHD()
        {
            string mhd = "";
            Random rd = new Random();
            mhd += "HD" + rd.Next(9999);
            return mhd;
        }

        public void setMaNV(ref ComboBox cb)
        {
            string listNV = sqlcthd.getListMaNV();
            string[] maNV = listNV.Split(' ');
            foreach (string s in maNV)
            {
                if(s != "")
                {
                    cb.Items.Add(s);
                }
            }
        }

        public void getTenNV(ref TextBox txtTenNV,string maNV)
        {
            txtTenNV.Text = sqlcthd.getTenNV(maNV);
        }

        public void searchTenKH(ref TextBox txtMaKH, ref TextBox txtTenKH, ref TextBox sdt, ref TextBox diachi)
        {
            string result = sqlcthd.SearchTenKH(txtTenKH.Text);
            if(result == "0")
            {
                Random rd = new Random();
                txtMaKH.Text = "KH" + rd.Next(9999).ToString();
                sdt.Text = "";
                diachi.Text = "";
            }
            else
            {
                string[] txt = result.Split(';');
                txtMaKH.Text = txt[0];
                sdt.Text = txt[2];
                diachi.Text = txt[3];
            }
        }

        public void setMaSP(ref ComboBox cbMaSP)
        {
            string[] text = sqlcthd.getListMaSP().Split(' ');
            foreach(string s in text)
            {
                if(s != "")
                {
                    cbMaSP.Items.Add(s);
                }
            }
        }

        public void getIFSP(string txtMaSP,ref TextBox txtTenSP, ref TextBox txtDonGia)
        {
            string[] txt = sqlcthd.getIFSP(txtMaSP).Split(';');
            txtTenSP.Text = txt[0];
            txtDonGia.Text = txt[1];
        }

        public void updateGia(ComboBox ComboBox, TextBox txtDonGia,ref TextBox txtSoLuong, ref TextBox txtThanhTien, ref Label lb)
        {
            lb.Visible = false;
            if (ComboBox.Text == "")
            {
                txtSoLuong.Text = 0.ToString();
                txtThanhTien.Text = "0";
            }
            else
            {
                int soluong = 0;
                try
                {
                    soluong = Convert.ToInt32(txtSoLuong.Text);
                }
                catch
                {
                    txtSoLuong.Text = "";
                    lb.Visible = true;
                    soluong = 0;
                }
                float dongia = Convert.ToSingle(txtDonGia.Text);
                float thanhtien = (float) soluong * dongia;
                txtThanhTien.Text = thanhtien.ToString();
            }
        }

        public void themSP(ref DataGridView dgvListSP,ref ComboBox ComboBox, ref TextBox txtTenSP, ref TextBox txtSoLuong, ref TextBox txtDonGia,ref TextBox txtThanhTien)
        {
            if(dgvListSP.RowCount == 1)
            {
                dgvListSP.Rows.Add(ComboBox.Text, txtTenSP.Text, txtSoLuong.Text, txtDonGia.Text, txtThanhTien.Text);
            }
            else
            {
                int check = 0;
                for (int i = 0; i < dgvListSP.RowCount - 1; i++)
                {
                    DataGridViewRow s = dgvListSP.Rows[i];
                    if (ComboBox.Text == s.Cells[0].Value.ToString())
                    {
                        check++;
                    }
                    
                }
                if(check > 0)
                {
                    MessageBox.Show("Đã có sản phẩm");
                }
                else
                {
                        dgvListSP.Rows.Add(ComboBox.Text, txtTenSP.Text, txtSoLuong.Text, txtDonGia.Text, txtThanhTien.Text);
                }
            }
        }

        public void showSP(DataGridViewRow dgv, ref ComboBox ComboBox, ref TextBox txtTenSP, ref TextBox txtSoLuong, ref TextBox txtDonGia, ref TextBox txtThanhTien)
        {
            ComboBox.Text = dgv.Cells[0].Value.ToString();
            txtTenSP.Text = dgv.Cells[1].Value.ToString();
            txtSoLuong.Text = dgv.Cells[2].Value.ToString();
            txtDonGia.Text = dgv.Cells[3].Value.ToString();
            txtThanhTien.Text = dgv.Cells[4].Value.ToString();
        }

        public void updateSP(ref DataGridView dgv, ref ComboBox ComboBox, ref TextBox txtTenSP, ref TextBox txtSoLuong, ref TextBox txtDonGia, ref TextBox txtThanhTien)
        {
            if(txtSoLuong.Text != "")
            {
                int index = 0;
                for (int i = 0; i < dgv.RowCount - 1; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value.ToString() == ComboBox.Text)
                    {
                        index = i;
                    }
                }
                dgv.Rows[index].Cells[2].Value = txtSoLuong.Text;
                dgv.Rows[index].Cells[4].Value = txtThanhTien.Text;
            }
            else
            {
                MessageBox.Show("Nhập số lượng");
            }
        }

        public void updateSPSQL(string maHD, string maSP, string soLuong, string thanhTien)
        {
            sqlcthd.updateSP(maHD, maSP, soLuong, thanhTien);
        }

        public void xoaSPSQL(string maHD, string maSP)
        {
            sqlcthd.xoaSP(maHD, maSP);
        }

        public void suaHD(string maHD, string maNV, string maKH, string tenKH, string dcKH, string sdtKH, string tongTien)
        {
            sqlcthd.suaHD(maHD,maNV, maKH, tenKH, dcKH, sdtKH, tongTien);
        }

        public void xoaSP(ref DataGridView dgv, ComboBox combo)
        {
            int index = 0;
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells[0].Value.ToString() == combo.Text)
                {
                    index = i;
                }
            }
            dgv.Rows.RemoveAt(index);
        }

        public void upDateTien(DataGridView dgv, ref TextBox txtTien)
        {
            float count = 0;
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                count += Convert.ToSingle(dgv.Rows[i].Cells[4].Value.ToString());
            }
            txtTien.Text = count.ToString();
        }

        public void getListSP(string maHD, ref DataGridView dgv)
        {
            dgv.DataSource = sqlcthd.getListSP(maHD);
        }

        public void themHD(TextBox maHD, ComboBox MaNV, DateTimePicker ngayBan, TextBox maKH, TextBox tenKH, TextBox dcKH, TextBox sdtKH, TextBox tongTien, string listSP)
        {
            sqlcthd.themHD(maHD.Text, MaNV.Text, ngayBan.Value.ToString("yyyy-MM-dd"), maKH.Text, tenKH.Text, dcKH.Text, sdtKH.Text, tongTien.Text, listSP);
        }
    }
}
