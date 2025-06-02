using CompanyManagement.Application.DTOs;
using CompanyManagement.Application.Services;

namespace CompanyManagement.API.Endpoints;

public static class CompanyEndpoints
{
    public static void MapCompanyEndpoints(this WebApplication app)
    {
        app.MapPost("/api/companies", async (CreateCompanyDto dto, CompanyService service) =>
        {
            var id = await service.CreateAsync(dto);
            return Results.Created($"/api/companies/{id}", new { id });
        });

        app.MapGet("/api/companies", async (CompanyService service) =>
        {
            var companies = await service.GetAllAsync();
            return Results.Ok(companies);
        });

        app.MapGet("/api/companies/{id:guid}", async (Guid id, CompanyService service) =>
        {
            var companies = await service.GetAllAsync();
            var match = companies.FirstOrDefault(c => c.Id == id);
            return match is not null ? Results.Ok(match) : Results.NotFound();
        });
    }
}