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
    public class CourseConfigration : IEntityTypeConfiguration<Course>
    {
        void IEntityTypeConfiguration<Course>.Configure(EntityTypeBuilder<Course> builder)
        {
           
            builder.HasKey(C => C.crs_Id);
            builder.Property(C => C.Name)
                    .HasColumnName("Course Name")
                    .HasColumnType("varchar(100)");


            builder.HasOne(C => C.courseTopic)
                 .WithMany(T => T.Courses)
                 .HasForeignKey(C => C.courseTopicId)
                 .IsRequired();

        }
    }
}
