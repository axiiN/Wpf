using System.Globalization;
using CsvHelper;
using CsvToDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Task3Database.Models;

namespace CsvToDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.Migrate();
            }

            var filePath = "\"C:\\Users\\dfn34\\OneDrive\\Asztali gép\\wpf1\\WpfDolgozat\\8.csv\"";

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<People>().ToList();

                using (var context = new AppDbContext())
                {
                    context.People.AddRange(records);
                    context.SaveChanges();
                }
            }
        }
    }
}
