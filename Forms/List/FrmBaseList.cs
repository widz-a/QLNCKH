
namespace QLNCKH.Forms {
    public partial class FrmBaseList : Form {
        public void PublicInitializeComponent() {
            InitializeComponent();
        }

        public DataGridView GetDgv() {
            return dgvSinhVien;
        }

        public ReaLTaiizor.Controls.Button GetButtonThem() {
            return btnThem;
        }

        public ReaLTaiizor.Controls.Button GetButtonXoa() {
            return btnXoa;
        }

        public ReaLTaiizor.Controls.Button GetButtonSua() {
            return btnSua;
        }
    }
}
