using KodlamaioHomepage.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.Entities.Concrete
{
    public class Instructor : IBaseEntity
    {
        public int Id { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }

    }
}
