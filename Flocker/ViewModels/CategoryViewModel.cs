﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class CategoryViewModel
    {
       public IEnumerable<Product> products { get; set; }

        public IEnumerable<Category> categories { get; set; }

        public Category Category { get; set; }


    }
}
