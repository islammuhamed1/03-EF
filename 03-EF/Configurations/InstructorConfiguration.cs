using _01_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EF.Configurations
{
    class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Salary).HasColumnType("decimal(18, 3)");
            builder.Property(I => I.Bouns).HasColumnType("decimal(18, 3)");
            builder.Property(I => I.HourRate).HasColumnType("decimal(18, 3)");

            builder.HasOne(I => I.ManageDepartment)
                .WithOne(D => D.Manager)
                .IsRequired(false)
                .HasForeignKey<Department>(D => D.ManagerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
