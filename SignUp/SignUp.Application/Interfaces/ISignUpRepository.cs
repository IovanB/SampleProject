using SignUp.Domain.Entities;

namespace SignUp.Application.Interfaces
{
    public interface ISignUpRepository
    {
        bool Add(Employee employee);    
        List<Employee> GetAll();    
    }
}
