using System.Threading.Tasks;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Services.Entities.Calenders
{
    public interface ICalenderService
    {
        Task<Calender> GetCalender(int id);
    }
}