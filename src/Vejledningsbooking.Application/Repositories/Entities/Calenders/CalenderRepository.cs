using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Bases;
using Vejledningsbooking.Domain.Contexts;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Entities.Calenders
{
    public class CalenderRepository : BaseAsyncRepository<Calender>, ICalenderRepository
    {
        private readonly IVejledningsbookingDbContext dbContext;

        public CalenderRepository(IVejledningsbookingDbContext dbContext, ILogger<CalenderRepository> logger) : base(dbContext, logger)
        {
            this.dbContext = dbContext;
        }

        public async override Task<Calender> GetById(int id)
        {
            var result = await base.GetById(id);

            await dbContext.Context.Entry(result)
                .Collection(p => p.BookingWindows)
                .Query()
                .Include(b => b.Bookings)
                .LoadAsync();

            return result;
        }
    }
}
