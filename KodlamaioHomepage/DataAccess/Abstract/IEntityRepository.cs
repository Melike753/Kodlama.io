using KodlamaioHomepage.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.DataAccess.Abstract
{
    // Tüm varlık (entity) tipleri için temel veritabanı işlemlerini (CRUD operasyonları) tanımlar.
    // IEntityRepository<T>: Generic bir arayüz olup, T tipindeki varlıklar için genel bir veritabanı erişim arayüzü sağlar.
    // where T : class, IBaseEntity, new(): Generic tipin bir sınıf olması, IBaseEntity arayüzünü uygulaması ve parametresiz bir kurucu metoda sahip olması gerektiğini belirten sınırlamalardır.

    public interface IEntityRepository<T> where T : class, IBaseEntity, new()
    {
        // Tüm varlıkları getiren bir metot.
        List<T> GetAll();

        // Belirli bir varlığı id'sine göre getiren bir metottur.
        T Get(int id);

        // Yeni bir varlık eklemek için kullanılır.
        void Add(T entity);

        //  Varlık güncelleme işlemi için kullanılır.
        void Update(T entity);

        // Belirli bir id'ye sahip varlığı silmek için kullanılır.
        void Delete(int id);
    }
}