using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Dtos
{
    public class BookingWindowDto : IBookingWindow
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CalenderId { get; set; }
        public byte[] Rowversion { get; set; }

    }
}
