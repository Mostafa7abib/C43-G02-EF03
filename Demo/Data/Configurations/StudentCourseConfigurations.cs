using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.Configurations
{
    internal class StudentCourseConfigurations : IEntityTypeConfiguration<StudentsCourses>
    {
        public void Configure(EntityTypeBuilder<StudentsCourses> builder)
        {
            builder
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}
