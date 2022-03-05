using EfCore.Domain.ProductAgg;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfCore.Infrastructure.EfCore
{
    public class EfContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public EfContext(DbContextOptions<EfContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }

}
