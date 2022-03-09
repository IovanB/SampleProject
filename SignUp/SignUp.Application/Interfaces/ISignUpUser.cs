using SignUp.Domain.Entities;

namespace SignUp.Application.Interfaces
{
    public interface ISignUpUser
    {
        void Register(Employee employee);
    }
}
