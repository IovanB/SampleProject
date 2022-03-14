using Autofac;
using FluentAssertions;
using Moq;
using SignUp.Application.Interfaces;
using SignUp.Application.UseCases.GetEmail;
using SignUp.Domain.Entities;
using System;
using Xunit;
using Xunit.Frameworks.Autofac;

namespace SingUp.Tests.IntegrationTest.Service
{
    public class Fixture
    {
        public IContainer Container { get; set; }

        public Fixture()
        {
            var builder = new ContainerBuilder();

            var getEmail = new Mock<IGetEmployeeEmail>();


            getEmail.Setup(x => x.GetEmail(It.IsAny<Guid>())).Returns("emplone@unittest.com");

            builder.RegisterInstance(getEmail.Object).As<IGetEmployeeEmail>();

            Container = builder.Build();
        }
    }

    [UseAutofacTestFramework]
    public class GetEmployeeEmailTest : IClassFixture<Fixture>
    {
        private readonly Fixture fixture;
        private readonly IGetEmailUseCase getEmailUseCase;

        public GetEmployeeEmailTest(Fixture fixture, IGetEmailUseCase getEmailUseCase)
        {
            this.fixture = fixture;
            this.getEmailUseCase = getEmailUseCase;
        }


        [Fact]
        public void GetEmailCorrectly()
        {

            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 22, Occupation.Support, DateTime.UtcNow, "");
            
            var result = getEmailUseCase.GetEmail(employee);

            result.Should().Equals("emplone@unittest.com");

        }
    }
}
