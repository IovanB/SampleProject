using SignUp.Domain.Entities;

namespace SignUp.Application.Interfaces
{
    public interface ICompanySignUp
    {
        Task<string> Register(Employee employee);
    }
}
