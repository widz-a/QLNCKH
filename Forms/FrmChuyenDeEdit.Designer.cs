namespace QLNCKH.Forms {
    partial class FrmChuyenDeEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChuyenDeEdit));
            tableLayoutPanel2 = new TableLayoutPanel();
            txtMaCD = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            title = new ReaLTaiizor.Controls.FoxBigLabel();
            cbLV = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbSV = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtTen = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.4409943F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.5590057F));
            tableLayoutPanel2.Controls.Add(cbLV, 1, 1);
            tableLayoutPanel2.Controls.Add(txtMaCD, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel2.Location = new Point(29, 76);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(337, 71);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // txtMaCD
            // 
            txtMaCD.Dock = DockStyle.Fill;
            txtMaCD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMaCD.Location = new Point(135, 6);
            txtMaCD.Margin = new Padding(3, 6, 3, 6);
            txtMaCD.Name = "txtMaCD";
            txtMaCD.Size = new Size(199, 26);
            txtMaCD.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(126, 39);
            label2.TabIndex = 9;
            label2.Text = "Lĩnh vực";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 38);
            label1.TabIndex = 8;
            label1.Text = "Mã chuyên đề:";
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
            title.Text = "Đăng kí chuyên đề NCKH";
            // 
            // cbLV
            // 
            cbLV.Dock = DockStyle.Fill;
            cbLV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLV.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbLV.FormattingEnabled = true;
            cbLV.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbLV.Location = new Point(135, 44);
            cbLV.Margin = new Padding(3, 6, 3, 6);
            cbLV.Name = "cbLV";
            cbLV.Size = new Size(199, 27);
            cbLV.TabIndex = 42;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4387741F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.5612259F));
            tableLayoutPanel1.Controls.Add(cbSV, 1, 1);
            tableLayoutPanel1.Controls.Add(txtTen, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel1.Location = new Point(393, 76);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(392, 71);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // cbSV
            // 
            cbSV.Dock = DockStyle.Fill;
            cbSV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSV.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbSV.FormattingEnabled = true;
            cbSV.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbSV.Location = new Point(137, 44);
            cbSV.Margin = new Padding(3, 6, 3, 6);
            cbSV.Name = "cbSV";
            cbSV.Size = new Size(252, 27);
            cbSV.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(3, 38);
            label3.Name = "label3";
            label3.Size = new Size(128, 39);
            label3.TabIndex = 9;
            label3.Text = "Sinh viên:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 38);
            label4.TabIndex = 8;
            label4.Text = "Tên chuyên đề:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTen
            // 
            txtTen.Dock = DockStyle.Fill;
            txtTen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTen.Location = new Point(137, 6);
            txtTen.Margin = new Padding(3, 6, 3, 6);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(252, 26);
            txtTen.TabIndex = 7;
            // 
            // FrmChuyenDeEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(title);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmChuyenDeEdit";
            Text = "Đăng kí chuyên đề NCKH";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnLuu;
        private Button btnHuy;
        private Label label1;
        private ReaLTaiizor.Controls.FoxBigLabel title;
        private TextBox txtMaCD;
        private Label label2;
        private ComboBox cbLV;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cbSV;
        private Label label3;
        private Label label4;
        private TextBox txtTen;
    }
}