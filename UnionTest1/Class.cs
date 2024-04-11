namespace UnionTest1
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {

        

        [Key]
        [Required]
        [MaxLength(100)]
        public string? ProductName { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string? QuantityPerUnit { get; set; }

        public int UnitsInStock { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }

        public string? Supplier { get; set; }

        public string? Columns { get; set; }
    }

    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=UnionTest1\\northwind.db"); 
        }
    }

    public class Program
    {
        static void Main()
        {
            using var context = new NorthwindContext();
            var products = context.Products
                .Include(p => p.Columns)
                .Include(p => p.Supplier)
                .ToList();

            foreach (var product in products)
            {
                Console.WriteLine($"Category: {product.CategoryName}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine($"Product: {product.ProductName}");
                Console.WriteLine($"Supplier: {product.Supplier}");
                Console.WriteLine($"Quantity Per Unit: {product.QuantityPerUnit}");
                Console.WriteLine($"Price: {product.UnitPrice:C}");
                Console.WriteLine($"In Stock Units: {product.UnitsInStock}");
                Console.WriteLine();
            }
        }
    }

}
