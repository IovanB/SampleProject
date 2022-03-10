using FluentAssertions;
using SignUp.Domain.Entities;
using System;
using Xunit;

namespace SingUp.Tests.UnitTests.Domain
{
    public class EmployeeTest
    {

        [Fact]
        public void IsEmployeeValid()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 22, Occupation.Support, DateTime.UtcNow);

            Assert.True(employee.IsValid);
            employee.IsValid.Should().BeTrue();
        }

        [Theory]
        [InlineData("Employee One",12)]
        [InlineData("Employee Two", 14)]
        [InlineData("Employee Three", 17)]
        public void EmployeeCannotBeUnderAge(string name, int age)
        {
            var employee = new Employee(Guid.NewGuid(), name, age, Occupation.Support, DateTime.UtcNow);

            Assert.False(employee.IsValid);
        }

        [Theory]
        [InlineData(Occupation.Support)]
        [InlineData(Occupation.Student)]
        [InlineData(Occupation.Manager)]
        public void EmployeeIsNotDeveloper(Occupation occupation)
        {
            var employee = new Employee(Guid.NewGuid(), "Employee", 19, occupation, DateTime.UtcNow);

            employee.Occupation.Should().NotBe(Occupation.Developer);
        }

        [Fact]
        public void EntryDateCannotBeNull()
        {
            var employee = new Employee(Guid.NewGuid(), "Employee One", 19, Occupation.Support, null);

            employee.IsValid.Should().BeFalse();


        }


    }
}
