using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.UnitOfWorks.Entities.Bookings;
using Vejledningsbooking.Application.UnitOfWorks.Entities.Calenders;
using Vejledningsbooking.Domain.Entities;
using Vejledningsbooking.Domain.Interfaces;

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

        public async Task<bool> CreateBooking(int calenderId, int bookingWindowId, IBooking booking)
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
                
                await bookingUoW.bookingRepository.Add((Booking)booking);
                await bookingUoW.CompleteAsync();
                return true;
            }
            return false;
        }

        public async Task<Booking> GetBooking(int bookingId)
        {
            return await bookingUoW.bookingRepository.GetById(bookingId);
        }

        public async Task<bool> UpdateBooking(IBooking booking)
        {
            var storedBooking = await GetBooking(booking.Id);
            bookingUoW.bookingRepository.StateModified(storedBooking);

            try
            {
                await bookingUoW.CompleteAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async Task<IEnumerable<IBooking>> GetBookings()
        {
            return (IEnumerable<IBooking>)await bookingUoW.bookingRepository.GetAll();
        }

        public async Task<bool> DeleteBooking(int bookingId)
        {
            var booking = await GetBooking(bookingId);
            if(booking == null)
            {
                return false;
            }
            else
            {
                await bookingUoW.bookingRepository.Remove(booking);
                await bookingUoW.CompleteAsync();
                return true;
            }
        }
    }
}
