using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vejledningsbooking.Domain.Entities
{
    public class Calender
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
        public virtual IEnumerable<BookingWindow> BookingWindows { get; set; }
    }
}
