using System;

namespace Vejledningsbooking.Domain.Interfaces
{
    public interface IBooking
    {
        int BookingWindowId { get; set; }
        DateTime EndTime { get; set; }
        int Id { get; set; }
        byte[] Rowversion { get; set; }
        DateTime StartTime { get; set; }
        int StudentId { get; set; }
    }
}