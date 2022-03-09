using SignUp.Domain.Entities;

namespace SignUp.Application.Interfaces
{
    public interface ISignUpRepository
    {
        void Add(Employee employee);    
        void Remove(Employee employee);    
        List<Employee> GetAll();    
    }
}
