using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public IEnumerable<Category> Categories { get; set; }



    }
}
