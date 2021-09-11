using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories;
using Vejledningsbooking.Application.Services;
using Vejledningsbooking.Application.UnitOfWorks;

namespace Vejledningsbooking.Application
{
    public static class ApplicationExtentions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddUnitOfWorks();
            services.AddServices();
            services.AddRepositories();
            return services;
        }
    }
}
