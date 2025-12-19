namespace QLNCKH.Forms {
    partial class FrmDanhMuc {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            txtTen = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            cboDanhMuc = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnXoa = new ReaLTaiizor.Controls.Button();
            btnSua = new ReaLTaiizor.Controls.Button();
            btnThem = new ReaLTaiizor.Controls.Button();
            dgvDanhMuc = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(800, 450);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.556675F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.443325F));
            tableLayoutPanel3.Controls.Add(panel1, 1, 0);
            tableLayoutPanel3.Controls.Add(dgvDanhMuc, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(794, 444);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(457, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 444);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(txtTen, 0, 1);
            tableLayoutPanel5.Location = new Point(12, 50);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(316, 67);
            tableLayoutPanel5.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(310, 23);
            label2.TabIndex = 7;
            label2.Text = "Nhập dữ liệu cần thêm, sửa, hoặc xóa:";
            // 
            // txtTen
            // 
            txtTen.Dock = DockStyle.Fill;
            txtTen.Location = new Point(3, 36);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(310, 27);
            txtTen.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(cboDanhMuc, 1, 0);
            tableLayoutPanel4.Location = new Point(12, 9);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(316, 35);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 35);
            label1.TabIndex = 9;
            label1.Text = "Chọn danh mục:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.Dock = DockStyle.Fill;
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(146, 3);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(167, 28);
            cboDanhMuc.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnXoa, 2, 0);
            tableLayoutPanel1.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel1.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 359);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(4, 4, 4, 40);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(337, 85);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.BorderColor = Color.FromArgb(59, 130, 246);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.EnteredBorderColor = Color.FromArgb(37, 99, 235);
            btnXoa.EnteredColor = Color.FromArgb(37, 99, 235);
            btnXoa.Font = new Font("Tahoma", 11F);
            btnXoa.Image = null;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.InactiveColor = Color.FromArgb(59, 130, 246);
            btnXoa.Location = new Point(225, 7);
            btnXoa.Name = "btnXoa";
            btnXoa.PressedBorderColor = Color.FromArgb(37, 99, 235);
            btnXoa.PressedColor = Color.FromArgb(37, 99, 235);
            btnXoa.Size = new Size(105, 35);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlignment = StringAlignment.Center;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.BorderColor = Color.FromArgb(59, 130, 246);
            btnSua.Dock = DockStyle.Fill;
            btnSua.EnteredBorderColor = Color.FromArgb(37, 99, 235);
            btnSua.EnteredColor = Color.FromArgb(37, 99, 235);
            btnSua.Font = new Font("Tahoma", 11F);
            btnSua.Image = null;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.InactiveColor = Color.FromArgb(59, 130, 246);
            btnSua.Location = new Point(116, 7);
            btnSua.Name = "btnSua";
            btnSua.PressedBorderColor = Color.FromArgb(37, 99, 235);
            btnSua.PressedColor = Color.FromArgb(37, 99, 235);
            btnSua.Size = new Size(103, 35);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.TextAlignment = StringAlignment.Center;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.BorderColor = Color.FromArgb(59, 130, 246);
            btnThem.Dock = DockStyle.Fill;
            btnThem.EnteredBorderColor = Color.FromArgb(37, 99, 235);
            btnThem.EnteredColor = Color.FromArgb(37, 99, 235);
            btnThem.Font = new Font("Tahoma", 11F);
            btnThem.Image = null;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.InactiveColor = Color.FromArgb(59, 130, 246);
            btnThem.Location = new Point(7, 7);
            btnThem.Name = "btnThem";
            btnThem.PressedBorderColor = Color.FromArgb(37, 99, 235);
            btnThem.PressedColor = Color.FromArgb(37, 99, 235);
            btnThem.Size = new Size(103, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.TextAlignment = StringAlignment.Center;
            // 
            // dgvDanhMuc
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhMuc.Dock = DockStyle.Fill;
            dgvDanhMuc.Location = new Point(3, 3);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.Size = new Size(451, 438);
            dgvDanhMuc.TabIndex = 3;
            // 
            // FrmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "FrmDanhMuc";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelTxtBorder;
        private ReaLTaiizor.Controls.Button btnThem;
        private ReaLTaiizor.Controls.Button btnXoa;
        private ReaLTaiizor.Controls.Button btnSua;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
        private DataGridView dgvDanhMuc;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private ComboBox cboDanhMuc;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtTen;
    }
}