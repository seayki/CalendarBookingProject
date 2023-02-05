using Microsoft.EntityFrameworkCore;

namespace CalendarBooking.API.Data
{

    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {


        }
        string cns = @"Data Source=mssql8.unoeuro.com; Database=seayki_dk_db_itbutik;User ID=seayki_dk;Password=zdt3pBehgnEm; encrypt=false";

        public DbSet<Student> Students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(cns);
        }
    }


}
