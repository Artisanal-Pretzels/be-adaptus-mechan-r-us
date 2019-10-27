using Microsoft.AspNetCore.Mvc;
using BackEnd.Models;
using BackEnd.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net;
using System.Text;

namespace BackEnd.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class ApiController : ControllerBase
  {

    [HttpGet]
    public IActionResult GetApi()
    {
      string endpoints = DataLoader.LoadEndpoints();

      return Ok(endpoints);
    }
  }
}