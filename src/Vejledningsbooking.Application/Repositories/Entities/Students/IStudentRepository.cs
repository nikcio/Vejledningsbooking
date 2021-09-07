using Vejledningsbooking.Application.Repositories.Bases;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Entities.Students
{
    public interface IStudentRepository : IBaseAsyncRepository<Student>
    {
    }
}