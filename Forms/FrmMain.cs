using Microsoft.EntityFrameworkCore;
using QLNCKH.Forms;
using System.Linq.Expressions;

namespace QLNCKH
{
    public partial class FrmMain : Form {

        private Dictionary<string, (Func<Form> func, string title)> forms = new Dictionary<string, (Func<Form> func, string title)> {
            ["Trang chủ"] = (() => new FrmHome(), "Trang chủ"),
            ["Danh Mục"] = (() => new FrmDanhMuc(), "Quản lý danh mục"),
            ["Sinh viên"] = (() => new FrmList<SinhVien>(
                new ListContext<SinhVien> {
                    Title = "Quản lý thông tin sinh viên",
                    GetHeaderSelector = (sv => new {
                        sv.MaSV, sv.HoTen, sv.NgaySinh, sv.Lop
                    }),
                    IdColumn = "MaSV",
                    HeaderNames = new Dictionary<string, string> {
                        ["MaSV"] = "Mã sinh viên",
                        ["HoTen"] = "Họ và tên",
                        ["NgaySinh"] = "Ngày sinh",
                        ["Lop"] = "Lớp",
                    },
                    GetEditForm = id => new FrmSinhVienEdit(id),
                    GetCreateForm = () => new FrmSinhVienEdit(),
                }    
            ), "Quản lý thông tin sinh viên")
        };

        public FrmMain() {
            InitializeComponent();
            InitSidebar();

            //Database Warm up
            using var db = new AppDbContext();
            db.Database.OpenConnection();
            db.Database.CloseConnection();

        }

        private void InitSidebar() {
            int top = 100;

            foreach (var item in forms) {
                pnlSidebar.Controls.Add(CreateMenuButton(item.Key, top, () => LoadForm(item.Value.func(), item.Value.title)));
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

        private void LoadForm(Form frm, string newTitle) {
            this.title.Text = newTitle;
            this.title.Refresh();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Padding = new Padding(20, 0, 20, 20);
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
    }
}
