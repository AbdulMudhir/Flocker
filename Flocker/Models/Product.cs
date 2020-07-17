using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Model
{
    public class Product
    {

        public int ProductId { get; set; }
        public String Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public bool Sold { get; set; }

        public DateTime DatePosted { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }


        public int LocationId { get; set; }

        public Location Location { get; set; }

        public int UserId { get; set; }

        public User Owner { get; set; }
    }
}
