using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flocker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flocker.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository _productRepository;

        ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;

            _categoryRepository = categoryRepository;
        }

        public IActionResult Detail(int id)
        {
         

            var product = _productRepository.GetProductById(id);

            



            if(product == null)
            {
                return NotFound();
            }


            ProductViewModel productView = new ProductViewModel();

            productView.Product = product;
            productView.Categories = _categoryRepository.AllCategory;
               



            return View(productView);
        }


        public ViewResult Add()

        {
            ProductViewModel productView = new ProductViewModel();

            productView.Categories = _categoryRepository.AllCategory;

            return View(productView);
        }

        [HttpPost]
        public IActionResult Add(ProductViewModel productView)
        {
            return RedirectToAction("add");
        }


    }
}
