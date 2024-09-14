using System.Linq.Expressions;

namespace DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> Get(Expression<Func<T, bool>> expression,
            params Expression<Func<T, Object>>[] includeproperties);
        T GetOne(Expression<Func<T, bool>> expression,
            params Expression<Func<T, Object>>[] includeproperties);

        void commit();
    }
}
