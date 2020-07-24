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

        public void AcceptOffer(Offer offer, OfferUpdateModel offerUpdate)
        {

            offer.isPending = false;
            offer.isApproved = true;
            offer.Product.Sold.IsSold = true;
            offer.Product.Sold.Offer = offer;
            offer.Product.Sold.DateSold = DateTime.Now.Date;

            var remainingOffer = AllOfferForProduct(offer.ProductId);

            foreach(var item in remainingOffer)
            {
                item.isApproved = false;
                item.isPending = false;
            }


            _databaseContext.SaveChanges();


        }

        public void AddOffer(Offer offer)
        {

            _databaseContext.Offers.Add(offer);

            _databaseContext.SaveChanges();
        }

        public IEnumerable<Offer> AllBuyerOffersByOwnerId(string userid)
        {

            return _databaseContext.Offers.Where(p => p.Product.OwnerId.Equals(userid) && !p.Product.Sold.IsSold)
                .Where(p => p.isPending).Include(p => p.Product).ThenInclude(p => p.Sold).Include(p => p.User);
        }

        public IEnumerable<Offer> AllOfferForProduct(int productId)
        {

            return _databaseContext.Offers.Where(p => p.Product.ProductId == productId && !p.isApproved);
        }

        public IEnumerable<Offer> AllOffersByUserId(string userid)
        {
            return _databaseContext.Offers.Where(o => o.UserId.Equals(userid)).Include(o => o.User).Include(o => o.Product).ThenInclude(p=>p.Sold)
                .Include(p => p.Product.Owner);
        }

        public void DeclineOffer(Offer offer, OfferUpdateModel offerUpdate)
        {
            offer.isPending = false;

            _databaseContext.SaveChanges();

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

        public void UpdateOffer(Offer offer, OfferUpdateModel offerUpdate)
        {
            
        }
    }
}
