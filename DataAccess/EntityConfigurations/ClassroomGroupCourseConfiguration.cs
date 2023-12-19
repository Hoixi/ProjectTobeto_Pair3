﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class ClassroomGroupCourseConfiguration : IEntityTypeConfiguration<ClassroomGroupCourse>
    {
        public void Configure(EntityTypeBuilder<ClassroomGroupCourse> builder)
        {
            builder.ToTable("ClassroomGroupCourses").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.ClassroomGroupId).HasColumnName("ClassroomGroupId");
            builder.Property(b => b.CourseId).HasColumnName("CourseId");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}