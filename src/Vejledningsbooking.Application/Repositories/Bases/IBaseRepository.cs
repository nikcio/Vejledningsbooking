using System.Collections.Generic;

namespace Vejledningsbooking.Application.Repositories.Bases
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        bool Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        bool Remove(TEntity entity);
    }
}