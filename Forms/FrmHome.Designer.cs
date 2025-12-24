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

        private void InitializeComponent()
        {
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Text = "Trang chủ";

            // ===== TITLE =====
            Label lblTitle = new Label
            {
                Text = "HỆ THỐNG QUẢN LÝ NGHIÊN CỨU KHOA HỌC\nHỌC VIỆN AN NINH NHÂN DÂN",
                Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(260, 30),
                AutoSize = true
            };
            Controls.Add(lblTitle);

            // ===== BUTTON =====
            Button btnNopBai = new Button
            {
                Text = "➕ Nộp bài nghiên cứu khoa học",
                Location = new System.Drawing.Point(260, 95),
                Size = new System.Drawing.Size(300, 38)
            };
            btnNopBai.Click += btnNopBai_Click;
            Controls.Add(btnNopBai);

            // ===== METRICS =====
            CreateMetric("TỔNG ĐỀ TÀI", out lblTongDeTai, 260);
            CreateMetric("ĐANG THỰC HIỆN", out lblDangThucHien, 450);
            CreateMetric("SINH VIÊN", out lblSinhVien, 640);
            CreateMetric("GIẢNG VIÊN", out lblGiangVien, 830);

            // ===== ĐỀ TÀI =====
            CreateListBox("ĐỀ TÀI NỔI BẬT", out lstDeTaiNoiBat, 260, 240);
            CreateListBox("ĐỀ TÀI MỚI", out lstDeTaiMoi, 650, 240);

            // ===== ĐỊNH HƯỚNG =====
            Panel pnlDinhHuong = CreateSection("ĐỊNH HƯỚNG",
                "Xây dựng hệ thống quản lý nghiên cứu khoa học hiện đại, số hóa toàn bộ quy trình từ đăng ký, theo dõi, đánh giá tiến độ, nghiệm thu kết quả và lưu trữ dữ liệu nghiên cứu khoa học của Học viện.",
                260, 520, 160);
            Controls.Add(pnlDinhHuong);

            // ===== LIÊN HỆ =====
            Panel pnlLienHe = CreateSection("LIÊN HỆ",
                "Phòng Quản lý nghiên cứu khoa học – Học viện ANND\nEmail: qlnckh@hvanninh.edu.vn",
                260, 690, 120);
            Controls.Add(pnlLienHe);

            // ===== FOOTER =====
            Label footer = new Label
            {
                Text = "Đơn vị phát triển: Nhóm QLNCKH | Phiên bản 1.0 – 2025",
                Location = new System.Drawing.Point(260, 830),
                Size = new System.Drawing.Size(760, 30),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                ForeColor = System.Drawing.Color.Gray
            };
            Controls.Add(footer);
        }

        Label lblTongDeTai, lblDangThucHien, lblSinhVien, lblGiangVien;
        ListBox lstDeTaiNoiBat, lstDeTaiMoi;

        private void CreateMetric(string title, out Label value, int x)
        {
            Panel p = new Panel
            {
                Location = new System.Drawing.Point(x, 150),
                Size = new System.Drawing.Size(170, 70),
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(p);

            p.Controls.Add(new Label
            {
                Text = title,
                Location = new System.Drawing.Point(10, 5),
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold)
            });

            value = new Label
            {
                Text = "0",
                Location = new System.Drawing.Point(10, 30),
                Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold)
            };
            p.Controls.Add(value);
        }

        private void CreateListBox(string title, out ListBox box, int x, int y)
        {
            Controls.Add(new Label
            {
                Text = title,
                Location = new System.Drawing.Point(x, y - 25),
                Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold)
            });

            box = new ListBox
            {
                Location = new System.Drawing.Point(x, y),
                Size = new System.Drawing.Size(360, 220)
            };
            Controls.Add(box);
        }

        private Panel CreateSection(string title, string content, int x, int y, int height)
        {
            Panel p = new Panel
            {
                Location = new System.Drawing.Point(x, y),
                Size = new System.Drawing.Size(760, height),
                BorderStyle = BorderStyle.FixedSingle
            };

            p.Controls.Add(new Label
            {
                Text = title,
                Location = new System.Drawing.Point(15, 10),
                Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold),
                AutoSize = true
            });

            Label lbl = new Label
            {
                Text = content,
                Location = new System.Drawing.Point(15, 40),
                MaximumSize = new System.Drawing.Size(730, 0),
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 9.5F)
            };
            p.Controls.Add(lbl);

            return p;
        }
    }
}
