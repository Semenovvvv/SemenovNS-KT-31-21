﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SemenovNS_31_21.Database;

#nullable disable

namespace SemenovNS_31_21.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SemenovNS_31_21.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентификатор дисциплины");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name")
                        .HasComment("Название дисциплины");

                    b.HasKey("Id")
                        .HasName("pk_disciplines_id");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентификатор группы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name")
                        .HasComment("Название группы");

                    b.HasKey("Id")
                        .HasName("pk_groups_id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентфикатор оценки");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DisciplineId")
                        .HasColumnType("integer")
                        .HasColumnName("discipline_id")
                        .HasComment("Идентификатор дисциплины");

                    b.Property<int>("Result")
                        .HasColumnType("integer")
                        .HasColumnName("result")
                        .HasComment("Оценка");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer")
                        .HasColumnName("student_id")
                        .HasComment("Идентификатор студента");

                    b.HasKey("Id")
                        .HasName("pk_marks_id");

                    b.HasIndex(new[] { "DisciplineId" }, "idx_marks_fk_discipline_id");

                    b.HasIndex(new[] { "StudentId" }, "idx_marks_fk_student_id");

                    b.ToTable("Marks", t =>
                        {
                            t.HasCheckConstraint("ck_marks_result", "\"result\" IN (5, 4, 3, 2)");
                        });
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентификатор студента");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age")
                        .HasComment("Возраст");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer")
                        .HasColumnName("group_id")
                        .HasComment("Идентификатор группы");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name")
                        .HasComment("Имя");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("patronymic")
                        .HasComment("Отчество");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("surname")
                        .HasComment("Фамилия");

                    b.HasKey("Id")
                        .HasName("pk_students_id");

                    b.HasIndex(new[] { "GroupId" }, "idx_students_fk_group_id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентификатор зачета");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DisciplineId")
                        .HasColumnType("integer")
                        .HasColumnName("discipline_id")
                        .HasComment("Идентификатор дисциплины");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("result")
                        .HasComment("Результат");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer")
                        .HasColumnName("student_id")
                        .HasComment("Идентификатор студента");

                    b.HasKey("Id")
                        .HasName("pk_tests_id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("StudentId");

                    b.ToTable("Tests", t =>
                        {
                            t.HasCheckConstraint("ck_tests_result", "\"result\" IN ('Зачет', 'Незачет')");
                        });
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Mark", b =>
                {
                    b.HasOne("SemenovNS_31_21.Models.Discipline", "Disciplince")
                        .WithMany("Marks")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discipline_id");

                    b.HasOne("SemenovNS_31_21.Models.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_student_id");

                    b.Navigation("Disciplince");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Student", b =>
                {
                    b.HasOne("SemenovNS_31_21.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_group_id");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Test", b =>
                {
                    b.HasOne("SemenovNS_31_21.Models.Discipline", "Disciplince")
                        .WithMany("Tests")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SemenovNS_31_21.Models.Student", "Student")
                        .WithMany("Tests")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplince");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Discipline", b =>
                {
                    b.Navigation("Marks");

                    b.Navigation("Tests");
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("SemenovNS_31_21.Models.Student", b =>
                {
                    b.Navigation("Marks");

                    b.Navigation("Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
