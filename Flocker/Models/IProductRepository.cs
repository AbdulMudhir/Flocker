using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public interface IProductRepository
    {

        public IEnumerable<Product> AllProduct { get; }


        public IEnumerable<Product> AllProductByCategory(int categoryId);


        public IEnumerable<Product> AllProductNotSold();


        public Product GetProductById(int productId);



        public IEnumerable<Product> AllProductByUserId(int ownerId);


        public IEnumerable<Product> AllProductOnSpotlight { get; }


        public int AddProduct(Product product);




    }
}
