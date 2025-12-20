using System.ComponentModel;
using System.Linq.Expressions;

public interface IRepository<T> where T : class {
    List<T> GetAll();
    BindingList<TResult> GetSome<TResult>(Expression<Func<T, TResult>>? selector);

    public BindingList<T> Filter(Expression<Func<T, bool>> predicate);
    public BindingList<TResult> Filter<TResult>(
        Expression<Func<T, bool>> predicate,
        Expression<Func<T, TResult>> selector);
    T GetById(object id);
    void Insert(T entity);
    void Update(T entity);
    void Delete(object id);
    bool Exists(object id);
}
