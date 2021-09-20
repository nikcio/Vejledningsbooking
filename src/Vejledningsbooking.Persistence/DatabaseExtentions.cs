using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Contexts;
using Vejledningsbooking.Persistence.Contexts;

namespace Vejledningsbooking.Persistence
{
    public static class DatabaseExtentions
    {
        public static IServiceCollection AddDbConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VejledningsbookingDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultDatabase")));
            services.AddScoped<IVejledningsbookingDbContextBase, VejledningsbookingDbContext>();
            services.AddScoped<IVejledningsbookingDbContext, VejledningsbookingDbContext>();

            return services;
        }
    }
}
