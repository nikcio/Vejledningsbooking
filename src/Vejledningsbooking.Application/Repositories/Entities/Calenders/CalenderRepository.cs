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
        public CalenderRepository(IVejledningsbookingDbContext dbContext, ILogger logger) : base(dbContext, logger)
        { }

    }
}
