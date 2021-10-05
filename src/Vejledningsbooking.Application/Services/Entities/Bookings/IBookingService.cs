using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Entities;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Application.Services.Entities.Bookings
{
    public interface IBookingService
    {
        Task<bool> CreateBooking(int calenderId, int bookingWindowId, IBooking booking);
        Task<bool> UpdateBooking(IBooking Booking);
        Task<Booking> GetBooking(int bookingId);
        Task<IEnumerable<IBooking>> GetBookings();
        Task<bool> DeleteBooking(int bookingId);
    }
}
