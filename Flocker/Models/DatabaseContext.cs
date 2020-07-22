using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class DatabaseContext:IdentityDbContext<CustomUserIdentity>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        
        public DbSet<Category> Categories { get; set; }


        public DbSet <ProductImage> ProductImages { get; set; }

        public DbSet <Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                Name = "Games",
                Image = "~/Image/game-console.png"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 2,
                Name = "Electronic",
                Image = "~/Image/game-console.png"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 3,
                Name = "Accessories",
                Image = "~/Image/game-console.png"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 4,
                Name = "Phone",
                Image = "~/Image/game-console.png"
            });


            //modelBuilder.Entity<Product>().HasData(

            //     new Product
            //     {
            //         ProductId = 1,
            //         Name = "XBOX ONE CONTROLLER",
            //         Price = 34.99M,
            //         CategoryId = 2,
            //         Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            //         Sold = false,
            //         DatePosted = DateTime.Today,
            //         Spotlight = false,

            //     });

            //modelBuilder.Entity<Product>().HasData(

            //   new Product
            //   {
            //       ProductId = 2,
            //       Price = 34.99M,
            //       Name = "XBOX ONE CONTROLLER FREE",
            //       CategoryId = 1,
            //       Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            //       Sold = false,
            //       DatePosted = DateTime.Today,
            //       Spotlight = true,
            //   }


            //  );
            //modelBuilder.Entity<Product>().HasData(

            //   new Product
            //   {
            //       ProductId = 3,
            //       Price = 34.99M,
            //       Name = "CUPBOARD",
            //       CategoryId = 1,
            //       Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            //       Sold = false,
            //       DatePosted = DateTime.Today,
            //       Spotlight = true,

            //   }


            //  );

            //modelBuilder.Entity<Product>().HasData(

            //   new Product
            //   {
            //       ProductId = 4,
            //       Name = "BED SHEET",
            //       Price = 34.99M,
            //       CategoryId = 2,
            //       Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            //       Sold = true,
            //       DatePosted = DateTime.Today,
            //       Spotlight = false,

            //   }


            //  );

            //modelBuilder.Entity<Product>().HasData(

            //   new Product
            //   {
            //       ProductId = 5,
            //       Name = "XBOX ONE GAMES",
            //       Price = 7200.99M,
            //       CategoryId = 3,
            //       Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
            //       Sold = true,
            //       DatePosted = DateTime.Today,
            //       Spotlight = false,

            //   }


            //  );

            //modelBuilder.Entity<ProductImage>().HasData(new ProductImage

            //{
            //    Id = 1,
            //    ProductId = 1,
            //    Image = "~/Image/bed.png"

            //}

            //    );


            //modelBuilder.Entity<ProductImage>().HasData(new ProductImage

            //{
            //    Id = 2,
            //    ProductId = 1,
            //    Image = "~/Image/bed.png"

            //}

            //    );


            //modelBuilder.Entity<ProductImage>().HasData(new ProductImage

            //{
            //    Id = 3,
            //    ProductId = 2,
            //    Image = "~/Image/bed.png"

            //}

            //    );


            //modelBuilder.Entity<ProductImage>().HasData(new ProductImage

            //{
            //    Id = 4,
            //    ProductId = 2,
            //    Image = "~/Image/bed.png"

            //}

            //    );


            //modelBuilder.Entity<ProductImage>().HasData(new ProductImage

            //{
            //    Id = 5,
            //    ProductId = 3,
            //    Image = "~/Image/bed.png"

            //}

            //    );



            //modelBuilder.Entity<User>().HasData(

            //      new User
            //      {
            //          UserId = 1,
            //          Username = "Test Dummy",
            //          Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg"

            //      }
            //    );

            //modelBuilder.Entity<User>().HasData(

            //  new User
            //  {

            //      UserId = 2,
            //      Username = "Bob Marley",
            //      Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg"

            //  }
            //);

            //modelBuilder.Entity<User>().HasData(

            //  new User
            //  {
            //      UserId = 3,
            //      Username = "Jack Danny",
            //      Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg"

            //  }
            //);

            //modelBuilder.Entity<User>().HasData(

            //  new User
            //  {
            //      UserId = 4,
            //      Username = "Easter Egg",
            //      Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg"

            //  }
            //);


            //modelBuilder.Entity<Comment>().HasData(

            //    new Comment
            //    {
            //        content = "how much is this?",

            //        CommentId = 1,
            //        ProductId = 1,
            //        UserId = 1,


            //    }


            //    );


            //modelBuilder.Entity<Comment>().HasData(

            //    new Comment
            //    {
            //        content = "how much is this?",

            //        CommentId = 2,
            //        ProductId = 1,
            //        UserId = 1,


            //    }


            //    );


            //modelBuilder.Entity<Comment>().HasData(

            //    new Comment
            //    {
            //        content = "how much is this?",
            //        CommentId = 3,
            //        ProductId = 1,
            //        UserId = 1,


            //    }


            //    );


            //modelBuilder.Entity<Comment>().HasData(

            //    new Comment
            //    {
            //        content = "how much is this?",
            //        CommentId = 4,
            //        ProductId = 1,
            //        UserId = 1,


            //    }


            //    );




        }
    }




}
