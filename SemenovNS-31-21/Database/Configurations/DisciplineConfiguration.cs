﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Disciplince>
    {
        private const string TableName = "disciplines";
        public void Configure(EntityTypeBuilder<Disciplince> builder)
        {
            builder.HasKey(d => d.Id)
                .HasName($"pk_{TableName}_id");

            builder.Property(d => d.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasComment("Идентификатор дисциплины");

            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name")
                .HasComment("Название дисциплины");

            builder.HasMany(d => d.Marks)
                .WithOne(m => m.Disciplince);

            builder.HasMany(d => d.Tests)
                .WithOne(t => t.Disciplince);
        }
    }
}
