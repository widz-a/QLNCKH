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
    public partial class FrmDeTaiSVEdit : Form {

        private string? _id = null;
        private string? _MaDT = null;

        public FrmDeTaiSVEdit() {
            InitializeComponent();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;
        }

        public FrmDeTaiSVEdit(string MaDT) : this() {
            _MaDT = MaDT;
            LoadDanhMuc();

        }

        public FrmDeTaiSVEdit(string id, string MaDT) : this(MaDT) {
            _id = id;
            LoadData();

            this.Text = "Sửa thông tin";
            title.Text = "Sửa thông tin";
            btnLuu.Text = "Lưu";
        }

        private void LoadDanhMuc() {
            Dictionary<string, ComboBox> dicts = new Dictionary<string, ComboBox>() {
                ["Vai trò đề tài"] = cbVT,
            };

            foreach (var item in dicts) {
                item.Value.DataSource = DanhMucService.GetAll(item.Key);
                item.Value.DisplayMember = "Ten";
                item.Value.ValueMember = "ID";
                item.Value.SelectedIndex = -1;
            }

            var deTai = new Repository<DeTai>().GetById(_MaDT);

            //TODO: Fix this later
            var maSvDaCo = (deTai?.SinhViens ?? Enumerable.Empty<DeTai_SinhVien>())
                .Select(x => x.MaSV)
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
            DeTai_SinhVien r = new Repository<DeTai_SinhVien>().GetById(_id, _MaDT);
            if (r == null) return;

            cbSV.SelectedValue = r.MaSV;
            cbVT.SelectedValue = r.VaiTroId.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateHelper.Required(cbSV, "Sinh viên")) return;
            if (!ValidateHelper.Required(cbVT, "Vai trò")) return;

            //Lưu
            var sv = new DeTai_SinhVien {
                MaDT = _MaDT,
                MaSV = cbSV.SelectedValue.ToString(),
                VaiTroId = (int) cbVT.SelectedValue,
            };


            Repository<DeTai_SinhVien> repo = new Repository<DeTai_SinhVien>();
            if (_id == null) {
                if (repo.Exists(cbSV.SelectedValue, _MaDT)) {
                    MessageBox.Show("Sinh viên này đã có trong nhóm", "Lỗi");
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
