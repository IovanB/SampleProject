using Autofac;
using FluentAssertions;
using Moq;
using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Frameworks.Autofac;

namespace SingUp.Tests.IntegrationTest.Infrastructure
{
    public class Fixture
    {
        public IContainer Container { get; set; }

        public Fixture()
        {
            var builder = new ContainerBuilder();

            var signUpUseCase = new Mock<ISignUpUser>();
            var signUpRepository = new Mock<ISignUpRepository>();

            signUpRepository.Setup(x => x.Add(It.IsAny<Employee>())).Returns(true);
            signUpRepository.Setup(x => x.Remove(It.IsAny<Employee>())).Returns(true);
            signUpRepository.Setup(x => x.GetAll()).Returns(new List<Employee>() {
                new Employee(Guid.NewGuid(), "Employee", 19, Occupation.Developer, DateTime.UtcNow),
                new Employee(Guid.NewGuid(), "Employee One", 29, Occupation.Support, DateTime.UtcNow),
                new Employee(Guid.NewGuid(), "Employee Two", 24, Occupation.Student, DateTime.UtcNow),
                new Employee(Guid.NewGuid(), "Employee Three", 45, Occupation.Manager, DateTime.UtcNow),
            });

            builder.RegisterInstance(signUpRepository.Object).As<ISignUpRepository>();
            builder.RegisterInstance(signUpUseCase.Object).As<ISignUpUser>();

            Container = builder.Build();
        }
    }

    [UseAutofacTestFramework]
    public class SignUpRepositoryTest : IClassFixture<Fixture>
    {
        //private readonly ISignUpRepository signUpRepository;
        private ISignUpRepository repositories;


        public SignUpRepositoryTest(Fixture fixture)
        {
            repositories = fixture.Container.Resolve<ISignUpRepository>();
        }

        public Fixture Fixture { get; }

        [Theory]
        [InlineData(true)]
        public void AddUserSuccess(bool expectedResult)
        {

            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);
            var response = repositories.Add(employee);

            response.Should().Be(expectedResult);

        }

        [Fact]
        public void GetAllUserSuccess()
        {
            var response = repositories.GetAll();

            response.Should().HaveCountGreaterThan(1);
        }

        [Fact]
        public void RemoveUserSuccess()
        {

            //Adding user

            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);

            var addedUser = repositories.Add(employee);

            addedUser.Should().BeTrue();

            //Removing User

            var response = repositories.Remove(employee);

            response.Should().BeTrue();

        }

        //private Employee GetEmployee()
        //{
        //    return new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);
        //}

        //private List<Employee> GetEmployeeList()
        //{
        //    return new List<Employee>() {
        //        new Employee(Guid.NewGuid(), "Employee", 19, Occupation.Developer, DateTime.UtcNow),
        //        new Employee(Guid.NewGuid(), "Employee One", 29, Occupation.Support, DateTime.UtcNow),
        //        new Employee(Guid.NewGuid(), "Employee Two", 24, Occupation.Student, DateTime.UtcNow),
        //        new Employee(Guid.NewGuid(), "Employee Three", 45, Occupation.Manager, DateTime.UtcNow),
        //    };
        //}

        private void AddEmployee()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);
            repositories.Add(employee);
        }
    }
}
