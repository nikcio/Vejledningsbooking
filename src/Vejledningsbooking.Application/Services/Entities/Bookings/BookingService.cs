using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.UnitOfWorks.Entities.Bookings;
using Vejledningsbooking.Application.UnitOfWorks.Entities.Calenders;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Services.Entities.Bookings
{
    public class BookingService : IBookingService
    {
        private readonly IBookingUoW bookingUoW;
        private readonly ICalenderUoW calenderUoW;

        public BookingService(IBookingUoW bookingUoW, ICalenderUoW calenderUoW)
        {
            this.bookingUoW = bookingUoW;
            this.calenderUoW = calenderUoW;
        }

        public async Task<bool> CreateBooking(int calenderId, int bookingWindowId, Booking booking)
        {
            if (booking is null)
            {
                throw new ArgumentNullException(nameof(booking));
            }

            var calender = await calenderUoW.CalenderRepository.GetById(calenderId);
            var bookingWindow = calender.BookingWindows.FirstOrDefault(window => window.Id == bookingWindowId);
            if (calender != null && 
                bookingWindow != null && 
                bookingWindow.IsBookingVaild(booking)
                )
            {
                booking.BookingWindowId = bookingWindowId;
                await bookingUoW.bookingRepository.Add(booking);
                await bookingUoW.CompleteAsync();
                return true;
            }
            return false;
        }
    }
}
