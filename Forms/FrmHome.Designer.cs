namespace QLNCKH.Forms
{
    partial class FrmHome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        private Panel pnlRoot;

        private void InitializeComponent() {
            pnlRoot = new Panel();
            panel1 = new Panel();
            tblMetrics = new TableLayoutPanel();
            pnlGiangVien = new Panel();
            lblGiangVienTitle = new Label();
            lblGiangVienValue = new Label();
            pnlSinhVien = new Panel();
            lblSinhVienTitle = new Label();
            lblSinhVienValue = new Label();
            pnlTongDeTai = new Panel();
            lblTongDeTaiTitle = new Label();
            lblTongDeTaiValue = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            label6 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDkDT = new Button();
            btnDkCD = new Button();
            btnNopBai = new Button();
            btnKQ = new Button();
            panel2 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            pGiaiNhat = new Panel();
            lblGiaiNhatTitle = new Label();
            lblGiaiNhatValue = new Label();
            pGiaiNhi = new Panel();
            lblGiaiNhiTitle = new Label();
            lblGiaiNhiValue = new Label();
            pGiaiBa = new Panel();
            lblGiaiBaTitle = new Label();
            lblGiaiBaValue = new Label();
            pGiaiKK = new Panel();
            lblGiaiKKTitle = new Label();
            lblGiaiKKValue = new Label();
            pnlContent = new Panel();
            pnlRoot.SuspendLayout();
            tblMetrics.SuspendLayout();
            pnlGiangVien.SuspendLayout();
            pnlSinhVien.SuspendLayout();
            pnlTongDeTai.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            pGiaiNhat.SuspendLayout();
            pGiaiNhi.SuspendLayout();
            pGiaiBa.SuspendLayout();
            pGiaiKK.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoot
            // 
            pnlRoot.BackColor = Color.White;
            pnlRoot.Controls.Add(pnlContent);
            pnlRoot.Dock = DockStyle.Fill;
            pnlRoot.Location = new Point(0, 0);
            pnlRoot.Name = "pnlRoot";
            pnlRoot.Size = new Size(816, 580);
            pnlRoot.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 2;
            // 
            // tblMetrics
            // 
            tblMetrics.ColumnCount = 3;
            tblMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMetrics.Controls.Add(pnlTongDeTai, 0, 0);
            tblMetrics.Controls.Add(pnlSinhVien, 1, 0);
            tblMetrics.Controls.Add(pnlGiangVien, 2, 0);
            tblMetrics.Dock = DockStyle.Top;
            tblMetrics.Location = new Point(20, 120);
            tblMetrics.Name = "tblMetrics";
            tblMetrics.RowCount = 1;
            tblMetrics.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMetrics.Size = new Size(776, 108);
            tblMetrics.TabIndex = 0;
            // 
            // pnlGiangVien
            // 
            pnlGiangVien.BorderStyle = BorderStyle.FixedSingle;
            pnlGiangVien.Controls.Add(lblGiangVienValue);
            pnlGiangVien.Controls.Add(lblGiangVienTitle);
            pnlGiangVien.Dock = DockStyle.Fill;
            pnlGiangVien.Location = new Point(521, 5);
            pnlGiangVien.Margin = new Padding(5);
            pnlGiangVien.Name = "pnlGiangVien";
            pnlGiangVien.Size = new Size(250, 98);
            pnlGiangVien.TabIndex = 2;
            // 
            // lblGiangVienTitle
            // 
            lblGiangVienTitle.Dock = DockStyle.Top;
            lblGiangVienTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGiangVienTitle.Location = new Point(0, 0);
            lblGiangVienTitle.Name = "lblGiangVienTitle";
            lblGiangVienTitle.Padding = new Padding(10, 8, 0, 0);
            lblGiangVienTitle.Size = new Size(248, 38);
            lblGiangVienTitle.TabIndex = 1;
            lblGiangVienTitle.Text = "GIẢNG VIÊN";
            // 
            // lblGiangVienValue
            // 
            lblGiangVienValue.Dock = DockStyle.Fill;
            lblGiangVienValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblGiangVienValue.Location = new Point(0, 38);
            lblGiangVienValue.Name = "lblGiangVienValue";
            lblGiangVienValue.Padding = new Padding(10, 0, 0, 0);
            lblGiangVienValue.Size = new Size(248, 58);
            lblGiangVienValue.TabIndex = 0;
            lblGiangVienValue.Text = "0";
            lblGiangVienValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSinhVien
            // 
            pnlSinhVien.BorderStyle = BorderStyle.FixedSingle;
            pnlSinhVien.Controls.Add(lblSinhVienValue);
            pnlSinhVien.Controls.Add(lblSinhVienTitle);
            pnlSinhVien.Dock = DockStyle.Fill;
            pnlSinhVien.Location = new Point(263, 5);
            pnlSinhVien.Margin = new Padding(5);
            pnlSinhVien.Name = "pnlSinhVien";
            pnlSinhVien.Size = new Size(248, 98);
            pnlSinhVien.TabIndex = 1;
            // 
            // lblSinhVienTitle
            // 
            lblSinhVienTitle.Dock = DockStyle.Top;
            lblSinhVienTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSinhVienTitle.Location = new Point(0, 0);
            lblSinhVienTitle.Name = "lblSinhVienTitle";
            lblSinhVienTitle.Padding = new Padding(10, 8, 0, 0);
            lblSinhVienTitle.Size = new Size(246, 38);
            lblSinhVienTitle.TabIndex = 1;
            lblSinhVienTitle.Text = "SINH VIÊN";
            // 
            // lblSinhVienValue
            // 
            lblSinhVienValue.Dock = DockStyle.Fill;
            lblSinhVienValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSinhVienValue.Location = new Point(0, 38);
            lblSinhVienValue.Name = "lblSinhVienValue";
            lblSinhVienValue.Padding = new Padding(10, 0, 0, 0);
            lblSinhVienValue.Size = new Size(246, 58);
            lblSinhVienValue.TabIndex = 0;
            lblSinhVienValue.Text = "0";
            lblSinhVienValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTongDeTai
            // 
            pnlTongDeTai.BorderStyle = BorderStyle.FixedSingle;
            pnlTongDeTai.Controls.Add(lblTongDeTaiValue);
            pnlTongDeTai.Controls.Add(lblTongDeTaiTitle);
            pnlTongDeTai.Dock = DockStyle.Fill;
            pnlTongDeTai.Location = new Point(5, 5);
            pnlTongDeTai.Margin = new Padding(5);
            pnlTongDeTai.Name = "pnlTongDeTai";
            pnlTongDeTai.Size = new Size(248, 98);
            pnlTongDeTai.TabIndex = 0;
            // 
            // lblTongDeTaiTitle
            // 
            lblTongDeTaiTitle.Dock = DockStyle.Top;
            lblTongDeTaiTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongDeTaiTitle.Location = new Point(0, 0);
            lblTongDeTaiTitle.Name = "lblTongDeTaiTitle";
            lblTongDeTaiTitle.Padding = new Padding(10, 8, 0, 0);
            lblTongDeTaiTitle.Size = new Size(246, 38);
            lblTongDeTaiTitle.TabIndex = 1;
            lblTongDeTaiTitle.Text = "TỔNG ĐỀ TÀI";
            // 
            // lblTongDeTaiValue
            // 
            lblTongDeTaiValue.Dock = DockStyle.Fill;
            lblTongDeTaiValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTongDeTaiValue.Location = new Point(0, 38);
            lblTongDeTaiValue.Name = "lblTongDeTaiValue";
            lblTongDeTaiValue.Padding = new Padding(10, 0, 0, 0);
            lblTongDeTaiValue.Size = new Size(246, 58);
            lblTongDeTaiValue.TabIndex = 0;
            lblTongDeTaiValue.Text = "0";
            lblTongDeTaiValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(20, 510);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(776, 50);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(770, 40);
            label1.TabIndex = 1;
            label1.Text = "2025 © LamChan Corp - All right reserved\r\nHotline: 113 - Adress: 125, Tran Phu, Ha Dong, Ha Noi - Email: lamchan@wida.dev\r\n";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9175262F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.0824738F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(20, 228);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(776, 206);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(307, 5);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(464, 196);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 8, 0, 0);
            label6.Size = new Size(462, 38);
            label6.TabIndex = 1;
            label6.Text = "CHỨC NĂNG NHANH";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnKQ, 1, 1);
            tableLayoutPanel3.Controls.Add(btnNopBai, 0, 1);
            tableLayoutPanel3.Controls.Add(btnDkCD, 1, 0);
            tableLayoutPanel3.Controls.Add(btnDkDT, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 38);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(462, 156);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnDkDT
            // 
            btnDkDT.Dock = DockStyle.Fill;
            btnDkDT.Location = new Point(10, 10);
            btnDkDT.Margin = new Padding(10);
            btnDkDT.Name = "btnDkDT";
            btnDkDT.Size = new Size(211, 58);
            btnDkDT.TabIndex = 2;
            btnDkDT.Text = "➕ Đăng kí đề tài";
            // 
            // btnDkCD
            // 
            btnDkCD.Dock = DockStyle.Fill;
            btnDkCD.Location = new Point(241, 10);
            btnDkCD.Margin = new Padding(10);
            btnDkCD.Name = "btnDkCD";
            btnDkCD.Size = new Size(211, 58);
            btnDkCD.TabIndex = 3;
            btnDkCD.Text = "➕ Đăng kí chuyên đề";
            // 
            // btnNopBai
            // 
            btnNopBai.Dock = DockStyle.Fill;
            btnNopBai.Location = new Point(10, 88);
            btnNopBai.Margin = new Padding(10);
            btnNopBai.Name = "btnNopBai";
            btnNopBai.Size = new Size(211, 58);
            btnNopBai.TabIndex = 4;
            btnNopBai.Text = "➕ Nộp sản phẩm";
            // 
            // btnKQ
            // 
            btnKQ.Dock = DockStyle.Fill;
            btnKQ.Location = new Point(241, 88);
            btnKQ.Margin = new Padding(10);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(211, 58);
            btnKQ.TabIndex = 5;
            btnKQ.Text = "➕ Xem kết quả";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 5);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 196);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 8, 0, 0);
            label4.Size = new Size(290, 38);
            label4.TabIndex = 3;
            label4.Text = "THỐNG KÊ GIẢI THƯỞNG";
            // 
            // panel4
            // 
            panel4.Controls.Add(pGiaiKK);
            panel4.Controls.Add(pGiaiBa);
            panel4.Controls.Add(pGiaiNhi);
            panel4.Controls.Add(pGiaiNhat);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(290, 156);
            panel4.TabIndex = 4;
            // 
            // pGiaiNhat
            // 
            pGiaiNhat.Controls.Add(lblGiaiNhatValue);
            pGiaiNhat.Controls.Add(lblGiaiNhatTitle);
            pGiaiNhat.Dock = DockStyle.Top;
            pGiaiNhat.Location = new Point(0, 0);
            pGiaiNhat.Name = "pGiaiNhat";
            pGiaiNhat.Size = new Size(290, 33);
            pGiaiNhat.TabIndex = 0;
            // 
            // lblGiaiNhatTitle
            // 
            lblGiaiNhatTitle.AutoSize = true;
            lblGiaiNhatTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiNhatTitle.Location = new Point(17, 9);
            lblGiaiNhatTitle.Name = "lblGiaiNhatTitle";
            lblGiaiNhatTitle.Size = new Size(105, 20);
            lblGiaiNhatTitle.TabIndex = 0;
            lblGiaiNhatTitle.Text = "\U0001f947 Giải Nhất:";
            // 
            // lblGiaiNhatValue
            // 
            lblGiaiNhatValue.AutoSize = true;
            lblGiaiNhatValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiNhatValue.Location = new Point(121, 4);
            lblGiaiNhatValue.Name = "lblGiaiNhatValue";
            lblGiaiNhatValue.Size = new Size(24, 28);
            lblGiaiNhatValue.TabIndex = 1;
            lblGiaiNhatValue.Text = "0";
            // 
            // pGiaiNhi
            // 
            pGiaiNhi.Controls.Add(lblGiaiNhiValue);
            pGiaiNhi.Controls.Add(lblGiaiNhiTitle);
            pGiaiNhi.Dock = DockStyle.Top;
            pGiaiNhi.Location = new Point(0, 33);
            pGiaiNhi.Name = "pGiaiNhi";
            pGiaiNhi.Size = new Size(290, 33);
            pGiaiNhi.TabIndex = 1;
            // 
            // lblGiaiNhiTitle
            // 
            lblGiaiNhiTitle.AutoSize = true;
            lblGiaiNhiTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiNhiTitle.Location = new Point(17, 9);
            lblGiaiNhiTitle.Name = "lblGiaiNhiTitle";
            lblGiaiNhiTitle.Size = new Size(95, 20);
            lblGiaiNhiTitle.TabIndex = 0;
            lblGiaiNhiTitle.Text = "\U0001f948 Giải Nhì:";
            // 
            // lblGiaiNhiValue
            // 
            lblGiaiNhiValue.AutoSize = true;
            lblGiaiNhiValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiNhiValue.Location = new Point(121, 4);
            lblGiaiNhiValue.Name = "lblGiaiNhiValue";
            lblGiaiNhiValue.Size = new Size(24, 28);
            lblGiaiNhiValue.TabIndex = 1;
            lblGiaiNhiValue.Text = "0";
            // 
            // pGiaiBa
            // 
            pGiaiBa.Controls.Add(lblGiaiBaValue);
            pGiaiBa.Controls.Add(lblGiaiBaTitle);
            pGiaiBa.Dock = DockStyle.Top;
            pGiaiBa.Location = new Point(0, 66);
            pGiaiBa.Name = "pGiaiBa";
            pGiaiBa.Size = new Size(290, 33);
            pGiaiBa.TabIndex = 1;
            // 
            // lblGiaiBaTitle
            // 
            lblGiaiBaTitle.AutoSize = true;
            lblGiaiBaTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiBaTitle.Location = new Point(17, 9);
            lblGiaiBaTitle.Name = "lblGiaiBaTitle";
            lblGiaiBaTitle.Size = new Size(88, 20);
            lblGiaiBaTitle.TabIndex = 0;
            lblGiaiBaTitle.Text = "\U0001f949 Giải Ba:";
            // 
            // lblGiaiBaValue
            // 
            lblGiaiBaValue.AutoSize = true;
            lblGiaiBaValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiBaValue.Location = new Point(121, 4);
            lblGiaiBaValue.Name = "lblGiaiBaValue";
            lblGiaiBaValue.Size = new Size(24, 28);
            lblGiaiBaValue.TabIndex = 1;
            lblGiaiBaValue.Text = "0";
            // 
            // pGiaiKK
            // 
            pGiaiKK.Controls.Add(lblGiaiKKValue);
            pGiaiKK.Controls.Add(lblGiaiKKTitle);
            pGiaiKK.Dock = DockStyle.Top;
            pGiaiKK.Location = new Point(0, 99);
            pGiaiKK.Name = "pGiaiKK";
            pGiaiKK.Size = new Size(290, 33);
            pGiaiKK.TabIndex = 2;
            // 
            // lblGiaiKKTitle
            // 
            lblGiaiKKTitle.AutoSize = true;
            lblGiaiKKTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiKKTitle.Location = new Point(17, 9);
            lblGiaiKKTitle.Name = "lblGiaiKKTitle";
            lblGiaiKKTitle.Size = new Size(90, 20);
            lblGiaiKKTitle.TabIndex = 0;
            lblGiaiKKTitle.Text = "🎖 Giải KK:";
            // 
            // lblGiaiKKValue
            // 
            lblGiaiKKValue.AutoSize = true;
            lblGiaiKKValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiKKValue.Location = new Point(121, 4);
            lblGiaiKKValue.Name = "lblGiaiKKValue";
            lblGiaiKKValue.Size = new Size(24, 28);
            lblGiaiKKValue.TabIndex = 1;
            lblGiaiKKValue.Text = "0";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Transparent;
            pnlContent.Controls.Add(tableLayoutPanel2);
            pnlContent.Controls.Add(tableLayoutPanel1);
            pnlContent.Controls.Add(tblMetrics);
            pnlContent.Controls.Add(panel1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(816, 580);
            pnlContent.TabIndex = 0;
            // 
            // FrmHome
            // 
            AutoScroll = true;
            ClientSize = new Size(816, 580);
            Controls.Add(pnlRoot);
            Name = "FrmHome";
            Text = "Trang chủ";
            pnlRoot.ResumeLayout(false);
            tblMetrics.ResumeLayout(false);
            pnlGiangVien.ResumeLayout(false);
            pnlSinhVien.ResumeLayout(false);
            pnlTongDeTai.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pGiaiNhat.ResumeLayout(false);
            pGiaiNhat.PerformLayout();
            pGiaiNhi.ResumeLayout(false);
            pGiaiNhi.PerformLayout();
            pGiaiBa.ResumeLayout(false);
            pGiaiBa.PerformLayout();
            pGiaiKK.ResumeLayout(false);
            pGiaiKK.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel pnlContent;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel4;
        private Panel pGiaiKK;
        private Label lblGiaiKKValue;
        private Label lblGiaiKKTitle;
        private Panel pGiaiBa;
        private Label lblGiaiBaValue;
        private Label lblGiaiBaTitle;
        private Panel pGiaiNhi;
        private Label lblGiaiNhiValue;
        private Label lblGiaiNhiTitle;
        private Panel pGiaiNhat;
        private Label lblGiaiNhatValue;
        private Label lblGiaiNhatTitle;
        private Label label4;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnKQ;
        private Button btnNopBai;
        private Button btnDkCD;
        private Button btnDkDT;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tblMetrics;
        private Panel pnlTongDeTai;
        private Label lblTongDeTaiValue;
        private Label lblTongDeTaiTitle;
        private Panel pnlSinhVien;
        private Label lblSinhVienValue;
        private Label lblSinhVienTitle;
        private Panel pnlGiangVien;
        private Label lblGiangVienValue;
        private Label lblGiangVienTitle;
        private Panel panel1;
    }
}
