using System.Linq;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private readonly AmruDbContext _context;

    public UserController(AmruDbContext context)
    {
      _context = context;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDTO>> GetUser(uint id)
    {
      UserDTO userDto = await _context.Users.Include(u => u.PhoneNumber).Select(u =>
                new UserDTO()
                {
                  UserID = u.UserID,
                  Username = u.Username,
                  Name = u.Name,
                  Email = u.Email,
                  PhoneNumber = u.PhoneNumber.Number,
                }).SingleOrDefaultAsync(u => u.UserID == id);

      if (userDto == null)
      {
        return NotFound();
      }

      return userDto;
    }
  }
}