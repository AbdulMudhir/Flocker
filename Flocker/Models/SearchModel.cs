using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class SearchModel
    {
        [Required]
        public string ProductName { get; set; }
    }
}
