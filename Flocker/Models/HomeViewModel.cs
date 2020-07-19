using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class HomeViewModel
    {

        public IEnumerable<Product> AllSpotlight { get; set; }
        public IEnumerable<Product> AllProduct { get; set; }

        public IEnumerable<Category> AllCategories { get; set; }


    }
}
