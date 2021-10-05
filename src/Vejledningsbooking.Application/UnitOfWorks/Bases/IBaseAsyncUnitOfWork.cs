﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vejledningsbooking.Application.UnitOfWorks.Bases
{
    public interface IBaseAsyncUnitOfWork
    {
        Task<bool> CompleteAsync();
    }
}
