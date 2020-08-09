using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatagoryService.Database
{
    public class CategoryServiceContext : DbContext
    {
        public CategoryServiceContext(DbContextOptions<CategoryServiceContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
