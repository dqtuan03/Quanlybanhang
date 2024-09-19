namespace GUI
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.xoaNV = new System.Windows.Forms.Button();
            this.suaNV = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.themNV = new System.Windows.Forms.Button();
            this.btHuyTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timKiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dosDienThoai = new System.Windows.Forms.Label();
            this.dosDiaChi = new System.Windows.Forms.Label();
            this.dosTen = new System.Windows.Forms.Label();
            this.dosMa = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.mnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(503, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 48);
            this.label8.TabIndex = 6;
            this.label8.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.themNV);
            this.groupBox2.Controls.Add(this.suaNV);
            this.groupBox2.Controls.Add(this.xoaNV);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(690, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 355);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(37)))));
            this.btnThoat.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Location = new System.Drawing.Point(29, 277);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 41);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // xoaNV
            // 
            this.xoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(37)))));
            this.xoaNV.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.xoaNV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.xoaNV.Location = new System.Drawing.Point(29, 157);
            this.xoaNV.Name = "xoaNV";
            this.xoaNV.Size = new System.Drawing.Size(101, 41);
            this.xoaNV.TabIndex = 2;
            this.xoaNV.Text = "Xoá";
            this.xoaNV.UseVisualStyleBackColor = false;
            this.xoaNV.Click += new System.EventHandler(this.button2_Click);
            // 
            // suaNV
            // 
            this.suaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(37)))));
            this.suaNV.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.suaNV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.suaNV.Location = new System.Drawing.Point(29, 97);
            this.suaNV.Name = "suaNV";
            this.suaNV.Size = new System.Drawing.Size(101, 41);
            this.suaNV.TabIndex = 2;
            this.suaNV.Text = "Sửa";
            this.suaNV.UseVisualStyleBackColor = false;
            this.suaNV.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(37)))));
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(29, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Huỷ bỏ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // themNV
            // 
            this.themNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(37)))));
            this.themNV.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.themNV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.themNV.Location = new System.Drawing.Point(29, 37);
            this.themNV.Name = "themNV";
            this.themNV.Size = new System.Drawing.Size(101, 41);
            this.themNV.TabIndex = 2;
            this.themNV.Text = "Thêm";
            this.themNV.UseVisualStyleBackColor = false;
            this.themNV.Click += new System.EventHandler(this.themNV_Click);
            // 
            // btHuyTim
            // 
            this.btHuyTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(37)))));
            this.btHuyTim.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btHuyTim.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btHuyTim.Location = new System.Drawing.Point(197, 186);
            this.btHuyTim.Name = "btHuyTim";
            this.btHuyTim.Size = new System.Drawing.Size(123, 44);
            this.btHuyTim.TabIndex = 3;
            this.btHuyTim.Text = "Huỷ bỏ";
            this.btHuyTim.UseVisualStyleBackColor = false;
            this.btHuyTim.Click += new System.EventHandler(this.btHuyTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(166, 118);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(166, 30);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(23, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã nhân viên:";
            // 
            // timKiem
            // 
            this.timKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(37)))));
            this.timKiem.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.timKiem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.timKiem.Location = new System.Drawing.Point(34, 186);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(123, 44);
            this.timKiem.TabIndex = 2;
            this.timKiem.Text = "Tìm kiếm";
            this.timKiem.UseVisualStyleBackColor = false;
            this.timKiem.Click += new System.EventHandler(this.timKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(99, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(241, 97);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(289, 30);
            this.txtTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(99, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(241, 230);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(289, 30);
            this.txtDiaChi.TabIndex = 1;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpNgaysinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(241, 186);
            this.dtpNgaysinh.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(289, 30);
            this.dtpNgaysinh.TabIndex = 3;
            this.dtpNgaysinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(99, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(99, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới tính:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(241, 274);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(289, 30);
            this.txtSDT.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(99, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(99, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txtMNV
            // 
            this.txtMNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNV.Location = new System.Drawing.Point(241, 51);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(289, 30);
            this.txtMNV.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dosDienThoai);
            this.groupBox1.Controls.Add(this.dosDiaChi);
            this.groupBox1.Controls.Add(this.dosTen);
            this.groupBox1.Controls.Add(this.dosMa);
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.txtMNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNgaysinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 355);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dosDienThoai
            // 
            this.dosDienThoai.AutoSize = true;
            this.dosDienThoai.ForeColor = System.Drawing.Color.Red;
            this.dosDienThoai.Location = new System.Drawing.Point(536, 278);
            this.dosDienThoai.Name = "dosDienThoai";
            this.dosDienThoai.Size = new System.Drawing.Size(15, 24);
            this.dosDienThoai.TabIndex = 6;
            this.dosDienThoai.Text = "*";
            this.dosDienThoai.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.dosDienThoai.Visible = false;
            // 
            // dosDiaChi
            // 
            this.dosDiaChi.AutoSize = true;
            this.dosDiaChi.ForeColor = System.Drawing.Color.Red;
            this.dosDiaChi.Location = new System.Drawing.Point(536, 234);
            this.dosDiaChi.Name = "dosDiaChi";
            this.dosDiaChi.Size = new System.Drawing.Size(15, 24);
            this.dosDiaChi.TabIndex = 6;
            this.dosDiaChi.Text = "*";
            this.dosDiaChi.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.dosDiaChi.Visible = false;
            // 
            // dosTen
            // 
            this.dosTen.AutoSize = true;
            this.dosTen.ForeColor = System.Drawing.Color.Red;
            this.dosTen.Location = new System.Drawing.Point(536, 101);
            this.dosTen.Name = "dosTen";
            this.dosTen.Size = new System.Drawing.Size(15, 24);
            this.dosTen.TabIndex = 6;
            this.dosTen.Text = "*";
            this.dosTen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.dosTen.Visible = false;
            // 
            // dosMa
            // 
            this.dosMa.AutoSize = true;
            this.dosMa.ForeColor = System.Drawing.Color.Red;
            this.dosMa.Location = new System.Drawing.Point(536, 55);
            this.dosMa.Name = "dosMa";
            this.dosMa.Size = new System.Drawing.Size(15, 24);
            this.dosMa.TabIndex = 6;
            this.dosMa.Text = "*";
            this.dosMa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.dosMa.Visible = false;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdoNu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdoNu.Location = new System.Drawing.Point(321, 148);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(47, 25);
            this.rdoNu.TabIndex = 5;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdoNam.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdoNam.Location = new System.Drawing.Point(241, 148);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(57, 25);
            this.rdoNam.TabIndex = 4;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnhanvien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mnv,
            this.tnv,
            this.gt,
            this.ns,
            this.dc,
            this.sdt});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvnhanvien.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvnhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvnhanvien.Location = new System.Drawing.Point(0, 466);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.ReadOnly = true;
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.RowTemplate.Height = 24;
            this.dgvnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhanvien.Size = new System.Drawing.Size(1275, 311);
            this.dgvnhanvien.TabIndex = 8;
            this.dgvnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellClick);
            this.dgvnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellContentClick);
            // 
            // mnv
            // 
            this.mnv.DataPropertyName = "MaNhanVien";
            this.mnv.HeaderText = "Mã nhân viên";
            this.mnv.MinimumWidth = 6;
            this.mnv.Name = "mnv";
            this.mnv.ReadOnly = true;
            // 
            // tnv
            // 
            this.tnv.DataPropertyName = "TenNhanVien";
            this.tnv.HeaderText = "Tên";
            this.tnv.MinimumWidth = 6;
            this.tnv.Name = "tnv";
            this.tnv.ReadOnly = true;
            // 
            // gt
            // 
            this.gt.DataPropertyName = "GioiTinh";
            this.gt.HeaderText = "Giới tính";
            this.gt.MinimumWidth = 6;
            this.gt.Name = "gt";
            this.gt.ReadOnly = true;
            // 
            // ns
            // 
            this.ns.DataPropertyName = "NgaySinh";
            this.ns.HeaderText = "Ngày sinh";
            this.ns.MinimumWidth = 6;
            this.ns.Name = "ns";
            this.ns.ReadOnly = true;
            // 
            // dc
            // 
            this.dc.DataPropertyName = "DiaChi";
            this.dc.HeaderText = "Địa chỉ";
            this.dc.MinimumWidth = 6;
            this.dc.Name = "dc";
            this.dc.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "DienThoai";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btHuyTim);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.timKiem);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(891, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 355);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1275, 777);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button timKiem;
        private System.Windows.Forms.Button xoaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button suaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button themNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.Button btHuyTim;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Label dosMa;
        private System.Windows.Forms.Label dosDienThoai;
        private System.Windows.Forms.Label dosDiaChi;
        private System.Windows.Forms.Label dosTen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
    }
}