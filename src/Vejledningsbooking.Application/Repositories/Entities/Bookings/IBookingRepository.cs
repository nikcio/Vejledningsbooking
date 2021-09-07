using Vejledningsbooking.Application.Repositories.Bases;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Entities.Bookings
{
    public interface IBookingRepository : IBaseAsyncRepository<Booking>
    {
    }
}