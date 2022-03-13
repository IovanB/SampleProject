using SignUp.Domain.Entities;

namespace SignUp.Application.Interfaces
{
    public interface ISignUpUser
    {
        string Register(Employee employee);
    }
}
