using System.Data;

namespace QLNCKH.Forms {
    public partial class FrmHoiDongEdit : Form {

        private int? _id = null;
        private string? _dc = null;

        public FrmHoiDongEdit() {
            InitializeComponent();
            LoadDanhMucThanhVien();

            //Ẩn tab
            tab.TabPages.Remove(tabDTCD);

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;

            this.Shown += (s, e) => {
                //txtMaCB.Focus();
            };

            cbDTCD.SelectedIndexChanged += (s, e) => {
                listView2.Items.Clear();
                LoadDanhMucDC();
            };

            btnDcThem.Click += (s, e) => {
                if (_dc == null) return;
                if (!ValidateHelper.Required(cbNameDC, _dc)) return;

                string maDT = cbNameDC.SelectedValue.ToString();
                
                string tenDT;
                if (_dc == "Đề tài") {
                    tenDT = new Repository<DeTai>().GetById(maDT).TenDT;
                } else {
                    tenDT = new Repository<ChuyenDe>().GetById(maDT).TenCD;
                }

                var item = new ListViewItem((listView2.Items.Count + 1).ToString());
                item.SubItems.Add(maDT);
                item.SubItems.Add(tenDT);

                listView2.Items.Add(item);
                LoadDanhMucDC();
            };

            btnDcXoa.Click += (s, e) => {
                if (listView2.SelectedItems.Count == 0) return;

                ListViewItem item = listView2.SelectedItems[0];
                listView2.Items.Remove(item);
                LoadDanhMucDC();
            };

            btnTvThem.Click += (s, e) => {
                if (!ValidateHelper.Required(cbCB, "Giảng viên")) return;
                if (!ValidateHelper.Required(cbVT, "Vai trò")) return;

                string maCB = cbCB.SelectedValue.ToString();
                GiangVien canbo = new Repository<GiangVien>().GetById(maCB);
                
                var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(maCB);
                item.SubItems.Add(canbo.HoTen);
                item.SubItems.Add(cbVT.SelectedItem.ToString());

                listView1.Items.Add(item);
                LoadDanhMucThanhVien();
            };

            btnTvXoa.Click += (s, e) => {
                if (listView1.SelectedItems.Count == 0) return;

                ListViewItem item = listView1.SelectedItems[0];
                listView1.Items.Remove(item);
                LoadDanhMucThanhVien();
            };
        }

        public FrmHoiDongEdit(string id) : this() {
            int __id;
            int.TryParse(id, out __id);
            _id = __id;
            LoadData();

            this.Text = "Sửa thông tin hội đồng";
            title.Text = "Sửa thông tin hội đồng";
            btnLuu.Text = "Lưu";

            cbDTCD.Enabled = false;
            LoadDanhMucDC();
        }

        private void LoadDanhMucDC() {
            _dc = cbDTCD.SelectedItem.ToString();
            tabDTCD.Text = _dc;

            if (tab.TabPages["tabDTCD"] == null) tab.TabPages.Add(tabDTCD);

            var existedCodes = listView2.Items
                .Cast<ListViewItem>()
                .Select(i => i.SubItems[1].Text)
                .ToList();
            MessageBox.Show(String.Join(", ", existedCodes));

            if (_dc == "Đề tài") {
                var usedCodes = new Repository<HoiDong_DeTai>()
                    .GetAll()
                    .Select(x => x.MaDT)
                    .Distinct()
                    .ToList();

                cbNameDC.DataSource = new Repository<DeTai>().Filter(
                    x => !existedCodes.Contains(x.MaDT)
                        && !usedCodes.Contains(x.MaDT),

                    x => new {
                        Value = x.MaDT,
                        Display = $"({x.MaDT}) {x.TenDT}"
                    });
            } else {
                var usedCodes = new Repository<HoiDong_ChuyenDe>()
                    .GetAll()
                    .Select(x => x.MaCD)
                    .Distinct()
                    .ToList();

                cbNameDC.DataSource = new Repository<ChuyenDe>().Filter(
                    x => !existedCodes.Contains(x.MaCD)
                        && !usedCodes.Contains(x.MaCD), 

                    x => new {
                        Value = x.MaCD,
                        Display = $"({x.MaCD}) {x.TenCD}"
                    });
            }

            cbNameDC.DisplayMember = "Display";
            cbNameDC.ValueMember = "Value";
            cbNameDC.SelectedIndex = -1;
        }

        private bool coChuTichChua() {
            return listView1.Items
                .Cast<ListViewItem>()
                .Any(i =>
                    i.SubItems.Count > 3 &&
                    i.SubItems[3].Text == "Chủ tịch"
                );
        }

        private bool coThuKyChua() {
            return listView1.Items
                .Cast<ListViewItem>()
                .Any(i =>
                    i.SubItems.Count > 3 &&
                    i.SubItems[3].Text == "Thư ký"
                );
        }

        private void LoadDanhMucThanhVien() {
            cbVT.Items.Clear();

            if (!coChuTichChua()) {
                cbVT.Items.Add("Chủ tịch");
            }
            if (!coThuKyChua()) {
                cbVT.Items.Add("Thư ký");
            }
            cbVT.Items.Add("Thành viên");

            var maCbDaCo = listView1.Items
                .Cast<ListViewItem>()
                .Where(i =>
                    i.SubItems.Count > 1 &&
                    !string.IsNullOrWhiteSpace(i.SubItems[1].Text)
                )
                .Select(i => i.SubItems[1].Text)
                .ToList();


            cbCB.DataSource = new Repository<GiangVien>()
                .Filter(
                    sv => !maCbDaCo.Contains(sv.MaCB),
                    sv => new {
                        Value = sv.MaCB,
                        Display = $"({sv.MaCB}) {sv.HoTen}"
                    }
                );

            cbCB.DisplayMember = "Display";
            cbCB.ValueMember = "Value";
            cbCB.SelectedIndex = -1;
        }

        private void LoadData() {
            if (_id == null) return;
            HoiDong r = new Repository<HoiDong>().GetById(_id);
            if (r == null) return;

            //Thông tin
            cbDTCD.SelectedItem = r.Loai;
            dtDate.Value = r.NgayCham;

            //Thành viên
            var canbo = new Repository<HoiDong_ThanhVien>().Filter(
                x => x.MaHD == _id,
                x => new {
                    x.MaCB,
                    HoTen = x.GiangVien.HoTen,
                    VaiTro = x.VaiTro
                }
            );
            foreach (var x in canbo) {
                var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(x.MaCB);
                item.SubItems.Add(x.HoTen);
                item.SubItems.Add(x.VaiTro);

                listView1.Items.Add(item);
                LoadDanhMucThanhVien();
            }

            //TODO: Đề tài
            if (_dc == "Đề tài") {
                Repository<HoiDong_DeTai> repoDT = new Repository<HoiDong_DeTai>();

                var dts = repoDT.Filter(
                    x => x.MaHD == _id,
                    x => new {
                        Ma = x.MaHD,
                        Ten = x.DeTai.TenDT,
                    }
                );

                foreach (var x in dts) {
                    var item = new ListViewItem((listView2.Items.Count + 1).ToString());
                    item.SubItems.Add(x.Ma + "");
                    item.SubItems.Add(x.Ten);

                    listView2.Items.Add(item);
                }
            } else {
                Repository<HoiDong_ChuyenDe> repoDT = new Repository<HoiDong_ChuyenDe>();

                var dts = repoDT.Filter(
                    x => x.MaHD == _id,
                    x => new {
                        Ma = x.MaHD,
                        Ten = x.ChuyenDe.TenCD,
                    }
                );

                foreach (var x in dts) {
                    var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                    item.SubItems.Add(x.Ma + "");
                    item.SubItems.Add(x.Ten);

                    listView2.Items.Add(item);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateHelper.Required(cbDTCD, "Loại")) return;
            if (listView1.Items.Count == 0) {
                MessageBox.Show("Vui lòng thêm thành viên.",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!coChuTichChua()) {
                MessageBox.Show("Vui lòng thêm chủ tịch",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!coThuKyChua()) {
                MessageBox.Show("Vui lòng thêm thư ký",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (listView1.Items.Count != 5) {
                MessageBox.Show("Hội đồng phải có 5 thành viên",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (listView2.Items.Count == 0) {
                MessageBox.Show($"Vui lòng thêm {_dc.ToLower()}.",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            //Lưu
            
            HoiDong hoiDong = new HoiDong {
                Loai = _dc,
                NgayCham = dtDate.Value,
            };

            Repository<HoiDong> repoHD = new Repository<HoiDong>();
            if (_id == null) {
                hoiDong = repoHD.Insert(hoiDong);
            } else
                hoiDong = repoHD.Update(hoiDong);

            // ===== LƯU LẠI THÀNH VIÊN =====
            Repository<HoiDong_ThanhVien> repoTv = new Repository<HoiDong_ThanhVien>();

            if (_id != null) {
                var oldItems = repoTv.Filter(x => x.MaHD == hoiDong.MaHD);
                foreach (var old in oldItems)
                    repoTv.Delete(old.MaHD, old.MaCB);
            }

            foreach (ListViewItem item in listView1.Items) {
                string maSV = item.SubItems[1].Text;
                string vaiTroTen = item.SubItems[3].Text;

                var sv = new HoiDong_ThanhVien {
                    MaHD = hoiDong.MaHD,
                    MaCB = item.SubItems[1].Text,
                    VaiTro = item.SubItems[3].Text
                };

                repoTv.Insert(sv);
            }

            //đỀ TÀI, CHUYÊN ĐỀ

            if (_dc == "Đề tài") {
                Repository<HoiDong_DeTai> repoDT = new Repository<HoiDong_DeTai>();

                if (_id != null) {
                    var oldItems = repoDT.Filter(x => x.MaHD == hoiDong.MaHD);
                    foreach (var old in oldItems)
                        repoDT.Delete(old.MaHD, old.MaDT);
                }

                foreach (ListViewItem item in listView2.Items) {
                    var dt = new HoiDong_DeTai {
                        MaHD = hoiDong.MaHD,
                        MaDT = item.SubItems[1].Text,
                    };

                    repoDT.Insert(dt);
                }
            } else {
                Repository<HoiDong_ChuyenDe> repoDT = new Repository<HoiDong_ChuyenDe>();
                Dictionary<string, int> dic = new Dictionary<string, int>();

                if (_id != null) {
                    var oldItems = repoDT.Filter(x => x.MaHD == hoiDong.MaHD);
                    foreach (var old in oldItems) {
                        dic[old.MaCD] = old.Vong;
                        repoDT.Delete(old.MaHD, old.MaCD);
                    }
                }

                foreach (ListViewItem item in listView2.Items) {
                    var dt = new HoiDong_ChuyenDe {
                        MaHD = hoiDong.MaHD,
                        MaCD = item.SubItems[1].Text,
                        Vong = dic.TryGetValue(item.SubItems[1].Text, out var vong) ? vong : 0
                    };

                    repoDT.Insert(dt);
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
