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
        private Button btnNopBai;

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

        private void InitializeComponent() {
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
            pnlHeader = new Panel();
            btnNopBai = new Button();
            pnlRoot.SuspendLayout();
            pnlContent.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblMetrics.SuspendLayout();
            pnlTongDeTai.SuspendLayout();
            pnlSinhVien.SuspendLayout();
            pnlGiangVien.SuspendLayout();
            pnlHeader.SuspendLayout();
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
            pnlContent.Controls.Add(tableLayoutPanel1);
            pnlContent.Controls.Add(tblMetrics);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(816, 510);
            pnlContent.TabIndex = 0;
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
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(770, 40);
            label1.TabIndex = 1;
            label1.Text = "2025 © LamChan Corp - All right reserved\r\nHotline: 113 - Adress: 125, Tran Phu, Ha Dong, Ha Noi - Email: lamchan@wida.dev\r\n";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tblMetrics
            // 
            tblMetrics.ColumnCount = 3;
            tblMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblMetrics.Controls.Add(pnlTongDeTai, 0, 0);
            tblMetrics.Controls.Add(pnlSinhVien, 1, 0);
            tblMetrics.Controls.Add(pnlGiangVien, 2, 0);
            tblMetrics.Dock = DockStyle.Top;
            tblMetrics.Location = new Point(20, 20);
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
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(btnNopBai);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20);
            pnlHeader.Size = new Size(816, 70);
            pnlHeader.TabIndex = 1;
            // 
            // btnNopBai
            // 
            btnNopBai.Dock = DockStyle.Right;
            btnNopBai.Location = new Point(636, 20);
            btnNopBai.Name = "btnNopBai";
            btnNopBai.Size = new Size(160, 30);
            btnNopBai.TabIndex = 1;
            btnNopBai.Text = "➕ Nộp bài";
            // 
            // FrmHome
            // 
            AutoScroll = true;
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
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}
