using Microsoft.AspNetCore.Mvc;
using SignUp.Application.UseCases.GetEmail;
using SignUp.Application.UseCases.SignUpUser.SignUpUsers;
using SignUp.Domain.Entities;

namespace SignUp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SignUpController : ControllerBase
    {
        private readonly ISignUpUser signUpUser;
        private readonly IGetEmailUseCase getEmailUseCase;

        public SignUpController(ISignUpUser signUpUser, IGetEmailUseCase getEmailUseCase )
        {
            this.signUpUser = signUpUser;
            this.getEmailUseCase = getEmailUseCase;
        }

        [HttpPost]
        [Route("SignUpUser")]
        public IActionResult SignUpUser([FromBody] RequestInput input)
        {
            var employee = new Employee(Guid.NewGuid(), input.Name, input.Age, input.Occupation, input.EntryDate, String.Empty);
            
            var response = signUpUser.Register(employee);

            return Ok(response);
        }

        [HttpPost]
        [Route("GetEmployeeEmail")]
        public IActionResult GetEmployeeEmail([FromBody] RequestInput input)
        {
            var employee = new Employee(Guid.NewGuid(), input.Name, input.Age, input.Occupation, input.EntryDate, String.Empty);
            var response = getEmailUseCase.GetEmployeeEmail(employee);

            return Ok(response);
        }
    }
}
