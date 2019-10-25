using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Models;
using FrontEndRequests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GoogleApiRequests;


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

    [Route("distance")]
    [HttpGet]
    public async Task<ActionResult<List<GarageDistanceDTO>>> GetGarages([FromQuery] UserLocation location)
    {
      double latitude = location.latitude;
      double longitude = location.longitude;
      double increment = location.increment;

      double latDelta = 0.01 * increment;
      double longDelta = 0.014 * increment;

      double minLat = latitude - latDelta;
      double maxLat = latitude + latDelta;
      double minLong = longitude - longDelta;
      double maxLong = longitude + longDelta;

      List<Garage> localGarages = await _context.Garages.Include(g => g.Address).Include(g => g.Review)
        .Where(garage => garage.Address.Latitude < maxLat
        && garage.Address.Latitude > minLat
        && garage.Address.Longitude < maxLong
        && garage.Address.Longitude > minLong)
        .ToListAsync();

      List<GarageDestinationLocation> garageLocations = new List<GarageDestinationLocation>();

      foreach (var garage in localGarages)
      {
          garageLocations.Add(new GarageDestinationLocation
          {
            GarageID = garage.GarageID,
            Longitude = garage.Address.Longitude,
            Latitude = garage.Address.Latitude
          });
      }

      List<dynamic> distances = await DistanceMatrix.GetGarageDistances(longitude, latitude, garageLocations);

      List<GarageDistanceDTO> garageDistances = new List<GarageDistanceDTO>();

      int count = 0;

      foreach (var garage in localGarages)
      {
        DistanceDTO dist = new DistanceDTO
        {
          Duration = distances[count].Duration.Text,
          DurationTraffic = distances[count].DurationInTraffic.Text,
          Distance = distances[count].Distance.Text
        };
        
        garageDistances.Add(new GarageDistanceDTO
        {
          GarageID = garage.GarageID,
          GarageName = garage.GarageName,
          Ratings = garage.Review.Average(e => e.Rating),
          BasePrice = garage.BasePrice,
          Distance = dist
        });

        count++;
      }

      return garageDistances;
    }
  }
}