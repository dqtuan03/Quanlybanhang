using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelHoaDonSubmenu.Visible = false;
            panelSanPhamSubMenu.Visible = false;
            panelNhanVienSubMenu.Visible = false;
            panelKhachHangSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelHoaDonSubmenu.Visible == true)
            {
                panelHoaDonSubmenu.Visible = false;
            }
            if (panelSanPhamSubMenu.Visible == true)
            {
                panelSanPhamSubMenu.Visible = false;
            }
            if (panelNhanVienSubMenu.Visible == true)
            {
                panelNhanVienSubMenu.Visible = false;
            }
            if (panelKhachHangSubMenu.Visible == true)
            {
                panelKhachHangSubMenu.Visible = false;
            }    
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false) 
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMenuHoaDon_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHoaDonSubmenu);
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyHoaDon());
            hideSubMenu();
        }

        private void btnChildSubThemHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDonBan());
            hideSubMenu();
        }

        private void btnMenuSanPham_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSanPhamSubMenu);
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
            hideSubMenu();
        }

        private void btnMenuNhanVien_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelNhanVienSubMenu);
        }

        private void btnChildSubQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
            hideSubMenu();
        }

        private void mnuQuanLySanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
        }

        private void mnuQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyHoaDon());
        }

        private void mnuThemHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDonBan());

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menutkhoadon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyHoaDon());

        }

        private void menutkSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());

        }

        private void menuQuanlynhanvien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());

        }

        private void mnuThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private Color originalColor;
        private void btnMenuHoaDon_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            originalColor = button.BackColor;
            button.BackColor = Color.DarkBlue;
        }

        private void btnMenuHoaDon_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = originalColor;
        }

        private void btnMenuSanPham_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            originalColor = button.BackColor;
            button.BackColor = Color.DarkBlue;
        }

        private void btnMenuSanPham_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = originalColor;
        }

        private void btnMenuNhanVien_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            originalColor = button.BackColor;
            button.BackColor = Color.DarkBlue;
        }

        private void btnMenuNhanVien_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = originalColor;
        }

        private void btnMenuKhachHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKhachHangSubMenu);
        }

        private void btnMenuKhachHang_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            originalColor = button.BackColor;
            button.BackColor = Color.DarkBlue;
        }

        private void btnMenuKhachHang_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = originalColor;
        }

        private void btnChildSubQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
            hideSubMenu();
        }
    }
}
