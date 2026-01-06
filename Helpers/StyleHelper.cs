using System.Drawing.Drawing2D;

public static class StyleHelper {
    public static void ApplyDGV(DataGridView dgv, bool stt = true) {
        dgv.EnableHeadersVisualStyles = false;
        dgv.BorderStyle = BorderStyle.None;
        dgv.BackgroundColor = Color.White;

        dgv.ReadOnly = true;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToResizeRows = false;

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //STT
        dgv.RowHeadersVisible = stt;
        if (stt) {
            dgv.RowPostPaint += (s, e) => {
                var grid = (DataGridView)s;
                var rowIdx = (e.RowIndex + 1).ToString();

                using var centerFormat = new StringFormat {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                var headerBounds = new Rectangle(
                    e.RowBounds.Left,
                    e.RowBounds.Top,
                    grid.RowHeadersWidth,
                    e.RowBounds.Height);

                e.Graphics.DrawString(
                    rowIdx,
                    grid.Font,
                    SystemBrushes.ControlText,
                    headerBounds,
                    centerFormat);
            };

            dgv.RowHeadersWidth = 55;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.RowHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(227, 236, 248);

            dgv.RowHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(55, 65, 81); // gray-700

            dgv.RowHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgv.RowHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgv.RowHeadersDefaultCellStyle.SelectionBackColor =
                dgv.RowHeadersDefaultCellStyle.BackColor;

            dgv.RowHeadersDefaultCellStyle.SelectionForeColor =
                dgv.RowHeadersDefaultCellStyle.ForeColor;
        }

        // Header
        dgv.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv.ColumnHeadersHeight = 48;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dgv.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(227, 236, 248);
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        dgv.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 10F, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            dgv.ColumnHeadersDefaultCellStyle.BackColor;
        dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor =
            dgv.ColumnHeadersDefaultCellStyle.ForeColor;

        dgv.CellPainting += (s, e) =>
        {
            if (e.RowIndex == -1 && (e.ColumnIndex >= 0 || (e.ColumnIndex < 0 && stt))) {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                if (e.ColumnIndex < dgv.Columns.Count - 1) {
                    using var pen = new Pen(Color.Black, 1);
                    int x = e.CellBounds.Right - 1;
                    int y1 = e.CellBounds.Top + 14;
                    int y2 = e.CellBounds.Bottom - 14;
                    e.Graphics.DrawLine(pen, x, y1, x, y2);
                }

                e.Handled = true;
            }
        };

        if (stt) {
            dgv.Paint += (s, e) =>
            {
                var grid = (DataGridView)s;

                Rectangle rect = new Rectangle(
                    0,
                    0,
                    grid.RowHeadersWidth,
                    grid.ColumnHeadersHeight
                );

                // nền
                using var bg = new SolidBrush(
                    grid.ColumnHeadersDefaultCellStyle.BackColor);
                e.Graphics.FillRectangle(bg, rect);

                // chữ STT (chừa 1px bên phải)
                using var sf = new StringFormat {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                var textRect = new Rectangle(
                    rect.X,
                    rect.Y,
                    rect.Width - 1,   // ❗ chừa chỗ cho divider
                    rect.Height
                );

                using var fg = new SolidBrush(
                    grid.ColumnHeadersDefaultCellStyle.ForeColor);

                e.Graphics.DrawString(
                    "STT",
                    grid.ColumnHeadersDefaultCellStyle.Font,
                    fg,
                    textRect,
                    sf
                );

                // divider STT | cột đầu
                using var pen = new Pen(Color.Black, 1);
                int x = rect.Right - 1;
                int y1 = rect.Top + 14;
                int y2 = rect.Bottom - 14;
                e.Graphics.DrawLine(pen, x, y1, x, y2);
            };
        }

        // Rows
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
        dgv.DefaultCellStyle.Font =
            new Font("Segoe UI", 10f, FontStyle.Regular);
        dgv.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(59, 130, 246);
        dgv.DefaultCellStyle.SelectionForeColor = Color.White;

        dgv.RowTemplate.Height = 38;

        // Alternating rows
        dgv.AlternatingRowsDefaultCellStyle.BackColor =
            Color.FromArgb(245, 246, 250);

        // Grid lines
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.GridColor = Color.FromArgb(230, 230, 230);

        dgv.CellMouseEnter += dgv_CellMouseEnter;
        dgv.CellMouseLeave += dgv_CellMouseLeave;
    }

    static int hoverRow = -1;

    private static void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
        if (!(sender is DataGridView dgv)) return;
        if (e.RowIndex < 0) return;
        
        hoverRow = e.RowIndex;
        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor =
            Color.FromArgb(237, 242, 247);
    }

    private static void dgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
        if (!(sender is DataGridView dgv)) return;
        if (e.RowIndex < 0) return;

        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor =
            e.RowIndex % 2 == 0 ? Color.White : Color.FromArgb(245, 246, 250);
    }

    public static void ApplyButtonDep(
        Button btn,
        Color color1,
        Color color2
    ) {
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.ForeColor = Color.White;
        btn.TextAlign = ContentAlignment.MiddleLeft;
        btn.Padding = new Padding(24);
        btn.Cursor = Cursors.Hand;
        btn.BackColor = Color.Transparent;

        bool hover = false;

        btn.MouseEnter += (_, __) => {
            hover = true;
            btn.Invalidate();
        };

        btn.MouseLeave += (_, __) => {
            hover = false;
            btn.Invalidate();
        };

        btn.Paint += (s, e) => {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = btn.ClientRectangle;
            int radius = 8;

            if (hover) {
                // hover:scale-105 (fake)
                rect = new Rectangle(1, 1, btn.Width - 2, btn.Height - 2);
            }

            using GraphicsPath path = RoundedRect(rect, radius);

            using LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                color1,
                color2,
                LinearGradientMode.Horizontal
            );

            e.Graphics.FillPath(brush, path);

            // shadow
            using Pen shadow = new Pen(Color.FromArgb(70, 0, 0, 0), 1);
            e.Graphics.DrawPath(shadow, path);

            TextRenderer.DrawText(
                e.Graphics,
                btn.Text,
                btn.Font,
                rect,
                btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        };
    }

    public static void ApplyStatCardPanel(
        Panel panel,
        bool drawLeftBorder = true,
        bool drawRightBorder = true
    ) {
        panel.BorderStyle = BorderStyle.None;
        panel.BackColor = Color.White;

        panel.Paint += (s, e) => {
            var g = e.Graphics;
            var r = panel.ClientRectangle;

            using var pen = new Pen(Color.Black, 1);

            // TOP
            g.DrawLine(pen, 1, 1, r.Width - 2, 1);

            // BOTTOM
            g.DrawLine(pen, 1, r.Height - 2, r.Width - 2, r.Height - 2);

            // LEFT
            if (drawLeftBorder)
                g.DrawLine(pen, 1, 1, 1, r.Height - 2);

            // RIGHT
            if (drawRightBorder)
                g.DrawLine(pen, r.Width - 2, 1, r.Width - 2, r.Height - 2);
        };

        panel.Invalidate(); // ÉP VẼ
    }

    private static GraphicsPath RoundedRect(Rectangle rect, int radius) {
        GraphicsPath path = new GraphicsPath();
        int d = radius * 2;

        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();

        return path;
    }
}
