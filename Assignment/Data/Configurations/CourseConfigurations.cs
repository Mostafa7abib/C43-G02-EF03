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
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder
                .HasKey(nameof(Course.ID));
            builder
                .Property(I => I.ID).UseIdentityColumn(1000, 1);
            builder
                .Property(D => D.Duration)
                .IsRequired().HasDefaultValue(0);
        }
    }
}
