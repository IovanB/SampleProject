using RestSharp;
using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;
using SignUp.Infrastructure.Entity;

namespace SignUp.Infrastructure.Repository
{
    public class SignUpForCompany : ISignUpForCompany
    {
        public async Task<string> RegisterUser(Employee employee)
        {

            var client = new RestClient("https://localhost:7042/returnemployeeid/employeenumber");

            var input = new Input()
            {
                Name = employee.Name,
                Age = employee.Age
            };

            var request = new RestRequest()
            .AddJsonBody(input);

            var response = client.PostAsync<string>(request);

            return await response ?? "Nothing to say";
        }
    }
}
