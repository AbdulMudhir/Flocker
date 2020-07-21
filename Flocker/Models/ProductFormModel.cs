using Microsoft.AspNetCore.Http;
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

        [Required]
        public decimal Price { get; set; }


        public Collection<IFormFile> Images { get; set; }



        [MaxLength(500)]
        [Required]
        public string Description { get; set; }



        public int UserId { get; set; }


        public int CategoryId { get; set; }


    }
}
