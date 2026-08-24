using Microsoft.AspNetCore.Mvc;
using UserAPI.Data;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public UsersController(ApplicationDbContext context)
        {
            db = context;
        }

        
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = db.Users.ToList();

            return Ok(users);
        }

       
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            db.Users.Add(user);

           

            return Ok(user);
        }
    }
}