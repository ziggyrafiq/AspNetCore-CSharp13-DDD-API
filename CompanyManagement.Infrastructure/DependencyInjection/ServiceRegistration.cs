using CompanyManagement.Application.Services;
using CompanyManagement.Domain.Interfaces;
using CompanyManagement.Infrastructure.Data;
using CompanyManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyManagement.Infrastructure.DependencyInjection;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Default")));

        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<CompanyService>();

        return services;
    }
}