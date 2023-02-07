using CalendarBooking.DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalendarBooking.InfrastructureLayer.Data;


public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options ) : base(options)
    {
        
       
    }
    string cns = @"Data Source=mssql8.unoeuro.com; Database=seayki_dk_db_itbutik;User ID=seayki_dk;Password=zdt3pBehgnEm; encrypt=false";

    public DbSet<Student> Students { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Timeslot> Timeslots { get; set; }
    public DbSet<Calendar> Calendars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(cns);
    }

   
}
