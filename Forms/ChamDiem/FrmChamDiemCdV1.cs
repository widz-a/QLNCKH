using QLNCKH.Forms.ChamDiem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNCKH.Forms {
    public partial class FrmChamDiemCdV1 : Form {
        private int? _maHd = null;
        private string? _maCd = null;

        public FrmChamDiemCdV1() {
            InitializeComponent();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;
        }

        public FrmChamDiemCdV1(int maHd, string maCd) : this() {
            _maCd = maCd;
            _maHd = maHd;
            LoadDanhMuc();
        }

        private void LoadDanhMuc() {
            if (_maHd == null || _maCd == null) return;

            var hd = new Repository<HoiDong_ChuyenDe>().Filter(
                x => x.MaCD == _maCd && x.MaHD == _maHd,
                x => new {
                    Name = $"HĐ#{x.MaHD} | CHUYÊN ĐỀ | Vòng {x.Vong + 1} | {x.HoiDong.NgayCham:dd/MM/yyyy}"
                }
            ).First();
            var cd = new Repository<ChuyenDe>().GetById(_maCd);
            tbHoiDong.Text = hd.Name;
            tbChuyenDe.Text = $"({cd.MaCD}) {cd.TenCD}";

            comboBox1.DataSource = new Repository<HoiDong_ThanhVien>().Filter(
                x => x.MaHD == _maHd,
                x => new {
                    Value = x.MaCB,
                    Display = $"({x.MaCB}) {x.GiangVien.HoTen}"
                });
            comboBox1.DisplayMember = "Display";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            decimal diem;

            if (_maHd == null || _maCd == null) return;
            if (!decimal.TryParse(textBox1.Text, out diem) || diem > 10 || diem < 0) {
                MessageBox.Show($"Điểm phải là số hợp lệ từ 0 đến 10.",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            Repository<PhieuCham> repo = new Repository<PhieuCham>();
            var ts = repo.Filter(
                x => x.Loai == "Chuyên đề" && x.MaCD == _maCd && x.MaHD == (int)_maHd
            ).FirstOrDefault();

            if (ts != null) {
                ts.Diem = diem;
                ts.MaCB = comboBox1.SelectedValue.ToString();
                repo.Update(ts);
            } else {
                var data = new PhieuCham {
                    MaHD = (int)_maHd,
                    MaCD = _maCd,
                    MaCB = comboBox1.SelectedValue.ToString(),
                    Loai = "Chuyên đề",
                    Diem = diem,
                    Vong = 0
                };
                repo.Insert(data);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
