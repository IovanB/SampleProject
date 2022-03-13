
using Autofac;
using Moq;
using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SingUp.Tests.Fixed
{
    public class Fixture
    {
        public IContainer Container{ get; set; }
        
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

            Container = builder.Build();
        }
        

    }
}
