using FluentAssertions;
using Moq;
using SignUp.Application.Interfaces;
using SignUp.Application.UseCases;
using SignUp.Domain.Entities;
using System;
using Xunit;

namespace SingUp.Tests.UnitTests.Application
{
    public class SignUpUserTest
    {
        //var category = new Category("Nova Category");
        //var categoryRepositoryMock = new Mock<ICategoryWriteOnlyUseCase>();
        //var categoryAddUseCase = new AddCategoryUseCase(categoryRepositoryMock.Object);
        //categoryAddUseCase.Add(category);
        //    categoryRepositoryMock.Verify(x => x.Add(It.IsAny<Category>()));

        [Fact]
        public void RegisterUserSuccess()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 22, Occupation.Support, DateTime.UtcNow);

            var employeeMock = new Mock<ISignUpRepository>();

            var registerUserUseCase = new SignUpUser(employeeMock.Object);

            registerUserUseCase.Register(employee);

            employeeMock.Verify(x => x.Add(It.IsAny<Employee>()));

        }

        [Fact]
        public void CannotRegisterUserUnderAge()
        {
            var employee = new Employee(Guid.NewGuid(), "EmployeeOne", 17, Occupation.Support, DateTime.UtcNow);

            var employeeMock = new Mock<ISignUpRepository>();

            var registerUserUseCase = new SignUpUser(employeeMock.Object);

            registerUserUseCase.Register(employee);

            registerUserUseCase.Should().BeOfType<InvalidOperationException>();

        }
    }
}
