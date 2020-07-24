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


        public ProfileController(IProductRepository productRepository, IOfferRepository offerRepository)
        {
            _productRepository = productRepository;
            _offerRepository = offerRepository;
        }

        public IActionResult Index()
        {
            var currentUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

           var products =  _productRepository.AllProductByUserId(currentUserID);


            return View(products);
        }

        public IActionResult Offer()
        {

            return View();
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

    }
}
