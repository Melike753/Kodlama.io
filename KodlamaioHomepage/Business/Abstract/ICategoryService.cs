using KodlamaioHomepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.Business.Abstract
{
    // Category işlemleri için temel operasyonları tanımlama.
    public interface ICategoryService
    {
        // Tüm kategorileri getiren bir metottur.
        List<Category> GetAll();

        //  Yeni bir kategori eklemek için kullanılır.
        void Add(Category category);

        // Mevcut bir kategoriyi güncellemek için kullanılır.
        void Update(Category category);

        // Belirli bir kategori id'sine sahip kategoriyi silmek için kullanılır.
        void Delete(int id);
    }
}
