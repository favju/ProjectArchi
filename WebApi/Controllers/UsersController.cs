using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Extension;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly SchoolContext _context;

        public UsersController(SchoolContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserM>>> GetUsers()
        {
            if(_context.Users == null)
            {
                return NotFound();
            }

            var userList = await _context.Users.ToListAsync();
            if (userList == null)
            {
                return NotFound();
            }
            var userM = new List<UserM>();
            foreach (var user in userList)
            {
                userM.Add(user.ConvertToUserM());
            }
            return userM;
        }

        [HttpGet("/id/{id}")]
        public async Task<ActionResult<UserM>> GetUser(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return user.ConvertToUserM();
        }

        [HttpGet("/username/{username}")]
        public async Task<ActionResult<UserM>> GetUser(string username)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(username);
            if (user == null)
            {
                return NotFound();
            }
            return user.ConvertToUserM();
        }
    }
}
