using Microsoft.AspNetCore.Mvc;

namespace SignUpForCompany.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReturnEmployeeIDController : ControllerBase
    {

        private static readonly string[] EmployeeId = new[]
        {
        "A0204E96-2379-429E-91F9-126DBE46B9DC", "9E9744AC-705A-4CF3-ACBB-5CB1133A402F", "26A99F2E-EE18-4EB9-952A-3685D2450565"
    };


        [HttpPost]
        [Route("EmployeeNumber")]
        public IActionResult EmployeeNumber([FromBody] Input input)
        {
            if (input.Age < 18)
                return BadRequest("Cannot register an employee under age");

            var randomId = EmployeeId[Random.Shared.Next(EmployeeId.Length)];

            return Ok(randomId);
        }


    }
}
