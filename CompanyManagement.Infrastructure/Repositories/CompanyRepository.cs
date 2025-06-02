using CompanyManagement.Domain.Entities;
using CompanyManagement.Domain.Interfaces;
using CompanyManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.Infrastructure.Repositories;

public class CompanyRepository(AppDbContext context) : ICompanyRepository
{
    public Task<List<Company>> GetAllAsync() => context.Companies.ToListAsync();
    public Task<Company?> GetByIdAsync(Guid id) => context.Companies.FindAsync(id).AsTask();
    public Task AddAsync(Company company) => context.Companies.AddAsync(company).AsTask();
    public void Update(Company company) => context.Companies.Update(company);
    public void Delete(Company company) => context.Companies.Remove(company);
}
