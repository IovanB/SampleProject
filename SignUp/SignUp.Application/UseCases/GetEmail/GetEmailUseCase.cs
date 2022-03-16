using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;

namespace SignUp.Application.UseCases.GetEmail
{
    public class GetEmailUseCase : IGetEmailUseCase
    {
        private readonly IGetEmployeeEmail getEmployeeEmail;

        public GetEmailUseCase(IGetEmployeeEmail getEmployeeEmail)
        {
            this.getEmployeeEmail = getEmployeeEmail;
        }

        public string GetEmployeeEmail(Employee employee)
        {
            var email = getEmployeeEmail.GetEmail(employee.Id);

            employee.Email = email;

            return email;   
        }
    }
}
