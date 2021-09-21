using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Services.Entities.Bookings;
using Vejledningsbooking.Application.Services.Entities.Calenders;
using Vejledningsbooking.Domain.Entities;

namespace VejledningsBooking.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly IBookingService bookingService;
        private readonly ICalenderService calenderService;

        public TestController(IBookingService bookingService, ICalenderService calenderService)
        {
            this.bookingService = bookingService;
            this.calenderService = calenderService;
        }

        [HttpGet]
        public async Task<Calender> GetCalender(int id)
        {
            var a = await calenderService.GetCalender(id);
            return a;
        }

        [HttpGet("Createbooking")]
        public async Task<bool> CreateBooking()
        {
            return await bookingService.CreateBooking(4, 1, new Booking { StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1), Student = new() });
        }

        [HttpGet("UpdateBookingTime")]
        public async Task<bool> UpdateBooking(int bookingId, DateTime newStartTime = default, DateTime newEndTime = default)
        {
            var booking = await bookingService.GetBooking(bookingId);
            if(booking == null)
            {
                return false;
            }
            booking.StartTime = newStartTime != default ? newStartTime : booking.StartTime;
            booking.EndTime = newEndTime != default ? newEndTime : booking.EndTime;
            return await bookingService.UpdateBooking(booking);
        }
    }
}
