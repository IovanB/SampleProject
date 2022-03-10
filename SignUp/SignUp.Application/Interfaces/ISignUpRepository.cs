using SignUp.Domain.Entities;

namespace SignUp.Application.Interfaces
{
    public interface ISignUpRepository
    {
        bool Add(Employee employee);    
        bool Remove(Employee employee);    
        List<Employee> GetAll();    
    }
}
