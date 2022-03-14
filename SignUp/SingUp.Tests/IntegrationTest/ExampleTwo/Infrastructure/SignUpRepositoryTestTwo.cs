using FluentAssertions;
using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;
using System;
using Xunit;

namespace SingUp.Tests.IntegrationTest.ExampleTwo.Infrastructure
{
    public class SignUpRepositoryTestTwo
    {
        private readonly ISignUpRepository signUpRepository;

        public SignUpRepositoryTestTwo(ISignUpRepository signUpRepository)
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

        }

        [Fact]
        public void ShouldRemoveUser()
        {

        }


      
    }
}
