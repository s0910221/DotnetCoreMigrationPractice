using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Entities
{
    public class MigrateContext : DbContext
    {
        public MigrateContext(DbContextOptions<MigrateContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }

}
