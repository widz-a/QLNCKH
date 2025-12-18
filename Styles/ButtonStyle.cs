using System.Drawing.Drawing2D;

public static class ButtonStyle {
    public static void Apply(Button btn) {
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.UseVisualStyleBackColor = false;

        btn.BackColor = Color.FromArgb(59, 130, 246);
        btn.ForeColor = Color.White;
        btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btn.Cursor = Cursors.Hand;

        /*void updateRegion() {
            if (btn.Width <= 0 || btn.Height <= 0) return;
            btn.Region = new Region(GetRoundedPath(btn.ClientRectangle, radius));
        }

        btn.SizeChanged += (s, e) => updateRegion();
        updateRegion();*/

        btn.MouseEnter += (s, e) =>
            btn.BackColor = Color.FromArgb(37, 99, 235);

        btn.MouseLeave += (s, e) =>
            btn.BackColor = Color.FromArgb(59, 130, 246);
    }

    private static GraphicsPath GetRoundedPath(Rectangle rect, int radius) {
        GraphicsPath path = new GraphicsPath();
        int d = radius * 2;

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();

        return path;
    }
}