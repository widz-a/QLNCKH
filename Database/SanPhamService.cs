public static class SanPhamService {
    public static DateTime? GetThoiGianNop(string maSo, string loai) {
        using var db = new AppDbContext();

        return db.NopSanPham
            .Where(x => x.MaSo == maSo && x.Loai == loai)
            .Max(x => (DateTime?)x.NgayNop);
    }

}