using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Flocker.Models
{
    public class Product
    {

        public int ProductId { get; set; }

        [MaxLength(100)]
        [Required]
        [DisplayName("Title")]
        public String Name { get; set; }

        [Required]
        public decimal Price { get; set; }


        public Collection<ProductImage> Images { get; set; } = new Collection<ProductImage>();

        [MaxLength(500)]
        [Required]
        public string Description { get; set; }


        public Sold Sold { get; set; }

       
        public DateTime DatePosted { get; set; }

   
        public int CategoryId { get; set; }

        public Category Category { get; set; }



        public string OwnerId { get; set; }

        public CustomUserIdentity Owner { get; set; }


        public Collection<Offer> Offers { get; set; }
        public Collection<Comment> Comments { get; set; }

        public bool Spotlight { get; set; }

    }
}
