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

namespace QLNCKH.Forms {
    public partial class FrmSinhVienEdit : Form {

        private string? _id = null;

        public FrmSinhVienEdit() {
            InitializeComponent();
            LoadDanhMuc();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;

            this.Shown += (s, e) => {
                txtMaSV.Focus();
            };
        }

        public FrmSinhVienEdit(string id) : this() {
            _id = id;
            LoadData();

            this.Text = "Sửa thông tin sinh viên";
            title.Text = "Sửa thông tin sinh viên";
            btnLuu.Text = "Lưu";

            txtMaSV.Enabled = false;
        }

        private void LoadDanhMuc() {
            cbDanToc.DataSource = DanhMucService.GetAll("Dân tộc");
            cbDanToc.DisplayMember = "Ten";
            cbDanToc.ValueMember = "ID";
            cbDanToc.SelectedIndex = -1;

            cbTonGiao.DataSource = DanhMucService.GetAll("Tôn giáo");
            cbTonGiao.DisplayMember = "Ten";
            cbTonGiao.ValueMember = "ID";

            cbChucVu.DataSource = DanhMucService.GetAll("Chức vụ");
            cbChucVu.DisplayMember = "Ten";
            cbChucVu.ValueMember = "ID";
            cbChucVu.SelectedIndex = -1;

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
            //cbXa.DataSource = TinhXaBus.GetXasFromTinh((int)cbTinh.SelectedValue);
            cbXa.DisplayMember = "TenXa";
            cbXa.ValueMember = "XaId";
        }

        private void LoadData() {
            if (string.IsNullOrEmpty(_id)) return;
            SinhVien r = new Repository<SinhVien>().GetById(_id);
            if (r == null) return;

            txtMaSV.Text = r.MaSV;
            txtHoTen.Text = r.HoTen;
            txtSDT.Text = r.SDT;
            txtLop.Text = r.Lop;
            txtNganh.Text = r.Nganh;
            txtChuyenNganh.Text = r.ChuyenNganh;

            dtNgaySinh.Value = r.NgaySinh;
            cbDanToc.SelectedValue = r.DanTocId;
            cbTonGiao.SelectedValue = r.TonGiaoId;
            //cbGioiTinh.SelectedIndex = cbGioiTinh.Items.IndexOf(r.GioiTinh.ToString());

            cbTinh.SelectedValue = r.TinhId;
            LoadXa();
            cbXa.SelectedValue = r.XaId;
            cbChucVu.SelectedValue = r.ChucVuId;

            if (cbGioiTinh.Items.Contains(r.GioiTinh))
                cbGioiTinh.SelectedItem = r.GioiTinh;
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateHelper.Required(txtMaSV, "Mã sinh viên")) return;
            if (!ValidateHelper.Required(txtHoTen, "Họ và tên")) return;
            if (!ValidateHelper.Required(txtLop, "Lớp")) return;
            if (!ValidateHelper.Required(cbGioiTinh, "Giới tính")) return;
            if (!ValidateHelper.Required(txtNganh, "Ngành")) return;
            if (!ValidateHelper.Required(txtChuyenNganh, "Chuyên ngành")) return;
            if (!ValidateHelper.Required(cbDanToc, "Dân tộc")) return;
            if (!ValidateHelper.Required(cbTonGiao, "Tôn giáo")) return;
            if (!ValidateHelper.Required(cbChucVu, "Chức vụ")) return;
            if (!ValidateHelper.Phone(txtSDT)) return;
            if (!ValidateHelper.Required(cbTinh, "Nơi sinh")) return;
            if (!ValidateHelper.Required(cbXa, "Nơi sinh")) return;

            //Lưu
            var sv = new SinhVien {
                MaSV = txtMaSV.Text,
                HoTen = txtHoTen.Text,
                SDT = txtSDT.Text,
                Lop = txtLop.Text,
                Nganh = txtNganh.Text,
                ChuyenNganh = txtChuyenNganh.Text,
                NgaySinh = dtNgaySinh.Value,
                GioiTinh = cbGioiTinh.Items[cbGioiTinh.SelectedIndex].ToString(),
                DanTocId = (int)cbDanToc.SelectedValue,
                TonGiaoId = (int)cbTonGiao.SelectedValue,

                TinhId = (int)cbTinh.SelectedValue,
                XaId = (int)cbXa.SelectedValue,
                ChucVuId = (int)cbChucVu.SelectedValue,
            };


            Repository<SinhVien> repo = new Repository<SinhVien>();
            if (_id == null) {
                if (repo.Exists(txtMaSV.Text)) {
                    MessageBox.Show("Mã sinh viên này đã tồn tại", "Lỗi");
                    return;
                }
                repo.Insert(sv);
            }
            else
                repo.Update(sv);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
