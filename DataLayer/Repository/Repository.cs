using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Markup;

namespace DataLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly MyDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(MyDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public T GetById(Guid id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<T> GetByIds(ICollection<Guid> ids)
        {
            var entities = _entities.Where(entity => ids.Contains(entity.Id)).ToList();
            foreach (var id in ids)
            {
                if (entities.Find(entity => entity.Id == id) == null)
                    return null;
            }
            return entities;
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _entities.Find(id);
            if (entity != null)
            {
                _entities.Remove(entity);
            }
        }

        public T FindFirst(Expression<Func<T, bool>> predicate)
        {
            var values = Find(predicate);
            if (!values.IsNullOrEmpty())
            {
                return values.First();
            }

            return null;
        }

        public IEnumerable<T> Include<TResult>(Expression<Func<T, ICollection<TResult>>> predicate)
        {
            return _entities.Include(predicate);
        }
    }
}
