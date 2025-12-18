using QLNCKH.Forms;

namespace QLNCKH
{
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
            InitSidebar();

            LoadForm(new FrmHome());
        }

        private void InitSidebar() {
            int top = 100;

            Dictionary<string, Func<Form>> forms = new Dictionary<string, Func<Form>> {
                { "Trang chủ", () => new FrmHome() },
                { "Danh Mục", () => new FrmDanhMuc() },
                { "Sinh viên", () => new FrmSinhVien() },
            };

            foreach (var item in forms) {
                pnlSidebar.Controls.Add(CreateMenuButton(item.Key, top, () => LoadForm(item.Value())));
                top += 42;

            }

            pnlSidebar.Controls.Add(CreateMenuButton("Thoát", top, () => Application.Exit())); // this.Height - 60
        }

        private Button CreateMenuButton(string text, int top, Action onClick) {
            Button btn = new Button {
                Text = "  " + text,
                Width = 220,
                Height = 42,
                Location = new Point(0, top),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(33, 42, 57),
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };

            btn.FlatAppearance.BorderSize = 0;

            btn.MouseEnter += (s, e) =>
                btn.BackColor = Color.FromArgb(45, 55, 72);

            btn.MouseLeave += (s, e) =>
                btn.BackColor = Color.FromArgb(33, 42, 57);

            btn.Click += (s, e) => onClick();

            return btn;
        }

        private void LoadForm(Form frm) {
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Padding = new Padding(20);
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
    }
}
