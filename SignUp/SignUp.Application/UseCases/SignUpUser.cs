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

            try
            {
                if (!IsEmployeeValid(employee))
                    throw new InvalidOperationException("You shall not pass!");

                signUpRepository.Add(employee); 
            }
            catch (Exception ex)
            {
                throw ex;
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
