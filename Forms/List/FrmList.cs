using QLNCKH.Forms;
using System.Linq.Expressions;

public class ListContext<T, TDto> where T : class where TDto : class {
    public string Name { get; set; }
    public Expression<Func<T, TDto>> GetHeaderSelector { get; set; }
    public string IdColumn { get; set; }
    public Dictionary<string, string> HeaderNames { get; set; }
    public Func<string, Form> GetEditForm { get; set; }
    public Func<Form> GetCreateForm { get; set; }
}

public class FrmList<T, TDto> : FrmBaseList where T : class where TDto : class {
    private FrmList() {
        PublicInitializeComponent();
        StyleHelper.ApplyDGV(GetDgv());

        GetButtonThem().Click += btnThem_Click;
        GetButtonSua().Click += btnSua_Click;
        GetButtonXoa().Click += btnXoa_Click;
    }

    private readonly ListContext<T, TDto> _ctx;
    public FrmList(ListContext<T, TDto> ctx) : this() {
        _ctx = ctx;
        LoadData();
    }

    private void LoadData() {
        GetDgv().DataSource = new Repository<T>().GetSome(_ctx.GetHeaderSelector);
        foreach (var item in _ctx.HeaderNames) {
            GetDgv().Columns[item.Key].HeaderText = item.Value;
        }
    }

    private string? GetSelectedId() {
        if (GetDgv().SelectedRows.Count == 0) return null;
        return GetDgv().SelectedRows[0].Cells[_ctx.IdColumn].Value.ToString();
    }

    private void btnThem_Click(object sender, EventArgs e) {
        using (var f = _ctx.GetCreateForm()) {
            if (f.ShowDialog() == DialogResult.OK)
                LoadData();
        }
    }

    private void btnSua_Click(object sender, EventArgs e) {
        string id = GetSelectedId();
        if (id == null) return;
        using (var f = _ctx.GetEditForm(id)) {
            if (f.ShowDialog() == DialogResult.OK)
                LoadData();
        }
    }

    private void btnXoa_Click(object sender, EventArgs e) {
        string id = GetSelectedId();
        if (id == null) return;

        if (MessageBox.Show($"Xóa {_ctx.Name} này?", "Xác nhận",
            MessageBoxButtons.YesNo) == DialogResult.Yes) {
            new Repository<T>().Delete(id);
            LoadData();
        }
    }
}