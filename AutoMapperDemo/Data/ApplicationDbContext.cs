using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}