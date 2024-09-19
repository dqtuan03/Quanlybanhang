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

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
		//SqlConnection conn = new SqlConnection(@"Data Source=TUAN;Initial Catalog=QuanLyBanHangTapHoa;Integrated Security=True");
		SqlConnection conn = new SqlConnection(Properties.Settings.Default.chuoiketnoi);

		private void button2_Click(object sender, EventArgs e)
        {
            themNV.Enabled = true;
            suaNV.Enabled = false;
            xoaNV.Enabled = false;
            string MHD = "";
            string[] listMHD;
            string sql = "delete NhanVien where MaNhanVien='" + txtMNV.Text + "'";
            string getMHD = "SELECT MaHoaDon from HoaDon where MaNhanVien = '"+txtMNV.Text+"'";
            string delNVfromHD = "delete HoaDon where MaNhanVien='" + txtMNV.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(getMHD, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MHD += rd.GetString(0) + " ";
            }
            conn.Close();
            listMHD = MHD.Split(' ');
            foreach (string s in listMHD)
            {
                    conn.Open();
                    string sqlDel = "DELETE FROM ChiTietHoaDon WHERE MaHoaDon = '" + s + "'";
                    SqlCommand cmdd = new SqlCommand(sqlDel, conn);
                    cmdd.ExecuteNonQuery();
                    conn.Close();
            }
            conn.Open();
            cmd = new SqlCommand(delNVfromHD,conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMNV.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;

            int newDay = 01;
            int newMonth = 01;
            int newYear = 2000;

            DateTime newDate = new DateTime(newYear, newMonth, newDay);

            dtpNgaysinh.Value = newDate;

            themNV.Enabled = true;
            suaNV.Enabled = false;
            xoaNV.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string gt;
            if (rdoNam.Checked == true)
                gt = "Nam";
            else gt = "Nữ";
            string sql = "update NhanVien set MaNhanVien ='" + txtMNV.Text + "',TenNhanVien =N'" + txtTen.Text + "',GioiTinh =N'" + gt + "',DiaChi =N'" + txtDiaChi.Text + "',DienThoai ='" + txtSDT.Text + "',NgaySinh ='" + dtpNgaysinh.Value.ToString("yyyy-MM-dd") + "' where MaNhanVien = '" + txtMNV.Text + "'";
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
            conn.Close();
            themNV.Enabled = true;
            suaNV.Enabled = false;
            xoaNV.Enabled = false;

            txtMNV.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;

            int newDay = 01;
            int newMonth = 01;
            int newYear = 2000;

            DateTime newDate = new DateTime(newYear, newMonth, newDay);

            dtpNgaysinh.Value = newDate;

            Hienthi();
        }

        private void Hienthi()
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from NhanVien", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            conn.Close();
            dgvnhanvien.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthi();
            suaNV.Enabled = false;
            xoaNV.Enabled = false;
        }

        private void btHuyTim_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            Hienthi();
        }


        private void timKiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select * from NhanVien where MaNhanVien ='" + txtTimKiem.Text + "'";
            SqlCommand com = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            conn.Close();
            dgvnhanvien.DataSource = dt;
        }


        private void themNV_Click(object sender, EventArgs e)
        {



            dosMa.Enabled = false;
            dosTen.Enabled = false;
            dosDiaChi.Enabled = false;
            dosDienThoai.Enabled = false;

            if (txtMNV.Text == "")
            {
                dosMa.Enabled = true;
            }
            if (txtTen.Text == "")
            {
                dosTen.Enabled = true;
            }
            if (txtDiaChi.Text == "")
            {
                dosDiaChi.Enabled = true;
            }
            if (txtSDT.Text == "")
            {
                dosDienThoai.Enabled = true;
            }

            if (dosDienThoai.Enabled == false && dosDiaChi.Enabled == false && dosTen.Enabled == false && dosDienThoai.Enabled == false)
            {
                try
                {
                    conn.Open();
                    string gt;
                    if (rdoNam.Checked == true)
                        gt = "Nam";
                    else gt = "Nữ";
                    string sqlInsert = "insert into NhanVien values ('" + txtMNV.Text + "',N'" + txtTen.Text + "',N'" + gt + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + dtpNgaysinh.Value.ToString("yyyy-MM-dd") + "')";
                    SqlCommand com = new SqlCommand(sqlInsert, conn);
                    com.ExecuteNonQuery();
                    conn.Close();
                    Hienthi();
                }
                catch
                {
                    txtMNV.Text = "";
                    MessageBox.Show("Trung Ma Nhan Vien");
                }
            }

        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            suaNV.Enabled = true;
            xoaNV.Enabled = true;
            themNV.Enabled = false;
            int t = dgvnhanvien.CurrentCell.RowIndex;
            txtMNV.Text = dgvnhanvien.Rows[t].Cells[0].Value.ToString();
            txtTen.Text = dgvnhanvien.Rows[t].Cells[1].Value.ToString();
            if (this.dgvnhanvien.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            txtDiaChi.Text = dgvnhanvien.Rows[t].Cells[3].Value.ToString();
            txtSDT.Text = dgvnhanvien.Rows[t].Cells[4].Value.ToString();
            dtpNgaysinh.Text = dgvnhanvien.Rows[t].Cells[5].Value.ToString();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Bạn có muốn thoát chương trình.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
