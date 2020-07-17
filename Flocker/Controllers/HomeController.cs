using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flocker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flocker.Controllers
{
    public class HomeController : Controller
    {

        ICategoryRepository _categoryRepository;

        public HomeController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {



            return View(_categoryRepository.AllCategory);
        }
    }
}
