using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Database.Configurations
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Result)
                .IsRequired();

            builder.Property(t => t.StudentId)
                .IsRequired();

            builder.Property(t => t.DisciplineId)
                .IsRequired();

            builder.HasCheckConstraint("CK_Tests_Result", "\"Result\" IN ('Зачет', 'Незачет')");

            builder.HasOne(t => t.Student)
                .WithMany(s => s.Tests)
                .HasForeignKey(t => t.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Disciplince)
                .WithMany(s => s.Tests)
                .HasForeignKey(t => t.DisciplineId);
        }
    }
}
