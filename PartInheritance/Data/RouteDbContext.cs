using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PartInheritance.Data.Models;

namespace PartInheritance.Data
{
    internal class RouteDbContext : DbContext
    {
        #region TPCC
        //public DbSet<FullTimeEmployee> fullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABOHABIB\\MSSQLSERVER01;Database=DemoEf03Inheritance;Trusted_Connection=True;Trustservercertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH
            modelBuilder.Entity<FullTimeEmployee>()
                .HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>()
                .HasBaseType<Employee>();
            #endregion       
        }
    }
}
