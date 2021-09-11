using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.UnitOfWorks.Entities.Calenders;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Services.Entities.Calenders
{
    public class CalenderService : ICalenderService
    {
        private readonly ICalenderUoW calenderUoW;

        public CalenderService(ICalenderUoW calenderUoW)
        {
            this.calenderUoW = calenderUoW;
        }

        public async Task<Calender> GetCalender(int id)
        {
            return await calenderUoW.CalenderRepository.GetById(id);
        }
    }
}
