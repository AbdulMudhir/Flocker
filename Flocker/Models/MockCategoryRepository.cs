using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategory => new List<Category>
        {
            new Category{
                CategoryId=0,
                Name="Games",
                Image="~/Image/game-console.png"
            },
            new Category{
                CategoryId=1,
                Name="Electronic",
                Image="~/Image/game-console.png"
            },
            new Category{
                CategoryId=2,
                Name="Accessories",
                Image="~/Image/game-console.png"
            },

            
            new Category{
                CategoryId=3,
                Name="Phone",
                Image="~/Image/game-console.png"
            }


        };

        public Category GetCategoryById(int categoryId)
        {
            return AllCategory.FirstOrDefault(cateogry => cateogry.CategoryId == categoryId);
        }
    }
}
