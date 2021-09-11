using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vejledningsbooking.Domain.Entities
{
    public class Teacher : IUser
    {
        public int Id { get; set; }
        public virtual IEnumerable<Class> Classes { get; set; }  // SELECT * FROM Docker;
    }
}
