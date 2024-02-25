using KodlamaioHomepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.Business.Abstract
{
    // Eğitmen işlemleri için temel operasyonları belirtme.
    public interface IInstructorService
    {
        // Tüm eğitmenleri getiren bir metot.
        List<Instructor> GetAll();

        // Yeni bir eğitmen eklemek için kullanılır.
        void Add(Instructor instructor);

        // Mevcut bir eğitmeni güncellemek için kullanılır.
        void Update(Instructor instructor);

        // Belirli bir eğitmen id'sine sahip eğitmeni silmek için kullanılır.
        void Delete(int id);

    }
}
