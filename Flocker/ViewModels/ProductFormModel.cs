using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class ProductFormModel

    {






        [MaxLength(100)]
        [Required]
        [DisplayName("Title")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Insert a price")]
        public decimal Price { get; set; }


        [DisplayName("Add photos")]
        [Required]
        public Collection<IFormFile> ImagesFiles { get; set; }



        [MaxLength(500)]
        [Required]
        public string Description { get; set; }


        [DisplayName("Category")]
        [Required]
        public List <SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        public string Category { get; set; }


     





    }
}
