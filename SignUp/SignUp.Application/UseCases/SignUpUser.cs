using SignUp.Application.Interfaces; 
using SignUp.Domain.Entities;

namespace SignUp.Application.UseCases
{
    public class SignUpUser : ISignUpUser
    {
        private readonly ISignUpRepository signUpRepository;

        public SignUpUser(ISignUpRepository signUpRepository)
        {
            this.signUpRepository = signUpRepository;
        }

        public void Register(Employee employee)
        {
            //checking whether the user is valid or not

            IsEmployeeValid(employee);

            try
            {
                signUpRepository.Add(employee);
            }
            catch (Exception ex)
            {
                throw null;
            }

        }

        private bool IsEmployeeValid(Employee employee)
        {
            if (employee.IsValid)
            {
                return true;
            }
            return false;
        }
    }
}
