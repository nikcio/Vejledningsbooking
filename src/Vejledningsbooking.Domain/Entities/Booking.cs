using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vejledningsbooking.Domain.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int BookingWindowId { get; set; }
        public int StudentId { get; set; }
        public virtual BookingWindow BookingWindow { get; set; }
        public virtual Student Student { get; set; }

        public bool IsOverlapping(Booking booking)
        {
            return (StartTime <= booking.StartTime && !(EndTime < booking.StartTime)) ||
                   (StartTime < booking.EndTime);
        }
    }
}
