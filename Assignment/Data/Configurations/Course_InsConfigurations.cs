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
    internal class Course_InsConfigurations : IEntityTypeConfiguration<Course_Ins>
    {
        public void Configure(EntityTypeBuilder<Course_Ins> builder)
        {
            builder
                .HasKey(ci => new { ci.Inst_id, ci.Course_id });
            builder
                .Property(ci => ci.Evaluate).IsRequired();
        }
    }
}
