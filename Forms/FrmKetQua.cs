using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLNCKH.Forms {
    public partial class FrmKetQua : Form {

        public FrmKetQua() {
            InitializeComponent();

            // Fake header (faker)
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Ma",
                HeaderText = "Mã đề tài",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Ten",
                HeaderText = "Tên đề tài",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Extra",
                HeaderText = "Số thành viên",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Giai",
                HeaderText = "Giải",
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Ma",
                HeaderText = "Mã chuyên đề",
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Ten",
                HeaderText = "Tên chuyên đề",
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Extra",
                HeaderText = "Sinh viên",
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Giai",
                HeaderText = "Giải",
            });

            StyleHelper.ApplyDGV(dataGridView1);
            StyleHelper.ApplyDGV(dataGridView2);

            // Set DataSource DT
            cbDT.DataSource = new Repository<HoiDong>()
                .Filter(
                hd => hd.Loai == "Đề tài",
                hd => new {
                    Value = hd.MaHD,
                    Display = $"HĐ#{hd.MaHD} | ĐỀ TÀI | {hd.NgayCham:dd/MM/yyyy}"
                });

            cbDT.DisplayMember = "Display";
            cbDT.ValueMember = "Value";

            // Set DataSource CD
            cbCD.DataSource = new Repository<HoiDong>()
                .Filter(
                hd => hd.Loai == "Chuyên đề",
                hd => new {
                    Value = hd.MaHD,
                    Display = $"HĐ#{hd.MaHD} | CHUYÊN ĐỀ | Vòng {hd.HoiDong_ChuyenDes.Max(x => x.Vong) + 1} | {hd.NgayCham:dd/MM/yyyy}"
                });

            cbCD.DisplayMember = "Display";
            cbCD.ValueMember = "Value";

            cbDT.SelectedIndex = -1;
            cbCD.SelectedIndex = -1;

            cbDT.SelectedIndexChanged += (s, e) => {
                LoadDataDt();
            };

            cbCD.SelectedIndexChanged += (s, e) => {
                LoadDataCd();
            };
        }

        private void fixName(DataGridView dgv, string name) {
            Dictionary<string, string> dictionary = new Dictionary<string, string>() {
                ["Ma"] = $"Mã {name}",
                ["Ten"] = $"Tên {name}",
                ["Giai"] = $"Giải",
                ["Extra"] = name == "đề tài" ? "Số thành viên" : "Sinh viên",
            };
            foreach (var item in dictionary) {
                dgv.Columns[item.Key].HeaderText = item.Value;
            }
        }

        private void LoadDataDt() {
            var maHD = (int)cbDT.SelectedValue;
            var daCoGiai = new Repository<KetQua_DeTai>()
                .GetAll()
                .Select(kq => kq.MaDT);
            var deTais = new Repository<HoiDong_DeTai>().Filter(
                x => x.MaHD == maHD && daCoGiai.Contains(x.MaDT),
                x => new {
                    Ma = x.MaDT,
                    Ten = x.DeTai != null ? x.DeTai.TenDT : "",
                    Extra = x.DeTai.SinhViens.Count,
                    Giai = new Repository<KetQua_DeTai>().GetById(x.MaDT).Giai,
                }
            );
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = deTais;
            fixName(dataGridView1, "đề tài");
        }

        private void LoadDataCd() {
            var maHD = (int)cbCD.SelectedValue;
            var daCoGiai = new Repository<KetQua_ChuyenDe>()
                .GetAll()
                .Select(kq => kq.MaCD);

            var chuyenDes = new Repository<HoiDong_ChuyenDe>().Filter(
                x => x.MaHD == maHD && daCoGiai.Contains(x.MaCD),
                x => new {
                    Ma = x.MaCD,
                    Ten = x.ChuyenDe != null ? x.ChuyenDe.MaCD : "",
                    Extra = x.ChuyenDe.SinhVien.HoTen,
                    Giai = new Repository<KetQua_ChuyenDe>().GetById(x.MaCD, 1).Giai
                }
            );

            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = chuyenDes;
            fixName(dataGridView2, "chuyên đề");
        }
    }
}
