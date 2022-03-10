using Microsoft.AspNetCore.Mvc;
using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;

namespace SignUp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResgisterEmployee : ControllerBase
    {
        private readonly ICompanySignUp companySignUp;

        public ResgisterEmployee(ICompanySignUp companySignUp)
        {
            this.companySignUp = companySignUp;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RequestInput input)
        {
            var employee = new Employee(Guid.NewGuid(), input.Name, input.Age, Occupation.Developer, input.EntryDate);

            var response =  companySignUp.Register(employee);

            return  Ok(response.Result);
        }
    }
}
