using CompanyManagement.Application.DTOs;
using CompanyManagement.Application.Services;
using CompanyManagement.Domain.Interfaces;
using Moq;

namespace CompanyManagement.Tests.Unit.Services;

public class CompanyServiceTests
{
    [Fact]
    public async Task CreateAsync_ShouldReturnNewId()
    {
        // Arrange
        var repoMock = new Mock<ICompanyRepository>();
        var uowMock = new Mock<IUnitOfWork>();

        var service = new CompanyService(repoMock.Object, uowMock.Object);
        var dto = new CreateCompanyDto("Ziggy Rafiq Test Co", DateTime.Now);

        // Act
        var result = await service.CreateAsync(dto);

        // Assert
        Assert.NotEqual(Guid.Empty, result);
    }
}