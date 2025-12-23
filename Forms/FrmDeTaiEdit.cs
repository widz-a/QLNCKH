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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.ListView;

namespace QLNCKH.Forms {
    public partial class FrmDeTaiEdit : Form {

        private string? _id = null;

        public FrmDeTaiEdit() {
            InitializeComponent();
            LoadDanhMuc();
            LoadDanhMucThanhVien();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;

            this.Shown += (s, e) => {
                //txtMaCB.Focus();
            };

            /*listView1.SelectedIndexChanged += (s, e) => {
                if (listView1.SelectedItems.Count == 0) return;

                ListViewItem item = listView1.SelectedItems[0];
                cbSV.SelectedItem = item.SubItems[1];
                cbVT.SelectedValue = item.SubItems[3];
            };*/

            btnTvThem.Click += (s, e) => {
                if (!ValidateHelper.Required(cbSV, "Sinh viên")) return;
                if (!ValidateHelper.Required(cbVT, "Vai trò")) return;

                var maSV = cbSV.SelectedValue.ToString();
                var sv = new Repository<SinhVien>().GetById(maSV);

                var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(maSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(DanhMucService.GetAll("Vai trò đề tài").Find(x => x.Id == (int)cbVT.SelectedValue).Ten);

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

        public FrmDeTaiEdit(string id) : this() {
            _id = id;
            LoadData();

            this.Text = "Sửa thông tin đề tài NCKH";
            title.Text = "Sửa thông tin đề tài NCKH";
            btnLuu.Text = "Lưu";

            txtMaDT.Enabled = false;
        }

        private void LoadDanhMuc() {
            var lvData = DanhMucService.GetAll("Lĩnh vực");
            cbLV.DataSource = lvData;
            cbLV.DisplayMember = "Ten";
            cbLV.ValueMember = "ID";
            cbLV.SelectedIndex = -1;

            cbGV.DataSource = new Repository<GiangVien>()
                .GetSome(gv => new {
                    Value = gv.MaCB,
                    Display = $"({gv.MaCB}) {gv.HoTen}"
                });

            cbGV.DisplayMember = "Display";
            cbGV.ValueMember = "Value";
            cbGV.SelectedIndex = -1;
        }

        private bool coNhomTruongChua() {
            return listView1.Items
                .Cast<ListViewItem>()
                .Any(i =>
                    i.SubItems.Count > 3 &&
                    i.SubItems[3].Text == "Nhóm trưởng"
                );
        }

        private void LoadDanhMucThanhVien() {
            var vtData = DanhMucService.GetAll("Vai trò đề tài");

            if (coNhomTruongChua()) {
                vtData = vtData
                    .Where(x => x.Ten != "Nhóm trưởng")
                    .ToList();
            }

            cbVT.DataSource = vtData;
            cbVT.DisplayMember = "Ten";
            cbVT.ValueMember = "ID";
            cbVT.SelectedIndex = -1;

            var maSvDaCo = listView1.Items
                .Cast<ListViewItem>()
                .Where(i =>
                    i.SubItems.Count > 1 &&
                    !string.IsNullOrWhiteSpace(i.SubItems[1].Text)
                )
                .Select(i => i.SubItems[1].Text)
                .ToList();


            cbSV.DataSource = new Repository<SinhVien>()
                .Filter(
                    sv => !maSvDaCo.Contains(sv.MaSV),
                    sv => new {
                        Value = sv.MaSV,
                        Display = $"({sv.MaSV}) {sv.HoTen}"
                    }
                );

            cbSV.DisplayMember = "Display";
            cbSV.ValueMember = "Value";
            cbSV.SelectedIndex = -1;
        }

        private void LoadData() {
            if (string.IsNullOrEmpty(_id)) return;
            DeTai r = new Repository<DeTai>().GetById(_id);
            if (r == null) return;

            txtMaDT.Text = r.MaDT;
            txtTen.Text = r.TenDT;
            cbLV.SelectedValue = r.LinhVucId;
            cbGV.SelectedValue = r.MaGVHuongDan;
            dtDate.Value = r.ThoiGianDuKien;

            //Thành viên

            var sinhViens = new Repository<DeTai_SinhVien>().Filter(
                x => x.MaDT == _id,
                x => new {
                    x.MaSV,
                    HoTen = x.SinhVien.HoTen,
                    VaiTro = x.VaiTro.Ten
                }
            );
            foreach (var x in sinhViens) {
                var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(x.MaSV);
                item.SubItems.Add(x.HoTen);
                item.SubItems.Add(x.VaiTro);

                listView1.Items.Add(item);
                LoadDanhMucThanhVien();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateHelper.Required(txtMaDT, "Mã đề tài")) return;
            if (!ValidateHelper.Required(txtTen, "Tên đề tài")) return;
            if (!ValidateHelper.Required(cbLV, "Lĩnh vực")) return;
            if (!ValidateHelper.Required(cbGV, "Giảng viên hướng dẫn")) return;

            if (listView1.Items.Count == 0) {
                MessageBox.Show("Vui lòng thêm thành viên.",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!coNhomTruongChua()) {
                MessageBox.Show("Vui lòng thêm nhóm trưởng",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            //Lưu
            DeTai data = new DeTai {
                MaDT = txtMaDT.Text.Trim(),
                TenDT = txtTen.Text.Trim(),
                LinhVucId = (int)cbLV.SelectedValue,
                MaGVHuongDan = cbGV.SelectedValue.ToString(),
                ThoiGianDuKien = dtDate.Value,
                TrangThaiId = 1
            };


            Repository<DeTai> repo = new Repository<DeTai>();
            if (_id == null) {
                if (repo.Exists(txtMaDT.Text)) {
                    MessageBox.Show("Mã giảng viên này đã tồn tại", "Lỗi");
                    return;
                }
                repo.Insert(data);
            } else
                repo.Update(data);

            // ===== LƯU LẠI THÀNH VIÊN =====
            Repository<DeTai_SinhVien> repoSv = new Repository<DeTai_SinhVien>();

            // 1️⃣ Nếu sửa → xóa hết thành viên cũ
            if (_id != null) {
                var oldItems = repoSv.Filter(x => x.MaDT == data.MaDT);
                foreach (var old in oldItems)
                    repoSv.Delete(old.MaDT, old.MaSV);
            }

            // 2️⃣ Lấy danh mục vai trò (cache 1 lần)
            var dsVaiTro = DanhMucService.GetAll("Vai trò đề tài");

            // 3️⃣ Insert lại từ ListView
            foreach (ListViewItem item in listView1.Items) {
                string maSV = item.SubItems[1].Text;
                string vaiTroTen = item.SubItems[3].Text;

                int vaiTroId = dsVaiTro
                    .First(x => x.Ten == vaiTroTen)
                    .Id;

                var sv = new DeTai_SinhVien {
                    MaDT = data.MaDT,
                    MaSV = maSV,
                    VaiTroId = vaiTroId
                };

                repoSv.Insert(sv);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
