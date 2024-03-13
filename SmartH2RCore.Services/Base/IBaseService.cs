
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Base
{
    public interface IBaseService<T> where T : class
    {
        Task<T> FirstAsync(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<T> FindAsync(params object[] keys);
        Task<T> AddAsync(T entity);
        Task DeleteSoftAsync(T entity);
        Task DeleteSoftAsync(object key);
        Task DeleteHardAsync(T entity);
        Task DeleteHardAsync(params object[] keys);
        Task UpdateAsync(T entity);
    }
}
