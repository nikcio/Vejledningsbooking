using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Bases;
using Vejledningsbooking.Domain.Contexts;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Repositories.Entities.Students
{
    public class StudentRepository : BaseAsyncRepository<Student>, IStudentRepository
    {
        public StudentRepository(IVejledningsbookingDbContext dbContext, ILogger<StudentRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
