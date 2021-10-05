using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Services.Entities.Bookings;
using Vejledningsbooking.Domain.Dtos;
using Vejledningsbooking.Domain.Entities;

namespace VejledningsBooking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService bookingService;

        public BookingsController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        // GET: api/Bookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingDto>>> GetBookings()
        {
            return Ok(await bookingService.GetBookings());
        }

        // GET: api/Bookings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingDto>> GetBooking(int id)
        {
            var booking = await bookingService.GetBooking(id);

            if (booking == null)
            {
                return NotFound();
            }
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Booking,  BookingDto>());
            var mapper = config.CreateMapper();
            return mapper.Map<BookingDto>(booking);
        }

        // PUT: api/Bookings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int bookingId, DateTime newStartTime = default, DateTime newEndTime = default)
        {
            var booking = await bookingService.GetBooking(bookingId);

            if(booking == null)
            {
                return NotFound();
            }

            booking.StartTime = newStartTime != default ? newStartTime : booking.StartTime;
            booking.EndTime = newEndTime != default ? newEndTime : booking.EndTime;

            var success = await bookingService.UpdateBooking((Vejledningsbooking.Domain.Interfaces.IBooking)booking);

            if (success)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        // POST: api/Bookings
        [HttpPost]
        public async Task<ActionResult<BookingDto>> PostBooking(int calenderId, int bookingWindowId, BookingDto booking)
        {
            var success = await bookingService.CreateBooking(calenderId, bookingWindowId, booking);
            if (success)
            {
                return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var success = await bookingService.DeleteBooking(id);

            if (success)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
