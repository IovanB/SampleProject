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
    [UseAutofacTestFramework]
    public class SignUpUserTest
    {
        private readonly ISignUpUser signUpUser;

        public SignUpUserTest(ISignUpUser signUpUser)
        {
            this.signUpUser = signUpUser;
            Utils.CleanDatabase();
        }

        [Fact]
        [Trait("UseCase", "SignUpUser")]
        public void RegisterUserSuccess()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 18, Occupation.Support, DateTime.UtcNow, String.Empty);
            var response = signUpUser.Register(employee);

            response.Should().Contain("User Added");

        }

        [Fact]
        [Trait("UseCase", "SignUpUser")]
        public void CannotRegisterUserUnderAge()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 16, Occupation.Developer, DateTime.UtcNow, "");
            var response = signUpUser.Register(employee);

            response.Should().Contain("Employee should not be under 18");
        }
    }
}
