using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UnionTest1.Models;
using UnionTest1;

namespace UnionTest1.Data
{
    public partial class UnionTest1Context : DbContext
    {
        public UnionTest1Context()
        {

        }

        public UnionTest1Context(DbContextOptions<UnionTest1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Keep your connection strings separate from your code!
            // Secure connection string guidance: https://aka.ms/ef-core-connection-strings
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Daniel\\source\\repos\\UnionTest1\\UnionTest1\\bin\\Debug\\northwind.db");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}