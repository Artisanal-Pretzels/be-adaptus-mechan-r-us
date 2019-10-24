using System.Collections.Generic;
using System.IO;
using BackEnd.Models;
using Newtonsoft.Json;

namespace BackEnd.Data
{
  public static class DataLoader
  {

    public static IEnumerable<T> LoadJson<T> (string file)
    {
      using (StreamReader r = new StreamReader ($"Data/test-data/{file}.json"))
      {
        string json = r.ReadToEnd ();
        IEnumerable<T> Hi = JsonConvert.DeserializeObject<List<T>> (json);
        return Hi;
      }
    }
  }
}