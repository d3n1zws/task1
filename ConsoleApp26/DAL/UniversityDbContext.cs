using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp26.Models.UniversityEntity;

namespace ConsoleApp26.DAL
{
    internal class UniversityDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ORMtask;Trusted_Connection=True;integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UniStudent> UniStudents { get; set; }
    }
}
