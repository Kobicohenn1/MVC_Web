using Microsoft.EntityFrameworkCore;
using Travel_Agency_MVC.Models;

namespace Travel_Agency_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Here starts the model part , at the moment there are no models available so this line is in comment
        //public DbSet<>

        public DbSet<Flight> Flights { get; set; }
    }
}
