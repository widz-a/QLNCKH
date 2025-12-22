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
    public partial class FrmChuyenDeEdit : Form {

        private string? _id = null;

        public FrmChuyenDeEdit() {
            InitializeComponent();
            LoadDanhMuc();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;

            this.Shown += (s, e) => {
                txtMaCD.Focus();
            };
        }

        public FrmChuyenDeEdit(string id) : this() {
            _id = id;
            LoadData();

            this.Text = "Sửa thông tin chuyên đề";
            title.Text = "Sửa thông tin chuyên đề";
            btnLuu.Text = "Lưu";

            txtMaCD.Enabled = false;
        }

        private void LoadDanhMuc() {
            Dictionary<string, ComboBox> dicts = new Dictionary<string, ComboBox>() {
                ["Lĩnh vực"] = cbLV,
            };

            foreach (var item in dicts) {
                item.Value.DataSource = DanhMucService.GetAll(item.Key);
                item.Value.DisplayMember = "Ten";
                item.Value.ValueMember = "ID";
                item.Value.SelectedIndex = -1;
            }

            cbSV.DataSource = new Repository<SinhVien>()
                .GetSome(gv => new {
                    Value = gv.MaSV,
                    Display = $"({gv.MaSV}) {gv.HoTen}"
                });

            cbSV.DisplayMember = "Display";
            cbSV.ValueMember = "Value";
            cbSV.SelectedIndex = -1;
        }

        private void LoadData() {
            if (string.IsNullOrEmpty(_id)) return;
            ChuyenDe r = new Repository<ChuyenDe>().GetById(_id);
            if (r == null) return;

            txtMaCD.Text = r.MaCD;
            txtTen.Text = r.TenCD;
            cbLV.SelectedValue = r.LinhVucId;
            cbSV.SelectedValue = r.MaSV;
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateHelper.Required(txtMaCD, "Mã chuyên đề")) return;
            if (!ValidateHelper.Required(txtTen, "Tên chuyên đề")) return;
            if (!ValidateHelper.Required(cbLV, "Lĩnh vực")) return;
            if (!ValidateHelper.Required(cbSV, "Sinh viên")) return;


            //Lưu
            var data = new ChuyenDe {
                MaCD = txtMaCD.Text,
                TenCD = txtTen.Text,
                MaSV = cbSV.SelectedValue.ToString(),
                LinhVucId = (int) cbLV.SelectedValue,
            };


            Repository<ChuyenDe> repo = new Repository<ChuyenDe>();
            if (_id == null) {
                if (repo.Exists(txtMaCD.Text)) {
                    MessageBox.Show("Mã chuyên đề này đã tồn tại", "Lỗi");
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
