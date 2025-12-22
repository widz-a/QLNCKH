namespace QLNCKH.Forms {
    partial class FrmDaoVanEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDaoVanEdit));
            tableLayoutPanel5 = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            title = new ReaLTaiizor.Controls.FoxBigLabel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            cbDT = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtLanQuet = new TextBox();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtTyLe = new TextBox();
            label5 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtKQ = new TextBox();
            label6 = new Label();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
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
            title.Text = "Kiểm tra đạo văn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 39);
            label1.TabIndex = 8;
            label1.Text = "Đề tài:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3964815F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.6035156F));
            tableLayoutPanel2.Controls.Add(cbDT, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel2.Location = new Point(29, 76);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(739, 36);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // cbDT
            // 
            cbDT.Dock = DockStyle.Fill;
            cbDT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbDT.FormattingEnabled = true;
            cbDT.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbDT.Location = new Point(102, 6);
            cbDT.Margin = new Padding(3, 6, 3, 6);
            cbDT.Name = "cbDT";
            cbDT.Size = new Size(634, 27);
            cbDT.TabIndex = 43;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.4971733F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.5028267F));
            tableLayoutPanel3.Controls.Add(txtLanQuet, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel3.Location = new Point(29, 129);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(177, 36);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // txtLanQuet
            // 
            txtLanQuet.Dock = DockStyle.Fill;
            txtLanQuet.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLanQuet.Location = new Point(103, 6);
            txtLanQuet.Margin = new Padding(3, 6, 3, 6);
            txtLanQuet.Name = "txtLanQuet";
            txtLanQuet.ReadOnly = true;
            txtLanQuet.Size = new Size(71, 26);
            txtLanQuet.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 38);
            label2.TabIndex = 8;
            label2.Text = "Lần quét:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.16575F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8342533F));
            tableLayoutPanel4.Controls.Add(txtTyLe, 1, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel4.Location = new Point(292, 129);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(192, 36);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // txtTyLe
            // 
            txtTyLe.Dock = DockStyle.Fill;
            txtTyLe.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTyLe.Location = new Point(137, 6);
            txtTyLe.Margin = new Padding(3, 6, 3, 6);
            txtTyLe.Name = "txtTyLe";
            txtTyLe.Size = new Size(52, 26);
            txtTyLe.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 38);
            label5.TabIndex = 8;
            label5.Text = "Tỉ lệ trùng lặp";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.3958321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.6041679F));
            tableLayoutPanel6.Controls.Add(txtKQ, 1, 0);
            tableLayoutPanel6.Controls.Add(label6, 0, 0);
            tableLayoutPanel6.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel6.Location = new Point(573, 129);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(192, 36);
            tableLayoutPanel6.TabIndex = 9;
            // 
            // txtKQ
            // 
            txtKQ.Dock = DockStyle.Fill;
            txtKQ.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtKQ.Location = new Point(94, 6);
            txtKQ.Margin = new Padding(3, 6, 3, 6);
            txtKQ.Name = "txtKQ";
            txtKQ.ReadOnly = true;
            txtKQ.Size = new Size(95, 26);
            txtKQ.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 38);
            label6.TabIndex = 8;
            label6.Text = "Kết quả:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmDaoVanEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel6);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(title);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDaoVanEdit";
            Text = "Kiểm tra đạo văn";
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnLuu;
        private Button btnHuy;
        private ReaLTaiizor.Controls.FoxBigLabel title;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cbDT;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox txtLanQuet;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtTyLe;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtKQ;
        private Label label6;
    }
}