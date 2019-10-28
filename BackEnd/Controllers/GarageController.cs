using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GarageController : ControllerBase
  {
    private readonly AmruDbContext _context;

    public GarageController(AmruDbContext context)
    {
      _context = context;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GarageDTO>> GetGarage(uint id)
    {
      Garage garage = await _context.Garages
                                .Include(g => g.Address)
                                .Include(g => g.User)
                                    .ThenInclude(u => u.PhoneNumber)
                                .Include(g => g.Invoice)
                                    .ThenInclude(i => i.User)
                                .Include(g => g.Review)
                                    .ThenInclude(r => r.User)
                                .SingleOrDefaultAsync(g => g.GarageID == id);

      if (garage == null)
      {
        return NotFound();
      }

      List<InvoiceDTO> invoices = new List<InvoiceDTO>();
      List<ReviewDTO> reviews = new List<ReviewDTO>();

      foreach (var invoice in garage.Invoice)
      {
        invoices.Add(new InvoiceDTO()
        {
          InvoiceID = invoice.InvoiceID,
          Username = invoice.User.Username,
          BasePrice = garage.BasePrice,
          Labour = Math.Round(invoice.Hours * garage.HourlyRate, 2),
          Parts = invoice.Parts,
          RecoveryFee = invoice.RecoveryFee
        });

 }


      foreach (var review in garage.Review)
      {
        reviews.Add(new ReviewDTO()
        {
          ReviewID = review.ReviewID,
          Rating = review.Rating,
          Body = review.Body,
          Username = review.User.Username
        });
      }

      GarageDTO garageDto = new GarageDTO()
      {
        GarageID = garage.GarageID,
        GarageName = garage.GarageName,
        Description = garage.Description,
        ImagePath = garage.ImagePath,
        BasePrice = garage.BasePrice,
        PhoneNumber = garage.User.PhoneNumber.Number,
        Address = new AddressDTO()
        {
          LineOne = garage.Address.LineOne,
          LineTwo = garage.Address.LineTwo,
          County = garage.Address.County,
          PostCode = garage.Address.PostCode
        },
        Invoices = invoices,
        Reviews = reviews
      };

      return garageDto;
    }
  }
}