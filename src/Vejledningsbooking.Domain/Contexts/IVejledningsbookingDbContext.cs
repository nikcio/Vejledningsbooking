using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vejledningsbooking.Domain.Contexts
{
    public interface IVejledningsbookingDbContext : IVejledningsbookingDbContextBase, IDisposable
    {
        DbContext Context { get; }

        public new void Dispose()
        {
            Context.Dispose();
        }
    }
}
