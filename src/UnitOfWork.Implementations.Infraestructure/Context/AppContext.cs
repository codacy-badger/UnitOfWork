using Microsoft.EntityFrameworkCore;

namespace UnitOfWork.Implementations.Infraestructure.Context
{
    public class ApplicationDatabaseContext : DbContext
    {

        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
