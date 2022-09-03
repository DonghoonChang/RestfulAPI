using System.Linq.Expressions;

namespace RestfulAPI.Application.Repositories;
public interface IRepository<T> where T: class
{
    T Get(int id);
    IEnumerable<T> GetAll();
    IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

    void Add(T entity);
    void AddAll(IEnumerable<T> entities);

    void Remove(T entity);
    void RemoveAll(IEnumerable<T> entities);
}