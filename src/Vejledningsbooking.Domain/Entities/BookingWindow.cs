using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Entities
{
    public class BookingWindow
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; } 
        public DateTime EndTime { get; set; }

        public virtual IEnumerable<Booking> Bookings { get; set; }
        public int CalenderId { get; set; }
        public virtual Calender Calender { get; set; }
        public byte[] Rowversion { get; set; }


        public bool IsBookingInBookingWindow(IBooking booking)
        {
            return StartTime < booking.StartTime && EndTime > booking.EndTime;
        }

        public bool IsBookingOverlapping(IBooking booking)
        {
            return !Bookings.Any(item => item.IsOverlapping(booking));
        }

        public bool IsBookingVaild(IBooking booking)
        {
            return IsBookingInBookingWindow(booking) && IsBookingOverlapping(booking);
        }
    }
}
