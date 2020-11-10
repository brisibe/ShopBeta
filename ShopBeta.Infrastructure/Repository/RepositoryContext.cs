using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopBeta.Core.Models;
using ShopBeta.Infrastructure.Authentication;
using ShopBeta.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;


namespace ShopBeta.Infrastructure.Repository
{
    public class RepositoryContext : IdentityDbContext<User>
    {
          public RepositoryContext(DbContextOptions options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
