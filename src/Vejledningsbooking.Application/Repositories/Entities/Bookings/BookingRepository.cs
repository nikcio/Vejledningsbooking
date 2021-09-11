using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Bases;
using Vejledningsbooking.Domain.Contexts;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Entities.Bookings
{
    public class BookingRepository : BaseAsyncRepository<Booking>, IBookingRepository
    {
        public BookingRepository(IVejledningsbookingDbContext dbContext, ILogger<BookingRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
