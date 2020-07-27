using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Threading.Tasks;
using Flocker.BlobStorageService;
using Flocker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Azure;

namespace Flocker.Controllers
{

    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        private ICategoryRepository _categoryRepository;

        private IWebHostEnvironment _hostingEnvironment;

        private IOfferRepository _offerRepository;

        private ICommentRepository _commentRepository;

        private IWatchListRepository _watchListRepository;

        private IBlobService _blobService;


        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, IWebHostEnvironment environment, IOfferRepository offerRepository,
            IWatchListRepository watchListRepository, ICommentRepository commentRepository, IBlobService blobService
            )
        {
            _productRepository = productRepository;

            _categoryRepository = categoryRepository;

            _offerRepository = offerRepository;
            _watchListRepository = watchListRepository;

            _commentRepository = commentRepository;

            _blobService = blobService;

            _hostingEnvironment = environment;
        }

        public IActionResult Detail(int id)
        {


            var product = _productRepository.GetProductById(id);





            if (product == null)
            {
                return NotFound();
            }



            ProductViewModel productView = new ProductViewModel();



            productView.Product = product;
            productView.Categories = _categoryRepository.AllCategory;

            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


           

            var offer =  _offerRepository.GetOfferForProductByUser(product.ProductId, userId);

                var watchlist = _watchListRepository.GetWatchListForUserForProduct(userId, product.ProductId);

            if (offer != null)
                {
                   
                    if (offer.isPending)
                    {
                        productView.HasOffer = true;
                    }



                }
                else
                {
                    productView.HasOffer = false;

                }


            if (watchlist != null)
                {
                    productView.HasWatchlist = true;
                }
                else
                {
                    productView.HasWatchlist = false;
                }



            }
            return View(productView);
        }





        [Authorize]
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


    

        [Authorize]
        // made using ajax posting
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(ProductFormModel productForm)
        {

            // no validation for now
            

            if (ModelState.IsValid)
            {

                    Product productToAdd = new Product
                    {

                        Name = productForm.Name,
                        Price = productForm.Price,
                        Description = productForm.Description,
                        CategoryId = int.Parse(productForm.Category),
                        DatePosted = DateTime.Now,
                        OwnerId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                        Sold = new Sold { },
                       

                                           };

                if (productForm.ImagesFiles.Count <= 8)
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

                           var imgUrl = await  _blobService.UploadFileBlobAsync(image, uniqueFileName);


                            // add all the iamge url to  the product object
                            productToAdd.Images.Add(new ProductImage { Image = imgUrl });
                        }

                    }

                    var productID = _productRepository.AddProduct(productToAdd);

                    return Json(new { id = productID, success = "true" });

                }

                else
                {



                    return Json(new { Errors = new { Images = new string[] { "You can only add 8  photos" } }, success = "false" });
                }

            }

            else { 



                        var errorList = ModelState.ToDictionary(
                  kvp => kvp.Key,
                  kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
              );

                        return Json(new { Errors = errorList, success = "false" });

                                    }




            





        }





        [Authorize]
        public IActionResult Edit(int id)
        {


         
          

            Product product = _productRepository.GetProductById(id);

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // check the product being edited is by the correct owner
            if(product.OwnerId.Equals(currentUserId))
            { 


                if (product != null)
                {




                    ProductFormEditModel productEditForm = new ProductFormEditModel
                    {

                        ProductId = product.ProductId,
                        Name = product.Name,
                        Price = product.Price,
                        Description = product.Description,
                        CategoryId = product.CategoryId




                    };




                    foreach (var img in product.Images)
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
                else
                {
                    return NotFound();
                }

            }






            return NotFound();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductFormEditModel productForm)
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

                            var imgUrl = await _blobService.UploadFileBlobAsync(image, uniqueFileName);


                        
                            // add all the iamge url to  the product object
                            productForm.Images.Add(new ProductImage { Image = imgUrl });
                        }

                    }


                    _productRepository.EditProduct(product, productForm);


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

        [Authorize]
        public IActionResult Delete([FromBody]int id)
        {

            var product = _productRepository.GetProductById(id);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            if (product != null)
            {

                if(product.OwnerId == userId)
                {
                    _productRepository.DeleteProduct(product);
                    return RedirectToAction("Index", "Home");
                }

            }


            return NotFound();

        }
        [Authorize]
        public IActionResult DeleteProduct( int id)
        {

            var product = _productRepository.GetProductById(id);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            if (product != null)
            {

                if (product.OwnerId == userId)
                {
                    _productRepository.DeleteProduct(product);
                    return RedirectToAction("Index", "Home");
                }

            }


            return NotFound();

        }

     


        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize]
        public IActionResult MakeOffer(Offer offer)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            var product = _productRepository.GetProductById(offer.ProductId);

            if (ModelState.IsValid) { 

            if(product != null)
            {

                if(!product.Sold.IsSold)
                {

                
            



            // will check latest offer
            var checkOfferAlreadyExist = _offerRepository.GetOfferForProductByUser(offer.ProductId, userId);


            if (checkOfferAlreadyExist == null )
            {

                        offer.UserId = userId;
                        offer.DatePosted = DateTime.Now;
                        offer.isPending = true;

                        _offerRepository.AddOffer(offer);

                return Json(new { success = "True", message = "Offer has been sent" });
            }

            // if the offer is not approved and is not in pending state  means product has been rejected
            else if(!checkOfferAlreadyExist.isApproved && !checkOfferAlreadyExist.isPending )
            {
                        offer.UserId = userId;
                            offer.DatePosted = DateTime.Now;
                            offer.isPending = true;
                            _offerRepository.AddOffer(offer);
                        return Json(new { success = "true", message = "Offer has been sent" });
            }

            // user already has an offer pending
            else
            {
                return Json(new { success = "false", message = "Offer is already pending" });

            }
                }

                return Json(new { success = "false", message = "Product has already been sold" });

            }
            }

            return NotFound();

        }


        [HttpPost]
        public IActionResult PostComment([FromBody] CommentPostModel comment)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (comment != null)
            {
                if (comment.Content.Length > 5 && comment.ProductId > 0)
                {
                    Comment comment1 = new Comment()
                    { ProductId = comment.ProductId,
                        Content = comment.Content,
                        UserId = userId,




                    };

                    _commentRepository.PostComment(comment1);


                    return Json(new { success = "true", date = DateTime.Now.ToString() });

                }

            }

            return Json( new { success="false" });
        }
        [HttpPost]
        public IActionResult SpotlightProduct([FromBody] int productId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var product = _productRepository.GetProductById(productId);
            
            if(userId.Equals("bf1fc4eb-f5b9-423d-a7b7-37697e50e266"))
            {
                if(product != null)
                {
                    _productRepository.SpotlightProduct(product);

                    return Json(new { success = "true" });
                }

            }

            return Json(new { success = "false" });
        }


        [HttpPost]
        public async Task<IActionResult> SearchResult([FromBody]SearchModel search)
        {

            if(ModelState.IsValid)
            {


            var products =  _productRepository.SearchProductByName(search.ProductName);

          
                if (products != null)
                {
                    

                    return Json(new { success = "true", data = products });
                }

            }


            return Json(new { success = "false" });
        }

    }
}
