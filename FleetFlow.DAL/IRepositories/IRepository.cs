using FleetFlow.Domain.Commons;
using System.Linq.Expressions;

namespace FleetFlow.DAL.IRepositories
{
    public interface IRepository<TEntity> where TEntity : Auditable
    {
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(long id, TEntity entity);
        IQueryable<TEntity> SelectAll();
        Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression);
        Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression);
        Task SaveAsync();
    }
}
