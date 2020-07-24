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

        public Offer GetOfferForProductByUser(int productID, string userId);

        public Offer GetOfferByOfferId(int offerId);


        public IEnumerable<Offer> AllOfferForProduct(int productId);
        public void AddOffer(Offer offer);

        public void DeleteOffer(Offer offer);

        public void UpdateOffer(Offer offer, OfferUpdateModel offerUpdate);

        public void AcceptOffer(Offer offer, OfferUpdateModel offerUpdate);
        public void DeclineOffer(Offer offer, OfferUpdateModel offerUpdate);
    }
}
