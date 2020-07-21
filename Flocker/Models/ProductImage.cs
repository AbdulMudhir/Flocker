using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class ProductImage
    {

        public int Id { get; set; }

        public int ProductId { get; set; }

        public string Image { get; set; }
    }
}
