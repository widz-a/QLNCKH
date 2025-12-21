public static class FormHelper {
    public static Button CreateMenuButton(string text, int top, Action onClick) {
        Button btn = new Button {
            Text = "  " + text,
            Width = 220,
            Height = 42,
            Location = new Point(0, top),
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