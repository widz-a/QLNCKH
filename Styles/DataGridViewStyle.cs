using ReaLTaiizor.Controls;

public static class DataGridViewStyle {
    public static void Apply(DataGridView dgv) {
        dgv.EnableHeadersVisualStyles = false;
        dgv.BorderStyle = BorderStyle.None;
        dgv.BackgroundColor = Color.White;

        dgv.RowHeadersVisible = false;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToResizeRows = false;

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            if (e.RowIndex == -1 && e.ColumnIndex >= 0) {
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

        //Mouse Event
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

}
