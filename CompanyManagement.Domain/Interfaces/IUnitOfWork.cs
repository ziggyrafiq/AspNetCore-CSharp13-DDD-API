namespace CompanyManagement.Domain.Interfaces;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
