using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLNCKH.Forms.ChamDiem {
    public partial class FrmDiem : Form {
        public FrmDiem() {
            InitializeComponent();
        }

        public double Diem { get; private set; }

        private void button1_Click(object sender, EventArgs e) {
            double diem;
            if (!double.TryParse(textBox1.Text, out diem) || diem > 10 || diem < 0) {
                MessageBox.Show($"Điểm phải là số hợp lệ từ 0 đến 10.",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            Diem = diem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
