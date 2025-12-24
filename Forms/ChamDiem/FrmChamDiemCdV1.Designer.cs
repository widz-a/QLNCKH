namespace QLNCKH.Forms {
    partial class FrmChamDiemCdV1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChamDiemCdV1));
            tableLayoutPanel5 = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            title = new ReaLTaiizor.Controls.FoxBigLabel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tbChuyenDe = new TextBox();
            tbHoiDong = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox1 = new TextBox();
            label5 = new Label();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            title.Text = "Phiếu chấm điểm chuyên đề";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 36);
            label1.TabIndex = 8;
            label1.Text = "Hội đồng:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1556158F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.84438F));
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(tbChuyenDe, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tbHoiDong, 1, 0);
            tableLayoutPanel2.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel2.Location = new Point(29, 76);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.Size = new Size(739, 74);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(106, 38);
            label2.TabIndex = 10;
            label2.Text = "Đề tài:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbChuyenDe
            // 
            tbChuyenDe.BackColor = SystemColors.Window;
            tbChuyenDe.Dock = DockStyle.Fill;
            tbChuyenDe.Enabled = false;
            tbChuyenDe.Font = new Font("Segoe UI", 10.2F);
            tbChuyenDe.Location = new Point(115, 39);
            tbChuyenDe.Name = "tbChuyenDe";
            tbChuyenDe.ReadOnly = true;
            tbChuyenDe.Size = new Size(621, 30);
            tbChuyenDe.TabIndex = 11;
            tbChuyenDe.TabStop = false;
            // 
            // tbHoiDong
            // 
            tbHoiDong.BackColor = SystemColors.Window;
            tbHoiDong.Dock = DockStyle.Fill;
            tbHoiDong.Enabled = false;
            tbHoiDong.Font = new Font("Segoe UI", 10.2F);
            tbHoiDong.Location = new Point(115, 3);
            tbHoiDong.Name = "tbHoiDong";
            tbHoiDong.ReadOnly = true;
            tbHoiDong.Size = new Size(621, 30);
            tbHoiDong.TabIndex = 9;
            tbHoiDong.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.96403F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.03597F));
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel1.Location = new Point(29, 151);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(556, 37);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 37);
            label8.TabIndex = 8;
            label8.Text = "Giảng viên:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.Font = new Font("Segoe UI", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(439, 31);
            comboBox1.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.11111F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.88889F));
            tableLayoutPanel3.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel3.Location = new Point(588, 151);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.Size = new Size(180, 37);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox1.Location = new Point(95, 6);
            textBox1.Margin = new Padding(3, 6, 3, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(82, 26);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 38);
            label5.TabIndex = 8;
            label5.Text = "Điểm:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmChamDiemCdV1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(title);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmChamDiemCdV1";
            Text = "Phiếu chấm điểm chuyên đề";
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnLuu;
        private Button btnHuy;
        private ReaLTaiizor.Controls.FoxBigLabel title;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbHoiDong;
        private Label label2;
        private TextBox tbChuyenDe;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}