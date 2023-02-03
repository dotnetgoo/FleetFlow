using FleetFlow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.DAL.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> InsertAsync(TEntity user);
        Task<TEntity> UpdateAsync(long id, TEntity user);
        Task<IEnumerable<TEntity>> SelectAllAsync(Func<TEntity, bool> predicate = null);
        Task<TEntity> SelectAsync(Func<TEntity, bool> predicate);
        Task<bool> DeleteAsync(long id);
    }
}
