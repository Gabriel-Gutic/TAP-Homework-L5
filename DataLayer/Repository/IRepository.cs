using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataLayer.Repository
{
    public interface IRepository<T> where T : class
    {
        T GetById(Guid id);
        IEnumerable<T> GetByIds(ICollection<Guid> ids);

        IEnumerable<T> Include<TResult>(Expression<Func<T, ICollection<TResult>>> predicate);
        IEnumerable<T> GetAll();
        T FindFirst(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Delete(Guid id);
        void SaveChanges();
    }
}
