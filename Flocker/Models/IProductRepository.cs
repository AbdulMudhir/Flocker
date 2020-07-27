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


        public IEnumerable<Product> AllProductByCategorySortByPrice(int categoryId);
 

        public IEnumerable<Product> AllProductNotSold();


        public Product GetProductById(int productId);



        public IEnumerable<Product> AllProductByUserId(string ownerId);


        public IEnumerable<Product> AllProductOnSpotlight { get; }

        public IEnumerable<Product> SearchProductByName(string name);

        public int AddProduct(Product product);
        public int EditProduct(Product product, ProductFormEditModel productForm);


        public int DeleteProduct(Product product);

        public void SpotlightProduct(Product product);

    }
}
