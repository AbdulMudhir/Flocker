﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class ProductRepository : IProductRepository
    {

        DatabaseContext _databaseContext;

        public ProductRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<Product> AllProduct => _databaseContext.Products.Where(p => !p.Sold.IsSold).Include(p => p.Category).Include(p => p.Owner).Include(p => p.Images);

        public IEnumerable<Product> AllProductOnSpotlight => _databaseContext.Products.Where(p => p.Spotlight && !p.Sold.IsSold).Include(p => p.Images);

        public IEnumerable<Product> AllProductByCategory(int categoryId)
        {
            return _databaseContext.Products.Where(p => p.CategoryId == categoryId && !p.Sold.IsSold).Include(p => p.Images);
        }

        public IEnumerable<Product> AllProductByUserId(string ownerId)
        {
            return _databaseContext.Products.Where(p => p.OwnerId.Equals(ownerId))
                .Include(p => p.Sold)
                .Include(p => p.Images).Include(p=>p.Category);
        }

        public IEnumerable<Product> AllProductNotSold()
        {
            return _databaseContext.Products.Where(p => !p.Sold.IsSold).Include(p => p.Category).Include(p => p.Owner).Include(p => p.Images);
        }

        public Product GetProductById(int productId)
        {
            return _databaseContext.Products.Include(p => p.Images)
                .Include(p => p.Owner).Include(p => p.Comments).ThenInclude(c => c.User)
                .Include(p=>p.Sold)
                .FirstOrDefault(p => p.ProductId == productId);
        }



        public int AddProduct(Product product)
        {


            var productAdded = _databaseContext.Products.Add(product);

            _databaseContext.SaveChanges();


            return productAdded.Entity.ProductId;

        }

        public int EditProduct(Product product, ProductFormEditModel productForm)
        {

            product.Name = productForm.Name;
            product.Price = productForm.Price;
            product.Description = productForm.Description;
            product.Images = productForm.Images;
            product.CategoryId = productForm.CategoryId;




            return _databaseContext.SaveChanges();
        }

        public int DeleteProduct(Product product)
        {

            _databaseContext.Products.Remove(product);

            return _databaseContext.SaveChanges();
            ;
        }

        public IEnumerable<Product> AllProductByCategorySortByPrice(int categoryId)
        {
            return _databaseContext.Products.Where(p => p.CategoryId == categoryId && !p.Sold.IsSold).Include(p => p.Images)
                .OrderBy (p => p.Price).OrderBy(p => p.Price);
        }

        public void SpotlightProduct(Product product)
        {
            if(product.Spotlight)
            {
                product.Spotlight = false;
            }
            else
            {
                product.Spotlight = true;
            }

            _databaseContext.SaveChanges();
        }

        public IEnumerable<Product> SearchProductByName(string name)
        {
            return _databaseContext.Products.Where(p => p.Name.Contains(name) && !p.Sold.IsSold).Include(p => p.Category);
        }
    }
}
