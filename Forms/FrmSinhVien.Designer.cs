namespace QLNCKH.Forms {
    partial class FrmSinhVien {
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
            dgvSinhVien = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnXoa = new ReaLTaiizor.Controls.Button();
            btnSua = new ReaLTaiizor.Controls.Button();
            btnThem = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Dock = DockStyle.Top;
            dgvSinhVien.Location = new Point(0, 0);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(800, 340);
            dgvSinhVien.TabIndex = 0;
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
            tableLayoutPanel1.Location = new Point(487, 381);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(4);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(301, 48);
            tableLayoutPanel1.TabIndex = 9;
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
            btnXoa.Location = new Point(201, 7);
            btnXoa.Name = "btnXoa";
            btnXoa.PressedBorderColor = Color.FromArgb(37, 99, 235);
            btnXoa.PressedColor = Color.FromArgb(37, 99, 235);
            btnXoa.Size = new Size(93, 34);
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
            btnSua.Location = new Point(104, 7);
            btnSua.Name = "btnSua";
            btnSua.PressedBorderColor = Color.FromArgb(37, 99, 235);
            btnSua.PressedColor = Color.FromArgb(37, 99, 235);
            btnSua.Size = new Size(91, 34);
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
            btnThem.Size = new Size(91, 34);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.TextAlignment = StringAlignment.Center;
            // 
            // FrmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvSinhVien);
            Name = "FrmSinhVien";
            Text = "FrmSinhVien";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSinhVien;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Button btnXoa;
        private ReaLTaiizor.Controls.Button btnSua;
        private ReaLTaiizor.Controls.Button btnThem;
    }
}