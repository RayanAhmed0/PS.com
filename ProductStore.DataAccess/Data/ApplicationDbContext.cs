using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductStore.Models;

namespace ProductStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // to prevent an issue with identityDbContext , and it's mandatory to put it
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 });

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Company A", City = "Riyadh", StreetAddress = "Neighborood , Street 500", State = "Riyadh", PostalCode = "12345", Phonenumber = "05999999999" },
                new Company { Id = 2, Name = "Company B", City = "Jeddah", StreetAddress = "Downtown, Street 200", State = "Jeddah", PostalCode = "54321", Phonenumber = "05666666666" },
                new Company { Id = 3, Name = "Company C", City = "Dammam", StreetAddress = "Suburb, Street 100", State = "Dammam", PostalCode = "67890", Phonenumber = "05333333333" });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Movie1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus felis magna.",
                    Price = 100,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Movie2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus felis magna.",
                    Price = 200,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Movie3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus felis magna.",
                    Price = 300,
                    CategoryId = 1
                }

                );
        }
    }
}