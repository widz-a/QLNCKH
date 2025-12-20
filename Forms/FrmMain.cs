using Microsoft.EntityFrameworkCore;
using QLNCKH.Forms;
using System.Linq.Expressions;

namespace QLNCKH
{
    public partial class FrmMain : Form {

        private Dictionary<string, (Func<Form> func, string title)> forms = new Dictionary<string, (Func<Form> func, string title)> {
            ["Trang chủ"] = (() => new FrmHome(), "Trang chủ"),
            ["Danh Mục"] = (() => new FrmDanhMuc(), "Quản lý danh mục"),
            ["Sinh viên"] = (() => new FrmList<SinhVien, SinhVienDTO>(
                new ListContext<SinhVien, SinhVienDTO> {
                    Name = "sinh viên",
                    GetHeaderSelector = (sv => new SinhVienDTO {
                        MaSV = sv.MaSV,
                        HoTen = sv.HoTen,
                        NgaySinh = sv.NgaySinh,
                        Lop = sv.Lop
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
            ), "Quản lý thông tin sinh viên"),
            ["Giảng viên"] = (() => new FrmList<GiangVien, GiangVienDto>(
                new ListContext<GiangVien, GiangVienDto> {
                    Name = "giảng viên",
                    GetHeaderSelector = (sv => new GiangVienDto {
                        MaCB = sv.MaCB,
                        HoTen = sv.HoTen,
                        NgaySinh = sv.NgaySinh,
                        TenDV = sv.DonViCongTac.TenDV,
                    }),
                    IdColumn = "MaCB",
                    HeaderNames = new Dictionary<string, string> {
                        ["MaCB"] = "Mã cán bộ",
                        ["HoTen"] = "Họ và tên",
                        ["NgaySinh"] = "Ngày sinh",
                        ["TenDV"] = "Đơn vị công tác",
                    },
                    GetEditForm = id => new FrmGiangVienEdit(id),
                    GetCreateForm = () => new FrmGiangVienEdit(),
                }
            ), "Quản lý thông tin giảng viên"),
            ["Đề tài"] = (() => new FrmList<DeTai, DeTaiDto>(
                new ListContext<DeTai, DeTaiDto> {
                    Name = "đề tài",
                    GetHeaderSelector = (sv => new DeTaiDto {
                        MaDT = sv.MaDT,
                        TenDT = sv.TenDT,
                        SoLuongSv = sv.SinhViens.Count,
                        TrangThai = sv.TrangThai.TenTrangThai,

                    }),
                    IdColumn = "MaCB",
                    HeaderNames = new Dictionary<string, string> {
                        ["MaDT"] = "Mã đề tài",
                        ["TenDT"] = "Tên đề tài",
                        ["SoLuongSv"] = "Số thành viên",
                        ["TrangThai"] = "Trạng thái",
                    },
                    GetEditForm = id => new FrmGiangVienEdit(id), //TODO
                    GetCreateForm = () => new FrmGiangVienEdit(), //TODO
                }
            ), "Quản lý thông tin đề tài NCKH")
        };

        public FrmMain() {
            InitializeComponent();
            InitSidebar();

            //Database Warm up
            using var db = new AppDbContext();
            db.Database.OpenConnection();
            db.Database.CloseConnection();

            //Load home
            LoadForm(new FrmHome(), "Trang chủ");

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
