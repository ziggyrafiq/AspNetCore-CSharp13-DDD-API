using CompanyManagement.Domain.Entities;

namespace CompanyManagement.Domain.Interfaces;

public interface ICompanyRepository
{
    Task<Company?> GetByIdAsync(Guid id);
    Task<List<Company>> GetAllAsync();
    Task AddAsync(Company company);
    void Update(Company company);
    void Delete(Company company);
}
