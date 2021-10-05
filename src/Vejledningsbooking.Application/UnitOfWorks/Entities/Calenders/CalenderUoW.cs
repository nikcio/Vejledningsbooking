using Microsoft.EntityFrameworkCore;
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
    public class CalenderUoW : ICalenderUoW
    {
        private readonly IVejledningsbookingDbContext context;
        private readonly ILogger<CalenderUoW> logger;

        public ICalenderRepository CalenderRepository { get; }

        public CalenderUoW(IVejledningsbookingDbContext context, ILogger<CalenderUoW> logger, ICalenderRepository calenderRepository)
        {
            this.context = context;
            this.logger = logger;
            CalenderRepository = calenderRepository;
        }

        public async Task<bool> CompleteAsync()
        {
            try
            {
                await context.Context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }
    }
}
