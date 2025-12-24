using System.Data;

namespace QLNCKH.Forms {
    public partial class FrmChamDiem : Form {

        public FrmChamDiem() {
            InitializeComponent();
            setDataSource(true);
            

            cbDT.SelectedIndexChanged += (s, e) => {
                LoadDataDt();
            };

            cbCD.SelectedIndexChanged += (s, e) => {
                LoadDataCd();
            };

            listView1.DoubleClick += (s, e) => {
                OpenDialogDt();
            };

            btnDtCham.Click += (s, e) => {
                //todo: xét giải
                LoadDataDt();
            };

            listView2.DoubleClick += (s, e) => {
                OpenDialogCd();
            };

            btnCdCham.Click += (s, e) => {
                //Lấy top 15 => đổi Vòng sang 1
                var maHd = (int) cbCD.SelectedValue;
                var chuyenDes = new Repository<HoiDong_ChuyenDe>().Filter(
                    x => x.MaHD == maHd,
                    x => new {
                        x.MaCD,
                        TenCD = x.ChuyenDe != null ? x.ChuyenDe.MaCD : "",
                        Vong = x.Vong + 1,
                        DiemTB = x.HoiDong != null &&
                                 x.HoiDong.PhieuChams.Any(p => p.MaCD == x.MaCD)
                            ? x.HoiDong.PhieuChams
                                .Where(p => p.MaCD == x.MaCD)
                                .Average(p => p.Diem)
                            : 0
                    });

                var maxVong = chuyenDes.Max(x => x.Vong);
                if (maxVong == 1) {
                    var top15 = chuyenDes
                    .OrderByDescending(x => x.DiemTB)
                    .Take(15)
                    .ToList();

                    var repo = new Repository<HoiDong_ChuyenDe>();
                    foreach (var cd in top15) {
                        var entity = repo.Filter(x =>
                            x.MaHD == maHd &&
                            x.MaCD == cd.MaCD
                        ).FirstOrDefault();

                        if (entity != null) {
                            entity.Vong = 1;
                            repo.Update(entity);
                        }
                    }
                }
                LoadDataCd();
            };
        }

        private void setDataSource(bool changeIndex = false) {
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

            if (changeIndex) {
                cbDT.SelectedIndex = -1;
                cbCD.SelectedIndex = -1;
            }
        }

        private void LoadDataDt() {
            var maHD = (int)cbDT.SelectedValue;
            var deTais = new Repository<HoiDong_DeTai>().Filter(
                x => x.MaHD == maHD,
                x => new {
                    x.MaDT,
                    TenDT = x.DeTai != null ? x.DeTai.TenDT : "",
                    DiemTB = x.HoiDong != null &&
                             x.HoiDong.PhieuChams.Any(p => p.MaDT == x.MaDT)
                        ? x.HoiDong.PhieuChams
                            .Where(p => p.MaDT == x.MaDT)
                            .Average(p => p.Diem)
                            .ToString("0.##")
                        : ""
        }
            );
            listView1.Items.Clear();
            foreach (var cb in deTais) {
                var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(cb.MaDT);
                item.SubItems.Add(cb.TenDT);
                item.SubItems.Add(cb.DiemTB);
                listView1.Items.Add(item);

            }
        }

        private void LoadDataCd() {
            var maHD = (int)cbCD.SelectedValue;
            var chuyenDes = new Repository<HoiDong_ChuyenDe>().Filter(
                x => x.MaHD == maHD,
                x => new {
                    x.MaCD,
                    TenCD = x.ChuyenDe != null ? x.ChuyenDe.MaCD : "",
                    Vong = x.Vong + 1,
                    DiemTB = x.HoiDong != null &&
                             x.HoiDong.PhieuChams.Any(p => p.MaCD == x.MaCD)
                        ? x.HoiDong.PhieuChams
                            .Where(p => p.MaCD == x.MaCD && p.Vong == 1)
                            .Average(p => p.Diem)
                            .ToString("0.##")
                        : ""
                }
            );

            var maxVong = 0;

            listView2.Items.Clear();
            foreach (var cb in chuyenDes) {
                var item = new ListViewItem((listView2.Items.Count + 1).ToString());
                item.SubItems.Add(cb.MaCD);
                item.SubItems.Add(cb.TenCD);
                
                if (cb.Vong == 1) {
                    Repository<PhieuCham> repo = new Repository<PhieuCham>();
                    var ts = repo.Filter(
                        x => x.Loai == "Chuyên đề" && x.MaCD == cb.MaCD && x.MaHD == maHD
                    ).FirstOrDefault();
                    if (ts != null) item.SubItems.Add(ts.Diem.ToString());
                } else
                    item.SubItems.Add(cb.DiemTB);

                listView2.Items.Add(item);
                if (cb.Vong > maxVong) maxVong = cb.Vong;
            }

            btnCdCham.Text = (maxVong == 1) ? "Xét vòng 2" : "Xét giải";
        }

        private void OpenDialogDt() {
            if (cbDT.SelectedValue == null) return;
            if (listView1.SelectedItems.Count == 0) return;

            var maHd = (int)cbDT.SelectedValue;
            var maDt = listView1.SelectedItems[0].SubItems[1].Text;

            using (var f = new FrmChamDiemDt(maHd, maDt)) {
                if (f.ShowDialog() == DialogResult.OK)
                    LoadDataDt();
            }
        }

        private void OpenDialogCd() {
            if (cbCD.SelectedValue == null) return;
            if (listView2.SelectedItems.Count == 0) return;

            var maHd = (int)cbCD.SelectedValue;
            var maCd = listView2.SelectedItems[0].SubItems[1].Text;
            var hd = new Repository<HoiDong_ChuyenDe>().Filter
                (
                    x => x.MaHD == maHd && x.MaCD == maCd,
                    x => x.Vong
                ).FirstOrDefault();
            if (hd == null) return;
            using (Form f = hd == 0 ? new FrmChamDiemCdV1(maHd, maCd) : new FrmChamDiemCd(maHd, maCd)) {
                if (f.ShowDialog() == DialogResult.OK)
                    LoadDataCd();
            }
        }
    }
}
