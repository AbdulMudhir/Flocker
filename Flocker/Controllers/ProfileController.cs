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

        public ProfileController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
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
            return View();
        }
    }
}
