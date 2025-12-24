using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNCKH.Forms
{
    public partial class FrmHome : Form
    {

        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            new FrmNopDeTaiEdit().ShowDialog();
        }
    }
}
