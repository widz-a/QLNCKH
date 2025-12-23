namespace QLNCKH.Forms {
    partial class FrmHoiDongEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoiDongEdit));
            tableLayoutPanel5 = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            title = new ReaLTaiizor.Controls.FoxBigLabel();
            tab = new TabControl();
            tabThongTin = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dtDate = new DateTimePicker();
            cbDTCD = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tabDTCD = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            listView2 = new ListView();
            dtStt = new ColumnHeader();
            dtMa = new ColumnHeader();
            dtTen = new ColumnHeader();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDcXoa = new Button();
            btnDcThem = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            cbNameDC = new ComboBox();
            label6 = new Label();
            tabThanhVien = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            listView1 = new ListView();
            lvStt = new ColumnHeader();
            lvMaSV = new ColumnHeader();
            lvTenSV = new ColumnHeader();
            lvVT = new ColumnHeader();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnTvXoa = new Button();
            btnTvThem = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            cbVT = new ComboBox();
            label5 = new Label();
            cbCB = new ComboBox();
            label3 = new Label();
            tableLayoutPanel5.SuspendLayout();
            tab.SuspendLayout();
            tabThongTin.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabDTCD.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tabThanhVien.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
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
            title.Text = "Thành lập hội đồng";
            // 
            // tab
            // 
            tab.Controls.Add(tabThongTin);
            tab.Controls.Add(tabDTCD);
            tab.Controls.Add(tabThanhVien);
            tab.Location = new Point(29, 69);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(739, 292);
            tab.TabIndex = 6;
            // 
            // tabThongTin
            // 
            tabThongTin.Controls.Add(tableLayoutPanel2);
            tabThongTin.Location = new Point(4, 29);
            tabThongTin.Name = "tabThongTin";
            tabThongTin.Padding = new Padding(3);
            tabThongTin.Size = new Size(731, 259);
            tabThongTin.TabIndex = 0;
            tabThongTin.Text = "Thông tin";
            tabThongTin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.57703F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.42297F));
            tableLayoutPanel2.Controls.Add(dtDate, 1, 1);
            tableLayoutPanel2.Controls.Add(cbDTCD, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel2.Location = new Point(29, 17);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(357, 77);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // dtDate
            // 
            dtDate.CustomFormat = "dd/MM/yyyy";
            dtDate.Dock = DockStyle.Fill;
            dtDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtDate.Format = DateTimePickerFormat.Custom;
            dtDate.Location = new Point(155, 45);
            dtDate.Margin = new Padding(3, 6, 3, 6);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(199, 26);
            dtDate.TabIndex = 28;
            dtDate.Value = new DateTime(2025, 7, 10, 0, 0, 0, 0);
            // 
            // cbDTCD
            // 
            cbDTCD.Dock = DockStyle.Fill;
            cbDTCD.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDTCD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbDTCD.FormattingEnabled = true;
            cbDTCD.Items.AddRange(new object[] { "Đề tài", "Chuyên đề" });
            cbDTCD.Location = new Point(155, 6);
            cbDTCD.Margin = new Padding(3, 6, 3, 6);
            cbDTCD.Name = "cbDTCD";
            cbDTCD.Size = new Size(199, 27);
            cbDTCD.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(3, 39);
            label2.Name = "label2";
            label2.Size = new Size(146, 38);
            label2.TabIndex = 9;
            label2.Text = "Ngày chấm:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 39);
            label1.TabIndex = 8;
            label1.Text = "Đề tài/chuyên đề:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabDTCD
            // 
            tabDTCD.Controls.Add(tableLayoutPanel1);
            tabDTCD.Location = new Point(4, 29);
            tabDTCD.Name = "tabDTCD";
            tabDTCD.Padding = new Padding(3);
            tabDTCD.Size = new Size(731, 259);
            tabDTCD.TabIndex = 2;
            tabDTCD.Text = "Đề tài";
            tabDTCD.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(listView2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.762846F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.23715F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(725, 253);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { dtStt, dtMa, dtTen });
            listView2.Dock = DockStyle.Fill;
            listView2.FullRowSelect = true;
            listView2.Location = new Point(3, 53);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(719, 197);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // dtStt
            // 
            dtStt.Text = "STT";
            // 
            // dtMa
            // 
            dtMa.Text = "Mã";
            dtMa.Width = 150;
            // 
            // dtTen
            // 
            dtTen.Text = "Tên";
            dtTen.Width = 400;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6036158F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.25173855F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6036158F));
            tableLayoutPanel3.Controls.Add(btnDcXoa, 3, 0);
            tableLayoutPanel3.Controls.Add(btnDcThem, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(719, 44);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnDcXoa
            // 
            btnDcXoa.Dock = DockStyle.Fill;
            btnDcXoa.Location = new Point(616, 3);
            btnDcXoa.Name = "btnDcXoa";
            btnDcXoa.Size = new Size(100, 38);
            btnDcXoa.TabIndex = 16;
            btnDcXoa.Text = "Xóa";
            btnDcXoa.UseVisualStyleBackColor = true;
            // 
            // btnDcThem
            // 
            btnDcThem.Dock = DockStyle.Fill;
            btnDcThem.Location = new Point(504, 3);
            btnDcThem.Name = "btnDcThem";
            btnDcThem.Size = new Size(98, 38);
            btnDcThem.TabIndex = 14;
            btnDcThem.Text = "Thêm";
            btnDcThem.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel8.Controls.Add(cbNameDC, 1, 0);
            tableLayoutPanel8.Controls.Add(label6, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(495, 38);
            tableLayoutPanel8.TabIndex = 17;
            // 
            // cbNameDC
            // 
            cbNameDC.Dock = DockStyle.Fill;
            cbNameDC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNameDC.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbNameDC.FormattingEnabled = true;
            cbNameDC.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbNameDC.Location = new Point(68, 6);
            cbNameDC.Margin = new Padding(3, 6, 3, 6);
            cbNameDC.Name = "cbNameDC";
            cbNameDC.Size = new Size(424, 27);
            cbNameDC.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 38);
            label6.TabIndex = 22;
            label6.Text = "Đề tài:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabThanhVien
            // 
            tabThanhVien.Controls.Add(tableLayoutPanel4);
            tabThanhVien.Location = new Point(4, 29);
            tabThanhVien.Name = "tabThanhVien";
            tabThanhVien.Padding = new Padding(3);
            tabThanhVien.Size = new Size(731, 259);
            tabThanhVien.TabIndex = 1;
            tabThanhVien.Text = "Thành viên";
            tabThanhVien.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(listView1, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 19.762846F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80.23715F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(725, 253);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { lvStt, lvMaSV, lvTenSV, lvVT });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(3, 53);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(719, 197);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // lvStt
            // 
            lvStt.Text = "STT";
            // 
            // lvMaSV
            // 
            lvMaSV.Text = "Mã sinh viên";
            lvMaSV.Width = 150;
            // 
            // lvTenSV
            // 
            lvTenSV.Text = "Họ và tên";
            lvTenSV.Width = 400;
            // 
            // lvVT
            // 
            lvVT.Text = "Vai trò";
            lvVT.Width = 200;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6036158F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.25173855F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6036158F));
            tableLayoutPanel6.Controls.Add(btnTvXoa, 3, 0);
            tableLayoutPanel6.Controls.Add(btnTvThem, 1, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(719, 44);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btnTvXoa
            // 
            btnTvXoa.Dock = DockStyle.Fill;
            btnTvXoa.Location = new Point(616, 3);
            btnTvXoa.Name = "btnTvXoa";
            btnTvXoa.Size = new Size(100, 38);
            btnTvXoa.TabIndex = 16;
            btnTvXoa.Text = "Xóa";
            btnTvXoa.UseVisualStyleBackColor = true;
            // 
            // btnTvThem
            // 
            btnTvThem.Dock = DockStyle.Fill;
            btnTvThem.Location = new Point(504, 3);
            btnTvThem.Name = "btnTvThem";
            btnTvThem.Size = new Size(98, 38);
            btnTvThem.TabIndex = 14;
            btnTvThem.Text = "Thêm";
            btnTvThem.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.Controls.Add(cbVT, 3, 0);
            tableLayoutPanel7.Controls.Add(label5, 2, 0);
            tableLayoutPanel7.Controls.Add(cbCB, 1, 0);
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(495, 38);
            tableLayoutPanel7.TabIndex = 17;
            // 
            // cbVT
            // 
            cbVT.Dock = DockStyle.Fill;
            cbVT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbVT.FormattingEnabled = true;
            cbVT.Items.AddRange(new object[] { "Chủ tịch", "Thư ký", "Thành viên" });
            cbVT.Location = new Point(400, 6);
            cbVT.Margin = new Padding(3, 6, 3, 6);
            cbVT.Name = "cbVT";
            cbVT.Size = new Size(92, 27);
            cbVT.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(330, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 38);
            label5.TabIndex = 43;
            label5.Text = "Vai trò:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbCB
            // 
            cbCB.Dock = DockStyle.Fill;
            cbCB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbCB.FormattingEnabled = true;
            cbCB.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbCB.Location = new Point(104, 6);
            cbCB.Margin = new Padding(3, 6, 3, 6);
            cbCB.Name = "cbCB";
            cbCB.Size = new Size(220, 27);
            cbCB.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 38);
            label3.TabIndex = 22;
            label3.Text = "Giảng viên:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmHoiDongEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tab);
            Controls.Add(title);
            Controls.Add(tableLayoutPanel5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmHoiDongEdit";
            Text = "Thành lập hội đồng";
            tableLayoutPanel5.ResumeLayout(false);
            tab.ResumeLayout(false);
            tabThongTin.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabDTCD.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tabThanhVien.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnLuu;
        private Button btnHuy;
        private ReaLTaiizor.Controls.FoxBigLabel title;
        private TabControl tab;
        private TabPage tabThongTin;
        private TabPage tabThanhVien;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private ListView listView1;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnTvThem;
        private Button btnTvXoa;
        private ColumnHeader lvStt;
        private ColumnHeader lvMaSV;
        private ColumnHeader lvTenSV;
        private ColumnHeader lvVT;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label3;
        private ComboBox cbCB;
        private DateTimePicker dtDate;
        private ComboBox cbDTCD;
        private TabPage tabDTCD;
        private ComboBox cbVT;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView2;
        private ColumnHeader dtStt;
        private ColumnHeader dtMa;
        private ColumnHeader dtTen;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnDcXoa;
        private Button btnDcThem;
        private TableLayoutPanel tableLayoutPanel8;
        private ComboBox cbNameDC;
        private Label label6;
    }
}