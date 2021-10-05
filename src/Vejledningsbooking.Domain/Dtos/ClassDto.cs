using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Dtos
{
    public class ClassDto : IClass
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int CalenderId { get; set; }
        public byte[] Rowversion { get; set; }

    }
}
