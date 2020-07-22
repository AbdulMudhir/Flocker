using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flocker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Flocker.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository _productRepository;
        ICategoryRepository _categoryRepository;

        public HomeController(ICategoryRepository categoryRepository, IProductRepository iproductRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = iproductRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            homeViewModel.AllCategories = _categoryRepository.AllCategory;
            homeViewModel.AllProduct = _productRepository.AllProduct;
            homeViewModel.AllSpotlight = _productRepository.AllProductOnSpotlight;



            return View(homeViewModel);
        }
    }
}
