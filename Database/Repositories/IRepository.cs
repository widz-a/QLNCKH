using System.ComponentModel;
using System.Linq.Expressions;

public interface IRepository<T> where T : class {
    List<T> GetAll();
    BindingList<TResult> GetSome<TResult>(Expression<Func<T, TResult>>? selector);

    public BindingList<T> Filter(Expression<Func<T, bool>> predicate);
    public BindingList<TResult> Filter<TResult>(
        Expression<Func<T, bool>> predicate,
        Expression<Func<T, TResult>> selector);
    T GetById(params object[] keyValues);
    T Insert(T entity);
    T Update(T entity);
    void Delete(params object[] keyValues);
    bool Exists(params object[] keyValues);
}
