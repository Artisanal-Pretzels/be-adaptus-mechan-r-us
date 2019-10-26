using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Models;
using FrontEndRequests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RegistrationController : ControllerBase
  {
    private readonly AmruDbContext _context;

    public RegistrationController(AmruDbContext context)
    {
      _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<UserDTO>> Post(UserRegistration request)
    {
      User newUser = new User()
      {
        Username = request.Username,
        Password = request.Password,
        Name = request.Name,
        Email = request.Email,
        PhoneNumber = new PhoneNumber() { Number = request.PhoneNumber },
        PaymentEmail = request.PaymentEmail
      };

      _context.Users.Add(newUser);
      await _context.SaveChangesAsync();

      UserDTO userDto = new UserDTO()
      {
        UserID = newUser.UserID,
        Username = newUser.Username,
        Name = newUser.Name,
        Email = newUser.Email,
        PhoneNumber = newUser.PhoneNumber.Number,
        GarageID = newUser.Garage?.GarageID
      };

      return Ok(userDto);
    }
  }
}