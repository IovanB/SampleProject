using SignUp.Application.Interfaces;
using SignUp.Application.UseCases.SignUpUser.SignUpUsers;
using SignUp.Domain.Entities;

namespace SignUp.Application.UseCases.SignUpUsers
{
    public class SignUpUser : ISignUpUser
    {
        private readonly ISignUpRepository signUpRepository;
        private readonly IGetEmployeeEmail getEmployeeEmail;

        public SignUpUser(ISignUpRepository signUpRepository, IGetEmployeeEmail getEmployeeEmail)
        {
            this.signUpRepository = signUpRepository;
            this.getEmployeeEmail = getEmployeeEmail;
        }


        public string Register(Employee employee)
        {
            //checking whether the user is valid or not
            if (employee.Age < 18)
                return "Employee should not be under 18";

            signUpRepository.Add(employee);

            return "User Added";

        }

        public string GetEmail(Employee employee)
        {
            var email = getEmployeeEmail.GetEmail(employee.Id);

            employee.Email = email; 

            return email;
        }

    }
}
