using Flocker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;


namespace Flocker.Controllers
{
    [Authorize]
    public class ProfileController: Controller
    {
        private IProductRepository _productRepository;
        private IOfferRepository _offerRepository;
        private IWatchListRepository _watchListRepository;


        public ProfileController(IProductRepository productRepository, 
            IOfferRepository offerRepository, IWatchListRepository watchListRepository)
        {
            _productRepository = productRepository;
            _offerRepository = offerRepository;
            _watchListRepository = watchListRepository;
        }

        public IActionResult Index()
        {
            var currentUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

           var products =  _productRepository.AllProductByUserId(currentUserID);


            return View(products);
        }

        public IActionResult Spotlight()
        {
            var currentUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);


            if (currentUserID.Equals("bf1fc4eb-f5b9-423d-a7b7-37697e50e266"))
            {
                return View(_productRepository.AllProduct);

            }

            return NotFound();

        }
        public IActionResult Offer()
        {

            var currentUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProfileOfferViewModel profileOfferViewModel = new ProfileOfferViewModel()
            {
                Offers = _offerRepository.AllBuyerOffersByOwnerId(currentUserID)

        };

            return View(profileOfferViewModel);
        }

        public IActionResult MyOffer()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
           var offers =  _offerRepository.AllOffersByUserId(userId);

            ProfileOfferViewModel profileOfferViewModel = new ProfileOfferViewModel
            { Offers = offers
            
            };


            return View(profileOfferViewModel);
        }
       

        public IActionResult WatchList()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            WatchListViewModel watchListViewModel = new WatchListViewModel
            {
                WatchLists = _watchListRepository.GetWatchListsByUserId(userId)
            };

            return View(watchListViewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult WatchList([FromBody]WatchlistPostModel watchlistPostModel)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var watchList = _watchListRepository.GetWatchListForUserForProduct(userId, watchlistPostModel.ProductId);

            if(watchList == null)
            {
                WatchList newWatchlist = new WatchList()
                {
                    ProductId = watchlistPostModel.ProductId,
                    UserID = userId,
                };

                _watchListRepository.AddWatchlist(newWatchlist);

                return Json(new { success = "true" });
            }

            else if (watchList.UserID.Equals(userId))
            {
                _watchListRepository.RemoveWatchlist(watchList);

                return Json(new { success = "true" });
            }


            return Json(new { success="false"});
        }



        [HttpPost]
        public IActionResult DeleteOffer([FromBody]Offer offerReceived)
        {

            var offer = _offerRepository.GetOfferByOfferId(offerReceived.OfferId);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            if (offer != null)
            {

                if (offer.UserId.Equals(userId))
                {

                    _offerRepository.DeleteOffer(offer);

                    return Json(new { success = "true" });
                }

            }


            return Json(new { success = "false" }); ;

        }


        [HttpPost]
        public IActionResult ApproveOrDeclineOffer([FromBody] OfferUpdateModel offerReceived)
        {

            var offer = _offerRepository.GetOfferByOfferId(offerReceived.OfferId);

            var product = _productRepository.GetProductById(offerReceived.ProductId);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);




            if (offer != null && product != null)
            {

                if (product.OwnerId.Equals(userId))
                {


                    if(offerReceived.Message.Equals("Approve"))
                    {

                        _offerRepository.AcceptOffer(offer, offerReceived);

                        return Json(new { success = "true" });
                    }
                    else if (offerReceived.Message.Equals("Decline"))
                    {
                        _offerRepository.DeclineOffer(offer, offerReceived);

                        return Json(new { success = "true" });
                    }
             



                    return Json(new { success = "false" });
                }

            }


            return Json(new { success = "false" }); ;

        }



    }
}
