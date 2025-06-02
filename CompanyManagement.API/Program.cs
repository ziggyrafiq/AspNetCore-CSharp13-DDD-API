using CompanyManagement.API.Configurations;
using CompanyManagement.API.Endpoints;
using CompanyManagement.API.Middleware;
using CompanyManagement.Infrastructure.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerDocumentation();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerDocumentation();
builder.Services.AddInfrastructure(builder.Configuration);

   
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapCompanyEndpoints();

app.UseHttpsRedirection();
