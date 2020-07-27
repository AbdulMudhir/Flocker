using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Flocker.Models;

namespace Flocker.Controllers
{
    public class CategoryController : Controller
    {

        IProductRepository _productRepository;
        ICategoryRepository _categoryRepository;

        public CategoryController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index(int id)
        {

            CategoryViewModel categoryViewModel = new CategoryViewModel();

            categoryViewModel.categories = _categoryRepository.AllCategory;

            categoryViewModel.products = _productRepository.AllProductByCategory(id);

            categoryViewModel.Category = _categoryRepository.GetCategoryById(id);

            return View(categoryViewModel);

        }

        [HttpPost]
        public IActionResult SortBy([FromBody] int CategoryId)
        {

            if(CategoryId != 0)
            {

                return Json(new
                {
                    success = "true",
                    data =
                    _productRepository.AllProductByCategorySortByPrice(CategoryId)
                });

            }


            return Json (new { success="false" });
        }
    }
}
