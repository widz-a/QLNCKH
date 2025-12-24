using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNCKH.Forms
{
    public partial class FrmHome : Form {
        private FrmMain? _mainForm = null;
        public FrmHome() {
            InitializeComponent();
            btnNopBai.Click += btnNopBai_Click;
        }

        public FrmHome(FrmMain mainForm) : this() {
            _mainForm = mainForm;
        }

        private void btnNopBai_Click(object sender, EventArgs e) {
            _mainForm.LoadForm(new FrmNopDeTaiEdit(), "Nộp sản phẩm");
        }
    }
}
