using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoogleApi.Entities.Common;
using GoogleApi;
using GoogleApi.Entities.Maps.DistanceMatrix.Request;
using System.Threading.Tasks;
using System.Linq;

namespace GoogleApiRequests
{
  public static class DistanceMatrix
  {
    public static async Task<List<dynamic>> GetGarageDistances(double longitude, double latitude, List<GarageDestinationLocation> garageLocations)
    {



      var request = new DistanceMatrixRequest
        {
          Key = ApiKey.apiKey,
          Origins = new[] { new Location(latitude, longitude)},
          Destinations = getLocations(garageLocations)
        };

      var response = await GoogleMaps.DistanceMatrix.QueryAsync(request);
      IEnumerable<dynamic> something = response.Rows.First().Elements;

      return something.ToList();
    }

    public static Collection<Location> getLocations(List<GarageDestinationLocation> garageLocations)
    {
      Collection<Location> locations = new Collection<Location>();

      foreach (var garage in garageLocations)
      {
        locations.Add(new Location(garage.Latitude, garage.Longitude));
      }

      return locations;
    }
  }
}