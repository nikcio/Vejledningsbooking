using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Entities;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Dtos
{
    public class TeacherDto : IUser, ITeacher
    {
        public int Id { get; set; }
        public byte[] Rowversion { get; set; }

    }
}
