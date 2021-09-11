using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Bases;
using Vejledningsbooking.Domain.Contexts;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Entities.BookingWindows
{
    public class BookingWindowRepository : BaseAsyncRepository<BookingWindow>, IBookingWindowRepository
    {
        public BookingWindowRepository(IVejledningsbookingDbContext dbContext, ILogger<BookingWindowRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
