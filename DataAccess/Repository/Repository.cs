using Microsoft.EntityFrameworkCore;
using DataAccess;
using DataAccess.Repository.IRepository;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDBContext context;
        private  DbSet<T> dbset;

       public Repository(ApplicationDBContext context)
        {
            this.context = context;
            dbset = context.Set<T>();
        }
       public void Add(T entity)
        {
            dbset.Add(entity);
        }
       public void Update(T entity)
        {
            dbset.Update(entity);
        }
       public void Delete(T entity)
        {
            dbset.Remove(entity);
        }
       public IEnumerable<T> Get(Expression<Func<T, bool>> expression,
            params Expression<Func<T, Object>>[] includeproperties)
        {
            IQueryable<T> query = dbset;

            if(query != null)
            {
                return dbset.Where(expression);
            }
            foreach(var property in includeproperties)
            {
                query = query.Include(property);
            }
            return query.ToList();
           
        }
       public T GetOne(Expression<Func<T, bool>> expression,
            params Expression<Func<T, Object>>[] includeproperties)
        {
            return Get(expression, includeproperties).FirstOrDefault();
        }

       public void commit()
        {
            context.SaveChanges();
        }
    }
}
