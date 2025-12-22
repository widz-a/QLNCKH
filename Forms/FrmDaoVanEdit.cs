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
    public partial class FrmDaoVanEdit : Form {
        public FrmDaoVanEdit() {
            InitializeComponent();
            LoadDanhMuc();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;

            this.Shown += (s, e) => {
                cbDT.Focus();
            };

            cbDT.SelectedIndexChanged += cbDT_SelectedIndexChanged;
            txtTyLe.Leave += txtTyLe_Leave;
        }

        private void LoadDanhMuc() {
            cbDT.DataSource = new Repository<DeTai>()
                .GetSome(dt => new {
                    Value = dt.MaDT,
                    Display = $"({dt.MaDT}) {dt.TenDT}"
                });

            cbDT.DisplayMember = "Display";
            cbDT.ValueMember = "Value";
            cbDT.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateHelper.Required(cbDT, "Đề tài")) return;
            if (!ValidateHelper.RequiredDouble(txtTyLe, "Tỷ lệ")) return;


            //Lưu
            var data = new DaoVan {
                MaDT = cbDT.SelectedValue.ToString(),
                TyLeTrungLap = double.Parse(txtTyLe.Text),
                KetLuan = txtKQ.Text,
                LanQuet = int.Parse(txtLanQuet.Text)
            };


            Repository<DaoVan> repo = new Repository<DaoVan>();
            repo.Insert(data);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            Close();
        }

        private void cbDT_SelectedIndexChanged(object sender, EventArgs e) {
            var daoVanCu = new Repository<DaoVan>().Filter(sp => sp.MaDT == cbDT.SelectedValue.ToString());
            if (daoVanCu == null || daoVanCu.Count == 0)
                txtLanQuet.Text = "1";
            else
                txtLanQuet.Text = (daoVanCu.Count + 1).ToString();
        }

        private void txtTyLe_Leave(object sender, EventArgs e) {
            if (!ValidateHelper.RequiredPercentage(txtTyLe, "Tỷ lệ")) return;
            double tyLe = double.Parse(txtTyLe.Text);
            txtKQ.Text = tyLe > 20 ? "Không đạt" : "Đạt";
        }
    }
}
