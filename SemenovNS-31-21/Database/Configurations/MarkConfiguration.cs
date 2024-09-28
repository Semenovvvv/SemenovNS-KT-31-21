using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SemenovNS_31_21.Database.Helpers;
using SemenovNS_31_21.Models;
using System.Drawing;

namespace SemenovNS_31_21.Database.Configurations
{
    public class MarkConfiguration : IEntityTypeConfiguration<Mark>
    {
        private const string TableName = "cd_marks";
        public void Configure(EntityTypeBuilder<Mark> builder)
        {
            builder.HasKey(m => m.Id)
                .HasName($"pk_{TableName}_id");

            builder.Property(m => m.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasComment("Идентфикатор оценки");

            builder.Property(t => t.Result)
                .IsRequired()
                .HasColumnType(ColumnType.Short)
                .HasColumnName("n_result")
                .HasComment("Оценка");

            builder.Property(t => t.StudentId)
                .IsRequired()
                .HasColumnName("f_student_id")
                .HasComment("Идентификатор студента");

            builder.Property(t => t.DisciplineId)
                .IsRequired()
                .HasColumnName("f_discipline_id")
                .HasComment("Идентификатор дисциплины");

            builder.ToTable(TableName)
                .HasOne(m => m.Student)
                .WithMany(s => s.Marks)
                .HasForeignKey(m => m.StudentId)
                .HasConstraintName("fk_student_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(m => m.StudentId, $"idx_{TableName}_fk_student_id");

            builder.ToTable(TableName)
                .HasOne(m => m.Discipline)
                .WithMany(d => d.Marks)
                .HasForeignKey(m => m.DisciplineId)
                .HasConstraintName("fk_discipline_id");

            builder.ToTable(TableName)
                .HasIndex(m => m.DisciplineId, $"idx_{TableName}_fk_discipline_id");

            builder.ToTable(TableName)
                .HasCheckConstraint("ck_marks_result", "\"result\" IN (5, 4, 3, 2)");

            builder.Navigation(t => t.Student)
                .AutoInclude();

            builder.Navigation(t => t.Discipline)
                .AutoInclude();
        }
    }
}
