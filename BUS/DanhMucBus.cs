using System.Collections.Generic;
using System.Data;

public static class DanhMucBUS {
    // Mapping: Tên hiển thị → (Table, IdColumn, NameColumn)
    public static Dictionary<string, (string Table, string Id, string Name)> Map =
        new Dictionary<string, (string, string, string)> {
            ["Dân tộc"] = ("DanToc", "DanTocId", "TenDanToc"),
            ["Tôn giáo"] = ("TonGiao", "TonGiaoId", "TenTonGiao"),
            ["Cấp bậc"] = ("CapBac", "CapBacId", "TenCapBac"),
            ["Chức vụ"] = ("ChucVu", "ChucVuId", "TenChucVu"),
            ["Học hàm"] = ("HocHam", "HocHamId", "TenHocHam"),
            ["Học vị"] = ("HocVi", "HocViId", "TenHocVi"),
            ["Trình độ CM"] = ("TrinhDoChuyenMon", "TrinhDoCMId", "TenTrinhDo"),
            ["Trình độ LLCT"] = ("TrinhDoLLCT", "TrinhDoLLCTId", "TenTrinhDo"),
            ["Lĩnh vực"] = ("LinhVuc", "LinhVucId", "TenLinhVuc"),
            ["Vai trò đề tài"] = ("VaiTroDeTai", "VaiTroId", "TenVaiTro"),
            ["Trạng thái đề tài"] = ("TrangThaiDeTai", "TrangThaiId", "TenTrangThai"),
            ["Giải thưởng"] = ("GiaiThuong", "GiaiId", "TenGiai")
        };

    public static DataTable GetAll(string key) {
        var m = Map[key];
        string sql = $"SELECT {m.Id} as N'ID', {m.Name} as N'Tên' FROM {m.Table}";
        return DbHelper.GetData(sql);
    }

    public static void Add(string key, string value) {
        var m = Map[key];
        string sql = $"INSERT INTO {m.Table}({m.Name}) VALUES(N'{value}')";
        DbHelper.Execute(sql);
    }

    public static void Update(string key, int id, string value) {
        var m = Map[key];
        string sql = $"UPDATE {m.Table} SET {m.Name}=N'{value}' WHERE {m.Id}={id}";
        DbHelper.Execute(sql);
    }

    public static void Delete(string key, int id) {
        var m = Map[key];
        string sql = $"DELETE FROM {m.Table} WHERE {m.Id}={id}";
        DbHelper.Execute(sql);
    }
}
