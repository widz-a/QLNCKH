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
        }

        private void LoadDanhMuc() {
            cboDanToc.DataSource = DanhMucBUS.GetAll("Dân tộc");
            cboDanToc.DisplayMember = "Tên";
            cboDanToc.ValueMember = "ID";

            cboTonGiao.DataSource = DanhMucBUS.GetAll("Tôn giáo");
            cboTonGiao.DisplayMember = "Tên";
            cboTonGiao.ValueMember = "ID";

            cboChucVu.DataSource = DanhMucBUS.GetAll("Chức vụ");
            cboChucVu.DisplayMember = "Tên";
            cboChucVu.ValueMember = "ID";

            cboTinh.DataSource = TinhXaBus.GetTinhs();
            cboTinh.DisplayMember = "TenTinh";
            cboTinh.ValueMember = "TinhId";
            cboTinh.SelectedIndexChanged += (s, e) => LoadXa();
            LoadXa();
        }

        private void LoadXa() {
            cboXa.DataSource = TinhXaBus.GetXasFromTinh((int)cboTinh.SelectedValue);
            cboXa.DisplayMember = "TenXa";
            cboXa.ValueMember = "XaId";
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
            txtNganh.Text = r["ChuyenNganh"].ToString(); //TODO

            dtNgaySinh.Value = Convert.ToDateTime(r["NgaySinh"]);
            cboDanToc.SelectedValue = r["DanTocId"];
            cboTonGiao.SelectedValue = r["TonGiaoId"];
            cboGioiTinh.SelectedText = (string)r["GioiTinh"];

            cboTinh.SelectedValue = r["TinhId"];
            cboXa.SelectedValue = r["XaId"];
            cboChucVu.SelectedValue = r["ChucVuId"];
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            var sv = new SinhVien {
                MaSV = txtMaSV.Text,
                HoTen = txtHoTen.Text,
                SDT = txtSDT.Text,
                Lop = txtLop.Text,
                Nganh = txtNganh.Text,
                ChuyenNganh = txtNganh.Text, //TODO
                NgaySinh = dtNgaySinh.Value,
                GioiTinh = cboGioiTinh.SelectedText,
                DanTocId = (int)cboDanToc.SelectedValue,
                TonGiaoId = (int)cboTonGiao.SelectedValue,

                TinhId = (int)cboTinh.SelectedValue,
                XaId = (int)cboXa.SelectedValue,
                ChucVuId = (int)cboChucVu.SelectedValue,
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
