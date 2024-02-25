using KodlamaioHomepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.Business.Abstract
{
    // Course işlemleri için temel operasyonları tanımlama.
    public interface ICourseService
    {
        // Tüm kursları getiren bir metot.
        List<Course> GetAll();

        // Yeni bir kurs eklemek için kullanılır.
        void Add(Course course);

        //  Mevcut bir kursu güncellemek için kullanılır.
        void Update(Course course);

        // Belirli bir kurs id'sine sahip kursu silmek için kullanılır.
        void Delete(int id);
    }
}
