using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public interface IOfferRepository
    {

        public IEnumerable<Offer> AllOffersByUserId(string userid);
        public IEnumerable<Offer> AllBuyerOffersByOwnerId(string userid);
    }
}
