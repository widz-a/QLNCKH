namespace QLNCKH.Forms {
    partial class FrmChamDiemDt {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChamDiemDt));
            tableLayoutPanel5 = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            title = new ReaLTaiizor.Controls.FoxBigLabel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tbDeTai = new TextBox();
            tbHoiDong = new TextBox();
            listView1 = new ListView();
            dtStt = new ColumnHeader();
            dtMa = new ColumnHeader();
            dtTen = new ColumnHeader();
            dtDiem = new ColumnHeader();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            title.Text = "Phiếu chấm điểm đề tài";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 36);
            label1.TabIndex = 8;
            label1.Text = "Hội đồng:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3964815F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.6035156F));
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(tbDeTai, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tbHoiDong, 1, 0);
            tableLayoutPanel2.Font = new Font("Tahoma", 10.8F);
            tableLayoutPanel2.Location = new Point(29, 76);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.Size = new Size(739, 73);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(93, 37);
            label2.TabIndex = 10;
            label2.Text = "Đề tài:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbDeTai
            // 
            tbDeTai.BackColor = SystemColors.Window;
            tbDeTai.Dock = DockStyle.Fill;
            tbDeTai.Enabled = false;
            tbDeTai.Font = new Font("Segoe UI", 10.2F);
            tbDeTai.Location = new Point(102, 39);
            tbDeTai.Name = "tbDeTai";
            tbDeTai.ReadOnly = true;
            tbDeTai.Size = new Size(634, 30);
            tbDeTai.TabIndex = 11;
            tbDeTai.TabStop = false;
            // 
            // tbHoiDong
            // 
            tbHoiDong.BackColor = SystemColors.Window;
            tbHoiDong.Dock = DockStyle.Fill;
            tbHoiDong.Enabled = false;
            tbHoiDong.Font = new Font("Segoe UI", 10.2F);
            tbHoiDong.Location = new Point(102, 3);
            tbHoiDong.Name = "tbHoiDong";
            tbHoiDong.ReadOnly = true;
            tbHoiDong.Size = new Size(634, 30);
            tbHoiDong.TabIndex = 9;
            tbHoiDong.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { dtStt, dtMa, dtTen, dtDiem });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(91, 158);
            listView1.Margin = new Padding(10);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(625, 174);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            dtTen.Width = 350;
            // 
            // dtDiem
            // 
            dtDiem.Text = "Điểm";
            // 
            // FrmChamDiemDt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(title);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmChamDiemDt";
            Text = "Phiếu chấm điểm đề tài";
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private TextBox tbDeTai;
        private ListView listView1;
        private ColumnHeader dtStt;
        private ColumnHeader dtMa;
        private ColumnHeader dtTen;
        private ColumnHeader dtDiem;
    }
}