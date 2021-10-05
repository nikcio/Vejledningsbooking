using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Entities.Bookings;
using Vejledningsbooking.Domain.Contexts;

namespace Vejledningsbooking.Application.UnitOfWorks.Entities.Bookings
{
    public class BookingUoW : IBookingUoW
    {
        private readonly IVejledningsbookingDbContext context;

        public IBookingRepository bookingRepository { get; }

        public BookingUoW(IVejledningsbookingDbContext context, IBookingRepository bookingRepository)
        {
            this.context = context;
            this.bookingRepository = bookingRepository;
        }

        public async Task<bool> CompleteAsync()
        {
            try
            {
                await context.Context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }
    }
}
