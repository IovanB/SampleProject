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
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 22, Occupation.Support, null);

            Assert.True(employee.IsValid);
        }

        [Theory]
        [InlineData("Employee One",12)]
        [InlineData("Employee Two", 14)]
        [InlineData("Employee Three", 17)]
        public void EmployeeCannotBeUnderAge(string name, int age)
        {
            var employee = new Employee(Guid.NewGuid(), name, age, Occupation.Support, null);

            Assert.False(employee.IsValid);
        }

        [Fact]
        public void GuidCannotBeInvalid()
        {
            var employee = new Employee(new Guid(), "Employee One", 19, Occupation.Support, null);

             
        }

    }
}
