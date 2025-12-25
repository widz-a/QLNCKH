public static class FormHelper {
    public static Button CreateMenuButton(string text, TableLayoutPanel tlp, Action onClick) {
        int insertRow = tlp.RowCount - 1;
        tlp.RowCount++;

        for (int i = tlp.Controls.Count - 1; i >= 0; i--) {
            Control c = tlp.Controls[i];
            int row = tlp.GetRow(c);

            if (row >= insertRow)
                tlp.SetRow(c, row + 1);
        }

        tlp.RowStyles.Insert(
            insertRow,
            new RowStyle(SizeType.AutoSize)
        );

        Button btn = new Button {
            Text = "  " + text,
            Width = 220,
            Height = 36,
            Dock = DockStyle.Fill,
            FlatStyle = FlatStyle.Flat,
            ForeColor = Color.White,
            BackColor = Color.FromArgb(33, 42, 57),
            TextAlign = ContentAlignment.MiddleLeft,
            Cursor = Cursors.Hand
        };

        btn.FlatAppearance.BorderSize = 0;

        btn.MouseEnter += (s, e) =>
            btn.BackColor = Color.FromArgb(45, 55, 72);

        btn.MouseLeave += (s, e) =>
            btn.BackColor = Color.FromArgb(33, 42, 57);

        btn.Click += (s, e) => onClick();

        tlp.Controls.Add(btn, 0, insertRow);

        return btn;
    }

    public static void LoadForm(Form frm, Panel parent) {
        parent.Controls.Clear();
        frm.TopLevel = false;
        frm.FormBorderStyle = FormBorderStyle.None;
        frm.Dock = DockStyle.Fill;
        frm.Padding = new Padding(20, 0, 20, 20);
        parent.Controls.Add(frm);
        frm.Show();
    }
}