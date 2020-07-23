using Flocker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Controllers
{
    public class ProfileController: Controller
    {
        private IProductRepository _productRepository;

        public ProfileController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
