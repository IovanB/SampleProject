using Autofac;
using FluentAssertions;
using Moq;
using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Frameworks.Autofac;

namespace SingUp.Tests.IntegrationTest.ExampleOne.Infrastructure
{
  

    [UseAutofacTestFramework]
    public class SignUpRepositoryTest 
    {
        //    //private readonly ISignUpRepository signUpRepository;
        //    private ISignUpRepository repositories;


        //    public SignUpRepositoryTest(Fixture fixture)
        //    {
        //        repositories = fixture.Container.Resolve<ISignUpRepository>();
        //    }

        //    public Fixture Fixture { get; }

        //    [Theory]
        //    [InlineData(true)]
        //    public void AddUserSuccess(bool expectedResult)
        //    {

        //        var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);
        //        var response = repositories.Add(employee);

        //        response.Should().Be(expectedResult);

        //    }

        //    [Fact]
        //    public void GetAllUserSuccess()
        //    {
        //        var response = repositories.GetAll();

        //        response.Should().HaveCountGreaterThan(1);
        //    }

        //    [Fact]
        //    public void RemoveUserSuccess()
        //    {

        //        //Adding user

        //        var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);

        //        var addedUser = repositories.Add(employee);

        //        addedUser.Should().BeTrue();

        //        //Removing User

        //        var response = repositories.Remove(employee);

        //        response.Should().BeTrue();

        //    }

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

        //private void AddEmployee()
        //{
        //    var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);
        //    repositories.Add(employee);
        //}
    }
}
