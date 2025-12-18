namespace QLNCKH.Forms {
    partial class FrmSinhVienEdit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tableLayoutPanel2 = new TableLayoutPanel();
            dtNgaySinh = new ReaLTaiizor.Controls.PoisonDateTime();
            cboChucVu = new ReaLTaiizor.Controls.PoisonComboBox();
            cboDanToc = new ReaLTaiizor.Controls.PoisonComboBox();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            txtNganh = new ReaLTaiizor.Controls.SmallTextBox();
            label3 = new Label();
            label2 = new Label();
            txtHoTen = new ReaLTaiizor.Controls.SmallTextBox();
            label1 = new Label();
            txtMaSV = new ReaLTaiizor.Controls.SmallTextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSDT = new ReaLTaiizor.Controls.SmallTextBox();
            label12 = new Label();
            cboGioiTinh = new ReaLTaiizor.Controls.PoisonComboBox();
            cboTonGiao = new ReaLTaiizor.Controls.PoisonComboBox();
            label5 = new Label();
            label6 = new Label();
            txtChuyenNganh = new ReaLTaiizor.Controls.SmallTextBox();
            label7 = new Label();
            label8 = new Label();
            txtLop = new ReaLTaiizor.Controls.SmallTextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            cboXa = new ReaLTaiizor.Controls.PoisonComboBox();
            cboTinh = new ReaLTaiizor.Controls.PoisonComboBox();
            label11 = new Label();
            foxBigLabel2 = new ReaLTaiizor.Controls.FoxBigLabel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.97734F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.02266F));
            tableLayoutPanel2.Controls.Add(dtNgaySinh, 1, 2);
            tableLayoutPanel2.Controls.Add(cboChucVu, 1, 5);
            tableLayoutPanel2.Controls.Add(cboDanToc, 1, 4);
            tableLayoutPanel2.Controls.Add(label10, 0, 5);
            tableLayoutPanel2.Controls.Add(label9, 0, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(txtNganh, 1, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(txtHoTen, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtMaSV, 1, 0);
            tableLayoutPanel2.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel2.Location = new Point(29, 76);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(353, 222);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Dock = DockStyle.Fill;
            dtNgaySinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtNgaySinh.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtNgaySinh.Location = new Point(130, 79);
            dtNgaySinh.MinimumSize = new Size(0, 30);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(220, 30);
            dtNgaySinh.TabIndex = 10;
            // 
            // cboChucVu
            // 
            cboChucVu.Dock = DockStyle.Fill;
            cboChucVu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboChucVu.FormattingEnabled = true;
            cboChucVu.ItemHeight = 24;
            cboChucVu.Location = new Point(130, 189);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(220, 30);
            cboChucVu.TabIndex = 33;
            cboChucVu.UseSelectable = true;
            // 
            // cboDanToc
            // 
            cboDanToc.Dock = DockStyle.Fill;
            cboDanToc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboDanToc.FormattingEnabled = true;
            cboDanToc.ItemHeight = 24;
            cboDanToc.Location = new Point(130, 153);
            cboDanToc.Name = "cboDanToc";
            cboDanToc.Size = new Size(220, 30);
            cboDanToc.TabIndex = 32;
            cboDanToc.UseSelectable = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Tahoma", 10.8F);
            label10.Location = new Point(3, 186);
            label10.Name = "label10";
            label10.Size = new Size(121, 36);
            label10.TabIndex = 31;
            label10.Text = "Chức vụ:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Tahoma", 10.8F);
            label9.Location = new Point(3, 150);
            label9.Name = "label9";
            label9.Size = new Size(121, 36);
            label9.TabIndex = 29;
            label9.Text = "Dân tộc:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Tahoma", 10.8F);
            label4.Location = new Point(3, 112);
            label4.Name = "label4";
            label4.Size = new Size(121, 38);
            label4.TabIndex = 27;
            label4.Text = "Ngành:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNganh
            // 
            txtNganh.BackColor = Color.Transparent;
            txtNganh.BorderColor = Color.FromArgb(180, 180, 180);
            txtNganh.CustomBGColor = Color.White;
            txtNganh.Dock = DockStyle.Fill;
            txtNganh.Font = new Font("Tahoma", 10.8F);
            txtNganh.ForeColor = Color.DimGray;
            txtNganh.Location = new Point(130, 115);
            txtNganh.MaxLength = 32767;
            txtNganh.Multiline = false;
            txtNganh.Name = "txtNganh";
            txtNganh.ReadOnly = false;
            txtNganh.Size = new Size(220, 32);
            txtNganh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtNganh.TabIndex = 26;
            txtNganh.TextAlignment = HorizontalAlignment.Left;
            txtNganh.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Tahoma", 10.8F);
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Size = new Size(121, 36);
            label3.TabIndex = 25;
            label3.Text = "Ngày sinh:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 10.8F);
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(121, 38);
            label2.TabIndex = 23;
            label2.Text = "Họ và tên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.Transparent;
            txtHoTen.BorderColor = Color.FromArgb(180, 180, 180);
            txtHoTen.CustomBGColor = Color.White;
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Font = new Font("Tahoma", 10.8F);
            txtHoTen.ForeColor = Color.DimGray;
            txtHoTen.Location = new Point(130, 41);
            txtHoTen.MaxLength = 32767;
            txtHoTen.Multiline = false;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = false;
            txtHoTen.Size = new Size(220, 32);
            txtHoTen.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtHoTen.TabIndex = 22;
            txtHoTen.TextAlignment = HorizontalAlignment.Left;
            txtHoTen.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 10.8F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 38);
            label1.TabIndex = 21;
            label1.Text = "Mã sinh viên:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaSV
            // 
            txtMaSV.BackColor = Color.Transparent;
            txtMaSV.BorderColor = Color.FromArgb(180, 180, 180);
            txtMaSV.CustomBGColor = Color.White;
            txtMaSV.Dock = DockStyle.Fill;
            txtMaSV.Font = new Font("Tahoma", 10.8F);
            txtMaSV.ForeColor = Color.DimGray;
            txtMaSV.Location = new Point(130, 3);
            txtMaSV.MaxLength = 32767;
            txtMaSV.Multiline = false;
            txtMaSV.Name = "txtMaSV";
            txtMaSV.ReadOnly = false;
            txtMaSV.Size = new Size(220, 32);
            txtMaSV.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtMaSV.TabIndex = 20;
            txtMaSV.TextAlignment = HorizontalAlignment.Left;
            txtMaSV.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnLuu, 0, 0);
            tableLayoutPanel5.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanel5.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel5.Location = new Point(585, 402);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(203, 36);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.Dock = DockStyle.Fill;
            btnLuu.Font = new Font("Tahoma", 10.8F);
            btnLuu.Location = new Point(3, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(95, 30);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Fill;
            btnHuy.Font = new Font("Tahoma", 10.8F);
            btnHuy.Location = new Point(104, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 30);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtSDT, 1, 4);
            tableLayoutPanel1.Controls.Add(label12, 0, 4);
            tableLayoutPanel1.Controls.Add(cboGioiTinh, 1, 1);
            tableLayoutPanel1.Controls.Add(cboTonGiao, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(txtChuyenNganh, 1, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(txtLop, 1, 0);
            tableLayoutPanel1.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel1.Location = new Point(432, 115);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(336, 183);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.Transparent;
            txtSDT.BorderColor = Color.FromArgb(180, 180, 180);
            txtSDT.CustomBGColor = Color.White;
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Font = new Font("Tahoma", 10.8F);
            txtSDT.ForeColor = Color.DimGray;
            txtSDT.Location = new Point(145, 151);
            txtSDT.MaxLength = 32767;
            txtSDT.Multiline = false;
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = false;
            txtSDT.Size = new Size(188, 32);
            txtSDT.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtSDT.TabIndex = 31;
            txtSDT.TextAlignment = HorizontalAlignment.Left;
            txtSDT.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Tahoma", 10.8F);
            label12.Location = new Point(3, 148);
            label12.Name = "label12";
            label12.Size = new Size(136, 35);
            label12.TabIndex = 30;
            label12.Text = "Số điện thoại:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Dock = DockStyle.Fill;
            cboGioiTinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.ItemHeight = 24;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(145, 41);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(188, 30);
            cboGioiTinh.TabIndex = 29;
            cboGioiTinh.UseSelectable = true;
            // 
            // cboTonGiao
            // 
            cboTonGiao.Dock = DockStyle.Fill;
            cboTonGiao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboTonGiao.FormattingEnabled = true;
            cboTonGiao.ItemHeight = 24;
            cboTonGiao.Location = new Point(145, 115);
            cboTonGiao.Name = "cboTonGiao";
            cboTonGiao.Size = new Size(188, 30);
            cboTonGiao.TabIndex = 28;
            cboTonGiao.UseSelectable = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Tahoma", 10.8F);
            label5.Location = new Point(3, 112);
            label5.Name = "label5";
            label5.Size = new Size(136, 36);
            label5.TabIndex = 27;
            label5.Text = "Tôn giáo:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Tahoma", 10.8F);
            label6.Location = new Point(3, 74);
            label6.Name = "label6";
            label6.Size = new Size(136, 38);
            label6.TabIndex = 25;
            label6.Text = "Chuyên ngành:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtChuyenNganh
            // 
            txtChuyenNganh.BackColor = Color.Transparent;
            txtChuyenNganh.BorderColor = Color.FromArgb(180, 180, 180);
            txtChuyenNganh.CustomBGColor = Color.White;
            txtChuyenNganh.Dock = DockStyle.Fill;
            txtChuyenNganh.Font = new Font("Tahoma", 10.8F);
            txtChuyenNganh.ForeColor = Color.DimGray;
            txtChuyenNganh.Location = new Point(145, 77);
            txtChuyenNganh.MaxLength = 32767;
            txtChuyenNganh.Multiline = false;
            txtChuyenNganh.Name = "txtChuyenNganh";
            txtChuyenNganh.ReadOnly = false;
            txtChuyenNganh.Size = new Size(188, 32);
            txtChuyenNganh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtChuyenNganh.TabIndex = 24;
            txtChuyenNganh.TextAlignment = HorizontalAlignment.Left;
            txtChuyenNganh.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Tahoma", 10.8F);
            label7.Location = new Point(3, 38);
            label7.Name = "label7";
            label7.Size = new Size(136, 36);
            label7.TabIndex = 23;
            label7.Text = "Giới tính:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Tahoma", 10.8F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 38);
            label8.TabIndex = 21;
            label8.Text = "Lớp:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLop
            // 
            txtLop.BackColor = Color.Transparent;
            txtLop.BorderColor = Color.FromArgb(180, 180, 180);
            txtLop.CustomBGColor = Color.White;
            txtLop.Dock = DockStyle.Fill;
            txtLop.Font = new Font("Tahoma", 10.8F);
            txtLop.ForeColor = Color.DimGray;
            txtLop.Location = new Point(145, 3);
            txtLop.MaxLength = 32767;
            txtLop.Multiline = false;
            txtLop.Name = "txtLop";
            txtLop.ReadOnly = false;
            txtLop.Size = new Size(188, 32);
            txtLop.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtLop.TabIndex = 20;
            txtLop.TextAlignment = HorizontalAlignment.Left;
            txtLop.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(cboXa, 2, 0);
            tableLayoutPanel3.Controls.Add(cboTinh, 1, 0);
            tableLayoutPanel3.Controls.Add(label11, 0, 0);
            tableLayoutPanel3.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel3.Location = new Point(29, 301);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(582, 36);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // cboXa
            // 
            cboXa.Dock = DockStyle.Fill;
            cboXa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboXa.FormattingEnabled = true;
            cboXa.ItemHeight = 24;
            cboXa.Location = new Point(357, 3);
            cboXa.Name = "cboXa";
            cboXa.Size = new Size(222, 30);
            cboXa.TabIndex = 33;
            cboXa.UseSelectable = true;
            // 
            // cboTinh
            // 
            cboTinh.Dock = DockStyle.Fill;
            cboTinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboTinh.FormattingEnabled = true;
            cboTinh.ItemHeight = 24;
            cboTinh.Location = new Point(129, 3);
            cboTinh.Name = "cboTinh";
            cboTinh.Size = new Size(222, 30);
            cboTinh.TabIndex = 13;
            cboTinh.UseSelectable = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Tahoma", 10.8F);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 36);
            label11.TabIndex = 32;
            label11.Text = "Nơi sinh:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // foxBigLabel2
            // 
            foxBigLabel2.BackColor = Color.Transparent;
            foxBigLabel2.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel2.ForeColor = Color.Black;
            foxBigLabel2.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel2.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel2.Location = new Point(29, 12);
            foxBigLabel2.Name = "foxBigLabel2";
            foxBigLabel2.Size = new Size(739, 51);
            foxBigLabel2.TabIndex = 10;
            foxBigLabel2.Text = "Thông tin sinh viên";
            // 
            // FrmSinhVienEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(foxBigLabel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel2);
            Name = "FrmSinhVienEdit";
            Text = "FrmSinhVienEdit";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnLuu;
        private Button btnHuy;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label6;
        private ReaLTaiizor.Controls.SmallTextBox txtChuyenNganh;
        private Label label7;
        private Label label8;
        private ReaLTaiizor.Controls.SmallTextBox txtLop;
        private Label label9;
        private Label label10;
        private ReaLTaiizor.Controls.SmallTextBox txtNganh;
        private ReaLTaiizor.Controls.SmallTextBox txtHoTen;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label11;
        private ReaLTaiizor.Controls.PoisonComboBox cboChucVu;
        private ReaLTaiizor.Controls.PoisonComboBox cboDanToc;
        private ReaLTaiizor.Controls.PoisonComboBox cboGioiTinh;
        private ReaLTaiizor.Controls.PoisonComboBox cboTonGiao;
        private ReaLTaiizor.Controls.PoisonComboBox cboXa;
        private ReaLTaiizor.Controls.PoisonComboBox cboTinh;
        private ReaLTaiizor.Controls.PoisonDateTime dtNgaySinh;
        private ReaLTaiizor.Controls.SmallTextBox txtMaSV;
        private ReaLTaiizor.Controls.SmallTextBox txtSDT;
        private Label label12;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel2;
    }
}