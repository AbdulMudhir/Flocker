using Microsoft.AspNetCore.Authorization.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class MockProductRepository : IProductRepository
    {
        MockCategoryRepository _mockCategory = new MockCategoryRepository();
        MockUserRepository _userRepository = new MockUserRepository();

   
        public IEnumerable<Product> AllProduct => new List<Product> {

        new Product
        {
            ProductId= 1,
            Name= "Product 1",
            Price = 34.99M,
            CategoryId = 2,
            Image ="https://i.imgur.com/w305JQE.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = false,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(2),
            UserId = 1,
            Owner = _userRepository.GetUserById(1)
        },

           new Product
        {
            ProductId= 2,
            Price = 34.99M,
                    Name= "Product 1",
            CategoryId = 2,
            Image ="https://i.imgur.com/w305JQE.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = false,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(2),
            UserId = 1,
            Owner = _userRepository.GetUserById(1)
        },

        new Product
        {
            ProductId= 3,
            Price = 34.99M,
                    Name= "Product 3",
            CategoryId = 3,
            Image ="https://i.imgur.com/w305JQE.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = false,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 2,
            Owner = _userRepository.GetUserById(2)
        },

         new Product
        {
            ProductId= 4,
                   Name= "Product 4",
            Price = 34.99M,
            CategoryId = 3,
            Image ="https://i.imgur.com/w305JQE.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 2,
            Owner = _userRepository.GetUserById(2)
        },

           new Product
        {
            ProductId= 5,
            Name= "Product 5",
            Price = 34.99M,
            CategoryId = 3,
            Image ="https://i.imgur.com/w305JQE.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 3,
            Owner = _userRepository.GetUserById(3)
        },

         new Product
        {
            ProductId= 6,
            Name= "Product 6",
            Price = 34.99M,
            CategoryId = 3,
            Image ="https://i.imgur.com/w305JQE.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 3,
            Owner = _userRepository.GetUserById(3)
        },
        };





        public IEnumerable<Product> AllProductByCategory(int categoryId)
        {
            return AllProduct.Where(product => product.CategoryId == categoryId);
        }

        public IEnumerable<Product> AllProductByUserId(int ownerId)
        {
            
            return AllProduct.Where(product => product.UserId == ownerId);
        }

        public IEnumerable<Product> AllProductNotSold()
        {
            return AllProduct.Where(product => !product.Sold);
        }

        public Product GetProductById(int productId)
        {
            return AllProduct.FirstOrDefault(product => product.ProductId == productId);
        }
    }
}
