using CompanyManagement.Domain.Interfaces;

namespace CompanyManagement.Infrastructure.Data;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public Task<int> SaveChangesAsync() => context.SaveChangesAsync();
}
