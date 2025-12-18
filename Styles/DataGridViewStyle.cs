using ReaLTaiizor.Controls;
using System.Drawing;
using System.Windows.Forms;

public static class DataGridViewStyle {
    
    public static void _Apply(PoisonDataGridView dgv) {
        // ====== GENERAL ======
        dgv.EnableHeadersVisualStyles = false;
        dgv.BorderStyle = BorderStyle.None;
        dgv.BackgroundColor = Color.White;

        dgv.RowHeadersVisible = false;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToResizeRows = false;
        dgv.MultiSelect = false;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        // ====== HEADER ======
        dgv.ColumnHeadersHeight = 44;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 42, 57);
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 10.5f, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleLeft;

        // ====== ROW ======
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
        dgv.DefaultCellStyle.Font =
            new Font("Segoe UI", 10f, FontStyle.Regular);
        dgv.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(59, 130, 246);
        dgv.DefaultCellStyle.SelectionForeColor = Color.White;

        dgv.RowTemplate.Height = 38;

        // ====== ALTERNATING ======
        dgv.AlternatingRowsDefaultCellStyle.BackColor =
            Color.FromArgb(245, 247, 250);

        // ====== GRID ======
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.GridColor = Color.FromArgb(229, 231, 235);

        // ====== SORT FIX ======
        foreach (DataGridViewColumn col in dgv.Columns) {
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
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
        dgv.ColumnHeadersHeight = 42;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dgv.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(33, 42, 57);
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 10F, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

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
