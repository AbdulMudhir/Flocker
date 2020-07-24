using Flocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class ProfileOfferViewModel
    {

        public IEnumerable<Offer> Offers { get; set; }

        public Offer Offer { get; set; }
    }
}
