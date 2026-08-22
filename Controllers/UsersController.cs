using Microsoft.AspNetCore.Mvc;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUser(
            [FromQuery] int id,
            [FromQuery] string name,
            [FromQuery] string email)
        {
            return Ok(new
            {
                Id = id,
                Name = name,
                Email = email
            });
        }
    }
}