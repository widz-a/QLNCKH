namespace QLNCKH.Forms {
    partial class FrmChamDiem {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChamDiem));
            tabCD = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnCdCham = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            cbCD = new ComboBox();
            label3 = new Label();
            tabDT = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            listView1 = new ListView();
            dtStt = new ColumnHeader();
            dtMa = new ColumnHeader();
            dtTen = new ColumnHeader();
            dtDiem = new ColumnHeader();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDtCham = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            cbDT = new ComboBox();
            label6 = new Label();
            tab = new TabControl();
            tabCD.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tabDT.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tab.SuspendLayout();
            SuspendLayout();
            // 
            // tabCD
            // 
            tabCD.Controls.Add(tableLayoutPanel4);
            tabCD.Location = new Point(4, 29);
            tabCD.Name = "tabCD";
            tabCD.Padding = new Padding(3);
            tabCD.Size = new Size(808, 547);
            tabCD.TabIndex = 1;
            tabCD.Text = "Chuyên đề";
            tabCD.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(listView2, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 9.05730152F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90.9426956F));
            tableLayoutPanel4.Size = new Size(802, 541);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView2.Dock = DockStyle.Fill;
            listView2.FullRowSelect = true;
            listView2.Location = new Point(10, 59);
            listView2.Margin = new Padding(10);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(782, 472);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên";
            columnHeader3.Width = 480;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Điểm";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.73878F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2612228F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(btnCdCham, 1, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(796, 43);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btnCdCham
            // 
            btnCdCham.Dock = DockStyle.Fill;
            btnCdCham.Location = new Point(661, 3);
            btnCdCham.Name = "btnCdCham";
            btnCdCham.Size = new Size(132, 37);
            btnCdCham.TabIndex = 18;
            btnCdCham.Text = "Xét duyệt";
            btnCdCham.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.Controls.Add(cbCD, 1, 0);
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(652, 37);
            tableLayoutPanel7.TabIndex = 17;
            // 
            // cbCD
            // 
            cbCD.Dock = DockStyle.Fill;
            cbCD.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbCD.FormattingEnabled = true;
            cbCD.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbCD.Location = new Point(94, 6);
            cbCD.Margin = new Padding(3, 6, 3, 6);
            cbCD.Name = "cbCD";
            cbCD.Size = new Size(555, 27);
            cbCD.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 37);
            label3.TabIndex = 22;
            label3.Text = "Hội đồng:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabDT
            // 
            tabDT.Controls.Add(tableLayoutPanel1);
            tabDT.Location = new Point(4, 29);
            tabDT.Name = "tabDT";
            tabDT.Padding = new Padding(3);
            tabDT.Size = new Size(808, 547);
            tabDT.TabIndex = 2;
            tabDT.Text = "Đề tài";
            tabDT.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(listView1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.05730152F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.9426956F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(802, 541);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { dtStt, dtMa, dtTen, dtDiem });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(10, 59);
            listView1.Margin = new Padding(10);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(782, 472);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // dtStt
            // 
            dtStt.Text = "STT";
            // 
            // dtMa
            // 
            dtMa.Text = "Mã";
            dtMa.Width = 150;
            // 
            // dtTen
            // 
            dtTen.Text = "Tên";
            dtTen.Width = 480;
            // 
            // dtDiem
            // 
            dtDiem.Text = "Điểm";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.73878F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2612228F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnDtCham, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(796, 43);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnDtCham
            // 
            btnDtCham.Dock = DockStyle.Fill;
            btnDtCham.Location = new Point(661, 3);
            btnDtCham.Name = "btnDtCham";
            btnDtCham.Size = new Size(132, 37);
            btnDtCham.TabIndex = 16;
            btnDtCham.Text = "Xét giải";
            btnDtCham.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel8.Controls.Add(cbDT, 1, 0);
            tableLayoutPanel8.Controls.Add(label6, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(652, 37);
            tableLayoutPanel8.TabIndex = 17;
            // 
            // cbDT
            // 
            cbDT.Dock = DockStyle.Fill;
            cbDT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbDT.FormattingEnabled = true;
            cbDT.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbDT.Location = new Point(94, 6);
            cbDT.Margin = new Padding(3, 6, 3, 6);
            cbDT.Name = "cbDT";
            cbDT.Size = new Size(555, 27);
            cbDT.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 37);
            label6.TabIndex = 22;
            label6.Text = "Hội đồng:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tab
            // 
            tab.Controls.Add(tabDT);
            tab.Controls.Add(tabCD);
            tab.Dock = DockStyle.Fill;
            tab.Location = new Point(0, 0);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(816, 580);
            tab.TabIndex = 6;
            // 
            // FrmChamDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 580);
            Controls.Add(tab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmChamDiem";
            Text = "Thành lập hội đồng";
            tabCD.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tabDT.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabCD;
        private TabPage tabDT;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnDtCham;
        private TableLayoutPanel tableLayoutPanel8;
        private ComboBox cbDT;
        private Label label6;
        private TabControl tab;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private ComboBox cbCD;
        private Label label3;
        private ListView listView1;
        private ColumnHeader dtStt;
        private ColumnHeader dtMa;
        private ColumnHeader dtTen;
        private ColumnHeader dtDiem;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnCdCham;
    }
}