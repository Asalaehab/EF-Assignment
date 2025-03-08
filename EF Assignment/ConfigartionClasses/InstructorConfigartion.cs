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
    public class InstructorConfigartion : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(I => I.Ins_Id);
            builder.Property(I => I.Name)
                    .HasColumnName("Instructor Name")
                    .HasColumnType("varchar(50)");

            builder.Property(I => I.Salary)
                .HasColumnType("decimal(18,2)");

            builder.Property(I => I.Bouns)
                .IsRequired();


            builder.HasOne(I => I.InstructorDepartment)
                .WithMany(D=>D.Instructors)
                .HasForeignKey(I=>I.InstructorDepartmentId)
                .IsRequired();

        }
    }
}
