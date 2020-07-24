using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class Sold
    {

        public int SoldId { get; set; }

        public int ProductId { get; set; }

        [DefaultValue(false)]
        public bool IsSold { get; set; } = false;

        public string UserId { get; set; }

        public CustomUserIdentity User { get; set; }

        public Decimal Price { get; set; }

        public DateTime DateSold { get; set; }
    }
}
