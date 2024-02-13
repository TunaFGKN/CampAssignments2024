using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category> 
            {
                new Category{CategoryId=1, CategoryName = "Backend Kursu"},
                new Category{CategoryId=2, CategoryName = "Frontend Kursu"},
                new Category{CategoryId=3, CategoryName = "Mobil Geliştirme Kursu"}
            };
        }
        public void Add(Category entity)
        {
            _categories.Add(entity);
            Console.WriteLine($"{entity.CategoryName} belleğe eklendi.");
        }

        public void Delete(Category entity)
        {
            Category categoryToDelete = null;
            categoryToDelete = _categories.SingleOrDefault(c => c.CategoryId == entity.CategoryId);
            _categories.Remove(categoryToDelete);
            Console.WriteLine($"{categoryToDelete.CategoryName} kategorisi bellekten silindi.");
        }

        public Category Get(int id)
        {
            return _categories.SingleOrDefault(c => c.CategoryId == id);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category entity)
        {
            Category categoryToUpdate = null;
            categoryToUpdate = _categories.SingleOrDefault(c => c.CategoryId == entity.CategoryId);
            categoryToUpdate.CategoryName = entity.CategoryName;
            Console.WriteLine($"{entity.CategoryName} düzenlendi.");
        }
    }
}
