namespace QLNCKH
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pnlSidebar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            logo_c500 = new PictureBox();
            label1 = new Label();
            pnlMain = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            title = new ReaLTaiizor.Controls.FoxBigLabel();
            pnlSidebar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_c500).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(33, 42, 57);
            pnlSidebar.Controls.Add(tableLayoutPanel1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 718);
            pnlSidebar.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(logo_c500, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(214, 66);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // logo_c500
            // 
            logo_c500.Dock = DockStyle.Fill;
            logo_c500.Image = (Image)resources.GetObject("logo_c500.Image");
            logo_c500.Location = new Point(3, 3);
            logo_c500.Name = "logo_c500";
            logo_c500.Size = new Size(68, 60);
            logo_c500.SizeMode = PictureBoxSizeMode.Zoom;
            logo_c500.TabIndex = 0;
            logo_c500.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(77, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 66);
            label1.TabIndex = 1;
            label1.Text = "Hệ thống quản lý NCKH Học viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.Control;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(3, 88);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(834, 627);
            pnlMain.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(title, 0, 0);
            tableLayoutPanel2.Controls.Add(pnlMain, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(220, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.83844F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.16156F));
            tableLayoutPanel2.Size = new Size(840, 718);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // title
            // 
            title.BackColor = Color.Transparent;
            title.Dock = DockStyle.Top;
            title.Font = new Font("Segoe UI Semibold", 20F);
            title.ForeColor = Color.Black;
            title.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            title.LineColor = Color.FromArgb(200, 200, 200);
            title.Location = new Point(20, 20);
            title.Margin = new Padding(20, 20, 20, 0);
            title.Name = "title";
            title.Size = new Size(800, 49);
            title.TabIndex = 5;
            title.Text = "Trang chủ";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 718);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "Hệ thống Quản lý Nghiên cứu khoa học";
            pnlSidebar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_c500).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox logo_c500;
        private Label label1;
        private Panel pnlMain;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.FoxBigLabel title;
    }
}
