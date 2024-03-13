using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual async Task<T> FirstAsync(Expression<Func<T, bool>> predicate)
        {
            return await _unitOfWork.GetRepository<T>().FindBy(predicate).FirstAsync();
        }

        public virtual async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _unitOfWork.GetRepository<T>().FindBy(predicate).FirstOrDefaultAsync();
        }

        public virtual IQueryable<T> GetAll()
        {
            return _unitOfWork.GetRepository<T>().GetAll();
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.GetRepository<T>().FindBy(predicate);
        }

        public virtual async Task<T> FindAsync(params object[] keys)
        {
            return await _unitOfWork.GetRepository<T>().GetAsync(keys);
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _unitOfWork.GetRepository<T>().AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public virtual async Task DeleteSoftAsync(T entity)
        {
            _unitOfWork.GetRepository<T>().SoftDelete(entity);
            await _unitOfWork.CommitAsync();
        }

        public virtual async Task DeleteSoftAsync(object key)
        {
            var entity = await _unitOfWork.GetRepository<T>().GetAsync(key);
            _unitOfWork.GetRepository<T>().SoftDelete(entity);
            await _unitOfWork.CommitAsync();
        }

        public virtual async Task DeleteHardAsync(T entity)
        {
            _unitOfWork.GetRepository<T>().SoftDelete(entity);
            await _unitOfWork.CommitAsync();
        }

        public virtual async Task DeleteHardAsync(params object[] keys)
        {
            var entity = _unitOfWork.GetRepository<T>().Get(keys);
            _unitOfWork.GetRepository<T>().HardDelete(entity);
            await _unitOfWork.CommitAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _unitOfWork.GetRepository<T>().Update(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
