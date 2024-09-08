using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Database.Configurations
{
    public class MarkConfiguration : IEntityTypeConfiguration<Mark>
    {
        public void Configure(EntityTypeBuilder<Mark> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Result)
                .IsRequired();

            builder.Property(t => t.StudentId)
                .IsRequired();

            builder.Property(t => t.DisciplineId)
                .IsRequired();

            builder.HasCheckConstraint("CK_Marks_Result", "\"Result\" IN (5, 4, 3, 2)");

            builder.HasOne(m => m.Student)
                .WithMany(s => s.Marks)
                .HasForeignKey(m => m.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.Disciplince)
                .WithMany(d => d.Marks)
                .HasForeignKey(m => m.DisciplineId);
        }
    }
}
