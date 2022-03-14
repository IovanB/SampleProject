using SignUp.Domain.Entities;

namespace SignUp.Application.UseCases.SignUpUser.SignUpUsers
{
    public interface ISignUpUser
    {
        string Register(Employee employee);
        string GetEmail(Employee employee);
    }
}
