using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Bases;
using Vejledningsbooking.Domain.Contexts;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Entities.Classes
{
    public class ClassRepository : BaseAsyncRepository<Class>, IClassRepository
    {
        public ClassRepository(IVejledningsbookingDbContext dbContext, ILogger<ClassRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
