using SignUp.Domain.Entities;

namespace SignUp.Application.UseCases.GetEmail
{
    public interface IGetEmailUseCase
    {
        string GetEmail(Employee employee); 
    }
}
