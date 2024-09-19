using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;

namespace GUI
{
    public partial class frmMain01 : Form
    {
        public frmMain01()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ConnectionSQL.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            ConnectionSQL.Disconnect();
            Application.Exit();
        }
    }
}
