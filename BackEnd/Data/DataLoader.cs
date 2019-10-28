using System.Collections.Generic;
using System.IO;
using BackEnd.Models;
using Newtonsoft.Json;

namespace BackEnd.Data
{
  public static class DataLoader
  {

    public static IEnumerable<T> LoadJson<T>(string file)
    {
      string path = $"Data/prod-data/{file}.json";

      using (StreamReader r = new StreamReader (path))
      {
        string json = r.ReadToEnd ();
        IEnumerable<T> dataObject = JsonConvert.DeserializeObject<List<T>> (json);
        return dataObject;
      }
    }

    public static string LoadEndpoints ()
    {
      using (StreamReader r = new StreamReader ("Data/endpoints.json"))
      {
        string json = r.ReadToEnd ();

        ApiEndpoint endpoints = JsonConvert.DeserializeObject<ApiEndpoint> (json);
        string endpointsString = JsonConvert.SerializeObject (endpoints, Formatting.Indented);

        return endpointsString;
      }
    }
  }
}