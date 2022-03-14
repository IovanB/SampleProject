using Microsoft.AspNetCore.Mvc;
using SignUp.Application.UseCases.SignUpUser.SignUpUsers;
using SignUp.Domain.Entities;

namespace SignUp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SignUpController : ControllerBase
    {
        private readonly ISignUpUser signUpUser;

        public SignUpController(ISignUpUser signUpUser)
        {
            this.signUpUser = signUpUser;
        }

        [HttpPost]
        [Route("SignUpUser")]
        public IActionResult SignUpUser([FromBody] RequestInput input)
        {
            var employee = new Employee(Guid.NewGuid(), input.Name, input.Age, input.Occupation, input.EntryDate);
            
            var response = signUpUser.Register(employee);

            return Ok(response);
        }

        [HttpPost]
        [Route("SignUpUser")]
        public IActionResult GetEmployeeEmail([FromBody] Guid input)
        {
            
            var response = signUpUser.Register(employee);

            return Ok(response);
        }
    }
}
