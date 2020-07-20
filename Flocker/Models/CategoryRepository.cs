using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class CategoryRepository:ICategoryRepository
    {

        DatabaseContext _databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<Category> AllCategory => _databaseContext.Categories;

        public Category GetCategoryById(int CategoryId)
        {
            return _databaseContext.Categories.FirstOrDefault(p => p.CategoryId == CategoryId);
        }
    }
}
