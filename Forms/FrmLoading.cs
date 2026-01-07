using Microsoft.EntityFrameworkCore;
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
    public partial class FrmLoading : Form {
        public FrmLoading() {
            InitializeComponent();
            Run();
        }

        private async void Run() {
            //Database Warm up
            using (var db = new AppDbContext()) {
                await db.Database.OpenConnectionAsync();
                await db.Database.CloseConnectionAsync();
            }

            await Task.Delay(1000);

            this.Hide();
            using (var f = new FrmMain()) {
                f.ShowDialog();
            }
            this.Close();
        }
    }
}
