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
  [Route ("api/[controller]")]
  [ApiController]
  public class LocationController : ControllerBase
  {
    private readonly AmruDbContext _context;

    public LocationController(AmruDbContext context)
    {
      _context = context;
    }
  }
}