using System.Collections.Generic;
using System.Reflection.Emit;
using EntityClasses;
using Microsoft.EntityFrameworkCore;

namespace HotelManagment.Application
{
    public class HotelDBContext : DbContext
    {
        public DbSet<BookingStatusHistory> BookingStatusHistories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAction> EmployeeActions { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingPayment> BookingPayments { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RoomStatus> RoomStatuses { get; set; }
        public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<StayHistory> StayHistories { get; set; }

        public HotelDBContext(DbContextOptions<HotelDBContext> options) : base(options)
        {
        }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API relationships
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Guest)
                .WithMany()
                .HasForeignKey(b => b.GuestId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Room)
                .WithMany()
                .HasForeignKey(b => b.RoomId);

            modelBuilder.Entity<Room>()
                .HasOne(r => r.Category)
                .WithMany()
                .HasForeignKey(r => r.CategoryId);
        }
    }
}
