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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNCKH.Forms
{
    public partial class FrmNopDeTaiEdit : Form
    {
        public FrmNopDeTaiEdit()
        {
            InitializeComponent();
            LoadComboBoxes();
            cbLoai.SelectedIndexChanged += CbLoai_SelectedIndexChanged;
            cbMa.SelectedIndexChanged += cbMa_SelectedIndexChanged;
            btnLuu.Click += btnLuu_Click;
        }

        private void LoadComboBoxes()
        {
            cbLoai.Items.Clear();
            cbLoai.Items.Add("Đề tài");
            cbLoai.Items.Add("Chuyên đề");
            cbLoai.SelectedIndex = -1;

        }
        private void CbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedItem == null) return;
            string loai = cbLoai.SelectedItem.ToString();
            cbMa.SelectedIndex = -1;

            if (loai == "Đề tài")
            {
                cbMa.DataSource = new Repository<DeTai>()
                .GetSome(x => new {
                    Value = x.MaDT,
                    Display = $"({x.MaDT}) {x.TenDT}"
                });
            }
            else
            {
                cbMa.DataSource = new Repository<ChuyenDe>()
                .GetSome(x => new {
                    Value = x.MaCD,
                    Display = $"({x.MaCD}) {x.MaCD}"
                });
            }
            cbMa.DisplayMember = "Display";
            cbMa.ValueMember = "Value";
            cbMa.SelectedIndex = -1;
        }

        private void cbMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedIndex <= -1|| cbMa.SelectedIndex <= -1) return;

            string loai = cbLoai.SelectedItem.ToString();
            string ma = cbMa.SelectedValue.ToString();

            if (loai == "Đề tài")
            {
                // Lấy danh sách người nộp là thành viên nhóm
                var thanhVien = new Repository<DeTai_SinhVien>()
                    .Filter(
                        x => x.MaDT == ma,
                        x => new {
                            x.SinhVien.MaSV,
                            x.SinhVien.HoTen
                        }
                    );
                cbNguoiNop.DataSource = thanhVien;
                cbNguoiNop.DisplayMember = "HoTen";
                cbNguoiNop.ValueMember = "MaSV";
                cbNguoiNop.SelectedIndex = -1;

                //nộp bản mềm, nộp bản cứng, nộp sau chỉnh sửa
                cbTrangThai.Items.Clear();

                var dt = new Repository<DeTai>().GetById(ma);
                if (dt == null) return;
                if (dt.TrangThaiId == null || dt.TrangThaiId < 3) cbTrangThai.Items.Add("Nộp bản mềm");
                if (dt.TrangThaiId == null || dt.TrangThaiId < 4) cbTrangThai.Items.Add("Nộp bản cứng");
                cbTrangThai.Items.Add("Nộp sau chỉnh sửa");
                cbTrangThai.SelectedIndex = -1;

            }
            else
            {
                var cd = new Repository<ChuyenDe>().GetById(ma);
                var thanhVien = new List<SinhVien>();
                if (cd != null && !string.IsNullOrEmpty(cd.MaSV))
                {
                    var sv = new Repository<SinhVien>().GetById(cd.MaSV);
                    if (sv != null) thanhVien.Add(sv);
                }
                cbNguoiNop.DataSource = thanhVien;
                cbNguoiNop.DisplayMember = "HoTen";
                cbNguoiNop.ValueMember = "MaSV";
                cbNguoiNop.SelectedIndex = -1;

                cbTrangThai.Items.Clear();
                cbTrangThai.Items.Add("Nộp bản mềm");
                cbTrangThai.Items.Add("Nộp bản cứng");
                cbTrangThai.Items.Add("Nộp sau chỉnh sửa");
                cbTrangThai.SelectedIndex = -1;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateHelper.Required(cbLoai, "Loại sản phẩm")) return;
            if (!ValidateHelper.Required(cbMa, "Sản phẩm")) return;
            if (!ValidateHelper.Required(cbTrangThai, "Trạng thái")) return;
            if (!ValidateHelper.Required(cbNguoiNop, "Người nộp")) return;

            var nop = new NopSanPham
            {
                Loai = cbLoai.SelectedItem.ToString(),
                MaSo = cbMa.SelectedValue.ToString(),
                NguoiNop = cbNguoiNop.SelectedValue.ToString(),
                TrangThaiNop = cbTrangThai.SelectedItem.ToString(),
                NgayNop = DateTime.Now
            };

            new Repository<NopSanPham>().Insert(nop);
            MessageBox.Show("Nộp sản phẩm thành công!");

            cbLoai.SelectedIndex = -1;
            cbTrangThai.DataSource = null;
            cbTrangThai.Items.Clear();
            cbMa.DataSource = null;
            cbMa.Items.Clear();
            cbNguoiNop.DataSource = null;
            cbNguoiNop.Items.Clear();

            // Logic sửa trạng thái đề tài
            if (nop.Loai != "Đề tài") return;
            var dt = new Repository<DeTai>().GetById(nop.MaSo);

            switch (nop.TrangThaiNop) {
                case "Nộp bản mềm":
                    if (dt.TrangThaiId < 3) dt.TrangThaiId = 3;
                    new Repository<DeTai>().Update(dt);
                    break;
                default:
                    if (dt.TrangThaiId < 4) dt.TrangThaiId = 4;
                    new Repository<DeTai>().Update(dt);
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 }

