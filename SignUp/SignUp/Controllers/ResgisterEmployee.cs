using Microsoft.AspNetCore.Mvc;

namespace SignUp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResgisterEmployee : ControllerBase
    {
        public ResgisterEmployee()
        {

        }

        [HttpPost]
        public ActionResult Register(string name)
        {
            return Ok();
        }
    }
}
