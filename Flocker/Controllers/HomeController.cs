using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flocker.Model;
using Microsoft.AspNetCore.Mvc;

namespace Flocker.Controllers
{
    public class HomeController : Controller
    {

        IProductRepository _productRepository;
        ICategoryRepository _categoryRepository;

        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {



            return View(_categoryRepository.AllCategory);
        }
    }
}
