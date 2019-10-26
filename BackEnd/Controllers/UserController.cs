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
      User user = await _context.Users.Include(u => u.PhoneNumber).Include(u => u.Garage).SingleOrDefaultAsync(u => u.UserID == id);

      if (user == null)
      {
        return NotFound();
      }

      UserDTO userDto = new UserDTO()
      {
        UserID = user.UserID,
        Username = user.Username,
        Name = user.Name,
        Email = user.Email,
        PhoneNumber = user.PhoneNumber.Number,
        GarageID = user.Garage?.GarageID
      };

      return userDto;
    }
  }
}