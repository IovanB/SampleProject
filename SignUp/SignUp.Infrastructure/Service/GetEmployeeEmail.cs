using RestSharp;
using SignUp.Application.Interfaces;

namespace SignUp.Infrastructure.Service
{
    public class GetEmployeeEmail : IGetEmployeeEmail
    {
        public string GetEmail(Guid id)
        {
            var client = new RestClient("https://www.github.com/iovanb/");
            var request = new RestRequest("",Method.Post);

            //var response = client.ExecuteAsync<Guid>(id,request);

            return "ok";
        }
    }
}
