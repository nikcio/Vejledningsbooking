using System;

namespace Vejledningsbooking.Domain.Interfaces
{
    public interface IBookingWindow
    {
        int CalenderId { get; set; }
        DateTime EndTime { get; set; }
        int Id { get; set; }
        byte[] Rowversion { get; set; }
        DateTime StartTime { get; set; }
    }
}