using Microsoft.EntityFrameworkCore;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ShopBeta.Infrastructure.Repository
{
    public class RepositoryContext : DbContext
    {
          public RepositoryContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
    }
}
