using Microsoft.EntityFrameworkCore;

namespace Store.Models
{
    public class RepositoryContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext>options)
        : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
            new Product() { ProductId=1,ProductName="Computer",Price=17000},
            new Product() { ProductId=2,ProductName="Keyboard",Price=1000},
            new Product() { ProductId=3,ProductName="Mause",Price=500},
            new Product() { ProductId=4,ProductName="Monitor",Price=7000},
            new Product() { ProductId=5,ProductName="Deck",Price=1500}
            );
        }
    }
}
