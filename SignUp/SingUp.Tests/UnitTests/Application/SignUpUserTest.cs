using Autofac;
using FluentAssertions;
using Moq;
using SignUp.Application.UseCases;
using SignUp.Application.UseCases.SignUpUser.SignUpUsers;
using SignUp.Domain.Entities;
using System;
using Xunit;
using Xunit.Frameworks.Autofac;

namespace SingUp.Tests.UnitTests.Application
{
    //public class Fixture
    //{
    //    public IContainer Container { get; set; }

    //    public Fixture()
    //    {
    //        var builder = new ContainerBuilder();

    //        var signUpUseCase = new Mock<ISignUpUser>();
    //        builder.RegisterInstance(signUpUseCase).As<Mock<ISignUpUser>>();

    //        Container = builder.Build();
    //    }
    //}

    [UseAutofacTestFramework]
    public class SignUpUserTest
    {
        private readonly ISignUpUser signUpUser;

        public SignUpUserTest(ISignUpUser signUpUser)
        {
            this.signUpUser = signUpUser;
        }

        [Fact]
        [Trait("UseCase", "SignUpUser")]
        public void RegisterUserSuccess()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 18, Occupation.Support, DateTime.UtcNow, "");
            var response = signUpUser.Register(employee);

            response.Should().Contain("User Added");

        }

        [Fact]
        [Trait("UseCase", "SignUpUser")]
        public void CannotRegisterUserUnderAge()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 16, Occupation.Developer, DateTime.UtcNow, "");
            var response = signUpUser.Register(employee);

            response.Should().Contain("Not allowed");
        }
    }
}
