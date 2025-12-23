using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Linq.Expressions;

public class Repository<T> : IRepository<T> where T : class {
    public List<T> GetAll() {
        using var db = new AppDbContext();
        return db.Set<T>().AsNoTracking().ToList();
    }

    public BindingList<TResult> GetSome<TResult>(Expression<Func<T, TResult>>? selector) {
        using var db = new AppDbContext();
        var list = db.Set<T>().AsNoTracking().Select(selector).ToList();
        return new BindingList<TResult>(list);
    }

    public BindingList<T> Filter(Expression<Func<T, bool>> predicate) {
        using var db = new AppDbContext();
        var list = db.Set<T>().AsNoTracking().Where(predicate).ToList();
        return new BindingList<T>(list);
    }

    public BindingList<TResult> Filter<TResult>(
        Expression<Func<T, bool>> predicate,
        Expression<Func<T, TResult>> selector) {
        using var db = new AppDbContext();
        var list = db.Set<T>()
                 .AsNoTracking()
                 .Where(predicate)
                 .Select(selector)
                 .ToList();
        return new BindingList<TResult>(list);
    }

    public T GetById(params object[] keyValues) {
        using var db = new AppDbContext();
        return db.Set<T>().Find(keyValues);
    }

    public T Insert(T entity) {
        using var db = new AppDbContext();
        db.Set<T>().Add(entity);
        db.SaveChanges();

        return entity;
    }

    public T Update(T entity) {
        using var db = new AppDbContext();
        db.Set<T>().Update(entity);
        db.SaveChanges();

        return entity;
    }

    public void Delete(params object[] keyValues) {
        using var db = new AppDbContext();

        var entity = db.Set<T>().Find(keyValues);
        if (entity == null) return;

        // ================= HỘI ĐỒNG =================
        if (entity is HoiDong hd) {
            int maHD = hd.MaHD;

            db.HoiDong_ThanhVien.RemoveRange(
                db.HoiDong_ThanhVien.Where(x => x.MaHD == maHD));

            db.HoiDong_DeTai.RemoveRange(
                db.HoiDong_DeTai.Where(x => x.MaHD == maHD));

            db.HoiDong_ChuyenDe.RemoveRange(
                db.HoiDong_ChuyenDe.Where(x => x.MaHD == maHD));

            db.PhieuCham.RemoveRange(
                db.PhieuCham.Where(x => x.MaHD == maHD));
        }

        // ================= ĐỀ TÀI =================
        else if (entity is DeTai dt) {
            string maDT = dt.MaDT;

            db.DeTai_SinhVien.RemoveRange(
                db.DeTai_SinhVien.Where(x => x.MaDT == maDT));

            db.HoiDong_DeTai.RemoveRange(
                db.HoiDong_DeTai.Where(x => x.MaDT == maDT));

            db.DaoVan.RemoveRange(
                db.DaoVan.Where(x => x.MaDT == maDT));

            db.KetQua_DeTai.RemoveRange(
                db.KetQua_DeTai.Where(x => x.MaDT == maDT));
        }

        // ================= CHUYÊN ĐỀ =================
        else if (entity is ChuyenDe cd) {
            string maCD = cd.MaCD;

            db.HoiDong_ChuyenDe.RemoveRange(
                db.HoiDong_ChuyenDe.Where(x => x.MaCD == maCD));

            db.KetQua_ChuyenDe.RemoveRange(
                db.KetQua_ChuyenDe.Where(x => x.MaCD == maCD));
        }

        // ================= SINH VIÊN =================
        else if (entity is SinhVien sv) {
            string maSV = sv.MaSV;

            db.DeTai_SinhVien.RemoveRange(
                db.DeTai_SinhVien.Where(x => x.MaSV == maSV));

            db.ChuyenDe.RemoveRange(
                db.ChuyenDe.Where(x => x.MaSV == maSV));
        }

        // ================= GIẢNG VIÊN =================
        else if (entity is GiangVien gv) {
            string maCB = gv.MaCB;

            db.HoiDong_ThanhVien.RemoveRange(
                db.HoiDong_ThanhVien.Where(x => x.MaCB == maCB));

            db.PhieuCham.RemoveRange(
                db.PhieuCham.Where(x => x.MaCB == maCB));

            db.DeTai.RemoveRange(
                db.DeTai.Where(x => x.MaGVHuongDan == maCB));
        }

        // ================= DANH MỤC =================
        else if (entity is IDanhMuc dm) {
            int id = dm.Id;

            // ❗ Danh mục: cứ xóa, DB nào fail thì fail
            // (vì mày đã chọn "xóa hết")
        }

        // ================= XÓA CHA =================
        db.Remove(entity);
        db.SaveChanges();
    }

    public bool Exists(params object[] keyValues) {
        return GetById(keyValues) != null;
    }
}
