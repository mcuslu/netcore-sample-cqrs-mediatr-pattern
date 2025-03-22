using Microsoft.EntityFrameworkCore;
using netcore_sample_cqrs_mediatr_pattern.Model;
using System.Collections.Generic;

namespace netcore_sample_cqrs_mediatr_pattern.DBContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
