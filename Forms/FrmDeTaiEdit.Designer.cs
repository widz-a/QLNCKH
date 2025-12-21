namespace QLNCKH.Forms {
    partial class FrmDeTaiEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeTaiEdit));
            tableLayoutPanel5 = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            title = new ReaLTaiizor.Controls.FoxBigLabel();
            tab = new TabControl();
            tabThongTin = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtTen = new RichTextBox();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dtDate = new DateTimePicker();
            cbLV = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            cbGV = new ComboBox();
            txtMaDT = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabThanhVien = new TabPage();
            pnlMain = new Panel();
            tableLayoutPanel5.SuspendLayout();
            tab.SuspendLayout();
            tabThongTin.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabThanhVien.SuspendLayout();
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
            title.Text = "Đăng kí đề tài NCKH";
            // 
            // tab
            // 
            tab.Controls.Add(tabThongTin);
            tab.Controls.Add(tabThanhVien);
            tab.Location = new Point(29, 69);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(739, 292);
            tab.TabIndex = 6;
            // 
            // tabThongTin
            // 
            tabThongTin.Controls.Add(tableLayoutPanel3);
            tabThongTin.Controls.Add(tableLayoutPanel1);
            tabThongTin.Controls.Add(tableLayoutPanel2);
            tabThongTin.Location = new Point(4, 29);
            tabThongTin.Name = "tabThongTin";
            tabThongTin.Padding = new Padding(3);
            tabThongTin.Size = new Size(731, 259);
            tabThongTin.TabIndex = 0;
            tabThongTin.Text = "Thông tin";
            tabThongTin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.205883F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.79412F));
            tableLayoutPanel3.Controls.Add(txtTen, 1, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel3.Location = new Point(29, 97);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(683, 89);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // txtTen
            // 
            txtTen.Dock = DockStyle.Fill;
            txtTen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTen.Location = new Point(154, 3);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(526, 83);
            txtTen.TabIndex = 12;
            txtTen.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 89);
            label4.TabIndex = 8;
            label4.Text = "Tên đề tài:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dtDate, 1, 1);
            tableLayoutPanel1.Controls.Add(cbLV, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel1.Location = new Point(417, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(295, 75);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // dtDate
            // 
            dtDate.CustomFormat = "dd/MM/yyyy";
            dtDate.Dock = DockStyle.Fill;
            dtDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtDate.Format = DateTimePickerFormat.Custom;
            dtDate.Location = new Point(158, 45);
            dtDate.Margin = new Padding(3, 6, 3, 6);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(134, 26);
            dtDate.TabIndex = 27;
            dtDate.Value = new DateTime(2025, 7, 10, 0, 0, 0, 0);
            // 
            // cbLV
            // 
            cbLV.Dock = DockStyle.Fill;
            cbLV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLV.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbLV.FormattingEnabled = true;
            cbLV.Location = new Point(158, 6);
            cbLV.Margin = new Padding(3, 6, 3, 6);
            cbLV.Name = "cbLV";
            cbLV.Size = new Size(134, 27);
            cbLV.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(3, 39);
            label7.Name = "label7";
            label7.Size = new Size(149, 38);
            label7.TabIndex = 23;
            label7.Text = "Thời gian dự kiến:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(149, 39);
            label8.TabIndex = 21;
            label8.Text = "Lĩnh vực:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.57703F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.42297F));
            tableLayoutPanel2.Controls.Add(cbGV, 1, 1);
            tableLayoutPanel2.Controls.Add(txtMaDT, 1, 0);
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
            // cbGV
            // 
            cbGV.Dock = DockStyle.Fill;
            cbGV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGV.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbGV.FormattingEnabled = true;
            cbGV.Location = new Point(155, 44);
            cbGV.Margin = new Padding(3, 6, 3, 6);
            cbGV.Name = "cbGV";
            cbGV.Size = new Size(199, 27);
            cbGV.TabIndex = 10;
            // 
            // txtMaDT
            // 
            txtMaDT.Dock = DockStyle.Fill;
            txtMaDT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMaDT.Location = new Point(155, 6);
            txtMaDT.Margin = new Padding(3, 6, 3, 6);
            txtMaDT.Name = "txtMaDT";
            txtMaDT.Size = new Size(199, 26);
            txtMaDT.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(146, 39);
            label2.TabIndex = 9;
            label2.Text = "GV hướng dẫn:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 38);
            label1.TabIndex = 8;
            label1.Text = "Mã đề tài:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabThanhVien
            // 
            tabThanhVien.Controls.Add(pnlMain);
            tabThanhVien.Location = new Point(4, 29);
            tabThanhVien.Name = "tabThanhVien";
            tabThanhVien.Padding = new Padding(3);
            tabThanhVien.Size = new Size(731, 259);
            tabThanhVien.TabIndex = 1;
            tabThanhVien.Text = "Thành viên";
            tabThanhVien.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.Control;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(3, 3);
            pnlMain.Margin = new Padding(3, 3, 3, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(725, 253);
            pnlMain.TabIndex = 7;
            // 
            // FrmDeTaiEdit
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
            Name = "FrmDeTaiEdit";
            Text = "Đăng kí đề tài NCKH";
            tableLayoutPanel5.ResumeLayout(false);
            tab.ResumeLayout(false);
            tabThongTin.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabThanhVien.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtMaDT;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private RichTextBox txtTen;
        private Panel pnlMain;
        private ComboBox cbLV;
        private DateTimePicker dtDate;
        private ComboBox cbGV;
    }
}