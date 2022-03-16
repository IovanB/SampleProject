using FluentAssertions;
using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;
using System;
using Xunit;
using Xunit.Frameworks.Autofac;

namespace SingUp.Tests.IntegrationTest.Infrastructure
{
    [UseAutofacTestFramework]
    public class SignUpRepositoryTest
    {
        private readonly ISignUpRepository signUpRepository;

        public SignUpRepositoryTest(ISignUpRepository signUpRepository)
        {
            this.signUpRepository = signUpRepository;
            Utils.CleanDatabase();
        }

        [Fact]
        public void ShouldAddUser()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 18, Occupation.Support, DateTime.UtcNow, "");

            Action act = () => signUpRepository.Add(employee);

            act.Should().NotThrow();
        }

        [Fact]
        public void ShouldGetAllUsers()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 18, Occupation.Support, DateTime.UtcNow, "test@teste.com");

            var employee2 = new Employee(Guid.NewGuid(), "EmployeeTwo", 18, Occupation.Support, DateTime.UtcNow, "test2@teste.com");

            signUpRepository.Add(employee);
            signUpRepository.Add(employee2);

            var result = signUpRepository.GetAll();

            result.Should().HaveCountGreaterThan(1);
        }
    }
}
