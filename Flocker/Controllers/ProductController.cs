using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Flocker.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Flocker.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        private ICategoryRepository _categoryRepository;

        private IWebHostEnvironment _hostingEnvironment;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, IWebHostEnvironment environment)
        {
            _productRepository = productRepository;

            _categoryRepository = categoryRepository;

            _hostingEnvironment = environment;
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


            return View(new ProductFormModel());
        }

        [HttpPost]
        public IActionResult Add(ProductFormModel productForm)
        {

            // no validation for now








            if(ModelState.IsValid)
            {

                Product productToAdd = new Product { 
                
                Name = productForm.Name,
                Price = productForm.Price,
                Description = productForm.Description,
                UserId = 1,
                CategoryId = productForm.CategoryId,
                
                };


                
                foreach(var image in productForm.Images)
                {

                    // get random filename and combine with the extension file camewith
                    var uniqueFileName = Path.GetRandomFileName() + Path.GetExtension(image.FileName);
                    var uploadPath = Path.Combine(_hostingEnvironment.WebRootPath, "ProductImages");
                    var filePath = Path.Combine(uploadPath, uniqueFileName);


                    using (var stream = System.IO.File.Create(filePath))
                    {
                        image.CopyTo(stream);

                    }

                    // add all the iamge url to  the product object
                    productToAdd.Images.Add(new ProductImage { Image = "~/ProductImages/" + uniqueFileName });


                }

                var productID = _productRepository.AddProduct(productToAdd);

                return RedirectToAction("Detail", new { id = productID});

            }







          

            return View(productForm);
        }



    }
}
