using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Services.Entities.Bookings
{
    public interface IBookingService
    {
        Task<bool> CreateBooking(int calenderId, int bookingWindowId, Booking booking);
        Task<bool> UpdateBooking(Booking Booking);
        Task<Booking> GetBooking(int bookingId);
    }
}
