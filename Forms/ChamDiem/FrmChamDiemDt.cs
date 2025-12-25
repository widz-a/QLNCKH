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
    public partial class FrmChamDiemDt : Form {
        private int? _maHd = null;
        private string? _maDt = null;

        public FrmChamDiemDt() {
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

        public FrmChamDiemDt(int maHd, string maDt) : this() {
            _maDt = maDt;
            _maHd = maHd;
            LoadDanhMuc();
        }

        private void LoadDanhMuc() {
            if (_maHd == null || _maDt == null) return;

            var hd = new Repository<HoiDong_DeTai>().Filter(
                x => x.MaDT == _maDt && x.MaHD == _maHd,
                x => new {
                    MaHD = x.MaHD,
                    NgayCham = x.HoiDong.NgayCham,
                    ThanhViens = x.HoiDong.HoiDong_ThanhViens.Select(x => x.GiangVien)
                }
            ).First();
            var dt = new Repository<DeTai>().GetById(_maDt);
            tbHoiDong.Text = $"HĐ#{hd.MaHD} | ĐỀ TÀI | {hd.NgayCham:dd/MM/yyyy}";
            tbDeTai.Text = $"({dt.MaDT}) {dt.TenDT}";

            foreach (var x in hd.ThanhViens) {
                var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(x.MaCB);
                item.SubItems.Add(x.HoTen);
                
                var diem = new Repository<PhieuCham>().Filter(y => y.MaHD == _maHd && y.MaDT == _maDt && y.MaCB == x.MaCB, x => x.Diem).FirstOrDefault();
                item.SubItems.Add(diem.ToString());

                listView1.Items.Add(item);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            if (_maHd == null || _maDt == null) return;

            //Validate
            foreach (ListViewItem item in listView1.Items) {
                Repository<PhieuCham> repo = new Repository<PhieuCham>();
                var ts = repo.Filter(
                    x => x.Loai == "Đề tài" && x.MaDT == _maDt && x.MaHD == (int)_maHd && x.MaCB == item.SubItems[1].Text
                ).FirstOrDefault();
                decimal diem;
                if (!decimal.TryParse(item.SubItems[3].Text, out diem)) continue;

                if (ts != null) {
                    ts.Diem = diem;
                    repo.Update(ts);
                } else {
                    var data = new PhieuCham {
                        MaHD = (int)_maHd,
                        MaDT = _maDt,
                        MaCB = item.SubItems[1].Text,
                        Loai = "Đề tài",
                        Diem = diem,
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
