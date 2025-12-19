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

            title.Text = "Sửa thông tin sinh viên";
            btnLuu.Text = "Lưu";
        }

        private void LoadDanhMuc() {
            cbDanToc.DataSource = DanhMucBUS.GetAll("Dân tộc");
            cbDanToc.DisplayMember = "Tên";
            cbDanToc.ValueMember = "ID";
            cbDanToc.SelectedIndex = -1;

            cbTonGiao.DataSource = DanhMucBUS.GetAll("Tôn giáo");
            cbTonGiao.DisplayMember = "Tên";
            cbTonGiao.ValueMember = "ID";

            cbChucVu.DataSource = DanhMucBUS.GetAll("Chức vụ");
            cbChucVu.DisplayMember = "Tên";
            cbChucVu.ValueMember = "ID";
            cbChucVu.SelectedIndex = -1;

            cbTinh.DataSource = TinhXaBus.GetTinhs();
            cbTinh.DisplayMember = "TenTinh";
            cbTinh.ValueMember = "TinhId";
            cbTinh.SelectedIndex = -1;
            cbTinh.SelectedIndexChanged += (s, e) => LoadXa();
        }

        private void LoadXa() {
            cbXa.Enabled = true;
            cbXa.DataSource = TinhXaBus.GetXasFromTinh((int)cbTinh.SelectedValue);
            cbXa.DisplayMember = "TenXa";
            cbXa.ValueMember = "XaId";
        }

        private void LoadData() {
            var dt = SinhVienBUS.GetById(_id);
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            txtMaSV.Text = r["MaSV"].ToString();
            txtHoTen.Text = r["HoTen"].ToString();
            txtSDT.Text = r["SDT"].ToString();
            txtLop.Text = r["Lop"].ToString();
            txtNganh.Text = r["Nganh"].ToString();
            txtChuyenNganh.Text = r["ChuyenNganh"].ToString();

            dtNgaySinh.Value = Convert.ToDateTime(r["NgaySinh"]);
            cbDanToc.SelectedValue = r["DanTocId"];
            cbTonGiao.SelectedValue = r["TonGiaoId"];
            cbGioiTinh.SelectedIndex = cbGioiTinh.Items.IndexOf(r["GioiTinh"].ToString());

            cbTinh.SelectedValue = r["TinhId"];
            LoadXa();
            cbXa.SelectedValue = r["XaId"];
            cbChucVu.SelectedValue = r["ChucVuId"];
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateHelper.RequiredSafe(txtMaSV, "Mã sinh viên")) return;
            if (!ValidateHelper.RequiredSafe(txtHoTen, "Họ và tên")) return;
            if (!ValidateHelper.RequiredSafe(txtLop, "Lớp")) return;
            if (!ValidateHelper.Required(cbGioiTinh, "Giới tính")) return;
            if (!ValidateHelper.RequiredSafe(txtNganh, "Ngành")) return;
            if (!ValidateHelper.RequiredSafe(txtChuyenNganh, "Chuyên ngành")) return;
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

            if (_id == null) {
                if (SinhVienBUS.GetById(sv.MaSV).Rows.Count != 0) {
                    MessageBox.Show("Mã sinh viên này đã tồn tại", "Lỗi");
                    return;
                }
                SinhVienBUS.Insert(sv);
            }
            else
                SinhVienBUS.Update(_id, sv);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
