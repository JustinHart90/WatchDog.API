using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchDog.API.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(c => c.Shows);

            modelBuilder.Entity<Show>().HasOne(b => b.Category);
            modelBuilder.Entity<Show>().HasOne(b => b.User);

            modelBuilder.Entity<User>().HasMany(c => c.Shows);

            modelBuilder.Seed();
        }

        public DbSet<Show> Shows { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Challenge> Challenges { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
