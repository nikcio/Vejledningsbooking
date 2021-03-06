// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vejledningsbooking.Persistence.Contexts;

namespace Vejledningsbooking.Persistence.Migrations
{
    [DbContext(typeof(VejledningsbookingDbContext))]
    [Migration("20210921072718_className-limit")]
    partial class classNamelimit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("ClassesId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("ClassStudent");
                });

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<int>("TeachersId")
                        .HasColumnType("int");

                    b.HasKey("ClassesId", "TeachersId");

                    b.HasIndex("TeachersId");

                    b.ToTable("ClassTeacher");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingWindowId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingWindowId");

                    b.HasIndex("StudentId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.BookingWindow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CalenderId");

                    b.ToTable("BookingWindows");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Calender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId")
                        .IsUnique();

                    b.ToTable("Calenders");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalenderId")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.HasOne("Vejledningsbooking.Domain.Entities.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vejledningsbooking.Domain.Entities.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.HasOne("Vejledningsbooking.Domain.Entities.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vejledningsbooking.Domain.Entities.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Booking", b =>
                {
                    b.HasOne("Vejledningsbooking.Domain.Entities.BookingWindow", "BookingWindow")
                        .WithMany("Bookings")
                        .HasForeignKey("BookingWindowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vejledningsbooking.Domain.Entities.Student", "Student")
                        .WithMany("Bookings")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingWindow");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.BookingWindow", b =>
                {
                    b.HasOne("Vejledningsbooking.Domain.Entities.Calender", "Calender")
                        .WithMany("BookingWindows")
                        .HasForeignKey("CalenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calender");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Calender", b =>
                {
                    b.HasOne("Vejledningsbooking.Domain.Entities.Class", "Class")
                        .WithOne("Calender")
                        .HasForeignKey("Vejledningsbooking.Domain.Entities.Calender", "ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.BookingWindow", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Calender", b =>
                {
                    b.Navigation("BookingWindows");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Class", b =>
                {
                    b.Navigation("Calender");
                });

            modelBuilder.Entity("Vejledningsbooking.Domain.Entities.Student", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
