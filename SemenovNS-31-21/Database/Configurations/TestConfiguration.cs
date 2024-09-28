using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SemenovNS_31_21.Database.Helpers;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Database.Configurations
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        private const string TableName = "cd_tests";
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(t => t.Id)
                .HasName($"pk_{TableName}_id");

            builder.Property(t => t.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasComment("Идентификатор зачета");

            builder.Property(t => t.Result)
                .IsRequired()
                .HasColumnType(ColumnType.String)
                .HasColumnName("c_result")
                .HasComment("Результат");

            builder.Property(t => t.StudentId)
                .IsRequired()
                .HasColumnName("f_student_id")
                .HasComment("Идентификатор студента");

            builder.Property(t => t.DisciplineId)
                .IsRequired()
                .HasColumnName("f_discipline_id")
                .HasComment("Идентификатор дисциплины");

            builder.HasCheckConstraint("ck_tests_result", "\"result\" IN ('Зачет', 'Незачет')");

            builder.ToTable(TableName)
                .HasOne(t => t.Student)
                .WithMany(s => s.Tests)
                .HasForeignKey(t => t.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasOne(t => t.Discipline)
                .WithMany(s => s.Tests)
                .HasForeignKey(t => t.DisciplineId);

            builder.Navigation(t => t.Student)
                .AutoInclude();

            builder.Navigation(t => t.Discipline)
                .AutoInclude();
        }
    }
}
