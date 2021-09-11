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
        public CalenderRepository(IVejledningsbookingDbContext dbContext, ILogger<CalenderRepository> logger) : base(dbContext, logger)
        { }

        public async override Task<Calender> GetById(object id)
        {
            var result = await base.GetById(id);
            await Context.Context.Entry(result).Collection(p => p.BookingWindows).Query().Include(b => b.Bookings).LoadAsync();
            return result;
        }
    }
}
