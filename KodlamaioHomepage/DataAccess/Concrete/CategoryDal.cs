using KodlamaioHomepage.DataAccess.Abstract;
using KodlamaioHomepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category{Id=1,CategoryName="Programlama"},
            };
        }

        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public void Delete(int id)
        {
            Category categoryToDelete = _categories.FirstOrDefault(c => c.Id == id);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }
        }
        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category Get(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Category entity)
        {
            Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == entity.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = entity.CategoryName;
            }
            else
            {
                Console.WriteLine("The category with the entered ID number cannot be found. Therefore, the update process cannot be performed!");
            }
        }
    }
}
