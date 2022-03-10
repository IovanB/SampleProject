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
        }

        [Fact]
        public void AddUserSuccess()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);

            var response = signUpRepository.Add(employee);

            response.Should().BeTrue();


        }

        [Fact]
        public void GetAllUserSuccess()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);

            signUpRepository.Add(employee);

            var response = signUpRepository.GetAll();

            response.Should().HaveCount(1);

        }

        [Fact]
        public void RemoveUserSuccess()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);

            signUpRepository.Add(employee);

            var getAllUsers = signUpRepository.GetAll();

            getAllUsers.Should().HaveCount(1);

            var response = signUpRepository.Remove(employee);

            response.Should().BeTrue();

        }
    }
}
