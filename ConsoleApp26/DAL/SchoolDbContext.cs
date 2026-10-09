using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp26.Models;

namespace ConsoleApp26.DAL
{
    internal class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ORMtask;Trusted_Connection=True;integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<Student> Students { get; set; }
    }

}
