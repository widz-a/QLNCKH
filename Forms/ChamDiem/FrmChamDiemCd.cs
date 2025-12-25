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
    public partial class FrmChamDiemCd : Form {
        private int? _maHd = null;
        private string? _maCd = null;

        public FrmChamDiemCd() {
            InitializeComponent();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;

            listView1.DoubleClick += (s, e) => {
                if (listView1.SelectedItems.Count == 0) return;
                var diemGoc = listView1.SelectedItems[0].SubItems[3].Text;
                using (var f = new FrmDiem(diemGoc)) {
                    if (f.ShowDialog() == DialogResult.OK) {
                        var diem = f.Diem;
                        listView1.SelectedItems[0].SubItems[3].Text = diem.ToString();
                    }
                }
            };
        }

        public FrmChamDiemCd(int maHd, string maCd) : this() {
            _maCd = maCd;
            _maHd = maHd;
            LoadDanhMuc();
        }

        private void LoadDanhMuc() {
            if (_maHd == null || _maCd == null) return;

            var hd = new Repository<HoiDong_ChuyenDe>().Filter(
                 x => x.MaCD == _maCd && x.MaHD == _maHd,
                 x => new {
                     ThanhViens = x.HoiDong.HoiDong_ThanhViens.Select(x => x.GiangVien),
                     Name = $"HĐ#{x.MaHD} | CHUYÊN ĐỀ | Vòng {x.Vong + 1} | {x.HoiDong.NgayCham:dd/MM/yyyy}"
                 }
             ).First();
            var cd = new Repository<ChuyenDe>().GetById(_maCd);
            tbHoiDong.Text = hd.Name;
            tbChuyenDe.Text = $"({cd.MaCD}) {cd.TenCD}";

            foreach (var x in hd.ThanhViens) {
                var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(x.MaCB);
                item.SubItems.Add(x.HoTen);

                var diem = new Repository<PhieuCham>().Filter(y => y.MaHD == _maHd && y.MaCD == _maCd && y.MaCB == x.MaCB, x => x.Diem).FirstOrDefault();
                item.SubItems.Add(diem.ToString());

                listView1.Items.Add(item);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            if (_maHd == null || _maCd == null) return;

            //Validate
            foreach (ListViewItem item in listView1.Items) {
                decimal diem;
                if (!decimal.TryParse(item.SubItems[3].Text, out diem)) continue;

                Repository<PhieuCham> repo = new Repository<PhieuCham>();
                var ts = repo.Filter(
                    x => x.Loai == "Chuyên đề" && x.MaCD == _maCd && x.MaHD == (int)_maHd && x.MaCB == item.SubItems[1].Text && x.Vong == 1
                ).FirstOrDefault();

                if (ts != null) {
                    ts.Diem = diem;
                    repo.Update(ts);
                } else {
                    var data = new PhieuCham {
                        MaHD = (int)_maHd,
                        MaCD = _maCd,
                        MaCB = item.SubItems[1].Text,
                        Loai = "Chuyên đề",
                        Diem = diem,
                        Vong = 1
                    };
                    repo.Insert(data);
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
