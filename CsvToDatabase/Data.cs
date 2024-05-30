using Microsoft.EntityFrameworkCore;
using Task3Database.Models;

namespace CsvToDatabase.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<People> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YOUR_SERVER;Database=Peter;Trusted_Connection=True;");
        }
    }
}
