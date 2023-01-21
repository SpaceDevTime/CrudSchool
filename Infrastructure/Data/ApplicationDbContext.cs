using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    // DB Context for database context generator
    // this class is used to generate the database context
    // and the database context is used to generate the database
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            // Base options for database configuration or connection string
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
