
using CompanyManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.Infrastructure.Data;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Company> Companies => Set<Company>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>().ToTable("Companies");
    }
}
