using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Flocker.Models
{
    public class Offer
    {
        public int OfferId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public DateTime DatePosted { get; set; }


        public bool isPending { get; set; }
        public string UserId { get; set; }
        public CustomUserIdentity User { get; set; }

        public bool isApproved { get; set; }

    }
}
