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
    public partial class FrmDanhMuc : Form {

        private int selectedId = -1;

        public FrmDanhMuc() {
            InitializeComponent();

            cboDanhMuc.DataSource = new BindingSource(DanhMucBUS.Map, null);
            cboDanhMuc.DisplayMember = "Key";
            cboDanhMuc.ValueMember = "Key";
            cboDanhMuc.SelectedIndexChanged += (s, e) => LoadData();

            DataGridViewStyle.Apply(dgvDanhMuc);
            dgvDanhMuc.CellClick += DgvDanhMuc_CellClick;

            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnThem.Click += btnThem_Click;

            LoadData();
        }

        private void LoadData() {
            if (cboDanhMuc.SelectedValue == null) return;

            string key = cboDanhMuc.SelectedValue.ToString();
            dgvDanhMuc.DataSource = DanhMucBUS.GetAll(key);

            selectedId = -1;
            txtTen.Clear();
        }

        private void DgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            selectedId = Convert.ToInt32(dgvDanhMuc.Rows[e.RowIndex].Cells[0].Value);
            txtTen.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtTen.Text)) return;

            DanhMucBUS.Add(cboDanhMuc.SelectedValue.ToString(), txtTen.Text);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (selectedId < 0) return;

            DanhMucBUS.Update(
                cboDanhMuc.SelectedValue.ToString(),
                selectedId,
                txtTen.Text
            );
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            if (selectedId < 0) return;

            if (MessageBox.Show("Xóa mục này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes) {
                DanhMucBUS.Delete(cboDanhMuc.SelectedValue.ToString(), selectedId);
                LoadData();
            }
        }
    }
}
