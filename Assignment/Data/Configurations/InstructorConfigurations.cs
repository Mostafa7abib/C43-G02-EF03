using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.Configurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder
                .HasKey(i => i.ID);
            builder
                .Property(i => i.ID).UseIdentityColumn(1, 1);
            builder
                .Property(i => i.Name).HasMaxLength(50).IsRequired();
            builder
                .Property(i => i.Bouns).IsRequired().HasColumnType("decimal");
            builder
                .Property(i => i.Salary).IsRequired().HasColumnType("decimal")
                .HasMaxLength(6);
            builder
                .Property(i => i.Address).HasMaxLength(100).IsRequired();
            builder
                .Property(i => i.Hour_Rate).IsRequired().HasColumnType("decimal");
        }
    }
}
