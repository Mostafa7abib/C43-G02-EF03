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
    internal class TopicConfigurations : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder
                .HasKey(t => t.ID);
            builder
                .Property(t => t.ID).UseIdentityColumn(200, 1);
            builder
                .Property(t => t.Name).HasMaxLength(50).IsRequired();
        }
    }
}
