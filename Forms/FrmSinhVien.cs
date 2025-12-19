using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNCKH.Forms {
    public partial class FrmSinhVien : Form {
        public FrmSinhVien() {
            InitializeComponent();
            LoadData();
            
            StyleHelper.ApplyDGV(dgvSinhVien);

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
        }

        private void LoadData() {
            //DataGridViewStyle.Apply(dgvSinhVien);
            dgvSinhVien.DataSource = new Repository<SinhVien>().GetSome(sv => new {
                sv.MaSV,
                sv.HoTen,
                sv.NgaySinh,
                sv.Lop
            });
            dgvSinhVien.Columns["MaSV"].HeaderText = "Mã sinh viên";
            dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["Lop"].HeaderText = "Lớp";
        }

        private string? GetSelectedId() {
            if (dgvSinhVien.SelectedRows.Count == 0) return null;
            return dgvSinhVien.SelectedRows[0].Cells["Mã sinh viên"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e) {
            using (var f = new FrmSinhVienEdit()) {
                if (f.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e) {
            string id = GetSelectedId();
            if (id == null) return;
            using (var f = new FrmSinhVienEdit(id)) {
                if (f.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            string id = GetSelectedId();
            if (id == null) return;

            if (MessageBox.Show("Xóa sinh viên này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes) {
                //SinhVienBUS.Delete(id);
                new Repository<SinhVien>().Delete(id);
                LoadData();
            }
        }
    }
}
