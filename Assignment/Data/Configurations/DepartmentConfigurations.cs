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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                .HasKey(nameof(Department.ID));
            builder
                .Property(p => p.ID).UseIdentityColumn(10, 10);
            builder
                .Property(D => D.Name)
                .HasColumnType("nvarchar")
                .IsRequired();
            builder
                .Property(P => P.Hiring_Date)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
