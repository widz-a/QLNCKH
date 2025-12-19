using Microsoft.EntityFrameworkCore;

public static class DanhMucService {
    public static List<IDanhMuc> GetAll(string key) {
        var type = DanhMucMap.Map[key];

        using var db = new AppDbContext();
        return db.GetDbSet(type)
             .Cast<IDanhMuc>()
             .AsNoTracking()
             .ToList();
    }

    public static void Add(string key, string ten) {
        var type = DanhMucMap.Map[key];
        var item = (IDanhMuc)Activator.CreateInstance(type)!;
        item.Ten = ten;

        using var db = new AppDbContext();
        db.Add(item);
        db.SaveChanges();
    }

    public static void Update(string key, int id, string ten) {
        var type = DanhMucMap.Map[key];

        using var db = new AppDbContext();
        var item = (IDanhMuc)db.Find(type, id);
        if (item == null) return;

        item.Ten = ten;
        db.SaveChanges();
    }

    public static void Delete(string key, int id) {
        var type = DanhMucMap.Map[key];

        using var db = new AppDbContext();
        var item = db.Find(type, id);
        if (item == null) return;

        db.Remove(item);
        db.SaveChanges();
    }
}