using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNCKH.Forms
{
    public partial class FrmHome : Form
    {
        private FrmMain? _mainForm = null;
        public FrmHome()
        {
            InitializeComponent();
            btnDkDT.Click += (s, e) => new FrmDeTaiEdit().ShowDialog();
            btnDkCD.Click += (s, e) => new FrmChuyenDeEdit().ShowDialog();
            btnNopBai.Click += (s, e) => _mainForm.LoadForm(new FrmNopDeTaiEdit(), "Nộp sản phẩm");
            btnKQ.Click += (s, e) => _mainForm.LoadForm(new FrmKetQua(), "Kết quả");

            //Show data

            lblTongDeTaiValue.Text = new Repository<DeTai>().GetAll().Count.ToString();
            lblSinhVienValue.Text = new Repository<SinhVien>().GetAll().Count.ToString();
            lblGiangVienValue.Text = new Repository<GiangVien>().GetAll().Count.ToString();

            /*
             "Nhất"
                            : i < 8 ? "Nhì"
                            : i < 15 ? "Ba"
                            : i < 25 ? "Khuyến khích"
             */

            lblGiaiNhatValue.Text = getSoLuongGiai("Nhất").ToString();
            lblGiaiNhiValue.Text = getSoLuongGiai("Nhì").ToString();
            lblGiaiBaValue.Text = getSoLuongGiai("Ba").ToString();
            lblGiaiKKValue.Text = getSoLuongGiai("Khuyến khích").ToString();
        }

        public FrmHome(FrmMain mainForm) : this()
        {
            _mainForm = mainForm;
        }

        private int getSoLuongGiai(string giai) {
            return
            new Repository<KetQua_ChuyenDe>()
                .Filter(kq => kq.Giai == giai).Count
                +
            new Repository<KetQua_DeTai>()
                .Filter(kq => kq.Giai == giai).Count;
        }
    }
}
