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

namespace QLNCKH.Forms {
    public partial class FrmGiangVienEdit : Form {

        private string? _id = null;

        public FrmGiangVienEdit() {
            InitializeComponent();
            LoadDanhMuc();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;

            this.Shown += (s, e) => {
                txtMaCB.Focus();
            };
        }

        public FrmGiangVienEdit(string id) : this() {
            _id = id;
            LoadData();

            this.Text = "Sửa thông tin giảng viên";
            title.Text = "Sửa thông tin giảng viên";
            btnLuu.Text = "Lưu";

            txtMaCB.Enabled = false;
        }

        private void LoadDanhMuc() {
            Dictionary<string, ComboBox> dicts = new Dictionary<string, ComboBox>() {
                ["Cấp bậc"] = cbCapBac,
                ["Đơn vị công tác"] = cbDV,
                ["Dân tộc"] = cbDanToc,
                ["Tôn giáo"] = cbTonGiao,
                ["Học hàm"] = cbHocHam,
                ["Học vị"] = cbHocVi,
                ["Chức vụ"] = cbChucVu,
                ["Trình độ CM"] = cbTDCM,
                ["Trình độ LLCT"] = cbLLCT,
                ["Trình độ LLCT"] = cbLLCT,
                ["Chức danh"] = cbChucDanh,

            };

            foreach (var item in dicts) {
                item.Value.DataSource = DanhMucService.GetAll(item.Key);
                item.Value.DisplayMember = "Ten";
                item.Value.ValueMember = "ID";
                item.Value.SelectedIndex = -1;
            }

            cbTinh.DataSource = new Repository<Tinh>().GetAll();
            cbTinh.DisplayMember = "TenTinh";
            cbTinh.ValueMember = "TinhId";
            cbTinh.SelectedIndex = -1;
            cbTinh.SelectedIndexChanged += (s, e) => LoadXa();
        }

        private void LoadXa() {
            if (cbTinh.SelectedValue == null) return;

            cbXa.Enabled = true;
            cbXa.DataSource = new Repository<Xa>().Filter(x => x.TinhId == (int)cbTinh.SelectedValue);
            cbXa.DisplayMember = "TenXa";
            cbXa.ValueMember = "XaId";
        }

        private void LoadData() {
            if (string.IsNullOrEmpty(_id)) return;
            GiangVien r = new Repository<GiangVien>().GetById(_id);
            if (r == null) return;

            // Tỉnh and gender first cuz difficult
            cbTinh.SelectedValue = r.TinhId;
            LoadXa();
            cbXa.SelectedValue = r.XaId;
            if (cbGioiTinh.Items.Contains(r.GioiTinh))
                cbGioiTinh.SelectedItem = r.GioiTinh;

            txtMaCB.Text = r.MaCB;
            txtHoTen.Text = r.HoTen;
            txtSDT.Text = r.SDT;
            txtHSL.Text = r.HeSoLuong.ToString();
            txtLVCM.Text = r.LinhVucChuyenMon;
            dtNgaySinh.Value = r.NgaySinh;

            cbCapBac.SelectedValue = r.CapBacId;
            cbDanToc.SelectedValue = r.DanTocId;
            cbTonGiao.SelectedValue = r.TonGiaoId;
            cbChucVu.SelectedValue = r.ChucVuId;
            cbHocHam.SelectedValue = r.HocHamId;
            cbHocVi.SelectedValue = r.HocViId;
            cbTDCM.SelectedValue = r.TrinhDoCMId;
            cbLLCT.SelectedValue = r.TrinhDoLLCTId;
            cbChucDanh.SelectedValue = r.ChucDanhId;
            cbDV.SelectedValue = r.MaDV;
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateHelper.RequiredSafe(txtMaCB, "Mã cán bộ")) return;
            if (!ValidateHelper.RequiredSafe(txtHoTen, "Họ tên")) return;
            if (!ValidateHelper.RequiredSafe(txtLVCM, "Lĩnh vực chuyên môn")) return;

            if (!ValidateHelper.RequiredDouble(txtHSL, "Hệ số lương")) return;

            if (!ValidateHelper.Required(txtSDT, "Số điện thoại")) return;
            if (!ValidateHelper.Phone(txtSDT)) return;

            if (!ValidateHelper.Required(cbCapBac, "Cấp bậc")) return;
            if (!ValidateHelper.Required(cbDV, "Đơn vị công tác")) return;
            if (!ValidateHelper.Required(cbGioiTinh, "Giới tính")) return;
            if (!ValidateHelper.Required(cbDanToc, "Dân tộc")) return;
            if (!ValidateHelper.Required(cbTonGiao, "Tôn giáo")) return;
            if (!ValidateHelper.Required(cbTinh, "Tỉnh")) return;
            if (!ValidateHelper.Required(cbXa, "Xã")) return;
            if (!ValidateHelper.Required(cbChucVu, "Chức vụ")) return;
            if (!ValidateHelper.Required(cbHocHam, "Học hàm")) return;
            if (!ValidateHelper.Required(cbHocVi, "Học vị")) return;
            if (!ValidateHelper.Required(cbTDCM, "Trình độ CM")) return;
            if (!ValidateHelper.Required(cbLLCT, "Trình độ LLCT")) return;
            if (!ValidateHelper.Required(cbChucDanh, "Chức danh")) return;

            //Lưu
            var data = new GiangVien {
                MaCB = txtMaCB.Text,
                CapBacId = (int) cbCapBac.SelectedValue,
                HeSoLuong = double.Parse(txtHSL.Text), //Validated so safe
                HoTen = txtHoTen.Text,
                MaDV = (int) cbDV.SelectedValue,
                SDT = txtSDT.Text,
                NgaySinh = dtNgaySinh.Value,
                GioiTinh = cbGioiTinh.Items[cbGioiTinh.SelectedIndex].ToString(),
                DanTocId = (int) cbDanToc.SelectedValue,
                TonGiaoId = (int) cbTonGiao.SelectedValue,
                TinhId = (int) cbTinh.SelectedValue,
                XaId = (int) cbXa.SelectedValue,
                ChucVuId = (int) cbChucVu.SelectedValue,
                HocHamId = (int) cbHocHam.SelectedValue,
                HocViId = (int) cbHocVi.SelectedValue,
                TrinhDoCMId = (int) cbTDCM.SelectedValue,
                TrinhDoLLCTId = (int) cbLLCT.SelectedValue,
                LinhVucChuyenMon = txtLVCM.Text,
                ChucDanhId = (int) cbChucDanh.SelectedValue
            };


            Repository<GiangVien> repo = new Repository<GiangVien>();
            if (_id == null) {
                if (repo.Exists(txtMaCB.Text)) {
                    MessageBox.Show("Mã giảng viên này đã tồn tại", "Lỗi");
                    return;
                }
                repo.Insert(data);
            }
            else
                repo.Update(data);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
