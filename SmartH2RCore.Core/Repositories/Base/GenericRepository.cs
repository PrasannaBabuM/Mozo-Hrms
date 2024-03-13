using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.EFContext;
using SmartH2RCore.Core.Repositories.Interfaces;

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartH2RCore.Core.Repositories.Base
{
    public class GenericRepository<T> : IGenericRepository<T>
         where T : class
    {
        private readonly IDatabaseContext _context;
        private readonly DbSet<T> dbSet;

        public GenericRepository(IDatabaseContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public async virtual Task<T> AddAsync(T entity)
        {
            var result = await dbSet.AddAsync(entity);
            return result.Entity;
        }

        public T Get<TKey>(TKey id)
        {
            return dbSet.Find(id);
        }

        public async Task<T> GetAsync<TKey>(TKey id)
        {
            return await dbSet.FindAsync(id);
        }

        public T Get(params object[] keyValues)
        {
            return dbSet.Find(keyValues);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, string include)
        {
            return FindBy(predicate).Include(include);
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public IQueryable<T> GetAll(int page, int pageCount)
        {
            var pageSize = (page - 1) * pageCount;

            return dbSet.Skip(pageSize).Take(pageCount);
        }

        public IQueryable<T> GetAll(string include)
        {
            return dbSet.Include(include);
        }

        public IQueryable<T> RawSql(string query, params object[] parameters)
        {
            return dbSet.FromSqlRaw(query, parameters);
        }

        public IQueryable<T> GetAll(string include, string include2)
        {
            return dbSet.Include(include).Include(include2);
        }

        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Any(predicate);
        }

        public virtual EntityState SoftDelete(T entity)
        {
            entity.GetType().GetProperty("IsArchived")?.SetValue(entity, true);
            return dbSet.Update(entity).State;
        }

        public virtual EntityState HardDelete(T entity)
        {
            return dbSet.Remove(entity).State;
        }
        public virtual T Update(T entity)
        {
            return dbSet.Update(entity).Entity;
        }
    }
}
