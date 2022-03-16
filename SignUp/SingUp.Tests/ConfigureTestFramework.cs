using Autofac;
using SignUp.Application.Interfaces;
using SignUp.Application.UseCases.GetEmail;
using SignUp.Application.UseCases.SignUpUser.SignUpUsers;
using SignUp.Application.UseCases.SignUpUsers;
using SignUp.Infrastructure;
using SignUp.Infrastructure.Repository;
using SignUp.Infrastructure.Service;
using Xunit;
using Xunit.Abstractions;
using Xunit.Frameworks.Autofac;

[assembly: TestFramework("SingUp.Tests.ConfigureTestFramework", "SingUp.Tests")]
namespace SingUp.Tests
{
    public class ConfigureTestFramework : AutofacTestFramework
    {

        public ConfigureTestFramework(IMessageSink diagnosticMessageSink)
        : base(diagnosticMessageSink)
        {

        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<SignUpRepository>().As<ISignUpRepository>().AsImplementedInterfaces().AsSelf();
            builder.RegisterType<SignUpUser>().As<ISignUpUser>().AsImplementedInterfaces().AsSelf();
            builder.RegisterType<GetEmployeeEmail>().As<IGetEmployeeEmail>().AsImplementedInterfaces().AsSelf();
            builder.RegisterType<GetEmailUseCase>().As<IGetEmailUseCase>().AsImplementedInterfaces().AsSelf();

            Context context = new Context();
        }
    }
}
