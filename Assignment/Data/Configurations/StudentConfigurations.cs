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
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .HasKey(nameof(Student.ID));
            builder
                .Property(I => I.ID).UseIdentityColumn(102, 1);
            builder
                .Property(N => N.FName)
                .HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            builder
                .Property(N => N.LName)
                .HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            builder
                .Property(A => A.Address)
                .IsRequired();

        }
    }
}
