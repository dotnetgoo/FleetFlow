using FleetFlow.DAL.DbContexts;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace FleetFlow.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        protected readonly FleetFlowDbContext dbContext;
        protected readonly DbSet<TEntity> dbSet;
        public Repository(FleetFlowDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }
        /// <summary>
        /// Deletes first item that matched expression and keep track of it until change saved
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>true if action is successful, false if unable to delete</returns>
        public async Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
        {
            var entity = await this.SelectAsync(expression);

            if (entity is not null)
            {
                this.dbSet.Remove(entity);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Inserts element to a table and keep track of it until change saved
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            var entry = await this.dbSet.AddAsync(entity);

            return entry.Entity;
        }

        /// <summary>
        /// Saves tracking changes and write them to database permenantly
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Selects all element of table
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> SelectAll() => this.dbSet;

        /// <summary>
        /// selects element from a table specified with expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression)
            => await this.dbSet.FirstOrDefaultAsync(expression);

        /// <summary>
        /// Updates entity and keep track of it until change saved
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            EntityEntry<TEntity> entryentity = this.dbContext.Update(entity);

            return entryentity.Entity;
        }
    }
}
