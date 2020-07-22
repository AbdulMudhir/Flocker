using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class ProductFormEditModel
    {


        public int ProductId { get; set; }
      

        [MaxLength(100)]
        [Required]
        [DisplayName("Title")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Insert a price")]
        public decimal Price { get; set; }


        [DisplayName("Add photos")]
        [Required]
        public Collection<IFormFile> ImagesFiles { get; set; }

        public Collection<string> ImagesUrl { get; set; } = new Collection<string>();

        public Collection<ProductImage> Images { get; set; } = new Collection<ProductImage>();


        [MaxLength(500)]
        [Required]
        public string Description { get; set; }


        [DisplayName("Category")]
        [Required]
        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();


        public int CategoryId { get; set; }
        public string Category { get; set; }

        public int UserId { get; set; }


    }
}
