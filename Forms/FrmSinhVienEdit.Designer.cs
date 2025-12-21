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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinhVienEdit));
            tableLayoutPanel2 = new TableLayoutPanel();
            dtNgaySinh = new DateTimePicker();
            cbChucVu = new ComboBox();
            cbDanToc = new ComboBox();
            txtNganh = new TextBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbTonGiao = new ComboBox();
            cbGioiTinh = new ComboBox();
            txtSDT = new TextBox();
            txtChuyenNganh = new TextBox();
            txtLop = new TextBox();
            label12 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            cbXa = new ComboBox();
            label11 = new Label();
            cbTinh = new ComboBox();
            title = new ReaLTaiizor.Controls.FoxBigLabel();
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
            tableLayoutPanel2.Controls.Add(cbChucVu, 1, 5);
            tableLayoutPanel2.Controls.Add(cbDanToc, 1, 4);
            tableLayoutPanel2.Controls.Add(txtNganh, 1, 3);
            tableLayoutPanel2.Controls.Add(txtHoTen, 1, 1);
            tableLayoutPanel2.Controls.Add(txtMaSV, 1, 0);
            tableLayoutPanel2.Controls.Add(label10, 0, 5);
            tableLayoutPanel2.Controls.Add(label9, 0, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(353, 231);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtNgaySinh.Dock = DockStyle.Fill;
            dtNgaySinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtNgaySinh.Format = DateTimePickerFormat.Custom;
            dtNgaySinh.Location = new Point(130, 82);
            dtNgaySinh.Margin = new Padding(3, 6, 3, 6);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(220, 26);
            dtNgaySinh.TabIndex = 2;
            dtNgaySinh.Value = new DateTime(2025, 7, 10, 0, 0, 0, 0);
            // 
            // cbChucVu
            // 
            cbChucVu.Dock = DockStyle.Fill;
            cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChucVu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(130, 197);
            cbChucVu.Margin = new Padding(3, 6, 3, 6);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(220, 27);
            cbChucVu.TabIndex = 5;
            // 
            // cbDanToc
            // 
            cbDanToc.Dock = DockStyle.Fill;
            cbDanToc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDanToc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbDanToc.FormattingEnabled = true;
            cbDanToc.Location = new Point(130, 158);
            cbDanToc.Margin = new Padding(3, 6, 3, 6);
            cbDanToc.Name = "cbDanToc";
            cbDanToc.Size = new Size(220, 27);
            cbDanToc.TabIndex = 4;
            // 
            // txtNganh
            // 
            txtNganh.Dock = DockStyle.Fill;
            txtNganh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNganh.Location = new Point(130, 120);
            txtNganh.Margin = new Padding(3, 6, 3, 6);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(220, 26);
            txtNganh.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHoTen.Location = new Point(130, 44);
            txtHoTen.Margin = new Padding(3, 6, 3, 6);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(220, 26);
            txtHoTen.TabIndex = 6;
            // 
            // txtMaSV
            // 
            txtMaSV.Dock = DockStyle.Fill;
            txtMaSV.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMaSV.Location = new Point(130, 6);
            txtMaSV.Margin = new Padding(3, 6, 3, 6);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(220, 26);
            txtMaSV.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(3, 191);
            label10.Name = "label10";
            label10.Size = new Size(121, 40);
            label10.TabIndex = 31;
            label10.Text = "Chức vụ:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(3, 152);
            label9.Name = "label9";
            label9.Size = new Size(121, 39);
            label9.TabIndex = 29;
            label9.Text = "Dân tộc:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(121, 38);
            label4.TabIndex = 27;
            label4.Text = "Ngành:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Size = new Size(121, 38);
            label3.TabIndex = 25;
            label3.Text = "Ngày sinh:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(121, 38);
            label2.TabIndex = 9;
            label2.Text = "Họ và tên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 38);
            label1.TabIndex = 8;
            label1.Text = "Mã sinh viên:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            btnLuu.Font = new Font("Segoe UI", 10.2F);
            btnLuu.Location = new Point(3, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(95, 30);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Thêm";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Fill;
            btnHuy.Font = new Font("Segoe UI", 10.2F);
            btnHuy.Location = new Point(104, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 30);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cbTonGiao, 1, 3);
            tableLayoutPanel1.Controls.Add(cbGioiTinh, 1, 1);
            tableLayoutPanel1.Controls.Add(txtSDT, 1, 4);
            tableLayoutPanel1.Controls.Add(txtChuyenNganh, 1, 2);
            tableLayoutPanel1.Controls.Add(txtLop, 1, 0);
            tableLayoutPanel1.Controls.Add(label12, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel1.Location = new Point(432, 115);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(336, 192);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // cbTonGiao
            // 
            cbTonGiao.Dock = DockStyle.Fill;
            cbTonGiao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTonGiao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbTonGiao.FormattingEnabled = true;
            cbTonGiao.Location = new Point(145, 121);
            cbTonGiao.Margin = new Padding(3, 6, 3, 6);
            cbTonGiao.Name = "cbTonGiao";
            cbTonGiao.Size = new Size(188, 27);
            cbTonGiao.TabIndex = 3;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.Dock = DockStyle.Fill;
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh.Location = new Point(145, 44);
            cbGioiTinh.Margin = new Padding(3, 6, 3, 6);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(188, 27);
            cbGioiTinh.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSDT.Location = new Point(145, 160);
            txtSDT.Margin = new Padding(3, 6, 3, 6);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(188, 26);
            txtSDT.TabIndex = 4;
            // 
            // txtChuyenNganh
            // 
            txtChuyenNganh.Dock = DockStyle.Fill;
            txtChuyenNganh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtChuyenNganh.Location = new Point(145, 83);
            txtChuyenNganh.Margin = new Padding(3, 6, 3, 6);
            txtChuyenNganh.Name = "txtChuyenNganh";
            txtChuyenNganh.Size = new Size(188, 26);
            txtChuyenNganh.TabIndex = 2;
            // 
            // txtLop
            // 
            txtLop.Dock = DockStyle.Fill;
            txtLop.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLop.Location = new Point(145, 6);
            txtLop.Margin = new Padding(3, 6, 3, 6);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(188, 26);
            txtLop.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 10.2F);
            label12.Location = new Point(3, 154);
            label12.Name = "label12";
            label12.Size = new Size(136, 38);
            label12.TabIndex = 30;
            label12.Text = "Số điện thoại:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(3, 115);
            label5.Name = "label5";
            label5.Size = new Size(136, 39);
            label5.TabIndex = 27;
            label5.Text = "Tôn giáo:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(3, 77);
            label6.Name = "label6";
            label6.Size = new Size(136, 38);
            label6.TabIndex = 25;
            label6.Text = "Chuyên ngành:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(3, 38);
            label7.Name = "label7";
            label7.Size = new Size(136, 39);
            label7.TabIndex = 23;
            label7.Text = "Giới tính:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 38);
            label8.TabIndex = 21;
            label8.Text = "Lớp:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(cbXa, 2, 0);
            tableLayoutPanel3.Controls.Add(label11, 0, 0);
            tableLayoutPanel3.Controls.Add(cbTinh, 1, 0);
            tableLayoutPanel3.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel3.Location = new Point(29, 310);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(582, 36);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // cbXa
            // 
            cbXa.Dock = DockStyle.Fill;
            cbXa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbXa.Enabled = false;
            cbXa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbXa.FormattingEnabled = true;
            cbXa.Location = new Point(357, 6);
            cbXa.Margin = new Padding(3, 6, 3, 6);
            cbXa.Name = "cbXa";
            cbXa.Size = new Size(222, 27);
            cbXa.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 36);
            label11.TabIndex = 32;
            label11.Text = "Nơi sinh:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbTinh
            // 
            cbTinh.Dock = DockStyle.Fill;
            cbTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbTinh.FormattingEnabled = true;
            cbTinh.Location = new Point(129, 6);
            cbTinh.Margin = new Padding(3, 6, 3, 6);
            cbTinh.Name = "cbTinh";
            cbTinh.Size = new Size(222, 27);
            cbTinh.TabIndex = 0;
            // 
            // title
            // 
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI Semibold", 20F);
            title.ForeColor = Color.Black;
            title.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            title.LineColor = Color.FromArgb(200, 200, 200);
            title.Location = new Point(29, 12);
            title.Name = "title";
            title.Size = new Size(739, 51);
            title.TabIndex = 0;
            title.Text = "Thêm thông tin sinh viên";
            // 
            // FrmSinhVienEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(title);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSinhVienEdit";
            Text = "Thêm thông tin sinh viên";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label11;
        private Label label12;
        private ReaLTaiizor.Controls.FoxBigLabel title;
        private TextBox txtMaSV;
        private TextBox txtNganh;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtChuyenNganh;
        private TextBox txtLop;
        private ComboBox cbTinh;
        private ComboBox cbXa;
        private ComboBox cbChucVu;
        private ComboBox cbDanToc;
        private ComboBox cbTonGiao;
        private ComboBox cbGioiTinh;
        private DateTimePicker dtNgaySinh;
    }
}