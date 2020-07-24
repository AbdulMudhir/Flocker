using Microsoft.EntityFrameworkCore;
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

        public void AddOffer(Offer offer)
        {

            _databaseContext.Offers.Add(offer);

            _databaseContext.SaveChanges();
        }

        public IEnumerable<Offer> AllBuyerOffersByOwnerId(string userid)
        {

            return (IEnumerable<Offer>)_databaseContext.Products.Where(p => p.OwnerId.Equals(userid)).Select(p => p.Offers);
        }

        public IEnumerable<Offer> AllOffersByUserId(string userid)
        {
            return _databaseContext.Offers.Where(o => o.UserId.Equals(userid)).Include(o => o.User).Include(o => o.Product).ThenInclude(p=>p.Sold);
        }

        public void DeleteOffer(Offer offer)
        {
            _databaseContext.Offers.Remove(offer);

            _databaseContext.SaveChanges();
        }

        public Offer GetOfferByOfferId(int   offerId)
        {
            return _databaseContext.Offers.FirstOrDefault(o => o.OfferId == offerId );

        }



        public Offer GetOfferForProductByUser(int productID, string userId)
        {

            return _databaseContext.Offers.OrderByDescending(o => o.DatePosted).FirstOrDefault(o => o.UserId == userId && o.ProductId == productID);
        }
    }
}
