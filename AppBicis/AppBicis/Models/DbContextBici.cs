using Microsoft.EntityFrameworkCore;

namespace AppBicis.Models
{
    public class DbContextBici : DbContext
    {

        public DbContextBici(DbContextOptions<DbContextBici> options) : base(options)
        {
        }
        public DbSet<Bici> Bicis { get; set; }

    }//cierre class
}// cierre namespace
