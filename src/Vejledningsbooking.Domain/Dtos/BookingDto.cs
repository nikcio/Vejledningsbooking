using System;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Dtos
{
    public class BookingDto : IBooking
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int BookingWindowId { get; set; }
        public int StudentId { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
