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
        private void InitializeComponent() {
            tableLayoutPanel3 = new TableLayoutPanel();
            cbMa = new ComboBox();
            cbNguoiNop = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            cbLoai = new ComboBox();
            cbTrangThai = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4387741F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.5612259F));
            tableLayoutPanel3.Controls.Add(cbMa, 1, 0);
            tableLayoutPanel3.Controls.Add(cbNguoiNop, 1, 1);
            tableLayoutPanel3.Controls.Add(label7, 0, 1);
            tableLayoutPanel3.Controls.Add(label8, 0, 0);
            tableLayoutPanel3.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel3.Location = new Point(409, 24);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(392, 78);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // cbMa
            // 
            cbMa.Dock = DockStyle.Fill;
            cbMa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbMa.FormattingEnabled = true;
            cbMa.Location = new Point(137, 6);
            cbMa.Margin = new Padding(3, 6, 3, 6);
            cbMa.Name = "cbMa";
            cbMa.Size = new Size(252, 27);
            cbMa.TabIndex = 45;
            // 
            // cbNguoiNop
            // 
            cbNguoiNop.Dock = DockStyle.Fill;
            cbNguoiNop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNguoiNop.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbNguoiNop.FormattingEnabled = true;
            cbNguoiNop.Location = new Point(137, 45);
            cbNguoiNop.Margin = new Padding(3, 6, 3, 6);
            cbNguoiNop.Name = "cbNguoiNop";
            cbNguoiNop.Size = new Size(252, 27);
            cbNguoiNop.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(3, 39);
            label7.Name = "label7";
            label7.Size = new Size(128, 39);
            label7.TabIndex = 9;
            label7.Text = "Người nộp:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 39);
            label8.TabIndex = 8;
            label8.Text = "Sản phẩm:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnLuu, 0, 0);
            tableLayoutPanel5.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanel5.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel5.Location = new Point(595, 113);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(203, 36);
            tableLayoutPanel5.TabIndex = 12;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.9287834F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.0712166F));
            tableLayoutPanel4.Controls.Add(cbLoai, 1, 0);
            tableLayoutPanel4.Controls.Add(cbTrangThai, 1, 1);
            tableLayoutPanel4.Controls.Add(label9, 0, 1);
            tableLayoutPanel4.Controls.Add(label10, 0, 0);
            tableLayoutPanel4.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel4.Location = new Point(45, 24);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(337, 125);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // cbLoai
            // 
            cbLoai.Dock = DockStyle.Fill;
            cbLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoai.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbLoai.FormattingEnabled = true;
            cbLoai.Location = new Point(178, 6);
            cbLoai.Margin = new Padding(3, 6, 3, 6);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(156, 27);
            cbLoai.TabIndex = 43;
            // 
            // cbTrangThai
            // 
            cbTrangThai.Dock = DockStyle.Fill;
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThai.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(178, 45);
            cbTrangThai.Margin = new Padding(3, 6, 3, 6);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(156, 27);
            cbTrangThai.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(3, 39);
            label9.Name = "label9";
            label9.Size = new Size(169, 39);
            label9.TabIndex = 9;
            label9.Text = "Trạng thái:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(169, 39);
            label10.TabIndex = 8;
            label10.Text = "Chọn loại sản phẩm:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmNopDeTaiEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 485);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel4);
            Name = "FrmNopDeTaiEdit";
            Text = "FrmNopDeTaiEdit";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label label3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox cbLoai;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnLuu;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox cbTrangThai;
        private Label label9;
        private Label label10;
        private ComboBox cbNguoiNop;
        private ComboBox cbMa;
        private Label label11;
    }
}