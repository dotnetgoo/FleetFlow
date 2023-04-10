using FleetFlow.DAL.DbContexts;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Commons;
using Microsoft.EntityFrameworkCore;
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

        #region Delete
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
        #endregion

        #region Insert
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
        #endregion

        #region Save
        /// <summary>
        /// Saves tracking changes and write them to database permenantly
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            await dbContext.SaveChangesAsync();
        }
        #endregion

        #region Select All
        /// <summary>
        /// Selects all element of table
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> SelectAll() => this.dbSet;
        #endregion

        #region Select
        /// <summary>
        /// selects element from a table specified with expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression)
            => await this.dbSet.FirstOrDefaultAsync(expression);
        #endregion

        public async Task<TEntity> UpdateAsync(long id, TEntity entity)
        {
            var existingEntity = await dbContext.Set<TEntity>().FindAsync(id);

            if (existingEntity == null)
                return null;

            dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);

            await dbContext.SaveChangesAsync();

            return existingEntity;
        }

    }
}
