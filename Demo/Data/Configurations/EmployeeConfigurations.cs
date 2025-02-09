using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                    .Property<string>("EmailAdress")
                    .HasColumnType("varchar")
                    .HasMaxLength(50)
                    .IsRequired();
            builder
                .Property("Name")
                .HasMaxLength(50);
        }
    }
}
