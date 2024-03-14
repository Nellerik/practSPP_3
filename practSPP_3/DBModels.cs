using Microsoft.EntityFrameworkCore;

namespace practSPP_3
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }

        public virtual List<Product> Products { get; set;}
    }

    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string? Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }

    public class ComputerCompanyContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public ComputerCompanyContext(DbContextOptions<ComputerCompanyContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
