using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

public class Repository<T> : IRepository<T> where T : class {
    public List<T> GetAll() {
        using var db = new AppDbContext();
        return db.Set<T>().AsNoTracking().ToList();
    }

    public List<TResult> GetSome<TResult>(Expression<Func<T, TResult>>? selector) {
        using var db = new AppDbContext();
        return db.Set<T>().AsNoTracking().Select(selector).ToList();

    }

    public List<T> Filter(Expression<Func<T, bool>> predicate) {
        using var db = new AppDbContext();
        return db.Set<T>().AsNoTracking().Where(predicate).ToList();
    }

    public List<TResult> Filter<TResult>(
        Expression<Func<T, bool>> predicate,
        Expression<Func<T, TResult>> selector) {
        using var db = new AppDbContext();
        return db.Set<T>()
                 .AsNoTracking()
                 .Where(predicate)
                 .Select(selector)
                 .ToList();
    }

    public T GetById(object id) {
        using var db = new AppDbContext();
        return db.Set<T>().Find(id);
    }

    public void Insert(T entity) {
        using var db = new AppDbContext();
        db.Set<T>().Add(entity);
        db.SaveChanges();
    }

    public void Update(T entity) {
        using var db = new AppDbContext();
        db.Set<T>().Update(entity);
        db.SaveChanges();
    }

    public void Delete(object id) {
        using var db = new AppDbContext();
        var entity = db.Set<T>().Find(id);
        if (entity == null) return;

        db.Set<T>().Remove(entity);
        db.SaveChanges();
    }

    public bool Exists(object id) {
        return GetById(id) != null;
    }
}
