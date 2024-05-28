using Xunit;
using NetArchTest.Rules;
using System.Linq;
using System.Reflection;
using ForeningsPortalen.Application.Repositories;

namespace ForeningsPortalen.Domain.Test.ArchitectureTest
{
    public class ArchitectureTest
    {
        private const string DomainNamespace = "ForeningsPortalen.Domain";
        private const string ApplicationNamespace = "ForeningsPortalen.Application";
        private const string InfrastructureNamespace = "ForeningsPortalen.Infrastructure";
        private const string ApiNamespace = "ForeningsPortalen.Api";
        private const string MigrationNamespace = "ForeningsPortalen.DatabaseMigration";
        private const string TestNamespace = "ForeningsPortalen.Domain.Test";
        private const string WebNamespace = "ForeningsPortalen.Website";

        [Fact]
        public void Application_Should_Have_Dependency_On_Domain()
        {
            // Arrange
            var assembly = typeof(Application.Features.Addresses.Commands.Implementations.AddressCommands).Assembly;
            var otherProjects = new[]
            {
                InfrastructureNamespace,
                ApiNamespace,
                MigrationNamespace,
                TestNamespace,
                WebNamespace
            };

            // Act
            var result = Types.InAssembly(assembly)
                              .ShouldNot()
                              .HaveDependencyOnAny(otherProjects)
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
                ApiNamespace,
                MigrationNamespace,
                TestNamespace,
                WebNamespace
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
        public void Infrastructure_Should_OnlyHave_Dependency_On_Application_Domain()
        {
            // Arrange
            var assembly = typeof(Infrastructure.Repositories.AddressRepository).Assembly;
            var otherProjects = new[]
            {
                ApiNamespace,
                MigrationNamespace,
                TestNamespace,
                WebNamespace
            };

            // Act
            var result = Types.InAssembly(assembly)
                              .ShouldNot()
                              .HaveDependencyOnAny(otherProjects)
                              .GetResult();

            // Assert
            Assert.True(result.IsSuccessful, "TheInfrastructure layer should have a dependency on the Domain and Application layer.");
        }

        [Fact]
        public void Api_Should_OnlyHave_Dependency_On_Application_Domain_Infrastructure()
        {
            // Arrange
            var assembly = typeof(Api.Controllers.AddressController).Assembly;
            var otherProjects = new[]
            {
                MigrationNamespace,
                TestNamespace,
                WebNamespace
            };

            // Act
            var result = Types.InAssembly(assembly)
                              .ShouldNot()
                              .HaveDependencyOnAny(otherProjects)
                              .GetResult();

            //Assert
            Assert.True(result.IsSuccessful, "The Api layer should have a dependency on the Domain, Application and Infrastructure layer.");

        }

        [Fact]
        public void DomainEntities_Should_Have_Protected_Empty_Constructor()
        {
            // Get all types in the specified namespace
            var entityTypes = Types.InAssembly(Assembly.GetAssembly(typeof(Domain.Entities.Address)))
                                   .That()
                                   .ResideInNamespace(DomainNamespace + ".Entities")
                                   .GetTypes();

            foreach (var type in entityTypes)
            {
                var constructors = type.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
                var hasProtectedParameterlessConstructor = constructors.Any(c => c.IsFamily && c.GetParameters().Length == 0);

                Assert.True(hasProtectedParameterlessConstructor, $"Type {type.FullName} does not have a protected parameterless constructor.");
            }

        }
        [Fact]
        public void Repositories_Should_Have_NameEndingWith_Repository()
        {
            //Arrange

            var assembly = typeof(Infrastructure.Repositories.AddressRepository).Assembly;

            //Act
            var result = Types.InAssembly(assembly)
                .That()
                .ImplementInterface(typeof(IAddressRepository))
                .Should()
                .HaveNameEndingWith("repository")
                .GetResult();

            //Assert
            Assert.True(result.IsSuccessful);
        }
    }
}



