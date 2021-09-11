using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Entities.Bookings;
using Vejledningsbooking.Application.UnitOfWorks.Bases;

namespace Vejledningsbooking.Application.UnitOfWorks.Entities.Bookings
{
    public interface IBookingUoW : IBaseAsyncUnitOfWork
    {
        IBookingRepository bookingRepository { get; }
    }
}
