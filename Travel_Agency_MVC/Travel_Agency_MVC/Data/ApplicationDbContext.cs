using Microsoft.EntityFrameworkCore;

namespace Travel_Agency_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Here starts the model part , at the moment there are no models available so this line is in comment
        //public DbSet<>
    }
}
