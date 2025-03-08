using EF_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.ConfigartionClasses
{
    public class TopicConfigration : IEntityTypeConfiguration<Topic>
    {
        void IEntityTypeConfiguration<Topic>.Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(T => T.TopicId);
            builder.Property(T => T.TopicName)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("Topic Name");
        }
    }
}
