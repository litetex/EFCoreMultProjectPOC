using Base;
using Microsoft.EntityFrameworkCore;
using System;

namespace MySQL
{
   public class MySQLContext : Context
   {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         base.OnConfiguring(optionsBuilder);

         optionsBuilder.UseMySQL("server=localhost;database=test;user=test;password=test");
      }
   }
}
