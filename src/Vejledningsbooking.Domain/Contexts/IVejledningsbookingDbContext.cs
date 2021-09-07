using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Domain.Contexts
{
    public interface IVejledningsbookingDbContext : IDbContext
    {
        DbSet<Booking> Bookings { get; set; }
        DbSet<BookingWindow> BookingWindows { get; set; }
        DbSet<Calender> Calenders { get; set; }
        DbSet<Class> Classes { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }
    }
}
