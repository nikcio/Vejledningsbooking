using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vejledningsbooking.Domain.Entities
{
    public class Student : IUser
    {
        public int Id { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }
        public IEnumerable<Class> Classes { get; set; }
    }
}
