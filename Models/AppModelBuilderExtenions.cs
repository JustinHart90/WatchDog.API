using Microsoft.EntityFrameworkCore;

namespace WatchDog.API.Models
{
    public static class AppModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Comedy" },
                new Category { Id = 2, Name = "Action" },
                new Category { Id = 3, Name = "Other" }
            );

            modelBuilder.Entity<Show>().HasData(
                new Show { Id = 1, CategoryId = 1, Description = "Animated comedy television show.", Title = "South Park", IsAvailable = true, UserId = 1 },
                new Show { Id = 2, CategoryId = 1, Description = "Animated comedy television show.", Title = "The Simpsons", IsAvailable = true, UserId = 1 },
                new Show { Id = 3, CategoryId = 1, Description = "Animated comedy television show.", Title = "Family Guy", IsAvailable = true, UserId = 1 },
                new Show { Id = 4, CategoryId = 2, Description = "The origin of crack in the 1970's Los Angeles area.", Title = "Snowball", IsAvailable = true, UserId = 1 },
                new Show { Id = 5, CategoryId = 2, Description = "Utter anarchy on a motorcycle.", Title = "Sons of Anarchy", IsAvailable = true, UserId = 1 },
                new Show { Id = 6, CategoryId = 2, Description = "Badass cowboys gunning for what's theirs.", Title = "Yellowstone", IsAvailable = true, UserId = 1 },
                new Show { Id = 7, CategoryId = 1, Description = "Animated comedy television show.", Title = "South Park", IsAvailable = true, UserId = 2 },
                new Show { Id = 8, CategoryId = 1, Description = "Animated comedy television show.", Title = "The Simpsons", IsAvailable = true, UserId = 2 },
                new Show { Id = 9, CategoryId = 1, Description = "Animated comedy television show.", Title = "Family Guy", IsAvailable = true, UserId = 2 },
                new Show { Id = 10, CategoryId = 2, Description = "The origin of crack in the 1970's Los Angeles area.", Title = "Snowball", IsAvailable = true, UserId = 2 },
                new Show { Id = 11, CategoryId = 2, Description = "Utter anarchy on a motorcycle.", Title = "Sons of Anarchy", IsAvailable = true, UserId = 2 },
                new Show { Id = 12, CategoryId = 2, Description = "Badass cowboys gunning for what's theirs.", Title = "Yellowstone", IsAvailable = true, UserId = 2 }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Adam", Email = "adam@example.com" },
                new User { Id = 2, Name = "Barbara", Email = "barbara@example.com" }
            );
        }
    }
}
