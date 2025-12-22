namespace QLNCKH.Forms
{
    partial class FrmNopDeTaiEdit
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            cbLoai = new ComboBox();
            cbMa = new ComboBox();
            txtTen = new TextBox();
            btnNop = new Button();
            btnHuy = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label4 = new Label();
            cbTrangThai = new ComboBox();
            cbNguoiNop = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.439024F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.5609741F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(cbLoai, 1, 2);
            tableLayoutPanel1.Controls.Add(cbMa, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTen, 1, 1);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel1.Location = new Point(24, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.04348F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.95652F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.Size = new Size(368, 241);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 56);
            label1.TabIndex = 4;
            label1.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 99);
            label3.Name = "label3";
            label3.Size = new Size(75, 56);
            label3.TabIndex = 6;
            label3.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 186);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 8;
            label5.Text = "Loại";
            // 
            // cbLoai
            // 
            cbLoai.FormattingEnabled = true;
            cbLoai.Location = new Point(85, 189);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(252, 36);
            cbLoai.TabIndex = 9;
            // 
            // cbMa
            // 
            cbMa.FormattingEnabled = true;
            cbMa.Location = new Point(85, 3);
            cbMa.Name = "cbMa";
            cbMa.Size = new Size(252, 36);
            cbMa.TabIndex = 10;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(85, 102);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(252, 34);
            txtTen.TabIndex = 11;
            // 
            // btnNop
            // 
            btnNop.Font = new Font("Segoe UI", 12F);
            btnNop.Location = new Point(167, 336);
            btnNop.Name = "btnNop";
            btnNop.Size = new Size(137, 46);
            btnNop.TabIndex = 4;
            btnNop.Text = "Nộp";
            btnNop.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F);
            btnHuy.Location = new Point(444, 336);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(136, 46);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.72727F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(cbTrangThai, 1, 0);
            tableLayoutPanel2.Controls.Add(cbNguoiNop, 1, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(dateTimePicker1, 1, 2);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel2.Location = new Point(395, 65);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.68421F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.31579F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.Size = new Size(407, 241);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 56);
            label2.TabIndex = 0;
            label2.Text = "Trạng thái nộp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Size = new Size(73, 56);
            label4.TabIndex = 1;
            label4.Text = "Người nộp";
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(114, 3);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(262, 36);
            cbTrangThai.TabIndex = 2;
            // 
            // cbNguoiNop
            // 
            cbNguoiNop.FormattingEnabled = true;
            cbNguoiNop.Location = new Point(114, 103);
            cbNguoiNop.Name = "cbNguoiNop";
            cbNguoiNop.Size = new Size(262, 36);
            cbNguoiNop.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 186);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 4;
            label6.Text = "Ngày nộp";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(114, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(290, 34);
            dateTimePicker1.TabIndex = 5;
            // 
            // FrmNopDeTaiEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 485);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnNop);
            Controls.Add(btnHuy);
            Controls.Add(tableLayoutPanel2);
            Name = "FrmNopDeTaiEdit";
            Text = "FrmNopDeTaiEdit";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNop;
        private Button btnHuy;
        private Label label1;
        private Label label3;
        private Label label5;
        private ComboBox cbLoai;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private ComboBox cbTrangThai;
        private Label label4;
        private ComboBox cbNguoiNop;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbMa;
        private TextBox txtTen;
    }
}