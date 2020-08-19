using Microsoft.AspNetCore.Mvc;
using Prueba_.Net.Models;

namespace Prueba_.Net.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {   
        private bool login(UserLogin user)
        {
            return true;
        }

        [HttpPost]
        public IActionResult  Post([FromBody] UserLogin user)
        {
            IActionResult response;
            response = BadRequest();
            if(login(user))
            {
                response = Ok(new { token = "Jwt" });
            }
            return response;
        }
    }
}
