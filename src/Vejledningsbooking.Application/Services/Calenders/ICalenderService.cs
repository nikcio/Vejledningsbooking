using System.Threading.Tasks;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Services.Calenders
{
    public interface ICalenderService
    {
        Task<Calender> GetCalender(int id);
    }
}