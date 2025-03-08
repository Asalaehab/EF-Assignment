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
    class DepartmetConfigration : IEntityTypeConfiguration<Department>
    {
        void IEntityTypeConfiguration<Department>.Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.dept_Id);

            builder.Property(D => D.HiringDate)
                .HasDefaultValueSql("GETDATE()");

        }
    }
}
