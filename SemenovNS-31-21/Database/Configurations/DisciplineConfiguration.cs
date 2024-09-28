using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemenovNS_31_21.Database.Helpers;
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

            builder.ToTable(TableName)
                .Property(d => d.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasComment("Идентификатор дисциплины");

            builder.ToTable(TableName)
                .Property(d => d.Name)
                .IsRequired()
                .HasColumnType(ColumnType.String)
                .HasMaxLength(50)
                .HasColumnName("c_name")
                .HasComment("Название дисциплины");
        }
    }
}
