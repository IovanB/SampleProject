using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;

namespace SignUp.Application.UseCases
{
    public  class CompanySignUp : ICompanySignUp
    {
        private readonly ISignUpForCompany signUpForCompany;

        public CompanySignUp(ISignUpForCompany signUpForCompany)
        {
            this.signUpForCompany = signUpForCompany;
        }

        public async Task<string> Register(Employee employee)
        {
            try
            {
                var response = await signUpForCompany.RegisterUser(employee);

                return  response;

            }
            catch (Exception)
            {

                throw null;
            }
        }
    }
}
