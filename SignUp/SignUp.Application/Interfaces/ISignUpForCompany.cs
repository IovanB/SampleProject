using SignUp.Domain.Entities;

namespace SignUp.Application.Interfaces
{
    public interface ISignUpForCompany
    {
        Task<string> RegisterUser(Employee employee);
    }
}
