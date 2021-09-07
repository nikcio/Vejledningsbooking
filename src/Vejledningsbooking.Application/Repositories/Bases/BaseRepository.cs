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
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected IVejledningsbookingDbContext Context { get; }
        internal DbSet<TEntity> DbSet;
        public readonly ILogger logger;

        public BaseRepository(IVejledningsbookingDbContext dbContext, ILogger logger)
        {
            Context = dbContext;
            DbSet = dbContext.Context.Set<TEntity>();
            this.logger = logger;
        }

        public virtual TEntity GetById(object id)
        {
            try
            {
                return DbSet.Find(id);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"GetById failed on {typeof(TEntity)} with id {id}");
                return null;
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            try
            {
                return DbSet.ToList();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"GetAll failed on {typeof(TEntity)}");
                return null;
            }
        }

        public virtual bool Add(TEntity entity)
        {
            try
            {
                DbSet.Add(entity);
                return true;
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Add failed on {typeof(TEntity)}");
                return false;
            }
        }

        public virtual bool Remove(TEntity entity)
        {
            try
            {
                DbSet.Remove(entity);
                return true;
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Remove failed on {typeof(TEntity)}");
                return false;
            }
        }
    }
}
