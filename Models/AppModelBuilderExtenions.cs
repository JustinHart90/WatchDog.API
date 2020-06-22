using Microsoft.EntityFrameworkCore;

namespace WatchDog.API.Models
{
    public static class AppModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Appetizer" },
                new Category { Id = 2, Name = "Entree" },
                new Category { Id = 3, Name = "Side" },
                new Category { Id = 4, Name = "Drink" },
                new Category { Id = 5, Name = "Desert" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Flatbread", Price = 5, IsAvailable = true },
                new Product { Id = 2, CategoryId = 1, Name = "Onion Rings", Price = 5, IsAvailable = true },
                new Product { Id = 3, CategoryId = 1, Name = "Bread Sticks", Price = 5, IsAvailable = true },
                new Product { Id = 4, CategoryId = 2, Name = "Hot Dog", Price = 5, IsAvailable = true },
                new Product { Id = 5, CategoryId = 2, Name = "Double Dog", Price = 7, IsAvailable = true },
                new Product { Id = 6, CategoryId = 2, Name = "Cheeseburger", Price = 7, IsAvailable = true },
                new Product { Id = 7, CategoryId = 3, Name = "Side Sauce", Price = 1, IsAvailable = true },
                new Product { Id = 8, CategoryId = 3, Name = "French Fries", Price = 3, IsAvailable = true },
                new Product { Id = 9, CategoryId = 3, Name = "Potato Chips", Price = 2, IsAvailable = true },
                new Product { Id = 10, CategoryId = 4, Name = "Cookie", Price = 3, IsAvailable = true },
                new Product { Id = 11, CategoryId = 4, Name = "Brownie", Price = 3, IsAvailable = true },
                new Product { Id = 12, CategoryId = 4, Name = "Ice Cream Sundae", Price = 4, IsAvailable = true }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Adam", Email = "adam@example.com" },
                new User { Id = 2, Name = "Barbara", Email = "barbara@example.com" }
            );
        }
    }
}
