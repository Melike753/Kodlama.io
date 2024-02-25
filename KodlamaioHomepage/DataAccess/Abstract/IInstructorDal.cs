using KodlamaioHomepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.DataAccess.Abstract
{
    // Tekrarlanan kodu azaltır. Bir tür standardizasyon sağlar.
    public interface IInstructorDal : IEntityRepository<Instructor>
    {
    }
}
