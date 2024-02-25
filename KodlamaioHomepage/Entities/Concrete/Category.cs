using KodlamaioHomepage.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.Entities.Concrete
{
    public class Category : IBaseEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

    }
}
