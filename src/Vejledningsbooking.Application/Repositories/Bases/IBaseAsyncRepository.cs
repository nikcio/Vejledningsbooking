using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vejledningsbooking.Application.Repositories.Bases
{
    public interface IBaseAsyncRepository<TEntity> where TEntity : class
    {
        Task<bool> Add(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(object id);
        Task<bool> Remove(TEntity entity);
    }
}