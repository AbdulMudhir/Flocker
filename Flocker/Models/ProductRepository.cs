using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Product> AllProduct => _databaseContext.Products.Where(p=> !p.Sold).Include(p => p.Category).Include(p => p.Owner);

        public IEnumerable<Product> AllProductOnSpotlight => _databaseContext.Products.Where(p => p.Spotlight);

        public IEnumerable<Product> AllProductByCategory(int categoryId)
        {
            return _databaseContext.Products.Where(p => p.CategoryId == categoryId);
        }

        public IEnumerable<Product> AllProductByUserId(int ownerId)
        {
            return _databaseContext.Products.Where(p => p.UserId == ownerId);
        }

        public IEnumerable<Product> AllProductNotSold()
        {
            return _databaseContext.Products.Where(p => !p.Sold).Include(p => p.Category).Include(p => p.Owner);
        }

        public Product GetProductById(int productId)
        {
            return _databaseContext.Products.Include(p => p.Owner).Include(p=>p.Comment).FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
