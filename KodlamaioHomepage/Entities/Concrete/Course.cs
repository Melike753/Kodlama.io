using KodlamaioHomepage.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.Entities.Concrete
{
    public class Course : IBaseEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int CoursePrice { get; set; }


    }
}
