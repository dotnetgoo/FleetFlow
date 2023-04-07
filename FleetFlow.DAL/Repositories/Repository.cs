using FleetFlow.DAL.DbContexts;
using FleetFlow.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly FleetFlowDbContext dbContext;
        protected readonly DbSet<TEntity> dbSet;
        public Repository(FleetFlowDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }
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
