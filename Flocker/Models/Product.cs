using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;



namespace Flocker.Models
{
    public class Product
    {

        public int ProductId { get; set; }

        [DisplayName("Title")]
        public String Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public bool Sold { get; set; }

        public DateTime DatePosted { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }




        public Collection<Comment> Comment { get; set; }

        public int UserId { get; set; }

        public bool Spotlight { get; set; }

        public User Owner { get; set; }
    }
}
