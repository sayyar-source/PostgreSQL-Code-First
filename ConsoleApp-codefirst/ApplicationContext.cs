using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_codefirst
{
   public class ApplicationContext:DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();   // Create the database
        }
        public DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string strconn = "User ID=user1;Password=123;Host=localhost;Port=5432;Database=DemoArticlesApp;Pooling=true;";
            optionsBuilder.UseNpgsql(strconn);
            base.OnConfiguring(optionsBuilder);
            
        }
    }
}
