using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Services.Entities.Bookings;
using Vejledningsbooking.Application.Services.Entities.Calenders;

namespace Vejledningsbooking.Application.Services
{
    public static class ServicesExtentions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<ICalenderService, CalenderService>();
            return services;
        }
    }
}
