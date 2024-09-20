using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        private const string TableName = "cd_disciplines";
        public void Configure(EntityTypeBuilder<Discipline> builder)
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

            builder.ToTable(TableName)
                .HasMany(d => d.Marks)
                .WithOne(m => m.Discipline);

            builder.ToTable(TableName)
                .HasMany(d => d.Tests)
                .WithOne(t => t.Discipline);
        }
    }
}
