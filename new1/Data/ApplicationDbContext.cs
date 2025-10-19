using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using new1.Models;


namespace new1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Driver> Drivers => Set<Driver>();
        public DbSet<StudentSearch> StudentSearches => Set<StudentSearch>();
    }
}