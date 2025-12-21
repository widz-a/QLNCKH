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

namespace QLNCKH.Forms {
    public partial class FrmDeTaiEdit : Form {

        private string? _id = null;

        public FrmDeTaiEdit() {
            InitializeComponent();
            LoadDanhMuc();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;

            this.Shown += (s, e) => {
                //txtMaCB.Focus();
            };

            //Thanh viên tab => FrmList
            tab.Selecting += (s, e) => {
                if (e.TabPage.Name != "tabThanhVien") return;
                if (_id == null) {
                    MessageBox.Show(
                        "Vui lòng lưu đề tài trước khi thêm thành viên.",
                        "Chưa thể chuyển tab",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    e.Cancel = true;
                }

                MessageBox.Show(txtMaDT.Text);

                FormHelper.LoadForm(new FrmList<DeTai_SinhVien, DeTai_SinhVienDto>(
                    new ListContext<DeTai_SinhVien, DeTai_SinhVienDto> {
                        Name = "sinh viên",
                        GetHeaderSelector = (sv => new DeTai_SinhVienDto {
                            MaSV = sv.MaSV,
                            HoTen = sv.SinhVien.HoTen,
                            Lop = sv.SinhVien.Lop,
                            VaiTro = sv.VaiTro.TenVaiTro
                        }),
                        IdColumn = "MaSV",
                        HeaderNames = new Dictionary<string, string> {
                            ["MaSV"] = "Mã sinh viên",
                            ["HoTen"] = "Họ và tên",
                            ["VaiTro"] = "Vai trò",
                            ["Lop"] = "Lớp",
                        },
                        GetEditForm = id => new FrmDeTaiSVEdit(id[0], txtMaDT.Text), //TODO
                        GetCreateForm = () => new FrmDeTaiSVEdit(txtMaDT.Text), //TODO
                        ExtraIds = [txtMaDT.Text]
                    }
                ), pnlMain);
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
            Dictionary<string, ComboBox> dicts = new Dictionary<string, ComboBox>() {
                ["Lĩnh vực"] = cbLV,
            };

            foreach (var item in dicts) {
                item.Value.DataSource = DanhMucService.GetAll(item.Key);
                item.Value.DisplayMember = "Ten";
                item.Value.ValueMember = "ID";
                item.Value.SelectedIndex = -1;
            }

            cbGV.DataSource = new Repository<GiangVien>()
                .GetSome(gv => new {
                    Value = gv.MaCB,
                    Display = $"({gv.MaCB}) {gv.HoTen}"
                });

            cbGV.DisplayMember = "Display";
            cbGV.ValueMember = "Value";
            cbGV.SelectedIndex = -1;
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
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateHelper.Required(txtMaDT, "Mã đề tài")) return;
            if (!ValidateHelper.Required(txtTen, "Tên đề tài")) return;
            if (!ValidateHelper.Required(cbLV, "Lĩnh vực")) return;
            if (!ValidateHelper.Required(cbGV, "Giảng viên hướng dẫn")) return;

            //Lưu
            DeTai data = new DeTai {
                MaDT = txtMaDT.Text.Trim(),
                TenDT = txtTen.Text.Trim(),
                LinhVucId = (int)cbLV.SelectedValue,
                MaGVHuongDan = cbGV.SelectedValue.ToString(),
                ThoiGianDuKien = dtDate.Value,
            };


            Repository<DeTai> repo = new Repository<DeTai>();
            if (_id == null) {
                if (repo.Exists(txtMaDT.Text)) {
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
