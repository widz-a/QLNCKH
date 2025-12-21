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
            tab.Selected += (s, e) => {
                if (e.TabPage.Name != "tabThanhVien") return;

                //TODO: Sửa
                FormHelper.LoadForm(new FrmList<SinhVien, SinhVienDTO>(
                    new ListContext<SinhVien, SinhVienDTO> {
                        Name = "sinh viên",
                        GetHeaderSelector = (sv => new SinhVienDTO {
                            MaSV = sv.MaSV,
                            HoTen = sv.HoTen,
                            NgaySinh = sv.NgaySinh,
                            Lop = sv.Lop
                        }),
                        IdColumn = "MaSV",
                        HeaderNames = new Dictionary<string, string> {
                            ["MaSV"] = "Mã sinh viên",
                            ["HoTen"] = "Họ và tên",
                            ["NgaySinh"] = "Ngày sinh",
                            ["Lop"] = "Lớp",
                        },
                        GetEditForm = id => new FrmSinhVienEdit(id),
                        GetCreateForm = () => new FrmSinhVienEdit(),
                    }
                ), pnlMain);
            };
        }

        public FrmDeTaiEdit(string id) : this() {
            _id = id;
            LoadData();

            this.Text = "Sửa thông tin giảng viên";
            title.Text = "Sửa thông tin giảng viên";
            btnLuu.Text = "Lưu";

            //txtMaCB.Enabled = false;
        }

        private void LoadDanhMuc() {
            Dictionary<string, ComboBox> dicts = new Dictionary<string, ComboBox>() {


            };

            foreach (var item in dicts) {
                item.Value.DataSource = DanhMucService.GetAll(item.Key);
                item.Value.DisplayMember = "Ten";
                item.Value.ValueMember = "ID";
                item.Value.SelectedIndex = -1;
            }
        }

        private void LoadXa() {

        }

        private void LoadData() {
            if (string.IsNullOrEmpty(_id)) return;
            GiangVien r = new Repository<GiangVien>().GetById(_id);
            if (r == null) return;


        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate


            //Lưu
            /*var data;


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
            Close();*/
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
