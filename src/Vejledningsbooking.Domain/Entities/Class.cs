 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vejledningsbooking.Domain.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public Calender Calender { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}
