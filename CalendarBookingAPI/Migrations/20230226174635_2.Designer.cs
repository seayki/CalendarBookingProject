// <auto-generated />
using System;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalendarBooking.API.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230226174635_2")]
    partial class _2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStop")
                        .HasColumnType("datetime2");

                    b.Property<int>("TimeslotId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("TimeslotId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Timeslot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalendarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SessionLength")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStop")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Timeslots");
                });

            modelBuilder.Entity("CalendarTeacher", b =>
                {
                    b.Property<int>("CalendarsId")
                        .HasColumnType("int");

                    b.Property<int>("TeachersId")
                        .HasColumnType("int");

                    b.HasKey("CalendarsId", "TeachersId");

                    b.HasIndex("TeachersId");

                    b.ToTable("CalendarTeacher");
                });

            modelBuilder.Entity("GroupStudent", b =>
                {
                    b.Property<int>("GroupsId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("GroupsId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("GroupStudent");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Booking", b =>
                {
                    b.HasOne("CalendarBooking.DomainLayer.Entities.Student", "Student")
                        .WithMany("Bookings")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalendarBooking.DomainLayer.Entities.Teacher", "Teacher")
                        .WithMany("Bookings")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalendarBooking.DomainLayer.Entities.Timeslot", "Timeslot")
                        .WithMany("Bookings")
                        .HasForeignKey("TimeslotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");

                    b.Navigation("Timeslot");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Calendar", b =>
                {
                    b.HasOne("CalendarBooking.DomainLayer.Entities.Group", "Group")
                        .WithMany("Calendars")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Timeslot", b =>
                {
                    b.HasOne("CalendarBooking.DomainLayer.Entities.Calendar", "Calendar")
                        .WithMany("Timeslots")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalendarBooking.DomainLayer.Entities.Teacher", "Teacher")
                        .WithMany("Timeslots")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calendar");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("CalendarTeacher", b =>
                {
                    b.HasOne("CalendarBooking.DomainLayer.Entities.Calendar", null)
                        .WithMany()
                        .HasForeignKey("CalendarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalendarBooking.DomainLayer.Entities.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroupStudent", b =>
                {
                    b.HasOne("CalendarBooking.DomainLayer.Entities.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalendarBooking.DomainLayer.Entities.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Calendar", b =>
                {
                    b.Navigation("Timeslots");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Group", b =>
                {
                    b.Navigation("Calendars");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Student", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Teacher", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Timeslots");
                });

            modelBuilder.Entity("CalendarBooking.DomainLayer.Entities.Timeslot", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
