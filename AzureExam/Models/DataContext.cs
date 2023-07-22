using Microsoft.EntityFrameworkCore;

namespace DMAWS_T2203E_PhamDuyHung.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring the Employee entity with no primary key
            modelBuilder.Entity<ProjectEmployee>().HasNoKey();
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }


    }
}
