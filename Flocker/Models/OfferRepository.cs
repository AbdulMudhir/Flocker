using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class OfferRepository : IOfferRepository
    {
        DatabaseContext _databaseContext;

        public OfferRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<Offer> AllBuyerOffersByOwnerId(string userid)
        {

            return (IEnumerable<Offer>)_databaseContext.Products.Where(p => p.OwnerId.Equals(userid)).Select(p => p.Offers);
        }

        public IEnumerable<Offer> AllOffersByUserId(string userid)
        {
            return _databaseContext.Offers.Where(o => o.UserId.Equals( userid));
        }
    }
}
