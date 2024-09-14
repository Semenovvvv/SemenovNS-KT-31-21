using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        private const string TableName = "groups";
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id)
                .HasName($"pk_{TableName}_id");

            builder.Property(g => g.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasComment("Идентификатор группы");

            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name")
                .HasComment("Название группы");

            builder.HasMany(g => g.Students)
                .WithOne(s => s.Group);

            builder.Navigation(g => g.Students)
                .AutoInclude();
        }
    }
}
