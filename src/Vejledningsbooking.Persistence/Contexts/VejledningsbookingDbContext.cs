using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Domain.Contexts;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Persistence.Contexts
{
    public class VejledningsbookingDbContext : DbContext, IVejledningsbookingDbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingWindow> BookingWindows { get; set; }
        public DbSet<Calender> Calenders { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbContext Context => this;

        public VejledningsbookingDbContext(DbContextOptions<VejledningsbookingDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Student)
                .WithMany(p => p.Bookings)
                .HasForeignKey(k => k.StudentId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.BookingWindow)
                .WithMany(p => p.Bookings)
                .HasForeignKey(k => k.BookingWindowId);

            modelBuilder.Entity<BookingWindow>()
                .HasOne(p => p.Calender)
                .WithMany(p => p.BookingWindows)
                .HasForeignKey(k => k.CalenderId);

            modelBuilder.Entity<BookingWindow>()
                .HasMany(p => p.Bookings)
                .WithOne(p => p.BookingWindow);

            modelBuilder.Entity<Calender>()
                .HasMany(p => p.BookingWindows)
                .WithOne(p => p.Calender);

            modelBuilder.Entity<Calender>()
                .HasOne(p => p.Class)
                .WithOne(p => p.Calender)
                .HasForeignKey<Calender>(p => p.ClassId);

            modelBuilder.Entity<Class>()
                .HasOne(p => p.Calender)
                .WithOne(p => p.Class);

            modelBuilder.Entity<Class>()
                .HasMany(p => p.Teachers)
                .WithMany(p => p.Classes);

            modelBuilder.Entity<Class>()
                .HasMany(p => p.Students)
                .WithMany(p => p.Classes);
        }
    }
}
