using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Entities.Calenders;
using Vejledningsbooking.Domain.Contexts;

namespace Vejledningsbooking.Application.UnitOfWorks.Entities.Calenders
{
    public class CalenderUoW : ICalenderUoW, IDisposable
    {
        private readonly IVejledningsbookingDbContext context;
        private readonly ILogger<CalenderUoW> logger;

        public ICalenderRepository CalenderRepository { get; }

        public CalenderUoW(IVejledningsbookingDbContext context, ILogger<CalenderUoW> logger)
        {
            this.context = context;
            this.logger = logger;

            CalenderRepository = new CalenderRepository(context, logger);
        }

        public async Task CompleteAsync()
        {
            await context.Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
