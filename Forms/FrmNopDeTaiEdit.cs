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
            LoadLoai();
            cbLoai.SelectedIndexChanged += CbLoai_SelectedIndexChanged;
            cbMa.SelectedIndexChanged += CbMaTen_SelectedIndexChanged;
            btnNop.Click += btnNop_Click;
        }
        public FrmNopDeTaiEdit(string id) : this()
        {
        }

        private void LoadLoai()
        {
            cbLoai.Items.Clear();
            cbLoai.Items.Add("Đề tài");
            cbLoai.Items.Add("Chuyên đề");
            cbLoai.SelectedIndex = -1;

            cbTrangThai.DataSource = DanhMucService.GetAll("Trạng thái đề tài");
            cbTrangThai.DisplayMember = "Ten";
            cbTrangThai.ValueMember = "ID";
            cbTrangThai.SelectedIndex = -1;
        }

        private void LoadData()
        {
        }
        private void CbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedItem == null) return;
            string loai = cbLoai.SelectedItem.ToString();

            if (loai == "Đề tài")
            {
                cbMa.DataSource = new Repository<DeTai>().GetAll();
                cbMa.DisplayMember = "MaDT";
                cbMa.ValueMember = "MaDT";
            }
            else
            {
                cbMa.DataSource = new Repository<ChuyenDe>().GetAll();
                cbMa.DisplayMember = "MaCD";
                cbMa.ValueMember = "MaCD";
            }
            cbMa.SelectedIndex = -1;
            txtTen.Clear();
            cbNguoiNop.DataSource = null;
        }

        private void CbMaTen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMa.SelectedValue == null || cbLoai.SelectedItem == null) return;

            string loai = cbLoai.SelectedItem.ToString();
            string ma = cbMa.SelectedValue.ToString();

            // Hiển thị tên sản phẩm
            if (loai == "Đề tài")
            {
                var dt = new Repository<DeTai>().GetById(ma);
                txtTen.Text = dt?.TenDT ?? "";
                // Lấy danh sách người nộp là thành viên nhóm
                var thanhVien = new Repository<DeTai_SinhVien>()
                                   .Filter(x => x.MaDT == ma)
                                   .Select(x => x.SinhVien)
                                   .ToList();
                cbNguoiNop.DataSource = thanhVien;
                cbNguoiNop.DisplayMember = "HoTen";
                cbNguoiNop.ValueMember = "MaSV";
            }
            else
            {
                var cd = new Repository<ChuyenDe>().GetById(ma);
                txtTen.Text = cd?.TenCD ?? "";
                // Lấy danh sách người nộp là thành viên nhóm
                var thanhVien = new List<SinhVien>();
                if (cd != null && !string.IsNullOrEmpty(cd.MaSV))
                {
                    var sv = new Repository<SinhVien>().GetById(cd.MaSV);
                    if (sv != null) thanhVien.Add(sv);
                }
                cbNguoiNop.DataSource = thanhVien;
                cbNguoiNop.DisplayMember = "HoTen";
                cbNguoiNop.ValueMember = "MaSV";
            }

            cbNguoiNop.SelectedIndex = -1;
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            if (cbLoai.SelectedIndex == -1 || cbMa.SelectedIndex == -1 || cbNguoiNop.SelectedIndex == -1 || cbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

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

        }
        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 }

