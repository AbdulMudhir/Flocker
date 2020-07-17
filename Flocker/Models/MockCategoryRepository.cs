using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Model
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategory => new List<Category>
        {
            new Category{
                CategoryId=0,
                Name="Games"
            },
            new Category{
                CategoryId=1,
                Name="Electronic"
            },
            new Category{
                CategoryId=2,
                Name="Home Accessories"
            },

            
            new Category{
                CategoryId=3,
                Name="Phone"
            }


        };

        public Category GetCategoryById(int categoryId)
        {
            return AllCategory.FirstOrDefault(cateogry => cateogry.CategoryId == categoryId);
        }
    }
}
