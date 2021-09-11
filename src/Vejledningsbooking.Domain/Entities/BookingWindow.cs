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
        public DateTime EndTime { get; set; } // start- and sluttimedot for a bookingvindue 

        public virtual IEnumerable<Booking> Bookings { get; set; }
        public int CalenderId { get; set; }
        public virtual Calender Calender { get; set; }
    }
}
