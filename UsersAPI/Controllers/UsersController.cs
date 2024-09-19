using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersAPI.Context;
using UsersAPI.Models;

namespace UsersAPI.Controllers
{
    [Route("")]
    [ApiController]
    public class UsersController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return Ok(new
            {
                status = "success"
            });
        }
    }
}
