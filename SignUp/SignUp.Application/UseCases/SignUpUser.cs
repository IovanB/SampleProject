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

        public string Register(Employee employee)
        {
            //checking whether the user is valid or not

                if (!IsEmployeeValid(employee))
                    return "Not allowed";

                signUpRepository.Add(employee);

            return "User Added";

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
