using Microsoft.Extensions.DependencyInjection;
using Vejledningsbooking.Application.UnitOfWorks.Entities.Bookings;
using Vejledningsbooking.Application.UnitOfWorks.Entities.Calenders;

namespace Vejledningsbooking.Application.UnitOfWorks
{
    public static class UnitOfWorkExtention
    {
        public static IServiceCollection AddUnitOfWorks(this IServiceCollection services)
        {
            services.AddScoped<IBookingUoW, BookingUoW>();
            services.AddScoped<ICalenderUoW, CalenderUoW>();
            return services;
        }
    }
}
