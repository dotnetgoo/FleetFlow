using FleetFlow.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.DAL.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> SelectAllAsync(Func<TEntity, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> SelectAsync(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(long id, TEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
