using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Bases;
using Vejledningsbooking.Application.Repositories.Entities.Bookings;
using Vejledningsbooking.Application.Repositories.Entities.BookingWindows;
using Vejledningsbooking.Application.Repositories.Entities.Calenders;
using Vejledningsbooking.Application.Repositories.Entities.Classes;
using Vejledningsbooking.Application.Repositories.Entities.Students;
using Vejledningsbooking.Application.Repositories.Entities.Teachers;

namespace Vejledningsbooking.Application.Repositories
{
    public static class RepositoryExtentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingWindowRepository, BookingWindowRepository>();
            services.AddScoped<ICalenderRepository, CalenderRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            return services;
        }
    }
}
