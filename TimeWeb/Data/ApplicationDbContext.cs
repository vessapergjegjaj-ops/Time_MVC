using Microsoft.EntityFrameworkCore;
using TimeWeb.Models;

namespace TimeWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        { 
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id =1 , Name = "Luxury Watches" , DisplayOrder= 1 },
                new Category { Id =2 , Name = "Women's Watches", DisplayOrder= 2 },
                new Category { Id =3 , Name = "Men's Watches", DisplayOrder = 3 }
                );
        }
    }
}
