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
    public class StudentConfigration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(S => S.stud_Id);

            builder
                .Property(S => S.FName)
                .HasColumnName("First Name")
                .HasColumnType("varchar(50)")
                .IsRequired(true);

            builder
                 .Property(S => S.LName)
                .HasColumnType("Last Name")
                .HasColumnType("varchar(50)")
                .IsRequired(true);

            builder
                .Property(S => S.Address)
                .HasColumnType("varchar(500)")
                .HasColumnName(" Student Address");

            builder
                .Property(S => S.Age)
                .HasColumnName("Student Age");


            //Relations


            builder.HasOne(S => S.StudentDepartment)
                .WithMany(D => D.Students)
                .HasForeignKey(S => S.StudentDepartmentId)
                .IsRequired();



        }
    }
}
