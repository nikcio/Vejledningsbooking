using System.Collections.Generic;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Bases
{
    public interface IBaseAsyncRepository<TEntity> where TEntity : class
    {
        Task<bool> Add(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<bool> Remove(TEntity entity);
        void StateModified(Booking booking);
    }
}