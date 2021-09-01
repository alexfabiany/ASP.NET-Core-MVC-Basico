using Microsoft.EntityFrameworkCore;
using Site01.Models;

namespace Site01.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Palavra> Palavras { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
