using SignUp.Domain.Entities;

namespace SignUp.Application.UseCases.GetEmail
{
    public interface IGetEmailUseCase
    {
        string GetEmployeeEmail(Employee employee); 
    }
}
