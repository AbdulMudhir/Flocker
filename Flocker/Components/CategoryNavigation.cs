using Flocker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Components
{
    public class CategoryNavigation:ViewComponent
    {

        ICategoryRepository _categoryRepository;

        public CategoryNavigation(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public IViewComponentResult Invoke()
        {

            return View(_categoryRepository.AllCategory);


        }
    }
}
