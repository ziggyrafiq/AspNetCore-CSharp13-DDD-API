using CompanyManagement.Application.DTOs;
using CompanyManagement.Domain.Entities;
using CompanyManagement.Domain.Interfaces;

namespace CompanyManagement.Application.Services;

public class CompanyService(ICompanyRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<Guid> CreateAsync(CreateCompanyDto dto)
    {
        var company = new Company(dto.Name, dto.EstablishedOn);
        await repository.AddAsync(company);
        await unitOfWork.SaveChangesAsync();
        return company.Id;
    }

    public async Task<List<Company>> GetAllAsync() => await repository.GetAllAsync();
}
