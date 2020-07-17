using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public interface ICategoryRepository
    {

        public IEnumerable<Category> AllCategory { get; }
        public Category GetCategoryById(int CategoryId);
    }
}
