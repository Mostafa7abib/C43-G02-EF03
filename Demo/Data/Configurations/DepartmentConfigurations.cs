using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Demo.Data.Models;

namespace Demo.Data.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                //.HasKey("DeptId") // first way to detecct key
                //.HasKey(d => d.DeptId) // second way to detecct key
                .HasKey(nameof(Department.DeptId)); // third way to detecct key *BETTER*
            builder
                .Property(p => p.DeptId).UseIdentityColumn(10, 10);
            builder
                .Property(D => D.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .IsRequired();
            builder
                .Property(P => P.CreationDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
