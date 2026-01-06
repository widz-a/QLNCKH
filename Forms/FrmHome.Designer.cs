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
            pnlContent = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialCard5 = new ReaLTaiizor.Controls.MaterialCard();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDkDT = new Button();
            btnKQ = new Button();
            btnNopBai = new Button();
            btnDkCD = new Button();
            label6 = new Label();
            materialCard4 = new ReaLTaiizor.Controls.MaterialCard();
            panel4 = new Panel();
            pGiaiKK = new Panel();
            lblGiaiKKValue = new Label();
            lblGiaiKKTitle = new Label();
            pGiaiBa = new Panel();
            lblGiaiBaValue = new Label();
            lblGiaiBaTitle = new Label();
            pGiaiNhi = new Panel();
            lblGiaiNhiValue = new Label();
            lblGiaiNhiTitle = new Label();
            pGiaiNhat = new Panel();
            lblGiaiNhatValue = new Label();
            lblGiaiNhatTitle = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tblMetrics = new TableLayoutPanel();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            lblGiangVienValue = new Label();
            lblGiangVienTitle = new Label();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            lblSinhVienValue = new Label();
            lblSinhVienTitle = new Label();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            lblTongDeTaiValue = new Label();
            lblTongDeTaiTitle = new Label();
            panel1 = new Panel();
            pnlRoot.SuspendLayout();
            pnlContent.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            materialCard5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            materialCard4.SuspendLayout();
            panel4.SuspendLayout();
            pGiaiKK.SuspendLayout();
            pGiaiBa.SuspendLayout();
            pGiaiNhi.SuspendLayout();
            pGiaiNhat.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblMetrics.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9175262F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.0824738F));
            tableLayoutPanel2.Controls.Add(materialCard5, 1, 0);
            tableLayoutPanel2.Controls.Add(materialCard4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(20, 240);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(776, 201);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(tableLayoutPanel3);
            materialCard5.Controls.Add(label6);
            materialCard5.Depth = 0;
            materialCard5.Dock = DockStyle.Fill;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(312, 10);
            materialCard5.Margin = new Padding(10);
            materialCard5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(10, 5, 10, 5);
            materialCard5.Size = new Size(454, 181);
            materialCard5.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnDkDT, 0, 0);
            tableLayoutPanel3.Controls.Add(btnKQ, 1, 1);
            tableLayoutPanel3.Controls.Add(btnNopBai, 0, 1);
            tableLayoutPanel3.Controls.Add(btnDkCD, 1, 0);
            tableLayoutPanel3.Location = new Point(10, 50);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(434, 111);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // btnDkDT
            // 
            btnDkDT.Dock = DockStyle.Fill;
            btnDkDT.Font = new Font("Segoe UI", 8F);
            btnDkDT.Location = new Point(10, 0);
            btnDkDT.Margin = new Padding(10, 0, 10, 10);
            btnDkDT.Name = "btnDkDT";
            btnDkDT.Size = new Size(197, 45);
            btnDkDT.TabIndex = 6;
            btnDkDT.Text = "📝 Đăng kí đề tài";
            // 
            // btnKQ
            // 
            btnKQ.Dock = DockStyle.Fill;
            btnKQ.Font = new Font("Segoe UI", 8F);
            btnKQ.Location = new Point(227, 55);
            btnKQ.Margin = new Padding(10, 0, 10, 10);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(197, 46);
            btnKQ.TabIndex = 5;
            btnKQ.Text = "📊 Xem kết quả";
            // 
            // btnNopBai
            // 
            btnNopBai.Dock = DockStyle.Fill;
            btnNopBai.Font = new Font("Segoe UI", 8F);
            btnNopBai.Location = new Point(10, 55);
            btnNopBai.Margin = new Padding(10, 0, 10, 10);
            btnNopBai.Name = "btnNopBai";
            btnNopBai.Size = new Size(197, 46);
            btnNopBai.TabIndex = 4;
            btnNopBai.Text = "➕ Nộp sản phẩm";
            // 
            // btnDkCD
            // 
            btnDkCD.Dock = DockStyle.Fill;
            btnDkCD.Font = new Font("Segoe UI", 8F);
            btnDkCD.Location = new Point(227, 0);
            btnDkCD.Margin = new Padding(10, 0, 10, 10);
            btnDkCD.Name = "btnDkCD";
            btnDkCD.Size = new Size(197, 45);
            btnDkCD.TabIndex = 3;
            btnDkCD.Text = "📚 Đăng kí chuyên đề";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(10, 5);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 8, 0, 0);
            label6.Size = new Size(434, 38);
            label6.TabIndex = 2;
            label6.Text = "CHỨC NĂNG NHANH";
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(panel4);
            materialCard4.Controls.Add(label4);
            materialCard4.Depth = 0;
            materialCard4.Dock = DockStyle.Fill;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(10, 10);
            materialCard4.Margin = new Padding(10);
            materialCard4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(10, 5, 10, 5);
            materialCard4.Size = new Size(282, 181);
            materialCard4.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(pGiaiKK);
            panel4.Controls.Add(pGiaiBa);
            panel4.Controls.Add(pGiaiNhi);
            panel4.Controls.Add(pGiaiNhat);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 133);
            panel4.TabIndex = 5;
            // 
            // pGiaiKK
            // 
            pGiaiKK.Controls.Add(lblGiaiKKValue);
            pGiaiKK.Controls.Add(lblGiaiKKTitle);
            pGiaiKK.Dock = DockStyle.Top;
            pGiaiKK.Location = new Point(0, 99);
            pGiaiKK.Name = "pGiaiKK";
            pGiaiKK.Size = new Size(262, 33);
            pGiaiKK.TabIndex = 2;
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
            // pGiaiBa
            // 
            pGiaiBa.Controls.Add(lblGiaiBaValue);
            pGiaiBa.Controls.Add(lblGiaiBaTitle);
            pGiaiBa.Dock = DockStyle.Top;
            pGiaiBa.Location = new Point(0, 66);
            pGiaiBa.Name = "pGiaiBa";
            pGiaiBa.Size = new Size(262, 33);
            pGiaiBa.TabIndex = 1;
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
            // pGiaiNhi
            // 
            pGiaiNhi.Controls.Add(lblGiaiNhiValue);
            pGiaiNhi.Controls.Add(lblGiaiNhiTitle);
            pGiaiNhi.Dock = DockStyle.Top;
            pGiaiNhi.Location = new Point(0, 33);
            pGiaiNhi.Name = "pGiaiNhi";
            pGiaiNhi.Size = new Size(262, 33);
            pGiaiNhi.TabIndex = 1;
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
            // pGiaiNhat
            // 
            pGiaiNhat.Controls.Add(lblGiaiNhatValue);
            pGiaiNhat.Controls.Add(lblGiaiNhatTitle);
            pGiaiNhat.Dock = DockStyle.Top;
            pGiaiNhat.Location = new Point(0, 0);
            pGiaiNhat.Name = "pGiaiNhat";
            pGiaiNhat.Size = new Size(262, 33);
            pGiaiNhat.TabIndex = 0;
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
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(10, 5);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 8, 0, 0);
            label4.Size = new Size(262, 38);
            label4.TabIndex = 4;
            label4.Text = "THỐNG KÊ GIẢI THƯỞNG";
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
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(770, 34);
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
            tblMetrics.Controls.Add(materialCard3, 2, 0);
            tblMetrics.Controls.Add(materialCard2, 1, 0);
            tblMetrics.Controls.Add(materialCard1, 0, 0);
            tblMetrics.Dock = DockStyle.Top;
            tblMetrics.Location = new Point(20, 120);
            tblMetrics.Name = "tblMetrics";
            tblMetrics.RowCount = 1;
            tblMetrics.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMetrics.Size = new Size(776, 120);
            tblMetrics.TabIndex = 0;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(lblGiangVienValue);
            materialCard3.Controls.Add(lblGiangVienTitle);
            materialCard3.Depth = 0;
            materialCard3.Dock = DockStyle.Fill;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(526, 10);
            materialCard3.Margin = new Padding(10);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(10, 5, 10, 5);
            materialCard3.Size = new Size(240, 100);
            materialCard3.TabIndex = 2;
            // 
            // lblGiangVienValue
            // 
            lblGiangVienValue.Dock = DockStyle.Fill;
            lblGiangVienValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblGiangVienValue.Location = new Point(10, 43);
            lblGiangVienValue.Name = "lblGiangVienValue";
            lblGiangVienValue.Padding = new Padding(10, 0, 0, 0);
            lblGiangVienValue.Size = new Size(220, 52);
            lblGiangVienValue.TabIndex = 2;
            lblGiangVienValue.Text = "0";
            lblGiangVienValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGiangVienTitle
            // 
            lblGiangVienTitle.Dock = DockStyle.Top;
            lblGiangVienTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGiangVienTitle.Location = new Point(10, 5);
            lblGiangVienTitle.Name = "lblGiangVienTitle";
            lblGiangVienTitle.Padding = new Padding(10, 8, 0, 0);
            lblGiangVienTitle.Size = new Size(220, 38);
            lblGiangVienTitle.TabIndex = 3;
            lblGiangVienTitle.Text = "GIẢNG VIÊN";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lblSinhVienValue);
            materialCard2.Controls.Add(lblSinhVienTitle);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(268, 10);
            materialCard2.Margin = new Padding(10);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(10, 5, 10, 5);
            materialCard2.Size = new Size(238, 100);
            materialCard2.TabIndex = 1;
            // 
            // lblSinhVienValue
            // 
            lblSinhVienValue.Dock = DockStyle.Fill;
            lblSinhVienValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSinhVienValue.Location = new Point(10, 43);
            lblSinhVienValue.Name = "lblSinhVienValue";
            lblSinhVienValue.Padding = new Padding(10, 0, 0, 0);
            lblSinhVienValue.Size = new Size(218, 52);
            lblSinhVienValue.TabIndex = 2;
            lblSinhVienValue.Text = "0";
            lblSinhVienValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSinhVienTitle
            // 
            lblSinhVienTitle.Dock = DockStyle.Top;
            lblSinhVienTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSinhVienTitle.Location = new Point(10, 5);
            lblSinhVienTitle.Name = "lblSinhVienTitle";
            lblSinhVienTitle.Padding = new Padding(10, 8, 0, 0);
            lblSinhVienTitle.Size = new Size(218, 38);
            lblSinhVienTitle.TabIndex = 3;
            lblSinhVienTitle.Text = "SINH VIÊN";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblTongDeTaiValue);
            materialCard1.Controls.Add(lblTongDeTaiTitle);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(10, 10);
            materialCard1.Margin = new Padding(10);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(10, 5, 10, 5);
            materialCard1.Size = new Size(238, 100);
            materialCard1.TabIndex = 0;
            // 
            // lblTongDeTaiValue
            // 
            lblTongDeTaiValue.Dock = DockStyle.Fill;
            lblTongDeTaiValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTongDeTaiValue.Location = new Point(10, 43);
            lblTongDeTaiValue.Name = "lblTongDeTaiValue";
            lblTongDeTaiValue.Padding = new Padding(10, 0, 0, 0);
            lblTongDeTaiValue.Size = new Size(218, 52);
            lblTongDeTaiValue.TabIndex = 2;
            lblTongDeTaiValue.Text = "0";
            lblTongDeTaiValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongDeTaiTitle
            // 
            lblTongDeTaiTitle.Dock = DockStyle.Top;
            lblTongDeTaiTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongDeTaiTitle.Location = new Point(10, 5);
            lblTongDeTaiTitle.Name = "lblTongDeTaiTitle";
            lblTongDeTaiTitle.Padding = new Padding(10, 8, 0, 0);
            lblTongDeTaiTitle.Size = new Size(218, 38);
            lblTongDeTaiTitle.TabIndex = 3;
            lblTongDeTaiTitle.Text = "TỔNG ĐỀ TÀI";
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
            // FrmHome
            // 
            AutoScroll = true;
            ClientSize = new Size(816, 580);
            Controls.Add(pnlRoot);
            Name = "FrmHome";
            Text = "Trang chủ";
            pnlRoot.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            materialCard5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            materialCard4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pGiaiKK.ResumeLayout(false);
            pGiaiKK.PerformLayout();
            pGiaiBa.ResumeLayout(false);
            pGiaiBa.PerformLayout();
            pGiaiNhi.ResumeLayout(false);
            pGiaiNhi.PerformLayout();
            pGiaiNhat.ResumeLayout(false);
            pGiaiNhat.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tblMetrics.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel pnlContent;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tblMetrics;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label lblTongDeTaiValue;
        private Label lblTongDeTaiTitle;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private Label lblGiangVienValue;
        private Label lblGiangVienTitle;
        private Label lblSinhVienValue;
        private Label lblSinhVienTitle;
        private ReaLTaiizor.Controls.MaterialCard materialCard5;
        private ReaLTaiizor.Controls.MaterialCard materialCard4;
        private Label label4;
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
        private Label label6;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnKQ;
        private Button btnNopBai;
        private Button btnDkCD;
        private Button btnDkDT;
    }
}
