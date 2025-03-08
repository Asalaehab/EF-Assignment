using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EF_Assignment.ConfigartionClasses;
using EF_Assignment.Models;
using Microsoft.EntityFrameworkCore;
namespace EF_Assignment.Dbcontexts
{
    class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=ITIDBAssignment;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Student>(new StudentConfigration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<StudentCourse>()
                .HasKey(SC => new { SC.StdId, SC.CrsId });//Compsoite pk

          
        }
        public DbSet<Student>students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}
