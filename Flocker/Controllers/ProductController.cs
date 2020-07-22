using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Flocker.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ProductFormModel productForm = new ProductFormModel();

            foreach (var category in _categoryRepository.AllCategory)
            {

                productForm.Categories.Add(
                    new SelectListItem
                    {
                        Value = category.CategoryId.ToString(),
                        Text = category.Name
                    }); ;
            }

                return View(productForm);
        }


        // made using ajax posting
        [HttpPost]
        [ValidateAntiForgeryToken]
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
                CategoryId = int.Parse(productForm.Category),
                DatePosted = DateTime.Now.Date
                
                };

                if(productForm.ImagesFiles.Count <=8) { 



                foreach (var image in productForm.ImagesFiles)
                    {

                        // check image size is not greater than 8mb otherwise skip
                        if (image.Length / 1024 / 1024 <= 8)
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

                }

                var productID = _productRepository.AddProduct(productToAdd);

                return Json(new { id = productID, success="true" });

            }

                else
                {



                    return Json(new { Errors = new {  Images = new string[] { "You can only add 8  photos" } }, success = "false" });
                }

            }
           



            var errorList = ModelState.ToDictionary(
      kvp => kvp.Key,
      kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
  );

            return Json(new { Errors = errorList, success = "false" });
        }


     



        public IActionResult Edit(int id)
        {

            Product product = _productRepository.GetProductById(id);

            if (product != null)
            {


               

                ProductFormEditModel productEditForm = new ProductFormEditModel
                { 
                
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Price =   product.Price,
                    Description = product.Description,
                    UserId = product.UserId,
                    CategoryId = product.CategoryId
                    
                    

                
                };




                foreach(var img in product.Images)
                {
                    productEditForm.ImagesUrl.Add(img.Image);
                }


                foreach (var category in _categoryRepository.AllCategory)
                {

                    productEditForm.Categories.Add(
                        new SelectListItem
                        {
                            Value = category.CategoryId.ToString(),
                            Text = category.Name
                        }); ;
                }




                return View(productEditForm);
            }







            return NotFound();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductFormEditModel productForm)
        {





            // no validation for now



            if (ModelState.IsValid)
            {


                Product product = _productRepository.GetProductById(productForm.ProductId);


                if (product != null)
                {



                    foreach (var image in productForm.ImagesFiles)
                    {

                        // check image size is not greater than 8mb otherwise skip
                        if (image.Length / 1024 / 1024 <= 8)
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
                            productForm.Images.Add(new ProductImage { Image = "~/ProductImages/" + uniqueFileName });
                        }

                    }


                    _productRepository.EditProduct(product,productForm);


                    /// change this below after test
                    return Json(new { success = "true" });



                }


                else
                {

                    return NotFound();

                }


            }


            var errorList = ModelState.ToDictionary(
                 kvp => kvp.Key,
                 kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
             );
            return Json(new { Errors = errorList, success = "false" });


        }


    }
}
