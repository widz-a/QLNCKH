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

            cbTonGiao.DataSource = DanhMucBUS.GetAll("Tôn giáo");
            cbTonGiao.DisplayMember = "Tên";
            cbTonGiao.ValueMember = "ID";

            cbChucVu.DataSource = DanhMucBUS.GetAll("Chức vụ");
            cbChucVu.DisplayMember = "Tên";
            cbChucVu.ValueMember = "ID";

            cbTinh.DataSource = TinhXaBus.GetTinhs();
            cbTinh.DisplayMember = "TenTinh";
            cbTinh.ValueMember = "TinhId";
            cbTinh.SelectedIndexChanged += (s, e) => LoadXa();
            LoadXa();
        }

        private void LoadXa() {
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

            if (_id == null)
                SinhVienBUS.Insert(sv);
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
