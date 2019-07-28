using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
   public class Context : DbContext
   {
      public DbSet<DemoEntity> MyTable { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseLazyLoadingProxies();
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder
            .Entity<DemoEntity>()
            .HasIndex(n => n.Name)
            .IsUnique();
      }
   }
}
