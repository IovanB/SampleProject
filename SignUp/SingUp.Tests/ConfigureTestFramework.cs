using Autofac;
using SignUp.Application.Interfaces;
using SignUp.Application.UseCases;
using SignUp.Infrastructure.Repository;
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


        //public ConfigureTestFramework()
        //{
        //    var builder = new ContainerBuilder();
           
        //    builder.RegisterInstance(new SignUpRepository()).As<ISignUpRepository>();
        //    //builder.RegisterInstance(new SignUpUser()).As<ISignUpUser>();
        //    //builder.RegisterServiceMiddleware<ISignUpUser, SignUpUser>();

        //    Container = builder.Build();
        //}


        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<SignUpRepository>().As<ISignUpRepository>().AsImplementedInterfaces().AsSelf();
            builder.RegisterType<SignUpUser>().As<ISignUpUser>().AsImplementedInterfaces().AsSelf();
        }
    }
}
