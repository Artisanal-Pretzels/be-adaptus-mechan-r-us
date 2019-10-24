using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Models;
using FrontEndRequests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class LoginController : ControllerBase
  {

    private readonly AmruDbContext _context;

    public LoginController(AmruDbContext context)
    {
      _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Post(UserLogin request)
    {
      User user = _context.Users.Include(u => u.PhoneNumber).SingleOrDefault(u => u.Username == request.Username);

      if (user == null)
      {
        return NotFound();
      }

      if (user.Password != request.Password)
      {
        return Unauthorized();
      }

      UserDTO userDto = new UserDTO()
      {
        UserID = user.UserID,
        Username = user.Username,
        Name = user.Name,
        Email = user.Email,
        PhoneNumber = user.PhoneNumber.Number,
      };

      return Ok(userDto);
    }

  }
}