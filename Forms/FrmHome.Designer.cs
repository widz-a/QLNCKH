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
        private Panel pnlHeader;
        private Panel pnlContent;

        private TableLayoutPanel tblMetrics;

        private Panel pnlTongDeTai;
        private Panel pnlSinhVien;
        private Panel pnlGiangVien;

        private Label lblTongDeTaiTitle;
        private Label lblTongDeTaiValue;

        private Label lblSinhVienTitle;
        private Label lblSinhVienValue;

        private Label lblGiangVienTitle;
        private Label lblGiangVienValue;

        private void InitializeComponent()
        {
            pnlRoot = new Panel();
            pnlContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tblMetrics = new TableLayoutPanel();
            pnlTongDeTai = new Panel();
            lblTongDeTaiValue = new Label();
            lblTongDeTaiTitle = new Label();
            pnlSinhVien = new Panel();
            lblSinhVienValue = new Label();
            lblSinhVienTitle = new Label();
            pnlGiangVien = new Panel();
            lblGiangVienValue = new Label();
            lblGiangVienTitle = new Label();
            panel1 = new Panel();
            btnNopBai = new Button();
            pnlHeader = new Panel();
            label2 = new Label();
            flpGiaiThuong = new FlowLayoutPanel();
            pGiaiNhat = new Panel();
            lblGiaiNhatTitle = new Label();
            lblGiaiNhatValue = new Label();
            pGiaiNhi = new Panel();
            lblGiaiNhiValue = new Label();
            lblGiaiNhiTitle = new Label();
            pGiaiBa = new Panel();
            lblGiaiBaValue = new Label();
            lblGiaiBaTitle = new Label();
            pGiaiKK = new Panel();
            lblGiaiKKValue = new Label();
            lblGiaiKKTitle = new Label();
            pnlRoot.SuspendLayout();
            pnlContent.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblMetrics.SuspendLayout();
            pnlTongDeTai.SuspendLayout();
            pnlSinhVien.SuspendLayout();
            pnlGiangVien.SuspendLayout();
            panel1.SuspendLayout();
            pnlHeader.SuspendLayout();
            pGiaiNhat.SuspendLayout();
            pGiaiNhi.SuspendLayout();
            pGiaiBa.SuspendLayout();
            pGiaiKK.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoot
            // 
            pnlRoot.BackColor = Color.White;
            pnlRoot.Controls.Add(pnlContent);
            pnlRoot.Controls.Add(pnlHeader);
            pnlRoot.Dock = DockStyle.Fill;
            pnlRoot.Location = new Point(0, 0);
            pnlRoot.Name = "pnlRoot";
            pnlRoot.Size = new Size(816, 580);
            pnlRoot.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pGiaiNhat);
            pnlContent.Controls.Add(pGiaiNhi);
            pnlContent.Controls.Add(pGiaiKK);
            pnlContent.Controls.Add(pGiaiBa);
            pnlContent.Controls.Add(flpGiaiThuong);
            pnlContent.Controls.Add(tableLayoutPanel1);
            pnlContent.Controls.Add(tblMetrics);
            pnlContent.Controls.Add(panel1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(816, 510);
            pnlContent.TabIndex = 0;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(20, 440);
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
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(770, 30);
            label1.TabIndex = 1;
            label1.Text = "2025 © LamChan Corp - All right reserved\r\nHotline: 113 - Adress: 125, Tran Phu, Ha Dong, Ha Noi - Email: lamchan@wida.dev\r\n";
            label1.TextAlign = ContentAlignment.BottomCenter;
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
            // panel1
            // 
            panel1.Controls.Add(btnNopBai);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 2;
            // 
            // btnNopBai
            // 
            btnNopBai.Dock = DockStyle.Right;
            btnNopBai.Location = new Point(596, 20);
            btnNopBai.Name = "btnNopBai";
            btnNopBai.Size = new Size(160, 60);
            btnNopBai.TabIndex = 2;
            btnNopBai.Text = "➕ Nộp bài nghiên\r\n   cứu khoa học";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(label2);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20);
            pnlHeader.Size = new Size(816, 70);
            pnlHeader.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(607, 42);
            label2.TabIndex = 0;
            label2.Text = "Hệ thống hỗ trợ quản lý, theo dõi và tổng hợp hoạt động nghiên cứu khoa học\r\n tại Học viện An ninh Nhân dân.";
            // 
            // flpGiaiThuong
            // 
            flpGiaiThuong.Dock = DockStyle.Right;
            flpGiaiThuong.Location = new Point(420, 228);
            flpGiaiThuong.Name = "flpGiaiThuong";
            flpGiaiThuong.Padding = new Padding(10);
            flpGiaiThuong.Size = new Size(376, 212);
            flpGiaiThuong.TabIndex = 3;
            flpGiaiThuong.WrapContents = false;
            // 
            // pGiaiNhat
            // 
            pGiaiNhat.Controls.Add(lblGiaiNhatValue);
            pGiaiNhat.Controls.Add(lblGiaiNhatTitle);
            pGiaiNhat.Location = new Point(420, 311);
            pGiaiNhat.Name = "pGiaiNhat";
            pGiaiNhat.Size = new Size(200, 33);
            pGiaiNhat.TabIndex = 0;
            // 
            // lblGiaiNhatTitle
            // 
            lblGiaiNhatTitle.AutoSize = true;
            lblGiaiNhatTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiNhatTitle.Location = new Point(17, 9);
            lblGiaiNhatTitle.Name = "lblGiaiNhatTitle";
            lblGiaiNhatTitle.Size = new Size(77, 15);
            lblGiaiNhatTitle.TabIndex = 0;
            lblGiaiNhatTitle.Text = "\U0001f947 Giải Nhất:";
            // 
            // lblGiaiNhatValue
            // 
            lblGiaiNhatValue.AutoSize = true;
            lblGiaiNhatValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiNhatValue.Location = new Point(121, 4);
            lblGiaiNhatValue.Name = "lblGiaiNhatValue";
            lblGiaiNhatValue.Size = new Size(19, 21);
            lblGiaiNhatValue.TabIndex = 1;
            lblGiaiNhatValue.Text = "0";
            // 
            // pGiaiNhi
            // 
            pGiaiNhi.Controls.Add(lblGiaiNhiValue);
            pGiaiNhi.Controls.Add(lblGiaiNhiTitle);
            pGiaiNhi.Location = new Point(420, 343);
            pGiaiNhi.Name = "pGiaiNhi";
            pGiaiNhi.Size = new Size(200, 33);
            pGiaiNhi.TabIndex = 1;
            // 
            // lblGiaiNhiValue
            // 
            lblGiaiNhiValue.AutoSize = true;
            lblGiaiNhiValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiNhiValue.Location = new Point(121, 4);
            lblGiaiNhiValue.Name = "lblGiaiNhiValue";
            lblGiaiNhiValue.Size = new Size(19, 21);
            lblGiaiNhiValue.TabIndex = 1;
            lblGiaiNhiValue.Text = "0";
            // 
            // lblGiaiNhiTitle
            // 
            lblGiaiNhiTitle.AutoSize = true;
            lblGiaiNhiTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiNhiTitle.Location = new Point(17, 9);
            lblGiaiNhiTitle.Name = "lblGiaiNhiTitle";
            lblGiaiNhiTitle.Size = new Size(69, 15);
            lblGiaiNhiTitle.TabIndex = 0;
            lblGiaiNhiTitle.Text = "\U0001f948 Giải Nhì:";
            // 
            // pGiaiBa
            // 
            pGiaiBa.Controls.Add(lblGiaiBaValue);
            pGiaiBa.Controls.Add(lblGiaiBaTitle);
            pGiaiBa.Location = new Point(420, 375);
            pGiaiBa.Name = "pGiaiBa";
            pGiaiBa.Size = new Size(200, 33);
            pGiaiBa.TabIndex = 1;
            // 
            // lblGiaiBaValue
            // 
            lblGiaiBaValue.AutoSize = true;
            lblGiaiBaValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiBaValue.Location = new Point(121, 4);
            lblGiaiBaValue.Name = "lblGiaiBaValue";
            lblGiaiBaValue.Size = new Size(19, 21);
            lblGiaiBaValue.TabIndex = 1;
            lblGiaiBaValue.Text = "0";
            // 
            // lblGiaiBaTitle
            // 
            lblGiaiBaTitle.AutoSize = true;
            lblGiaiBaTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiBaTitle.Location = new Point(17, 9);
            lblGiaiBaTitle.Name = "lblGiaiBaTitle";
            lblGiaiBaTitle.Size = new Size(64, 15);
            lblGiaiBaTitle.TabIndex = 0;
            lblGiaiBaTitle.Text = "\U0001f949 Giải Ba:";
            // 
            // pGiaiKK
            // 
            pGiaiKK.Controls.Add(lblGiaiKKValue);
            pGiaiKK.Controls.Add(lblGiaiKKTitle);
            pGiaiKK.Location = new Point(420, 407);
            pGiaiKK.Name = "pGiaiKK";
            pGiaiKK.Size = new Size(200, 33);
            pGiaiKK.TabIndex = 2;
            // 
            // lblGiaiKKValue
            // 
            lblGiaiKKValue.AutoSize = true;
            lblGiaiKKValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiKKValue.Location = new Point(121, 4);
            lblGiaiKKValue.Name = "lblGiaiKKValue";
            lblGiaiKKValue.Size = new Size(19, 21);
            lblGiaiKKValue.TabIndex = 1;
            lblGiaiKKValue.Text = "0";
            // 
            // lblGiaiKKTitle
            // 
            lblGiaiKKTitle.AutoSize = true;
            lblGiaiKKTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaiKKTitle.Location = new Point(17, 9);
            lblGiaiKKTitle.Name = "lblGiaiKKTitle";
            lblGiaiKKTitle.Size = new Size(101, 15);
            lblGiaiKKTitle.TabIndex = 0;
            lblGiaiKKTitle.Text = "🎖 Khuyến khích:";
            // 
            // FrmHome
            // 
            ClientSize = new Size(816, 580);
            Controls.Add(pnlRoot);
            Name = "FrmHome";
            Text = "Trang chủ";
            pnlRoot.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tblMetrics.ResumeLayout(false);
            pnlTongDeTai.ResumeLayout(false);
            pnlSinhVien.ResumeLayout(false);
            pnlGiangVien.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pGiaiNhat.ResumeLayout(false);
            pGiaiNhat.PerformLayout();
            pGiaiNhi.ResumeLayout(false);
            pGiaiNhi.PerformLayout();
            pGiaiBa.ResumeLayout(false);
            pGiaiBa.PerformLayout();
            pGiaiKK.ResumeLayout(false);
            pGiaiKK.PerformLayout();
            ResumeLayout(false);
        }
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnNopBai;
        private FlowLayoutPanel flpGiaiThuong;
        private Panel pGiaiBa;
        private Label lblGiaiBaValue;
        private Label lblGiaiBaTitle;
        private Panel pGiaiNhi;
        private Label lblGiaiNhiValue;
        private Label lblGiaiNhiTitle;
        private Panel pGiaiNhat;
        private Label lblGiaiNhatValue;
        private Label lblGiaiNhatTitle;
        private Panel pGiaiKK;
        private Label lblGiaiKKValue;
        private Label lblGiaiKKTitle;
    }
}
