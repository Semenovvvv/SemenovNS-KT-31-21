using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemenovNS_31_21.Database.Helpers;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Database.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        private const string TableName = "cd_students";

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id)
                .HasName($"pk_{TableName}_id");

            builder.Property(s => s.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasComment("Идентификатор студента");

            builder.Property(s => s.Surname)
                .IsRequired()
                .HasColumnType(ColumnType.String)
                .HasMaxLength(50)
                .HasColumnName("c_surname")
                .HasComment("Фамилия");

            builder.Property(s => s.Name)
                .IsRequired()
                .HasColumnType(ColumnType.String)
                .HasMaxLength(50)
                .HasColumnName("c_name")
                .HasComment("Имя");

            builder.Property(s => s.Patronymic)
                .IsRequired()
                .HasColumnType(ColumnType.String)
                .HasMaxLength(50)
                .HasColumnName("c_patronymic")
                .HasComment("Отчество");

            builder.Property(s => s.GroupId)
                .IsRequired()
                .HasColumnName("f_group_id")
                .HasComment("Идентификатор группы");

            builder.ToTable(TableName)
                .HasOne(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupId)
                .HasConstraintName("fk_group_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(s => s.GroupId, $"idx_{TableName}_fk_group_id");

            builder.Navigation(s => s.Marks)
                .AutoInclude();

            builder.Navigation(s => s.Tests)
                .AutoInclude();

            builder.Navigation(s => s.Group)
                .AutoInclude();
        }
    }
}
