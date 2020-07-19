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
            Name= "XBOX ONE CONTROLLER",
            Price = 34.99M,
            CategoryId = 2,
            Image ="https://i.imgur.com/w305JQE.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = false,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(2),
            UserId = 1,
            Spotlight=true,
            Owner = _userRepository.GetUserById(1)
        },

           new Product
        {
            ProductId= 2,
            Price = 34.99M,
                    Name= "XBOX ONE CONTROLLER FREE",
            CategoryId = 2,
            Image ="~/Image/controller.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = false,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(2),
            UserId = 1,
                  Spotlight=true,
            Owner = _userRepository.GetUserById(1)
        },

        new Product
        {
            ProductId= 3,
            Price = 34.99M,
                    Name= "CUPBOARD",
            CategoryId = 3,
            Image ="~/Image/cupboard.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = false,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 2,
                  Spotlight=true,
            Owner = _userRepository.GetUserById(2)
        },

         new Product
        {
            ProductId= 4,
                   Name= "BED SHEET",
            Price = 34.99M,
            CategoryId = 3,
            Image ="~/Image/bed.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 2,
                  Spotlight=true,
            Owner = _userRepository.GetUserById(2)
        },

           new Product
        {
            ProductId= 5,
            Name= "XBOX ONE GAMES",
            Price = 7200.99M,
            CategoryId = 3,
            Image ="~/Image/games.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 3,
                  Spotlight=true,
            Owner = _userRepository.GetUserById(3)
        },
               new Product
        {
            ProductId= 5,
            Name= "XBOX ONE GAMES",
            Price = 7200.99M,
            CategoryId = 3,
            Image ="~/Image/games.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 3,
                  Spotlight=true,
            Owner = _userRepository.GetUserById(3)
        },

                   new Product
        {
            ProductId= 5,
            Name= "XBOX ONE GAMES",
            Price = 7200.99M,
            CategoryId = 3,
            Image ="~/Image/games.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 3,
                  Spotlight=true,
            Owner = _userRepository.GetUserById(3)
        },

                       new Product
        {
            ProductId= 5,
            Name= "XBOX ONE GAMES",
            Price = 7200.99M,
            CategoryId = 3,
            Image ="~/Image/games.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 3,
                  Spotlight=true,
            Owner = _userRepository.GetUserById(3)
        },

                           new Product
        {
            ProductId= 5,
            Name= "XBOX ONE GAMES",
            Price = 7200.99M,
            CategoryId = 3,
            Image ="~/Image/games.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 3,
                  Spotlight=true,
            Owner = _userRepository.GetUserById(3)
        },


         new Product
        {
            ProductId= 6,
            Name= "Product 6",
            Price = 100.99M,
            CategoryId = 3,
            Image ="https://i.imgur.com/w305JQE.png",
            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            Sold = true,
            DatePosted = DateTime.Today,
            Category = _mockCategory.GetCategoryById(3),
            UserId = 3,
                  Spotlight=false,
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
                  Spotlight=false,
            Owner = _userRepository.GetUserById(3)
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
                  Spotlight=true,
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
                  Spotlight=true,
            Owner = _userRepository.GetUserById(2)
        },


        };

        IEnumerable<Product> IProductRepository.AllProductOnSpotlight => AllProduct.Where(p => p.Spotlight);


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

        public IEnumerable<Product> AllProductOnSpotlight()
        {

            return AllProduct.Where(p => p.Spotlight);

        }


}
}
