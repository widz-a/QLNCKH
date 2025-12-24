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
                    GetEditForm = id => new FrmSinhVienEdit(id[0]),
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
                    GetEditForm = id => new FrmGiangVienEdit(id[0]),
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
                    IdColumn = "MaDT",
                    HeaderNames = new Dictionary<string, string> {
                        ["MaDT"] = "Mã đề tài",
                        ["TenDT"] = "Tên đề tài",
                        ["SoLuongSv"] = "Số thành viên",
                        ["TrangThai"] = "Trạng thái",
                    },
                    GetEditForm = id => new FrmDeTaiEdit(id[0]),
                    GetCreateForm = () => new FrmDeTaiEdit(),
                }
            ), "Quản lý thông tin đề tài NCKH"),
            ["Chuyên đề"] = (() => new FrmList<ChuyenDe, ChuyenDeTdo>(
                new ListContext<ChuyenDe, ChuyenDeTdo> {
                    Name = "đề tài",
                    GetHeaderSelector = (sv => new ChuyenDeTdo {
                        MaCD = sv.MaCD,
                        TenCD = sv.TenCD,
                        TenSV = sv.SinhVien.HoTen,
                        LinhVuc = sv.LinhVuc.TenLinhVuc,

                    }),
                    IdColumn = "MaCD",
                    HeaderNames = new Dictionary<string, string> {
                        ["MaCD"] = "Mã",
                        ["TenCD"] = "Tên chuyên đề",
                        ["TenSV"] = "Sinh viên",
                        ["LinhVuc"] = "Lĩnh vực",
                    },
                    GetEditForm = id => new FrmChuyenDeEdit(id[0]),
                    GetCreateForm = () => new FrmChuyenDeEdit(),
                }
            ), "Quản lý thông tin chuyên đề NCKH"),

            ["Nộp sản phẩm"] = (() => new FrmNopDeTaiEdit(), "Nộp sản phẩm"),


            ["Đạo văn"] = (() => new FrmList<DaoVan, DaoVanDto>(
                new ListContext<DaoVan, DaoVanDto> {
                    Name = "đề tài",
                    GetHeaderSelector = (sv => new DaoVanDto {
                        Id = sv.Id,
                        TenDT = sv.DeTai.TenDT,
                        LanQuet = sv.LanQuet,
                        TyLeTrungLap = sv.TyLeTrungLap,
                        KetLuan = sv.KetLuan,

                    }),
                    IdColumn = "Id",
                    HeaderNames = new Dictionary<string, string> {
                        ["Id"] = "Mã đề tài",
                        ["TenDT"] = "Tên đề tài",
                        ["LanQuet"] = "Lần quét",
                        ["TyLeTrungLap"] = "KQ rà quét",
                        ["KetLuan"] = "Kết luận",
                    },
                    GetCreateForm = () => new FrmDaoVanEdit(),
                }
            ), "Quản lý kiểm tra đạo văn"),

            ["Hội đồng"] = (() => new FrmList<HoiDong, HoiDongDto>(
                new ListContext<HoiDong, HoiDongDto> {
                    Name = "hội đồng",
                    GetHeaderSelector = (sv => new HoiDongDto {
                        MaHD = sv.MaHD,
                        Loai = sv.Loai,
                        NgayCham = sv.NgayCham,
                        SoThanhVien = sv.HoiDong_ThanhViens.Count,

                    }),
                    IdColumn = "MaHD",
                    HeaderNames = new Dictionary<string, string> {
                        ["MaHD"] = "Mã hộ đồng",
                        ["Loai"] = "Sản phẩm",
                        ["NgayCham"] = "Ngày chấm",
                        ["SoThanhVien"] = "Số thành viên",
                    },
                    GetCreateForm = () => new FrmHoiDongEdit(),
                    GetEditForm = (id) => new FrmHoiDongEdit(id[0]),
                }
            ), "Quản lý thông tin hội đồng"),
            ["Chấm điểm"] = (() => new FrmChamDiem(), "Chấm điểm sản phẩm"),
            ["Kết quả"] = (() => new FrmKetQua(), "Kết quả"),

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
                pnlSidebar.Controls.Add(FormHelper.CreateMenuButton(item.Key, top, () => LoadForm(item.Value.func(), item.Value.title)));
                top += 42;

            }

            pnlSidebar.Controls.Add(FormHelper.CreateMenuButton("Thoát", top, () => Application.Exit())); // this.Height - 60
        }

        private void LoadForm(Form frm, string newTitle) {
            this.title.Text = newTitle;
            this.title.Refresh();
            FormHelper.LoadForm(frm, pnlMain);
        }
    }
}
