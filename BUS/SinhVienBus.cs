using System.Data;

public static class SinhVienBUS {
    public static DataTable GetAll() {
        string sql = @"
            SELECT MaSV as N'Mã sinh viên', 
            HoTen as N'Họ và tên', 
            Lop as N'Lớp', 
            NgaySinh as N'Ngày sinh'
            FROM SinhVien
            ORDER BY MaSV
        ";
        return DbHelper.GetData(sql);
    }

    public static DataTable GetById(string maSV) {
        return DbHelper.GetData(
            $"SELECT * FROM SinhVien WHERE MaSV = N'{maSV}'"
        );
    }

    public static void Insert(SinhVien sv) {
        string sql = $@"
            INSERT INTO SinhVien
            (MaSV, HoTen, GioiTinh, NgaySinh, TinhId, XaId, DanTocId, TonGiaoId,
             SDT, Lop, ChucVuId, Nganh, ChuyenNganh)
            VALUES
            (N'{sv.MaSV}', N'{sv.HoTen}', N'{sv.GioiTinh}', '{sv.NgaySinh:yyyy-MM-dd}',
             {sv.TinhId}, {sv.XaId}, {sv.DanTocId}, {sv.TonGiaoId},
             N'{sv.SDT}', N'{sv.Lop}', {sv.ChucVuId},
             N'{sv.Nganh}', N'{sv.ChuyenNganh}')";
        DbHelper.Execute(sql);
    }

    public static void Update(string maSV, SinhVien sv) {
        string sql = $@"
        UPDATE SinhVien SET
        HoTen=N'{sv.HoTen}',
        GioiTinh=N'{sv.GioiTinh}',
        NgaySinh='{sv.NgaySinh:yyyy-MM-dd}',
        TinhId={sv.TinhId},
        XaId={sv.XaId},
        DanTocId={sv.DanTocId},
        TonGiaoId={sv.TonGiaoId},
        SDT=N'{sv.SDT}',
        Lop=N'{sv.Lop}',
        ChucVuId={sv.ChucVuId},
        Nganh=N'{sv.Nganh}',
        ChuyenNganh=N'{sv.ChuyenNganh}'
        WHERE MaSV=N'{maSV}'";
        DbHelper.Execute(sql);
    }


    public static void Delete(string maSV) {
        DbHelper.Execute($"DELETE FROM SinhVien WHERE MaSV=N'{maSV}'");
    }
}
