using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool IsBookingInBookingWindow(Booking booking)
        {
            return StartTime < booking.StartTime && EndTime > booking.EndTime;
        }

        public bool IsBookingOverlapping(Booking booking)
        {
            return !Bookings.Any(item => item.IsOverlapping(booking));
        }

        public bool IsBookingVaild(Booking booking)
        {
            return IsBookingInBookingWindow(booking) && IsBookingOverlapping(booking);
        }
    }
}
