using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Contexts;

namespace Vejledningsbooking.Application.Repositories.Bases
{
    public class BaseAsyncRepository<TEntity> : IBaseAsyncRepository<TEntity> where TEntity : class
    {
        protected IVejledningsbookingDbContext Context { get; }
        internal DbSet<TEntity> DbSet;
        public readonly ILogger logger;

        public BaseAsyncRepository(IVejledningsbookingDbContext dbContext, ILogger logger)
        {
            Context = dbContext;
            DbSet = dbContext.Context.Set<TEntity>();
            this.logger = logger;
        }

        public virtual async Task<bool> Add(TEntity entity)
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

        public virtual async Task<IEnumerable<TEntity>> GetAll()
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

        public virtual async Task<TEntity> GetById(object id)
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
    }
}
