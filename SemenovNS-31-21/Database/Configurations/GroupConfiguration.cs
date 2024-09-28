using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SemenovNS_31_21.Database.Helpers;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        private const string TableName = "cd_groups";
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id)
                .HasName($"pk_{TableName}_id");

            builder.ToTable(TableName)
                .Property(g => g.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasComment("Идентификатор группы");

            builder.ToTable(TableName)
                .Property(g => g.Name)
                .IsRequired()
                .HasColumnName("c_name")
                .HasColumnType(ColumnType.String)
                .HasMaxLength(50)
                .HasComment("Название группы");

            //builder.Navigation(g => g.Students)
            //    .AutoInclude();

            builder.ToTable(TableName)
                .HasIndex(g => g.Name)
                .IsUnique();
        }
    }
}
