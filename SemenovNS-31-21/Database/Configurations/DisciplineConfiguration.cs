using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Disciplince>
    {
        public void Configure(EntityTypeBuilder<Disciplince> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                .ValueGeneratedOnAdd();

            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(d => d.Marks)
                .WithOne(m => m.Disciplince);

            builder.HasMany(d => d.Tests)
                .WithOne(t => t.Disciplince);
        }
    }
}
