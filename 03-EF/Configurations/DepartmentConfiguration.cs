﻿using _01_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EF.Configurations
{
    class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);

            builder.HasMany(D => D.Instructors)
                .WithOne(I => I.WorkDepartment)
                .HasForeignKey(I => I.DepartmentId)
                .IsRequired(false);


        }
    }
}
