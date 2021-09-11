using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Bases;
using Vejledningsbooking.Domain.Contexts;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Entities.Teachers
{
    public class TeacherRepository : BaseAsyncRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(IVejledningsbookingDbContext dbContext, ILogger<TeacherRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
