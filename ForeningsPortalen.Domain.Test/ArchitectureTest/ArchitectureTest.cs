using Xunit;
using NetArchTest.Rules;
using System.Linq;

namespace ForeningsPortalen.Domain.Test.ArchitectureTest
{
    public class ArchitectureTest
    {
        private const string DomainNamespace = "ForeningsPortalen.Domain.Entities";
        private const string ApplicationNamespace = "ForeningsPortalen.Application.Features.Addresses.Commands.Implementations";
        private const string InfrastructureNamespace = "ForeningsPortalen.Infrastructure.Repositories";
        private const string ApiNamespace = "ForeningsPortalen.Api.Controllers";

        [Fact]
        public void Application_Should_Have_Dependency_On_Domain()
        {
            // Arrange
            var assembly = typeof(Application.Features.Addresses.Commands.Implementations.AddressCommands).Assembly;

            // Act
            var result = Types.InAssembly(assembly)
                              .That()
                              .ResideInNamespace(ApplicationNamespace)
                              .Should()
                              .HaveDependencyOn(DomainNamespace)
                              .GetResult();

            // Assert
            Assert.True(result.IsSuccessful, "The Application layer should have a dependency on the Domain layer.");
        }

        [Fact]
        public void Domain_Should_Not_HaveDependenciesOnOtherProjects()
        {
            // Arrange
            var assembly = typeof(Domain.Entities.Address).Assembly;
            var otherProjects = new[]
            {
                ApplicationNamespace,
                InfrastructureNamespace,
                ApiNamespace
            };

            // Act
            var result = Types.InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOnAny(otherProjects)
                .GetResult();

            // Assert
            Assert.True(result.IsSuccessful, "The Domain layer should not have dependencies on other projects");
        }

        [Fact]
        public void Infrastructure_Should_Have_Dependency_On_Application_Domain()
        {
            // Arrange
            var assembly = typeof(Infrastructure.Repositories.AddressRepository).Assembly;
            var otherProjects = new[]
            {
                DomainNamespace,
                ApplicationNamespace
            };

            // Act
            var result = Types.InAssembly(assembly)
                              .That()
                              .ResideInNamespace(InfrastructureNamespace)
                              .Should()
                              .HaveDependencyOnAny(otherProjects)
                              .GetResult();

            // Assert
            Assert.True(result.IsSuccessful, "The Application layer should have a dependency on the Domain layer.");
        }


       
    }


}
