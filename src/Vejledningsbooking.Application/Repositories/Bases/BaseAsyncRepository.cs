using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Contexts;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Bases
{
    public class BaseAsyncRepository<TEntity> : IBaseAsyncRepository<TEntity> where TEntity : class
    {
        internal DbSet<TEntity> DbSet;
        private readonly IVejledningsbookingDbContext dbContext;
        public readonly ILogger logger;

        public BaseAsyncRepository(IVejledningsbookingDbContext dbContext, ILogger logger)
        {
            DbSet = dbContext.Context.Set<TEntity>();
            this.dbContext = dbContext;
            this.logger = logger;
        }

        public async virtual Task<bool> Add(TEntity entity)
        {
            try
            {
                await DbSet.AddAsync(entity);
                return true;
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Add failed on {typeof(TEntity)}");
                return false;
            }
        }

        public async virtual Task<IEnumerable<TEntity>> GetAll()
        {
            try
            {
                return await DbSet.ToListAsync();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"GetAll failed on {typeof(TEntity)}");
                return null;
            }
        }

        public async virtual Task<TEntity> GetById(int id)
        {
            return await GetByIdBase(id);
        }

        protected async virtual Task<TEntity> GetByIdBase(object id)
        {
            try
            {
                return await DbSet.FindAsync(id);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"GetById failed on {typeof(TEntity)} with id {id}");
                return null;
            }
        }

        public virtual Task<bool> Remove(TEntity entity)
        {
            try
            {
                DbSet.Remove(entity);
                return Task.FromResult(true);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Remove failed on {typeof(TEntity)}");
                return null;
            }
        }

        public virtual void StateModified(Booking booking)
        {
            dbContext.Context.Entry(booking).State = EntityState.Modified;
        }

    }
}
