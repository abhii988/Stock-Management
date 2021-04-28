using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StockManagementSystem.Models;

namespace SMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StockManagementSystem.Models.Customer> Customer { get; set; }
        public DbSet<StockManagementSystem.Models.Category> Category { get; set; }
        public DbSet<StockManagementSystem.Models.Product> Product { get; set; }
        public DbSet<StockManagementSystem.Models.Stock> Stock { get; set; }
        public DbSet<StockManagementSystem.Models.Sales> Sales { get; set; }
        public DbSet<StockManagementSystem.Models.SalesDetail> SalesDetail { get; set; }
        public DbSet<StockManagementSystem.Models.Purchase> Purchase { get; set; }
        public DbSet<StockManagementSystem.Models.PurchaseDetail> PurchaseDetail { get; set; }
    }
}
