using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PartInheritance.Data.Models;

namespace PartInheritance.Data
{
    internal class RouteDbContext : DbContext
    {
        public DbSet<FullTimeEmployee> fullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABOHABIB\\MSSQLSERVER01;Database=DemoEf03Inheritance;Trusted_Connection=True;Trustservercertificate=True");
        }
    }
}
