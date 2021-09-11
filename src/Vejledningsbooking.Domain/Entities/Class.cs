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
        public int CalenderId { get; set; }
        public virtual Calender Calender { get; set; }
        public virtual IEnumerable<Student> Students { get; set; }
        public virtual IEnumerable<Teacher> Teachers { get; set; }
    }
}
