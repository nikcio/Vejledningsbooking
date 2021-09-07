using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Repositories.Entities.Calenders;
using Vejledningsbooking.Application.UnitOfWorks.Bases;

namespace Vejledningsbooking.Application.UnitOfWorks.Entities.Calenders
{
    public interface ICalenderUoW : IBaseAsyncUnitOfWork
    {
        ICalenderRepository CalenderRepository { get; }
    }
}
